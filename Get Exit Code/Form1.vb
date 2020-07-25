Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim startInfo As New System.Diagnostics.ProcessStartInfo
        Dim MyProces As Process

        startInfo.FileName = "..\..\..\ExitCode\bin\Debug\ExitCode.exe"
        startInfo.Arguments = InputBox("Enter exit code to send and verify if that code returns")
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden

        MyProces = Process.Start(startInfo)
        MyProces.WaitForExit()

        MsgBox(MyProces.ExitCode)
        MsgBox("0x" + Hex(MyProces.ExitCode()))
    End Sub
End Class
