Public Class frmPrincipal


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDataHora.Text = Date.Now 'mostrar hora e data no status.
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If (MessageBox.Show("Deseja realmente sair do Sistema?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            Application.Exit() 'perguntar se deseja fechar form
        End If
    End Sub

    Private Sub DesconectarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesconectarToolStripMenuItem.Click
        Me.Dispose() 'distruir formulario
        frmLogin.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        frmCliente.ShowDialog() 'abrir form cliente
    End Sub

    Private Sub ForneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForneToolStripMenuItem.Click
        frmFornecedor.ShowDialog() 'abrir form fornecedor
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        frmProduto.ShowDialog() 'abrir form produto
    End Sub




    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuarioLogado.Text = usuarioLogado

        'RESTRIÇÕES DE NIVEL DE ACESSO
        If (nivel = 2) Then
            'OCULTAR CADASTRO
            ClienteToolStripMenuItem.Visible = False
            ForneToolStripMenuItem.Visible = False

            'OCULTAR GESTÃO
            ClienteToolStripMenuItem1.Visible = False
            FornecedorToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        frmGestaoCliente.ShowDialog()
    End Sub

    Private Sub ArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArquivoToolStripMenuItem.Click

    End Sub

    Private Sub ProdutoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem1.Click
        frmGestaoProduto.ShowDialog()
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class