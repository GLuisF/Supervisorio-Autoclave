Public Class SplashScreen
    Public LoadingText(10) As String
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadingText(0) = "Inicializando Supervisório Autoclave"
        LoadingText(1) = LoadingText(0)
        LoadingText(2) = "Verificando pasta de Logs"
        LoadingText(3) = LoadingText(2)
        LoadingText(4) = "Verificando pasta de Relatórios"
        LoadingText(5) = LoadingText(4)
        LoadingText(6) = "Verificando Porta Serial"
        LoadingText(7) = LoadingText(6)
        LoadingText(8) = "Inicialização concluída com sucesso"
        LoadingText(9) = LoadingText(8)
        LoadingText(10) = LoadingText(9)

        LabelVersion.Text = "v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor _
                        & "." & My.Application.Info.Version.Build
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        System.Threading.Thread.Sleep(100)
        For i = 0 To 10
            ProgressBarLoading.Value = 10 * i
            LabelPorcentagem.Text = 10 * i & "%"
            LabelLoadingText.Text = LoadingText(i)
            System.Threading.Thread.Sleep(300)
            Application.DoEvents()
        Next
    End Sub
End Class