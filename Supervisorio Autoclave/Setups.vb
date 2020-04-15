Imports System.IO

Public Class Setups

    Private Sub Setups_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxPortas.Items.Add(sp)
        Next
        'LerConfig()
        TextBoxLogs.Text = My.Settings.CaminhoLogs
        TextBoxRelatorios.Text = My.Settings.CaminhoRelatorios
        ComboBoxPortas.Text = My.Settings.PortaCOM
        CheckBoxAutoConect.Checked = My.Settings.AutoConect
        RadioButtonInicio.Checked = My.Settings.LimparAoIniciar
        RadioButtonFim.Checked = Not My.Settings.LimparAoIniciar
        If My.Settings.CaminhoLogs = "" Or Not Directory.Exists(My.Settings.CaminhoLogs) Then
            TextBoxLogs.BackColor = Color.LightPink
        End If
        If My.Settings.CaminhoRelatorios = "" Or Not Directory.Exists(My.Settings.CaminhoRelatorios) Then
            TextBoxRelatorios.BackColor = Color.LightPink
        End If
        If My.Settings.PortaCOM = "" Or Not My.Computer.Ports.SerialPortNames.Contains(ComboBoxPortas.Text) Then
            'Aviso
        End If
    End Sub

    Private Sub TextBoxLogs_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLogs.TextChanged
        If TextBoxLogs.Text = "" Or Not Directory.Exists(TextBoxLogs.Text) Then
            TextBoxLogs.BackColor = Color.LightPink
        Else
            TextBoxLogs.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBoxRelatorios_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRelatorios.TextChanged
        If TextBoxRelatorios.Text = "" Or Not Directory.Exists(TextBoxRelatorios.Text) Then
            TextBoxRelatorios.BackColor = Color.LightPink
        Else
            TextBoxRelatorios.BackColor = Color.White
        End If
    End Sub

    Private Sub ComboBoxPortas_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPortas.DropDown
        ComboBoxPortas.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxPortas.Items.Add(sp)
        Next
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim Validado As Boolean = True
        Dim PortaValida As Boolean = True
        If TextBoxLogs.Text = "" Or Not Directory.Exists(TextBoxLogs.Text) Then
            TextBoxLogs.BackColor = Color.LightPink
            Validado = False
        End If
        If TextBoxRelatorios.Text = "" Or Not Directory.Exists(TextBoxRelatorios.Text) Then
            TextBoxRelatorios.BackColor = Color.LightPink
            Validado = False
        End If
        If ComboBoxPortas.Text = "" Or Not My.Computer.Ports.SerialPortNames.Contains(ComboBoxPortas.Text) Then
            PortaValida = False
            MessageBox.Show("Selecione uma porta COM válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Validado Then
            My.Settings.CaminhoLogs = TextBoxLogs.Text
            My.Settings.CaminhoRelatorios = TextBoxRelatorios.Text
            My.Settings.PortaCOM = ComboBoxPortas.Text
            My.Settings.AutoConect = CheckBoxAutoConect.Checked
            My.Settings.LimparAoIniciar = RadioButtonInicio.Checked
            My.Settings.Save()
            FormMain.StatusPort.Text = My.Settings.PortaCOM
            Me.Close()
        Else
            MessageBox.Show("Verifique os caminhos das pastas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Function SelectFolder() As String
        FolderBrowserDialog1.Description = "Selecione uma pasta"
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            SelectFolder = FolderBrowserDialog1.SelectedPath
        Else
            SelectFolder = ""
        End If
    End Function

    Private Sub ButtonSelLogs_Click(sender As Object, e As EventArgs) Handles ButtonSelLogs.Click
        Dim Pasta As String = SelectFolder()
        If Pasta <> "" Then
            TextBoxLogs.Text = Pasta
        End If
    End Sub

    Private Sub ButtonSelRelatorios_Click(sender As Object, e As EventArgs) Handles ButtonSelRelatorios.Click
        Dim Pasta As String = SelectFolder()
        If Pasta <> "" Then
            TextBoxRelatorios.Text = Pasta
        End If
    End Sub

End Class