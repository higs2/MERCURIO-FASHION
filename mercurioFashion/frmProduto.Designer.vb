<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.gbFoto = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.gbGeral = New System.Windows.Forms.GroupBox()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.gbFoto.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGeral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(22, 145)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(500, 29)
        Me.txtDescricao.TabIndex = 9
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.Green
        Me.btnCadastrar.FlatAppearance.BorderSize = 2
        Me.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrar.Location = New System.Drawing.Point(151, 554)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(123, 38)
        Me.btnCadastrar.TabIndex = 36
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        Me.btnCadastrar.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fornecedor"
        '
        'btnApagar
        '
        Me.btnApagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApagar.FlatAppearance.BorderSize = 2
        Me.btnApagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagar.ForeColor = System.Drawing.Color.Black
        Me.btnApagar.Location = New System.Drawing.Point(290, 554)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(123, 38)
        Me.btnApagar.TabIndex = 37
        Me.btnApagar.Text = "Apagar Campos"
        Me.btnApagar.UseVisualStyleBackColor = False
        Me.btnApagar.Visible = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNovo.FlatAppearance.BorderSize = 2
        Me.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Location = New System.Drawing.Point(22, 554)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(123, 38)
        Me.btnNovo.TabIndex = 39
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(22, 73)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(211, 29)
        Me.txtCodigoBarras.TabIndex = 3
        '
        'gbFoto
        '
        Me.gbFoto.Controls.Add(Me.btnLimpar)
        Me.gbFoto.Controls.Add(Me.btnProcurar)
        Me.gbFoto.Controls.Add(Me.pbFoto)
        Me.gbFoto.Enabled = False
        Me.gbFoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFoto.Location = New System.Drawing.Point(548, 138)
        Me.gbFoto.Name = "gbFoto"
        Me.gbFoto.Size = New System.Drawing.Size(239, 355)
        Me.gbFoto.TabIndex = 35
        Me.gbFoto.TabStop = False
        Me.gbFoto.Text = "Foto"
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.LightCoral
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.FlatAppearance.BorderSize = 2
        Me.btnLimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(123, 311)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(110, 38)
        Me.btnLimpar.TabIndex = 41
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.DarkGray
        Me.btnProcurar.FlatAppearance.BorderSize = 2
        Me.btnProcurar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.Black
        Me.btnProcurar.Location = New System.Drawing.Point(6, 311)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(110, 38)
        Me.btnProcurar.TabIndex = 40
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(6, 28)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(227, 260)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 0
        Me.pbFoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código de Barras"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSair.FlatAppearance.BorderSize = 2
        Me.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Location = New System.Drawing.Point(419, 554)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(123, 38)
        Me.btnSair.TabIndex = 38
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        Me.btnSair.Visible = False
        '
        'gbGeral
        '
        Me.gbGeral.Controls.Add(Me.txtFornecedor)
        Me.gbGeral.Controls.Add(Me.txtEstoque)
        Me.gbGeral.Controls.Add(Me.Label7)
        Me.gbGeral.Controls.Add(Me.txtPrecoVenda)
        Me.gbGeral.Controls.Add(Me.Label6)
        Me.gbGeral.Controls.Add(Me.txtDepartamento)
        Me.gbGeral.Controls.Add(Me.Label3)
        Me.gbGeral.Controls.Add(Me.txtTipo)
        Me.gbGeral.Controls.Add(Me.Label1)
        Me.gbGeral.Controls.Add(Me.txtDescricao)
        Me.gbGeral.Controls.Add(Me.Label5)
        Me.gbGeral.Controls.Add(Me.Label4)
        Me.gbGeral.Controls.Add(Me.txtCodigoBarras)
        Me.gbGeral.Controls.Add(Me.Label2)
        Me.gbGeral.Enabled = False
        Me.gbGeral.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGeral.Location = New System.Drawing.Point(11, 138)
        Me.gbGeral.Name = "gbGeral"
        Me.gbGeral.Size = New System.Drawing.Size(531, 355)
        Me.gbGeral.TabIndex = 33
        Me.gbGeral.TabStop = False
        Me.gbGeral.Text = "Informações Gerais"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Items.AddRange(New Object() {"Roupa", "Calçado", "Acessório"})
        Me.txtFornecedor.Location = New System.Drawing.Point(264, 73)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(258, 29)
        Me.txtFornecedor.TabIndex = 18
        '
        'txtEstoque
        '
        Me.txtEstoque.Location = New System.Drawing.Point(286, 295)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(236, 29)
        Me.txtEstoque.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Quantidade Estoque"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Location = New System.Drawing.Point(22, 295)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(236, 29)
        Me.txtPrecoVenda.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Preço de Venda"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.FormattingEnabled = True
        Me.txtDepartamento.Items.AddRange(New Object() {"Adulto", "Infantil", "Masculino", "Feminino"})
        Me.txtDepartamento.Location = New System.Drawing.Point(287, 221)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(236, 29)
        Me.txtDepartamento.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Departamento"
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Items.AddRange(New Object() {"Roupa", "Calçado", "Acessório"})
        Me.txtTipo.Location = New System.Drawing.Point(22, 221)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(236, 29)
        Me.txtTipo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tipo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mercurioFashion.My.Resources.Resources.ProdutoBack
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'ofd
        '
        Me.ofd.Filter = "(*.jpeg;*.jpg;*.png;*.webp)|*.jpeg;*.jpg;*.png;*.webp"
        '
        'frmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(799, 671)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.btnApagar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.gbFoto)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.gbGeral)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mercúrio Fashion - Cadastro de Produtos"
        Me.gbFoto.ResumeLayout(False)
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGeral.ResumeLayout(False)
        Me.gbGeral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnApagar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents gbFoto As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents gbGeral As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDepartamento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnProcurar As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents txtFornecedor As ComboBox
End Class
