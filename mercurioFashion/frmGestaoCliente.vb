Imports MySql.Data.MySqlClient
Public Class frmGestaoCliente
    Private conexao As MySqlConnection = New MySqlConnection("server=localhost;uid=root;password=;database=mfdb")



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
        txtID.ResetText()

        gbGeral.Enabled = False
        gbEndereco.Enabled = False
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        ResetaCampos()
        Try
            conexao.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from clientes where id=@id", conexao)
            cmd.Parameters.AddWithValue("@id", txtPesquisar.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()
            If (dr.HasRows) Then
                txtID.Text = dr("id").ToString
                txtNome.Text = dr("nome").ToString
                txtNascimento.Text = dr("nascimento").ToString
                txtGenero.Text = dr("genero").ToString
                txtRG.Text = dr("rg").ToString
                txtCPF.Text = dr("cpf").ToString
                txtCel.Text = dr("celular").ToString
                txtEmail.Text = dr("email").ToString
                txtLogradouro.Text = dr("logradouro").ToString
                txtBairro.Text = dr("bairro").ToString
                txtCidade.Text = dr("cidade").ToString
                txtCEP.Text = dr("cep").ToString
                txtEstado.Text = dr("estado").ToString
                txtSituacao.Text = dr("situacao").ToString

                btnEditar.Enabled = True
                btnSalvar.Enabled = False
                btnApagar.Enabled = True

                txtPesquisar.ResetText()
            Else
                MessageBox.Show("Cliente nao encontrado", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Catch ex As MySqlException
            MessageBox.Show(" Falha na conexão:" + ex.Message, "falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexao.Close()
        End Try

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        gbGeral.Enabled = True
        gbEndereco.Enabled = True

        btnSalvar.Enabled = True
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If (MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then

            Try
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("update cliente set 
                nome=@nome,
                genero=@genero,
                nascimento = @nascimento,
                rg=@rg,
                cpf=@cpf,
                situacao=@situacao,
                logradouro=@logradouro,
                bairro=@bairro,
                cidade=@cidade,
                estado=@estado,
                cep=@cep ,
                celular=@celular ,
                email=@email
                where id=@id", conexao)

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
                cmd.Parameters.AddWithValue("@id", txtID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Alterações salvas com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                gbGeral.Enabled = False
                gbEndereco.Enabled = False

                btnEditar.Enabled = True
                btnSalvar.Enabled = False
                btnApagar.Enabled = True


            Catch ex As MySqlException
                MessageBox.Show(ex.Message + "Falha ao salvar", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                conexao.Close()
            End Try
        End If
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        If MessageBox.Show("Deseja apagar o cliente?", "Apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Try
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("delete from cliente where id=@id", conexao)
                cmd.Parameters.AddWithValue("@id", txtID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente apagado com sucesso", "apagado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                btnEditar.Enabled = False
                btnSalvar.Enabled = False
                btnApagar.Enabled = False

                ResetaCampos()
            Catch ex As MySqlException
                MessageBox.Show("Falha ao apagar o cliente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexao.Close()
            End Try
        End If
    End Sub
End Class