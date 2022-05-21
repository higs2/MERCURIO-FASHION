Imports MySql.Data.MySqlClient
Public Class frmCliente
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If (MessageBox.Show("Deseja cadastrar o cliente?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            Try
                Dim conexao As MySqlConnection = New MySqlConnection("server=localhost;uid=root;password=;database=mfdb")
                Dim cmd As MySqlCommand = New MySqlCommand("insert into cliente values (default,@nome,@genero,@nascimento,@rg,@cpf,@situacao,@logradouro,@bairro,@cidade,@estado,@cep,@celular,@email)", conexao)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@genero", txtGenero.Text)
                cmd.Parameters.AddWithValue("@nascimento", txtNascimento.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@logradouro", txtLogradouro.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@estado", txtEstado.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@celular", txtCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente cadastrado com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetaCampos()
                btnCadastrar.Visible = False
                conexao.Close()
            Catch ex As MySqlException
                MessageBox.Show("Falha ao cadastrar o cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
        txtNascimento.Text = ""
        txtGenero.Text = ""
        txtRG.Text = ""
        txtCPF.Text = ""
        txtCel.Text = ""
        txtEmail.Text = ""
        txtLogradouro.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCEP.Text = ""
        txtEstado.Text = ""
        txtSituacao.Text = ""


    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        gbGeral.Enabled = True
        gbEndereco.Enabled = True
        btnCadastrar.Visible = True

    End Sub

    Private Sub ResetaCampos()
        txtNome.ResetText()
        txtNascimento.ResetText()
        txtGenero.ResetText()
        txtRG.ResetText()
        txtCPF.ResetText()
        txtCel.ResetText()
        txtEmail.ResetText()
        txtLogradouro.ResetText()
        txtBairro.ResetText()
        txtCidade.ResetText()
        txtCEP.ResetText()
        txtEstado.ResetText()
        txtSituacao.ResetText()

        gbGeral.Enabled = False
        gbEndereco.Enabled = False
    End Sub

End Class