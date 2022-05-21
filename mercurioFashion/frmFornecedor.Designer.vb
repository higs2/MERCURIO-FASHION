<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbGeral = New System.Windows.Forms.GroupBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRazao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.gbEndereco = New System.Windows.Forms.GroupBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGeral.SuspendLayout()
        Me.gbEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mercurioFashion.My.Resources.Resources.FornecedorBack
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(801, 136)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gbGeral
        '
        Me.gbGeral.Controls.Add(Me.txtCelular)
        Me.gbGeral.Controls.Add(Me.txtTelefone)
        Me.gbGeral.Controls.Add(Me.Label7)
        Me.gbGeral.Controls.Add(Me.Label6)
        Me.gbGeral.Controls.Add(Me.txtSite)
        Me.gbGeral.Controls.Add(Me.Label5)
        Me.gbGeral.Controls.Add(Me.txtRazao)
        Me.gbGeral.Controls.Add(Me.Label4)
        Me.gbGeral.Controls.Add(Me.txtCNPJ)
        Me.gbGeral.Controls.Add(Me.Label3)
        Me.gbGeral.Controls.Add(Me.txtNome)
        Me.gbGeral.Controls.Add(Me.label2)
        Me.gbGeral.Enabled = False
        Me.gbGeral.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGeral.Location = New System.Drawing.Point(12, 140)
        Me.gbGeral.Name = "gbGeral"
        Me.gbGeral.Size = New System.Drawing.Size(772, 268)
        Me.gbGeral.TabIndex = 1
        Me.gbGeral.TabStop = False
        Me.gbGeral.Text = "Dados"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(249, 226)
        Me.txtCelular.Mask = "(00) 00000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(127, 29)
        Me.txtCelular.TabIndex = 13
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(38, 226)
        Me.txtTelefone.Mask = "(00)0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(163, 29)
        Me.txtTelefone.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Celular"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefone"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(342, 168)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(190, 29)
        Me.txtSite.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Site Web"
        '
        'txtRazao
        '
        Me.txtRazao.Location = New System.Drawing.Point(38, 168)
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.Size = New System.Drawing.Size(269, 29)
        Me.txtRazao.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Razão Social"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(556, 113)
        Me.txtCNPJ.Mask = "00,000,000/0000-00"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(210, 29)
        Me.txtCNPJ.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CNPJ"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(38, 113)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(494, 29)
        Me.txtNome.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(34, 89)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 21)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Nome"
        '
        'gbEndereco
        '
        Me.gbEndereco.Controls.Add(Me.txtCEP)
        Me.gbEndereco.Controls.Add(Me.Label12)
        Me.gbEndereco.Controls.Add(Me.Label11)
        Me.gbEndereco.Controls.Add(Me.txtEstado)
        Me.gbEndereco.Controls.Add(Me.Label10)
        Me.gbEndereco.Controls.Add(Me.txtCidade)
        Me.gbEndereco.Controls.Add(Me.Label9)
        Me.gbEndereco.Controls.Add(Me.txtBairro)
        Me.gbEndereco.Controls.Add(Me.Label8)
        Me.gbEndereco.Controls.Add(Me.txtLogradouro)
        Me.gbEndereco.Enabled = False
        Me.gbEndereco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEndereco.Location = New System.Drawing.Point(12, 414)
        Me.gbEndereco.Name = "gbEndereco"
        Me.gbEndereco.Size = New System.Drawing.Size(772, 174)
        Me.gbEndereco.TabIndex = 2
        Me.gbEndereco.TabStop = False
        Me.gbEndereco.Text = "Endereços"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(556, 120)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(127, 29)
        Me.txtCEP.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(552, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 21)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "CEP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(277, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 21)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(281, 120)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(251, 29)
        Me.txtEstado.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(38, 120)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(210, 29)
        Me.txtCidade.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(552, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 21)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(556, 53)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(210, 29)
        Me.txtBairro.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Logradouro"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(38, 53)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(494, 29)
        Me.txtLogradouro.TabIndex = 25
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSair.FlatAppearance.BorderSize = 2
        Me.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Location = New System.Drawing.Point(676, 606)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(102, 38)
        Me.btnSair.TabIndex = 34
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpar.FlatAppearance.BorderSize = 2
        Me.btnLimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(566, 606)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(104, 38)
        Me.btnLimpar.TabIndex = 33
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
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
        Me.btnCadastrar.Location = New System.Drawing.Point(181, 594)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(138, 38)
        Me.btnCadastrar.TabIndex = 32
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        Me.btnCadastrar.Visible = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.SlateGray
        Me.btnNovo.FlatAppearance.BorderSize = 2
        Me.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Location = New System.Drawing.Point(37, 594)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(138, 38)
        Me.btnNovo.TabIndex = 35
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'frmFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(796, 656)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.gbEndereco)
        Me.Controls.Add(Me.gbGeral)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFornecedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGeral.ResumeLayout(False)
        Me.gbGeral.PerformLayout()
        Me.gbEndereco.ResumeLayout(False)
        Me.gbEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbGeral As GroupBox
    Friend WithEvents txtSite As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRazao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbEndereco As GroupBox
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnNovo As Button
End Class
