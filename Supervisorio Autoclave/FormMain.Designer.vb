<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.RichTextBoxLog = New System.Windows.Forms.RichTextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBoxCiclo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTipo = New System.Windows.Forms.TextBox()
        Me.ButtonOnOff = New System.Windows.Forms.Button()
        Me.TextBoxResultado = New System.Windows.Forms.TextBox()
        Me.TextBoxOperacao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxInicio = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalvarLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRelatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSobre = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxLog
        '
        Me.RichTextBoxLog.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.RichTextBoxLog.Location = New System.Drawing.Point(15, 22)
        Me.RichTextBoxLog.Name = "RichTextBoxLog"
        Me.RichTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxLog.Size = New System.Drawing.Size(316, 287)
        Me.RichTextBoxLog.TabIndex = 0
        Me.RichTextBoxLog.Text = ""
        '
        'SerialPort1
        '
        '
        'TextBoxCiclo
        '
        Me.TextBoxCiclo.Location = New System.Drawing.Point(391, 34)
        Me.TextBoxCiclo.Name = "TextBoxCiclo"
        Me.TextBoxCiclo.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxCiclo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ciclo Nº"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo"
        '
        'TextBoxTipo
        '
        Me.TextBoxTipo.Location = New System.Drawing.Point(391, 62)
        Me.TextBoxTipo.Name = "TextBoxTipo"
        Me.TextBoxTipo.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxTipo.TabIndex = 2
        '
        'ButtonOnOff
        '
        Me.ButtonOnOff.Location = New System.Drawing.Point(357, 176)
        Me.ButtonOnOff.Name = "ButtonOnOff"
        Me.ButtonOnOff.Size = New System.Drawing.Size(68, 23)
        Me.ButtonOnOff.TabIndex = 5
        Me.ButtonOnOff.Text = "Ligar"
        Me.ButtonOnOff.UseVisualStyleBackColor = True
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxResultado.Location = New System.Drawing.Point(12, 315)
        Me.TextBoxResultado.MaxLength = 50
        Me.TextBoxResultado.Name = "TextBoxResultado"
        Me.TextBoxResultado.ReadOnly = True
        Me.TextBoxResultado.Size = New System.Drawing.Size(319, 13)
        Me.TextBoxResultado.TabIndex = 10
        Me.TextBoxResultado.TabStop = False
        '
        'TextBoxOperacao
        '
        Me.TextBoxOperacao.Location = New System.Drawing.Point(391, 89)
        Me.TextBoxOperacao.Name = "TextBoxOperacao"
        Me.TextBoxOperacao.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxOperacao.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Operação"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Inicio"
        '
        'TextBoxInicio
        '
        Me.TextBoxInicio.Location = New System.Drawing.Point(391, 117)
        Me.TextBoxInicio.Name = "TextBoxInicio"
        Me.TextBoxInicio.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxInicio.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MenuConfig, Me.MenuAjuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSalvarLog, Me.ToolStripSeparator1, Me.MenuLogs, Me.MenuRelatorios, Me.ToolStripSeparator2, Me.MenuSair})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "&Arquivo"
        '
        'MenuSalvarLog
        '
        Me.MenuSalvarLog.Name = "MenuSalvarLog"
        Me.MenuSalvarLog.Size = New System.Drawing.Size(199, 22)
        Me.MenuSalvarLog.Text = "Salvar log"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'MenuLogs
        '
        Me.MenuLogs.Name = "MenuLogs"
        Me.MenuLogs.Size = New System.Drawing.Size(199, 22)
        Me.MenuLogs.Text = "Abrir pasta de logs"
        '
        'MenuRelatorios
        '
        Me.MenuRelatorios.Name = "MenuRelatorios"
        Me.MenuRelatorios.Size = New System.Drawing.Size(199, 22)
        Me.MenuRelatorios.Text = "Abrir pasta de relatórios"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'MenuSair
        '
        Me.MenuSair.Name = "MenuSair"
        Me.MenuSair.Size = New System.Drawing.Size(199, 22)
        Me.MenuSair.Text = "Sair"
        '
        'MenuConfig
        '
        Me.MenuConfig.Name = "MenuConfig"
        Me.MenuConfig.Size = New System.Drawing.Size(96, 20)
        Me.MenuConfig.Text = "&Configurações"
        '
        'MenuAjuda
        '
        Me.MenuAjuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSobre})
        Me.MenuAjuda.Name = "MenuAjuda"
        Me.MenuAjuda.Size = New System.Drawing.Size(50, 20)
        Me.MenuAjuda.Text = "A&juda"
        '
        'MenuSobre
        '
        Me.MenuSobre.Name = "MenuSobre"
        Me.MenuSobre.Size = New System.Drawing.Size(104, 22)
        Me.MenuSobre.Text = "Sobre"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 334)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxInicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxOperacao)
        Me.Controls.Add(Me.TextBoxResultado)
        Me.Controls.Add(Me.ButtonOnOff)
        Me.Controls.Add(Me.TextBoxTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCiclo)
        Me.Controls.Add(Me.RichTextBoxLog)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supervisório Autoclave"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBoxLog As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents TextBoxCiclo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTipo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOnOff As System.Windows.Forms.Button
    Friend WithEvents TextBoxResultado As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOperacao As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInicio As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSalvarLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAjuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSobre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuRelatorios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
