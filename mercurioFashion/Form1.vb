Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim conexao As MySqlConnection = New MySqlConnection
        Try

            conexao.ConnectionString = "Server=localhost;uid=root;password=;database=mfdb"
            conexao.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from login where usuario=@usuario and senha=@senha", conexao)
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()
            If (dr.HasRows) Then
                Me.Hide()
                MessageBox.Show("Olá " + dr("nome").ToString + ", seja bem vindo ao sistema")
                usuarioLogado = dr("nome").ToString
                nivel = dr("nivel").ToString
                txtUsuario.ResetText()
                txtSenha.ResetText()
                frmPrincipal.Show()

            Else
                MessageBox.Show("Usuário e/ou senha inváidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Banco offline")
        Finally
            conexao.Close()
        End Try
    End Sub
End Class
