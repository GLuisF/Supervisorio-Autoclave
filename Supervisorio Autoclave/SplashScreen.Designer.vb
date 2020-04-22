<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.ProgressBarLoading = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelLoadingText = New System.Windows.Forms.Label()
        Me.LabelPorcentagem = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SupervisorioAutoclave.My.Resources.Resources.Logo_Frasel
        Me.PictureBox1.Location = New System.Drawing.Point(24, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(198, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FRASEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(200, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Supervisório Autoclave"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelVersion.ForeColor = System.Drawing.Color.Gray
        Me.LabelVersion.Location = New System.Drawing.Point(485, 95)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(54, 16)
        Me.LabelVersion.TabIndex = 3
        Me.LabelVersion.Text = "version"
        '
        'ProgressBarLoading
        '
        Me.ProgressBarLoading.Location = New System.Drawing.Point(206, 136)
        Me.ProgressBarLoading.Name = "ProgressBarLoading"
        Me.ProgressBarLoading.Size = New System.Drawing.Size(303, 20)
        Me.ProgressBarLoading.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelLoadingText)
        Me.Panel1.Controls.Add(Me.LabelPorcentagem)
        Me.Panel1.Controls.Add(Me.LabelVersion)
        Me.Panel1.Controls.Add(Me.ProgressBarLoading)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 198)
        Me.Panel1.TabIndex = 5
        '
        'LabelLoadingText
        '
        Me.LabelLoadingText.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelLoadingText.ForeColor = System.Drawing.Color.Gray
        Me.LabelLoadingText.Location = New System.Drawing.Point(206, 159)
        Me.LabelLoadingText.Name = "LabelLoadingText"
        Me.LabelLoadingText.Size = New System.Drawing.Size(303, 19)
        Me.LabelLoadingText.TabIndex = 6
        Me.LabelLoadingText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelPorcentagem
        '
        Me.LabelPorcentagem.AutoSize = True
        Me.LabelPorcentagem.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelPorcentagem.ForeColor = System.Drawing.Color.Gray
        Me.LabelPorcentagem.Location = New System.Drawing.Point(510, 140)
        Me.LabelPorcentagem.Name = "LabelPorcentagem"
        Me.LabelPorcentagem.Size = New System.Drawing.Size(28, 16)
        Me.LabelPorcentagem.TabIndex = 5
        Me.LabelPorcentagem.Text = "0%"
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(565, 198)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents ProgressBarLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelPorcentagem As System.Windows.Forms.Label
    Friend WithEvents LabelLoadingText As System.Windows.Forms.Label
End Class
