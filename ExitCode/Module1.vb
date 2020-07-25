Module Module1

    Sub Main()

        Dim Args() As String = System.Environment.GetCommandLineArgs()

        Dim ec As Integer
        If Args.Count = 2 Then
            Try
                ec = Args(1)
            Catch ex As Exception
                ec = -1
            End Try
        Else
            ec = -2
        End If

        MsgBox("vou sair")
        Environment.Exit(Args(1))
        MsgBox("sai")
    End Sub

End Module
