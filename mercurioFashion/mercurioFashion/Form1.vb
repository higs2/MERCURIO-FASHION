Public Class frmLogin
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If txtUsuario.Text = "admin" And txtSenha.Text = "admin" Then
            MessageBox.Show("Bem vindo ao sistema", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuário ou senha incorreto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


End Class
