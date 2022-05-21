Public Class frmPrincipal


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDataHora.Text = Date.Now 'mostrar hora e data no status.
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja realmente sair do Sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DesconectarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesconectarToolStripMenuItem.Click
        Me.Dispose() 'distruir formulario
        frmLogin.Show()
    End Sub
End Class