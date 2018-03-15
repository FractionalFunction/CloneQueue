Public Class CloneQueue
    ' Main Class

    Public Shared Sub Clone(url As String)
        ' Clone the Git repository using the command line

        Process.Start("git", "clone " & url)
    End Sub
End Class
