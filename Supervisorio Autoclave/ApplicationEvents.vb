Imports System.Collections.ObjectModel
Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Verifica o número de instancias da aplicação já a correr
            Dim p() As Process = Process.GetProcessesByName(My.Application.Info.AssemblyName)

            ' Caso sejam mais do que 1
            If p.Length > 1 Then

                MessageBox.Show("O aplicatico já está sendo executado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ' Cancela o processo de inicialização
                e.Cancel = True

            End If
        End Sub

        Protected Overrides Function OnInitialize(commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 4000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

    End Class


End Namespace

