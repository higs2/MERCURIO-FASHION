Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmProduto
    Private destino As String

    Private Sub ResetaCampos()
        txtCodigoBarras.ResetText()
        txtFornecedor.ResetText()
        txtDescricao.ResetText()
        txtTipo.ResetText()
        txtDepartamento.ResetText()
        txtPrecoVenda.ResetText()
        txtEstoque.ResetText()

        pbFoto.Image = Nothing
        ofd.FileName = Nothing
        destino = Nothing

        gbGeral.Enabled = False
        gbFoto.Enabled = False
    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        gbGeral.Enabled = True
        gbFoto.Enabled = True

        btnCadastrar.Visible = True
        btnApagar.Visible = True
        btnSair.Visible = True
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If (MessageBox.Show("Deseja cadastrar o cliente?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            Dim conexao As MySqlConnection = New MySqlConnection("server=localhost;uid=root;password=;database=mfdb")
            Try

                Dim cmd As MySqlCommand = New MySqlCommand("insert into produto values (default,@codigo_barras,@id_fornecedor,@descricao,@tipo,@departamento,@preco_venda,@estoque,@foto)", conexao)
                cmd.Parameters.AddWithValue("@codigo_barras", txtCodigoBarras.Text)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text)
                cmd.Parameters.AddWithValue("@departamento", txtDepartamento.Text)
                cmd.Parameters.AddWithValue("@preco_venda", CDbl(txtPrecoVenda.Text))
                cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text)
                cmd.Parameters.AddWithValue("@foto", destino)

                conexao.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Produto cadastrado com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetaCampos()
                btnCadastrar.Visible = False

            Catch ex As MySqlException
                MessageBox.Show("Falha ao cadastrar o produto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexao.Close()
            End Try
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        If (ofd.ShowDialog = DialogResult.OK) Then
            Directory.CreateDirectory(Directory.GetCurrentDirectory + "\imagens")
            pbFoto.Image = New System.Drawing.Bitmap(ofd.FileName)
            destino = "\imagens\" + ofd.SafeFileName
            File.Copy(ofd.FileName, Directory.GetCurrentDirectory + destino)
            btnProcurar.Enabled = False
            btnLimpar.Enabled = True
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Dim foto As String = Directory.GetCurrentDirectory + destino
        File.Delete(foto)
        pbFoto.Image = Nothing
        ofd.FileName = Nothing
        destino = Nothing
        btnLimpar.Enabled = False
        btnProcurar.Enabled = True
    End Sub

    Private Sub txtPrecoVenda_Leave(sender As Object, e As EventArgs) Handles txtPrecoVenda.Leave
        txtPrecoVenda.Text = FormatCurrency(txtPrecoVenda.Text)
    End Sub

    Private Sub FrmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexao As MySqlConnection = New MySqlConnection("server=localhost;uid=root;password=;database=mfdb")
        Try
            conexao.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select id, nome from fornecedor", conexao)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Dim dt As DataTable = New DataTable
            dt.Load(dr)
            txtFornecedor.DataSource = dt 'fonte de dados
            txtFornecedor.DisplayMember = "nome" 'mostra na tela
            txtFornecedor.ValueMember = "id"    'pega o valor

        Catch ex As MySqlException
            MessageBox.Show("Falha ao carregar fornecedores", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexao.Close()
        End Try
    End Sub


End Class