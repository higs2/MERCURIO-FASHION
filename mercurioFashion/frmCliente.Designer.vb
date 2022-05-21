<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCliente
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbGeral = New System.Windows.Forms.GroupBox()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.label122 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.txtNascimento = New System.Windows.Forms.DateTimePicker()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbEndereco = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.ComboBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.label213 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGeral.SuspendLayout()
        Me.gbEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mercurioFashion.My.Resources.Resources.ClienteBack
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gbGeral
        '
        Me.gbGeral.Controls.Add(Me.txtSituacao)
        Me.gbGeral.Controls.Add(Me.Label12)
        Me.gbGeral.Controls.Add(Me.label122)
        Me.gbGeral.Controls.Add(Me.Label8)
        Me.gbGeral.Controls.Add(Me.txtCel)
        Me.gbGeral.Controls.Add(Me.txtEmail)
        Me.gbGeral.Controls.Add(Me.txtRG)
        Me.gbGeral.Controls.Add(Me.txtNascimento)
        Me.gbGeral.Controls.Add(Me.txtCPF)
        Me.gbGeral.Controls.Add(Me.Label6)
        Me.gbGeral.Controls.Add(Me.Label5)
        Me.gbGeral.Controls.Add(Me.txtGenero)
        Me.gbGeral.Controls.Add(Me.Label4)
        Me.gbGeral.Controls.Add(Me.Label3)
        Me.gbGeral.Controls.Add(Me.txtNome)
        Me.gbGeral.Controls.Add(Me.Label2)
        Me.gbGeral.Enabled = False
        Me.gbGeral.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGeral.Location = New System.Drawing.Point(12, 138)
        Me.gbGeral.Name = "gbGeral"
        Me.gbGeral.Size = New System.Drawing.Size(771, 298)
        Me.gbGeral.TabIndex = 0
        Me.gbGeral.TabStop = False
        Me.gbGeral.Text = "Informações Gerais"
        '
        'txtSituacao
        '
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"ATIVO", "BLOQUEADO", "DESATIVADO"})
        Me.txtSituacao.Location = New System.Drawing.Point(597, 258)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(161, 29)
        Me.txtSituacao.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(592, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 21)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Situação"
        '
        'label122
        '
        Me.label122.AutoSize = True
        Me.label122.Location = New System.Drawing.Point(328, 230)
        Me.label122.Name = "label122"
        Me.label122.Size = New System.Drawing.Size(59, 21)
        Me.label122.TabIndex = 14
        Me.label122.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Email"
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(333, 258)
        Me.txtCel.Mask = "(00) 00000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(216, 29)
        Me.txtCel.TabIndex = 15
        Me.txtCel.ValidatingType = GetType(Date)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(37, 258)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 29)
        Me.txtEmail.TabIndex = 13
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(286, 191)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(263, 29)
        Me.txtRG.TabIndex = 9
        '
        'txtNascimento
        '
        Me.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNascimento.Location = New System.Drawing.Point(37, 191)
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(200, 29)
        Me.txtNascimento.TabIndex = 7
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(597, 191)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(161, 29)
        Me.txtCPF.TabIndex = 11
        Me.txtCPF.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(592, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CPF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RG"
        '
        'txtGenero
        '
        Me.txtGenero.FormattingEnabled = True
        Me.txtGenero.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.txtGenero.Location = New System.Drawing.Point(597, 123)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(161, 29)
        Me.txtGenero.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(592, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gênero Sexual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data de Nascimento"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(37, 123)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(512, 29)
        Me.txtNome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'gbEndereco
        '
        Me.gbEndereco.Controls.Add(Me.txtEstado)
        Me.gbEndereco.Controls.Add(Me.txtCEP)
        Me.gbEndereco.Controls.Add(Me.Label11)
        Me.gbEndereco.Controls.Add(Me.txtCidade)
        Me.gbEndereco.Controls.Add(Me.Label10)
        Me.gbEndereco.Controls.Add(Me.Label9)
        Me.gbEndereco.Controls.Add(Me.txtBairro)
        Me.gbEndereco.Controls.Add(Me.label213)
        Me.gbEndereco.Controls.Add(Me.txtLogradouro)
        Me.gbEndereco.Controls.Add(Me.Label7)
        Me.gbEndereco.Enabled = False
        Me.gbEndereco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEndereco.Location = New System.Drawing.Point(12, 442)
        Me.gbEndereco.Name = "gbEndereco"
        Me.gbEndereco.Size = New System.Drawing.Size(771, 157)
        Me.gbEndereco.TabIndex = 18
        Me.gbEndereco.TabStop = False
        Me.gbEndereco.Text = "Dados de Endereço"
        '
        'txtEstado
        '
        Me.txtEstado.FormattingEnabled = True
        Me.txtEstado.Items.AddRange(New Object() {"RJ", "SP", "MG", "ES"})
        Me.txtEstado.Location = New System.Drawing.Point(275, 124)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(161, 29)
        Me.txtEstado.TabIndex = 26
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(555, 122)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(140, 29)
        Me.txtCEP.TabIndex = 28
        Me.txtCEP.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(552, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 21)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "CEP"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(36, 123)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(190, 29)
        Me.txtCidade.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(556, 61)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(206, 29)
        Me.txtBairro.TabIndex = 22
        '
        'label213
        '
        Me.label213.AutoSize = True
        Me.label213.Location = New System.Drawing.Point(551, 33)
        Me.label213.Name = "label213"
        Me.label213.Size = New System.Drawing.Size(52, 21)
        Me.label213.TabIndex = 21
        Me.label213.Text = "Bairro"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(36, 61)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(502, 29)
        Me.txtLogradouro.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Logradouro"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.BorderSize = 2
        Me.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrar.Location = New System.Drawing.Point(247, 621)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(123, 38)
        Me.btnCadastrar.TabIndex = 29
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        Me.btnCadastrar.Visible = False
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
        Me.btnLimpar.Location = New System.Drawing.Point(447, 621)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(123, 38)
        Me.btnLimpar.TabIndex = 30
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
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
        Me.btnSair.Location = New System.Drawing.Point(647, 621)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(123, 38)
        Me.btnSair.TabIndex = 31
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
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
        Me.btnNovo.Location = New System.Drawing.Point(47, 621)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(123, 38)
        Me.btnNovo.TabIndex = 32
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(804, 711)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.gbEndereco)
        Me.Controls.Add(Me.gbGeral)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mercúrio Fashion - Cadastro de Clientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGeral.ResumeLayout(False)
        Me.gbGeral.PerformLayout()
        Me.gbEndereco.ResumeLayout(False)
        Me.gbEndereco.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbGeral As GroupBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenero As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNascimento As DateTimePicker
    Friend WithEvents txtRG As TextBox
    Friend WithEvents gbEndereco As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents label122 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCel As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents label213 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstado As ComboBox
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnNovo As Button
End Class
