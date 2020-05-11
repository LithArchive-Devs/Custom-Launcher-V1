Public Class TPSLauncher
    Public Class MyUtilities
        Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
            pi.FileName = "Lithtech.exe"
            p.StartInfo = pi
            p.Start()
        End Sub
    End Class


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MyUtilities.RunCommandCom("Lithtech.exe", "-cmdfile launchcmds.txt -GOMULTIJOIN 1 +join " + IPAddress.Text + ":" + Port.Text, True)

    End Sub

End Class
