<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setups
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setups))
        Me.ButtonSelLogs = New System.Windows.Forms.Button()
        Me.TextBoxLogs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonSelRelatorios = New System.Windows.Forms.Button()
        Me.TextBoxRelatorios = New System.Windows.Forms.TextBox()
        Me.ComboBoxPortas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxAutoConect = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'ButtonSelLogs
        '
        Me.ButtonSelLogs.Location = New System.Drawing.Point(579, 37)
        Me.ButtonSelLogs.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSelLogs.Name = "ButtonSelLogs"
        Me.ButtonSelLogs.Size = New System.Drawing.Size(29, 21)
        Me.ButtonSelLogs.TabIndex = 7
        Me.ButtonSelLogs.TabStop = False
        Me.ButtonSelLogs.Text = "..."
        Me.ButtonSelLogs.UseVisualStyleBackColor = True
        '
        'TextBoxLogs
        '
        Me.TextBoxLogs.BackColor = System.Drawing.Color.White
        Me.TextBoxLogs.Location = New System.Drawing.Point(15, 37)
        Me.TextBoxLogs.Name = "TextBoxLogs"
        Me.TextBoxLogs.Size = New System.Drawing.Size(561, 20)
        Me.TextBoxLogs.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Local da pasta de logs:"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(505, 129)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(35, 23)
        Me.ButtonOK.TabIndex = 5
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(546, 129)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(62, 23)
        Me.ButtonCancelar.TabIndex = 6
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Local da pasta de relatórios:"
        '
        'ButtonSelRelatorios
        '
        Me.ButtonSelRelatorios.Location = New System.Drawing.Point(579, 78)
        Me.ButtonSelRelatorios.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSelRelatorios.Name = "ButtonSelRelatorios"
        Me.ButtonSelRelatorios.Size = New System.Drawing.Size(29, 21)
        Me.ButtonSelRelatorios.TabIndex = 7
        Me.ButtonSelRelatorios.TabStop = False
        Me.ButtonSelRelatorios.Text = "..."
        Me.ButtonSelRelatorios.UseVisualStyleBackColor = True
        '
        'TextBoxRelatorios
        '
        Me.TextBoxRelatorios.Location = New System.Drawing.Point(15, 78)
        Me.TextBoxRelatorios.Name = "TextBoxRelatorios"
        Me.TextBoxRelatorios.Size = New System.Drawing.Size(561, 20)
        Me.TextBoxRelatorios.TabIndex = 2
        '
        'ComboBoxPortas
        '
        Me.ComboBoxPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPortas.FormattingEnabled = True
        Me.ComboBoxPortas.Location = New System.Drawing.Point(138, 104)
        Me.ComboBoxPortas.Name = "ComboBoxPortas"
        Me.ComboBoxPortas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBoxPortas.Size = New System.Drawing.Size(84, 21)
        Me.ComboBoxPortas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Selecione a porta serial:"
        '
        'CheckBoxAutoConect
        '
        Me.CheckBoxAutoConect.AutoSize = True
        Me.CheckBoxAutoConect.Location = New System.Drawing.Point(229, 107)
        Me.CheckBoxAutoConect.Name = "CheckBoxAutoConect"
        Me.CheckBoxAutoConect.Size = New System.Drawing.Size(252, 17)
        Me.CheckBoxAutoConect.TabIndex = 4
        Me.CheckBoxAutoConect.Text = "Conectar automaticamente ao ligar o programa?"
        Me.CheckBoxAutoConect.UseVisualStyleBackColor = True
        '
        'Setups
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancelar
        Me.ClientSize = New System.Drawing.Size(624, 162)
        Me.Controls.Add(Me.CheckBoxAutoConect)
        Me.Controls.Add(Me.ComboBoxPortas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonSelRelatorios)
        Me.Controls.Add(Me.TextBoxRelatorios)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSelLogs)
        Me.Controls.Add(Me.TextBoxLogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setups"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSelLogs As System.Windows.Forms.Button
    Friend WithEvents TextBoxLogs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelRelatorios As System.Windows.Forms.Button
    Friend WithEvents TextBoxRelatorios As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxPortas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxAutoConect As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
