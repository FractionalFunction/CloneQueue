Public Class CloneQueue
    ' Main Class

    Public Shared Sub Clone(url As String)
        ' Clone the Git repository using the command line

        Dim clone As New Process()

        clone.StartInfo.UseShellExecute = False
        clone.StartInfo.CreateNoWindow = True
        clone.StartInfo.FileName = "git"
        clone.StartInfo.Arguments = "clone " & url

        ' Allow the outputs of the process to be read
        clone.StartInfo.RedirectStandardOutput = True
        clone.StartInfo.RedirectStandardError = True

        ' Clone the repository
        clone.Start()

        ' Pause the function until the process exits
        clone.WaitForExit()

        If clone.ExitCode = 0 Then
            ' Indicate that the clone was successful
            Dim successMessage As String = "Clone complete." _
                & Environment.NewLine _
                & clone.StandardOutput.ReadToEnd()

            MessageBox.Show(successMessage)

        Else
            ' Display the error code and the standard error
            ' output From git if the clone fails
            Dim errorMessage As String =
                clone.StandardError.ReadToEnd() _
                & Environment.NewLine _
                & "Error code: " & clone.ExitCode.ToString()

            MessageBox.Show(errorMessage)
        End If
    End Sub
End Class
