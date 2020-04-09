Imports System.IO
Imports System.Text

Public Class FormMain
    Dim ComunicacaoOK As Boolean = False
    Dim CICLO_OK As Boolean = False

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
        RichTextBoxLog.AppendText(meustring)
        RichTextBoxLog.ScrollToCaret()
        For Each linha In meustring.Split(vbLf) '(vbNewLine)
            If linha.Length >= 9 Then
                If Not linha.Contains("FIM DE CICLO") And linha.Contains("CICLO") And Not CICLO_OK Then
                    Dim i As Byte
                    Dim c As Char
                    Dim sCiclo As String = ""
                    For i = 0 To linha.Length - 1
                        c = linha.Substring(i, 1)
                        If c >= "0" And c <= "9" Then
                            sCiclo = sCiclo & c
                        End If
                    Next
                    If sCiclo = "" Then sCiclo = "0000"
                    TextBoxCiclo.Text = sCiclo
                    CICLO_OK = True
                End If
                If linha.Contains("PROGRAMA") Then
                    Dim i As Byte
                    Dim c As Char
                    Dim sPrograma As String = ""
                    Dim Programa As Integer
                    For i = 0 To linha.Length - 1
                        c = linha.Substring(i, 1)
                        If c >= "0" And c <= "9" Then
                            sPrograma = sPrograma & c
                        End If
                    Next
                    If sPrograma = "" Then sPrograma = "0"
                    Programa = Val(sPrograma)
                    TextBoxTipo.Text = Programa
                End If
                If linha.Contains("OPERACAO") Then
                    Dim aOperacao = linha.TrimEnd.Split(" ")
                    Dim Operacao = aOperacao(1)
                    Dim Inicio = aOperacao.Last
                    TextBoxOperacao.Text = Operacao
                    TextBoxInicio.Text = Inicio
                End If
                If linha.Contains("FIM DE CICLO") Then
                    If Directory.Exists(My.Settings.CaminhoLogs) Then
                        Dim FileName As String = TextBoxTipo.Text & "-" & TextBoxCiclo.Text & ".txt"
                        SaveFile(My.Settings.CaminhoLogs & "\" & FileName)
                        TextBoxResultado.Text = "Arquivo " & FileName & " gerado com sucesso"
                        RichTextBoxLog.Text = ""
                        TextBoxCiclo.Text = ""
                        TextBoxOperacao.Text = ""
                        TextBoxTipo.Text = ""
                        TextBoxInicio.Text = ""
                        CICLO_OK = False
                    Else
                        MessageBox.Show("Pasta de Logs não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBoxResultado.Text = "Erro ao gerar o arquivo"
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub ButtonOnOff_Click(sender As Object, e As EventArgs) Handles ButtonOnOff.Click
        If ButtonOnOff.Text = "Ligar" Then
            LigarComunicacao()
        Else
            DesligarComunicacao()
        End If
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
            ButtonOnOff.Text = "Desligar"
            ComunicacaoOK = True
            TextBoxResultado.Text = "Porta " & My.Settings.PortaCOM & " aberta com sucesso"
        Else
            ButtonOnOff.Text = "Ligar"
            ComunicacaoOK = False
        End If
    End Sub

    Private Sub DesligarComunicacao()
        ComunicacaoOK = False
        ClosePort()
        ButtonOnOff.Text = "Ligar"
        TextBoxResultado.Text = ""
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
                        & vbNewLine & "Desenvolvido por André e Giovani", "Supervisorio Autoclave")
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
            SaveFile(SelectedFile)
        End If
    End Sub

    Private Sub SaveFile(ByVal FilePath As String)
        Dim fs As StreamWriter = File.CreateText(FilePath)
        Dim linha_log As String
        For Each linha_log In RichTextBoxLog.Text.Split(vbLf)
            fs.Write(linha_log & vbCrLf)
        Next
        fs.Close()
    End Sub
End Class