Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmGestaoProduto
    Private destino As String
    Private conexao As MySqlConnection = New MySqlConnection("server=localhost;uid=root;password=;database=mfdb")


    Private Sub ResetaCampos()
        txtCodigoBarras.ResetText()
        txtFornecedor.ResetText()
        txtDescricao.ResetText()
        txtTipo.ResetText()
        txtDepartamento.ResetText()
        txtPrecoVenda.ResetText()
        txtEstoque.ResetText()
        txtID.ResetText()

        pbFoto.Image = Nothing
        ofd.FileName = Nothing
        destino = Nothing
        btnLimpar.Enabled = False
        btnProcurar.Enabled = True

        gbGeral.Enabled = False
        gbFoto.Enabled = False
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
        pbFoto.Image.Dispose()
        Dim foto As String = Directory.GetCurrentDirectory + destino
        File.Delete(foto)
        pbFoto.Image = Nothing
        ofd.FileName = Nothing
        destino = Nothing
        btnLimpar.Enabled = False
        btnProcurar.Enabled = True
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        ResetaCampos()
        Try
            conexao.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select p.id, f.nome as nome_fornecedor, p.descricao, p.codigo_barras, p.tipo, p.departamento, p.preco_venda, p.estoque, p.foto from produto as p inner join fornecedor as f on f.id = p.id_fornecedor where p.id=@id", conexao)
            cmd.Parameters.AddWithValue("@id", txtPesquisar.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()
            If (dr.HasRows) Then
                txtID.Text = dr("id").ToString
                txtFornecedor.Text = dr("nome_fornecedor").ToString
                txtCodigoBarras.Text = dr("codigo_barras").ToString
                txtDescricao.Text = dr("descricao").ToString
                txtTipo.Text = dr("tipo").ToString
                txtDepartamento.Text = dr("departamento").ToString
                txtPrecoVenda.Text = FormatCurrency(dr("preco_venda").ToString)
                txtEstoque.Text = dr("estoque").ToString
                destino = dr("foto").ToString

                If (destino <> Nothing) Then
                    pbFoto.Image = New System.Drawing.Bitmap(Directory.GetCurrentDirectory + destino)
                    btnProcurar.Enabled = False
                    btnLimpar.Enabled = True
                End If

                btnEditar.Enabled = True
                btnSalvar.Enabled = False
                btnApagar.Enabled = True

                txtPesquisar.ResetText()
            Else
                MessageBox.Show("produto não encontrado", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnEditar.Enabled = False
                btnSalvar.Enabled = False
                btnApagar.Enabled = False

                txtPesquisar.ResetText()
            End If
        Catch ex As MySqlException
            MessageBox.Show("Falha na conexão MySQL: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        gbGeral.Enabled = True
        gbFoto.Enabled = True

        btnSalvar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If (MessageBox.Show("Deseja salvar as alterações?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            Try
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("update produto set codigo_barras=@codigo_barras,id_fornecedor=@id_fornecedor,descricao=@descricao,tipo=@tipo,departamento=@departamento,preco_venda=@preco_venda,estoque=@estoque,foto=@foto where id=@id", conexao)
                cmd.Parameters.AddWithValue("@codigo_barras", txtCodigoBarras.Text)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text)
                cmd.Parameters.AddWithValue("@departamento", txtDepartamento.Text)
                cmd.Parameters.AddWithValue("@preco_venda", CDbl(txtPrecoVenda.Text))
                cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text)
                cmd.Parameters.AddWithValue("@foto", destino)
                cmd.Parameters.AddWithValue("@id", txtID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Alterações salvas com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                gbGeral.Enabled = False
                gbFoto.Enabled = False

                btnEditar.Enabled = True
                btnSalvar.Enabled = False
                btnApagar.Enabled = True

            Catch ex As MySqlException
                MessageBox.Show("Falha ao salvar as alteraçôes", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexao.Close()
            End Try
        End If
    End Sub

    Private Sub txtPrecoVenda_Leave(sender As Object, e As EventArgs) Handles txtPrecoVenda.Leave
        txtPrecoVenda.Text = FormatCurrency(txtPrecoVenda.Text)
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        If (MessageBox.Show("Deseja apagar o produto?", "apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            Try
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("delete from produto where id=@id", conexao)
                cmd.Parameters.AddWithValue("@id", txtID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("produto removido com sucesso", "apagado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                pbFoto.Image.Dispose()

                Dim foto As String = Directory.GetCurrentDirectory + destino
                File.Delete(foto)

                ResetaCampos()

                btnEditar.Enabled = False
                btnSalvar.Enabled = False
                btnApagar.Enabled = False
            Catch ex As MySqlException
                MessageBox.Show("Falha ao apagar o produto", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexao.Close()
            End Try
        End If
    End Sub

    Private Sub FrmGestaoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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