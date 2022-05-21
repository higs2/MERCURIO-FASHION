Imports MySql.Data.MySqlClient
Public Class frmFornecedor
    Private Sub frmFornecedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
        txtCNPJ.Text = ""
        txtRazao.Text = ""
        txtSite.Text = ""
        txtCelular.Text = ""
        txtTelefone.Text = ""
        txtLogradouro.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCEP.Text = ""
        txtEstado.Text = ""

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()

    End Sub

    Private Sub ResetaCampos()
        txtNome.ResetText()
        txtRazao.ResetText()
        txtCNPJ.ResetText()
        txtTelefone.ResetText()
        txtCelular.ResetText()
        txtSite.ResetText()
        txtLogradouro.ResetText()
        txtBairro.ResetText()
        txtCidade.ResetText()
        txtEstado.ResetText()
        txtCEP.ResetText()

        gbGeral.Enabled = False
        gbEndereco.Enabled = False
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        gbGeral.Enabled = True
        gbEndereco.Enabled = True

        btnCadastrar.Visible = True
    End Sub

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If (MessageBox.Show("Deseja cadastrar o fornecedor?", "Cadastrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            Dim conexao As MySqlConnection = New MySqlConnection("server=localhost;uid=root;password=;database=mfdb")
            Try
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("insert into fornecedor values (default,@nome,@razao,@cnpj,@telefone,@celular,@site,@logradouro,@bairro,@cidade,@estado,@cep)", conexao)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@razao", txtRazao.Text)
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@celular", txtCelular.Text)
                cmd.Parameters.AddWithValue("@site", txtSite.Text)
                cmd.Parameters.AddWithValue("@logradouro", txtLogradouro.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@estado", txtEstado.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Fornecedor cadastrado com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetaCampos()
                btnCadastrar.Visible = False
            Catch ex As MySqlException
                MessageBox.Show("Falha ao cadastrar fornecedor", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexao.Close()
            End Try
        End If
    End Sub
End Class