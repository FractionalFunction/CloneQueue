﻿Public Class CloneQueue
    ' Main Class

    Public Shared Function GitIsFunctional(displayErrors As Boolean) As Boolean
        ' Check that Git is reachable and operational
        ' Calls "git --version"

        Dim git As New Process()

        git.StartInfo.UseShellExecute = False
        git.StartInfo.CreateNoWindow = True
        git.StartInfo.FileName = "git"
        git.StartInfo.Arguments = "--version"

        ' Allow the outputs of the process to be read
        git.StartInfo.RedirectStandardOutput = True
        git.StartInfo.RedirectStandardError = True

        Try
            git.Start()
        Catch ex As Exception
            ' Git is not installed or was not added to the system path

            If displayErrors Then
                Dim errorMessage As String =
                    "Git is not reachable." _
                    & "Make sure that Git is installed" _
                    & "and was added to the system path." _
                    & Environment.NewLine _
                    & ex.Message

                MessageBox.Show(
                    errorMessage,
                    "Git error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End If

            Return False
        End Try

        ' Pause the function until the process exits
        git.WaitForExit()

        If git.ExitCode <> 0 Then
            ' Git is reachable but returned an error

            If displayErrors Then
                Dim errorMessage As String =
                    "Git encountered an error:" _
                    & Environment.NewLine _
                    & git.StandardError.ReadToEnd() _
                    & Environment.NewLine _
                    & "Error code: " & git.ExitCode.ToString()

                MessageBox.Show(
                    errorMessage,
                    "Git error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End If

            Return False
        End If

        Return True
    End Function

    Public Shared Function Clone(url As String) As Process
        ' Clone the Git repository using the command line

        Dim cloneCall As New Process()

        cloneCall.StartInfo.UseShellExecute = False
        cloneCall.StartInfo.CreateNoWindow = True
        cloneCall.StartInfo.FileName = "git"
        cloneCall.StartInfo.Arguments = "clone " & url

        ' Allow the outputs of the process to be read
        cloneCall.StartInfo.RedirectStandardOutput = True
        cloneCall.StartInfo.RedirectStandardError = True

        ' Clone the repository
        cloneCall.Start()

        ' Pause the function until the process exits
        cloneCall.WaitForExit()

        If cloneCall.ExitCode = 0 Then
            ' Indicate that the clone was successful
            Dim successMessage As String = "Clone complete." _
                & Environment.NewLine _
                & cloneCall.StandardOutput.ReadToEnd()

            MessageBox.Show(successMessage)

        Else
            ' Display the error code and the standard error
            ' output From git if the clone fails
            Dim errorMessage As String =
                cloneCall.StandardError.ReadToEnd() _
                & Environment.NewLine _
                & "Error code: " & cloneCall.ExitCode.ToString()

            MessageBox.Show(
                errorMessage,
                "Could not clone repository",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End If

        Return cloneCall

    End Function

End Class
