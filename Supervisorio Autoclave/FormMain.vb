Imports System.IO
Imports System.Text

Public Class FormMain
    Dim ComunicacaoOK As Boolean = False
    Dim Ciclo As New clsCiclo
    Dim FirstMinimized As Boolean = True

    Private Sub FormMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'If Me.WindowState = FormWindowState.Minimized Then OcultarForm()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReexibirForm()
        End If
    End Sub

    Private Sub NotifReexibir_Click(sender As Object, e As EventArgs) Handles NotifReexibir.Click
        ReexibirForm()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        ReexibirForm()
    End Sub

    Private Sub OcultarForm()
        Try
            Me.Visible = False
            NotifyIcon1.Visible = True
            If FirstMinimized Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipTitle = "Aplicação em segundo plano"
                NotifyIcon1.BalloonTipText = "Clique para reexibir"
                NotifyIcon1.ShowBalloonTip(500)
                FirstMinimized = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReexibirForm()
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing And ComunicacaoOK Then
            e.Cancel = True
            OcultarForm()
        End If
    End Sub

    Private Sub NotifSair_Click(sender As Object, e As EventArgs) Handles NotifSair.Click
        End
    End Sub

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        StatusPort.Text = My.Settings.PortaCOM
        StatusPort.Image = My.Resources.Disconnected
        If My.Settings.AutoConect Then
            LigarComunicacao()
        End If
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        ClosePort()
    End Sub

    Delegate Sub meumetodo(ByVal [text] As String)
    Dim subrotinaSTR As New meumetodo(AddressOf TratamentoSTR)
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        System.Threading.Thread.Sleep(500)
        If SerialPort1.IsOpen() Then
            Dim string1 As String = SerialPort1.ReadExisting()
            Invoke(subrotinaSTR, string1)
        End If
    End Sub
    Sub TratamentoSTR(ByVal meustring As String)
        If Not Ciclo.Iniciado Then
            Ciclo.Iniciado = True
            If My.Settings.LimparAoIniciar Then LimparForm()
        End If
        RichTextBoxLog.AppendText(meustring)
        RichTextBoxLog.ScrollToCaret()
        For Each linha In meustring.Split(vbLf) '(vbNewLine)
            If linha.Length >= 9 Then
                If linha.Contains("CICLO") And Not linha.Contains("FIM") And Ciclo.Numero = "" Then
                    Dim i As Byte
                    Dim c As Char
                    For i = 0 To linha.Length - 1
                        c = linha.Substring(i, 1)
                        If c >= "0" And c <= "9" Then
                            Ciclo.Numero = Ciclo.Numero & c
                        End If
                    Next
                    If Ciclo.Numero = "" Then Ciclo.Numero = "0000"
                    TextBoxCiclo.Text = Ciclo.Numero
                End If
                If linha.Contains("PROGRAMA") Then
                    Dim i As Byte
                    Dim c As Char
                    Dim sPrograma As String = ""
                    For i = 0 To linha.Length - 1
                        c = linha.Substring(i, 1)
                        If c >= "0" And c <= "9" Then
                            sPrograma = sPrograma & c
                        End If
                    Next
                    If sPrograma = "" Then sPrograma = "0"
                    Ciclo.Programa = Val(sPrograma)
                    TextBoxTipo.Text = Ciclo.Programa
                End If
                If linha.Contains("OPERACAO") Then
                    Dim aOperacao = linha.TrimEnd.Split(" ")
                    Dim Operacao = aOperacao(1)
                    Dim Inicio = aOperacao.Last
                    TextBoxOperacao.Text = Operacao
                    TextBoxInicio.Text = Inicio
                    Select Case Operacao
                        Case "1"
                            Ciclo.Operacao(1).Inicio = Inicio
                        Case "2"
                            Ciclo.Operacao(1).Fim = Inicio
                            Ciclo.Operacao(2).Inicio = Inicio
                        Case "3"
                            Ciclo.Operacao(2).Fim = Inicio
                            Ciclo.Operacao(3).Inicio = Inicio
                        Case "4"
                            Ciclo.Operacao(3).Fim = Inicio
                            Ciclo.Operacao(4).Inicio = Inicio
                    End Select
                End If
                If linha.Contains("FIM DE CICLO") Then
                    Dim aFim = linha.TrimEnd.Split(" ")
                    Ciclo.Operacao(4).Fim = aFim.Last
                End If
                If linha.Contains("OPER.") Then
                    If Ciclo.Numero = "" Then
                        StatusResultado.Text = "Número do ciclo não recebido. Salvar Log manualmente"
                        If Me.Visible = False Then
                            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                            NotifyIcon1.BalloonTipTitle = StatusResultado.Text
                            NotifyIcon1.BalloonTipText = "Clique para reexibir"
                            NotifyIcon1.ShowBalloonTip(500)
                        End If
                    Else
                        If Directory.Exists(My.Settings.CaminhoRelatorios) And Directory.Exists(My.Settings.CaminhoLogs) Then
                            Dim FileName As String = "PROGRAMA " & Ciclo.Programa & ".txt"
                            SaveRelatorio(My.Settings.CaminhoRelatorios & "\" & FileName)
                            FileName = Ciclo.Programa & "-" & Ciclo.Numero & ".txt"
                            SaveLog(My.Settings.CaminhoLogs & "\" & FileName)
                            StatusResultado.Text = "Arquivo " & FileName & " salvo com sucesso"
                            If Me.Visible = False Then
                                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                                NotifyIcon1.BalloonTipTitle = StatusResultado.Text
                                NotifyIcon1.BalloonTipText = "Clique para reexibir"
                                NotifyIcon1.ShowBalloonTip(500)
                            End If
                            If My.Settings.LimparAoIniciar = False Then LimparForm()
                            Ciclo.Resetar()
                        Else
                            StatusResultado.Text = "Erro ao gerar o arquivo"
                            If Me.Visible = False Then
                                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                                NotifyIcon1.BalloonTipTitle = StatusResultado.Text
                                NotifyIcon1.BalloonTipText = "Clique para reexibir"
                                NotifyIcon1.ShowBalloonTip(500)
                            Else
                                MessageBox.Show("A pasta de Logs e/ou Relatórios não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Dim Ligado As Boolean = False
    Private Sub ButtonLigaDesliga_Click(sender As Object, e As EventArgs) Handles ButtonLigaDesliga.Click
        If Not ComunicacaoOK Then
            LigarComunicacao()
        Else
            DesligarComunicacao()
        End If
        RichTextBoxLog.Focus()
    End Sub

    Private Sub LigarComunicacao()
        Dim Ligar As Boolean = True
        If Not VerificarCaminhos() Then
            Ligar = False
            MessageBox.Show("Verifique os caminhos das pastas de Logs e Relatórios em Configurações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not OpenPort() Then
            Ligar = False
            MessageBox.Show("Erro ao tentar abrir a porta " & My.Settings.PortaCOM, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Ligar Then
            ButtonLigaDesliga.BackgroundImage = My.Resources.Ligado
            LabelLigaDesliga.Text = "Ligado"
            ComunicacaoOK = True
            StatusResultado.Text = "Porta " & My.Settings.PortaCOM & " conectada com sucesso"
            StatusPort.Image = My.Resources.Connected

        Else
            ButtonLigaDesliga.BackgroundImage = My.Resources.Desligado
            LabelLigaDesliga.Text = "Desligado"
            ComunicacaoOK = False
        End If
    End Sub

    Private Sub DesligarComunicacao()
        ButtonLigaDesliga.BackgroundImage = My.Resources.Desligado
        LabelLigaDesliga.Text = "Desligado"
        ComunicacaoOK = False
        ClosePort()
        StatusResultado.Text = "Porta " & My.Settings.PortaCOM & " desconectada"
        StatusPort.Image = My.Resources.Disconnected
    End Sub

    Private Function OpenPort() As Boolean
        OpenPort = False
        If Not SerialPort1.IsOpen() And My.Settings.PortaCOM <> "" Then
            SerialPort1.PortName = My.Settings.PortaCOM
            Try
                SerialPort1.Open()
            Catch ex As Exception
                'MessageBox.Show("A Porta " & PortaCOM & " esta sendo usada por outro aplicativo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            If SerialPort1.IsOpen Then
                OpenPort = True
                'Mensagem de porta aberta com sucesso
            End If
        End If
    End Function

    Private Sub ClosePort()
        SerialPort1.Close()
    End Sub

    Private Sub MenuConfig_Click(sender As Object, e As EventArgs) Handles MenuConfig.Click
        DesligarComunicacao()
        Setups.Show()
    End Sub

    Private Sub MenuSair_Click(sender As Object, e As EventArgs) Handles MenuSair.Click
        End
    End Sub

    Private Sub MenuSobre_Click(sender As Object, e As EventArgs) Handles MenuSobre.Click
        MessageBox.Show("Supervisório Autoclave v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor _
                        & "." & My.Application.Info.Version.Build & vbNewLine & "Desenvolvido por André e Giovani", "Supervisorio Autoclave")
    End Sub

    Private Function VerificarCaminhos() As Boolean
        VerificarCaminhos = False
        If Directory.Exists(My.Settings.CaminhoLogs) And Directory.Exists(My.Settings.CaminhoRelatorios) Then
            VerificarCaminhos = True
        End If
    End Function

    Private Sub MenuLogs_Click(sender As Object, e As EventArgs) Handles MenuLogs.Click
        If Directory.Exists(My.Settings.CaminhoLogs) Then Process.Start(My.Settings.CaminhoLogs)
    End Sub

    Private Sub MenuRelatorios_Click(sender As Object, e As EventArgs) Handles MenuRelatorios.Click
        If Directory.Exists(My.Settings.CaminhoRelatorios) Then Process.Start(My.Settings.CaminhoRelatorios)
    End Sub

    Private Sub MenuSalvarLog_Click(sender As Object, e As EventArgs) Handles MenuSalvarLog.Click
        If My.Settings.CaminhoLogs <> "" Then SaveFileDialog1.InitialDirectory = My.Settings.CaminhoLogs
        SaveFileDialog1.FileName = TextBoxTipo.Text & "-" & TextBoxCiclo.Text & ".txt"
        SaveFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim SelectedFile As String = SaveFileDialog1.FileName
            SaveLog(SelectedFile)
            StatusResultado.Text = "Arquivo " & SelectedFile.Split("\").Last & " salvo com sucesso"
            Dim FileName As String = "PROGRAMA " & Ciclo.Programa & ".txt"
            SaveRelatorio(My.Settings.CaminhoRelatorios & "\" & FileName)
        End If
    End Sub

    Private Sub SaveLog(ByVal FilePath As String)
        Dim fs As StreamWriter = File.CreateText(FilePath)
        Dim linha_log As String
        For Each linha_log In RichTextBoxLog.Text.Split(vbLf)
            fs.Write(linha_log & vbCrLf)
        Next
        fs.Close()
    End Sub

    Private Sub SaveRelatorio(ByVal FilePath As String)
        Dim Texto As String
        If Not File.Exists(FilePath) Then
            Dim CreateFile As StreamWriter = File.CreateText(FilePath)
            Texto = "CICLO"
            For i = 1 To 4
                Texto = Texto & vbTab & "OPERAÇÃO " & i
            Next
            Texto = Texto & vbTab & "FIM" & vbCrLf
            CreateFile.Write(Texto)
            CreateFile.Close()
        End If
        Dim AppendFile As StreamWriter = File.AppendText(FilePath)
        Texto = Ciclo.Numero
        For i = 1 To 4
            Texto = Texto & vbTab & Ciclo.Operacao(i).Inicio
        Next
        Texto = Texto & vbTab & Ciclo.Operacao(4).Fim & vbCrLf
        AppendFile.Write(Texto)
        AppendFile.Close()
    End Sub

    Public Structure sOperacao
        Dim Tipo As Integer
        Dim Inicio As String
        Dim Fim As String
    End Structure

    Public Class clsCiclo
        Public Iniciado As Boolean
        Public Numero As String
        Public Programa As Integer
        Public Operacao(4) As sOperacao
        Public Sub New()
            Resetar()
        End Sub
        Public Sub Resetar()
            Iniciado = False
            Numero = ""
            Programa = 0
            For i = 1 To 4
                Operacao(i).Inicio = "00:00:00"
                Operacao(i).Fim = "00:00:00"
            Next
        End Sub
    End Class

    Private Sub TextBoxCiclo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCiclo.TextChanged
        Ciclo.Numero = TextBoxCiclo.Text
    End Sub
    Private Sub TextBoxTipo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTipo.TextChanged
        Ciclo.Programa = Val(TextBoxTipo.Text)
    End Sub

    Private Sub LimparForm()
        RichTextBoxLog.Text = ""
        TextBoxCiclo.Text = ""
        TextBoxOperacao.Text = ""
        TextBoxTipo.Text = ""
        TextBoxInicio.Text = ""
    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        LimparForm()
        Ciclo.Resetar()
        StatusResultado.Text = ""
    End Sub

End Class