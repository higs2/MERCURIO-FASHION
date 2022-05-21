<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestaoCliente
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.label122 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.txtNascimento = New System.Windows.Forms.DateTimePicker()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.label213 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.ComboBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbEndereco = New System.Windows.Forms.GroupBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbGeral = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.gbPesquisar = New System.Windows.Forms.GroupBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.gbID = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.gbEndereco.SuspendLayout()
        Me.gbGeral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPesquisar.SuspendLayout()
        Me.gbID.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Estado"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(556, 52)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(206, 29)
        Me.txtBairro.TabIndex = 22
        '
        'txtSituacao
        '
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"ATIVO", "BLOQUEADO", "DESATIVADO"})
        Me.txtSituacao.Location = New System.Drawing.Point(600, 193)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(161, 29)
        Me.txtSituacao.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(595, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 21)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Situação"
        '
        'label122
        '
        Me.label122.AutoSize = True
        Me.label122.Location = New System.Drawing.Point(332, 165)
        Me.label122.Name = "label122"
        Me.label122.Size = New System.Drawing.Size(59, 21)
        Me.label122.TabIndex = 14
        Me.label122.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Email"
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(337, 193)
        Me.txtCel.Mask = "(00) 00000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(216, 29)
        Me.txtCel.TabIndex = 15
        Me.txtCel.ValidatingType = GetType(Date)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(41, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 29)
        Me.txtEmail.TabIndex = 13
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(290, 126)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(263, 29)
        Me.txtRG.TabIndex = 9
        '
        'txtNascimento
        '
        Me.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNascimento.Location = New System.Drawing.Point(41, 126)
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(200, 29)
        Me.txtNascimento.TabIndex = 7
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(601, 126)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(161, 29)
        Me.txtCPF.TabIndex = 11
        Me.txtCPF.ValidatingType = GetType(Date)
        '
        'label213
        '
        Me.label213.AutoSize = True
        Me.label213.Location = New System.Drawing.Point(551, 24)
        Me.label213.Name = "label213"
        Me.label213.Size = New System.Drawing.Size(52, 21)
        Me.label213.TabIndex = 21
        Me.label213.Text = "Bairro"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(36, 52)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(502, 29)
        Me.txtLogradouro.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Logradouro"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Cyan
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 2
        Me.btnSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Location = New System.Drawing.Point(156, 542)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(123, 38)
        Me.btnSalvar.TabIndex = 36
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(596, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CPF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RG"
        '
        'txtGenero
        '
        Me.txtGenero.FormattingEnabled = True
        Me.txtGenero.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.txtGenero.Location = New System.Drawing.Point(601, 58)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(161, 29)
        Me.txtGenero.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(596, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gênero Sexual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Cidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data de Nascimento"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Gold
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 2
        Me.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Location = New System.Drawing.Point(27, 542)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 38)
        Me.btnEditar.TabIndex = 39
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(41, 58)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(512, 29)
        Me.txtNome.TabIndex = 3
        '
        'txtEstado
        '
        Me.txtEstado.FormattingEnabled = True
        Me.txtEstado.Items.AddRange(New Object() {"RJ", "SP", "MG", "ES"})
        Me.txtEstado.Location = New System.Drawing.Point(275, 115)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(161, 29)
        Me.txtEstado.TabIndex = 26
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(555, 113)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(140, 29)
        Me.txtCEP.TabIndex = 28
        Me.txtCEP.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(552, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 21)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "CEP"
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
        Me.gbEndereco.Location = New System.Drawing.Point(14, 356)
        Me.gbEndereco.Name = "gbEndereco"
        Me.gbEndereco.Size = New System.Drawing.Size(771, 161)
        Me.gbEndereco.TabIndex = 35
        Me.gbEndereco.TabStop = False
        Me.gbEndereco.Text = "Dados de Endereço"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(36, 114)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(190, 29)
        Me.txtCidade.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
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
        Me.gbGeral.Location = New System.Drawing.Point(12, 113)
        Me.gbGeral.Name = "gbGeral"
        Me.gbGeral.Size = New System.Drawing.Size(771, 238)
        Me.gbGeral.TabIndex = 33
        Me.gbGeral.TabStop = False
        Me.gbGeral.Text = "Informações Gerais"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mercurioFashion.My.Resources.Resources.GestaoBack
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'btnApagar
        '
        Me.btnApagar.BackColor = System.Drawing.Color.Chocolate
        Me.btnApagar.Enabled = False
        Me.btnApagar.FlatAppearance.BorderSize = 2
        Me.btnApagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagar.ForeColor = System.Drawing.Color.Black
        Me.btnApagar.Location = New System.Drawing.Point(285, 542)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(123, 38)
        Me.btnApagar.TabIndex = 40
        Me.btnApagar.Text = "Apagar"
        Me.btnApagar.UseVisualStyleBackColor = False
        '
        'gbPesquisar
        '
        Me.gbPesquisar.Controls.Add(Me.btnPesquisar)
        Me.gbPesquisar.Controls.Add(Me.txtPesquisar)
        Me.gbPesquisar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPesquisar.Location = New System.Drawing.Point(414, 525)
        Me.gbPesquisar.Name = "gbPesquisar"
        Me.gbPesquisar.Size = New System.Drawing.Size(371, 55)
        Me.gbPesquisar.TabIndex = 41
        Me.gbPesquisar.TabStop = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.Teal
        Me.btnPesquisar.FlatAppearance.BorderSize = 2
        Me.btnPesquisar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.ForeColor = System.Drawing.Color.Black
        Me.btnPesquisar.Location = New System.Drawing.Point(264, 17)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(107, 38)
        Me.btnPesquisar.TabIndex = 41
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(6, 22)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(252, 29)
        Me.txtPesquisar.TabIndex = 0
        '
        'gbID
        '
        Me.gbID.Controls.Add(Me.Label1)
        Me.gbID.Controls.Add(Me.txtID)
        Me.gbID.Enabled = False
        Me.gbID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbID.Location = New System.Drawing.Point(12, 34)
        Me.gbID.Name = "gbID"
        Me.gbID.Size = New System.Drawing.Size(265, 76)
        Me.gbID.TabIndex = 42
        Me.gbID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(13, 41)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(226, 29)
        Me.txtID.TabIndex = 0
        '
        'frmGestaoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(799, 631)
        Me.Controls.Add(Me.gbID)
        Me.Controls.Add(Me.gbPesquisar)
        Me.Controls.Add(Me.btnApagar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.gbEndereco)
        Me.Controls.Add(Me.gbGeral)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGestaoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mercúrio Fashion - Gestão de Clientes"
        Me.gbEndereco.ResumeLayout(False)
        Me.gbEndereco.PerformLayout()
        Me.gbGeral.ResumeLayout(False)
        Me.gbGeral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisar.ResumeLayout(False)
        Me.gbPesquisar.PerformLayout()
        Me.gbID.ResumeLayout(False)
        Me.gbID.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents label122 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCel As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtRG As TextBox
    Friend WithEvents txtNascimento As DateTimePicker
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents label213 As Label
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenero As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEstado As ComboBox
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents gbEndereco As GroupBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbGeral As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnApagar As Button
    Friend WithEvents gbPesquisar As GroupBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents gbID As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
End Class
