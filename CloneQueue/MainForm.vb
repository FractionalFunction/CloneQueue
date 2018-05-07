Imports CloneQueue

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        CloneQueue.GitIsFunctional(True)
    End Sub

    Private Sub CloneList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CloneList.SelectedIndexChanged

    End Sub

    Private Sub RepoURL_TextChanged(sender As Object, e As EventArgs) Handles RepoURL.TextChanged

    End Sub

    Private Sub CloneRepo_Click(sender As Object, e As EventArgs) Handles CloneRepo.Click
        If Not String.IsNullOrEmpty(Me.RepoURL.Text) And CloneQueue.GitIsFunctional(True) Then
            CloneBackgroundWorker.RunWorkerAsync(Me.RepoURL.Text)
        End If
    End Sub

    ' Background worker
    Private Sub CloneBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CloneBackgroundWorker.DoWork
        Dim cloneCall As Process = CloneQueue.Clone(Me.RepoURL.Text)
        e.Result = cloneCall

    End Sub

    Private Sub CloneBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
    Handles CloneBackgroundWorker.RunWorkerCompleted
        Dim cloneCall As Process = CType(e.Result, Process)

        ' If the clone was successful, clear the RepoURL text box
        If cloneCall.ExitCode = 0 Then
            RepoURL.Text = String.Empty
        End If

    End Sub

    Private Sub CloneBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CloneBackgroundWorker.DoWork
        Dim cloneCall As Process = CloneQueue.Clone(Me.RepoURL.Text)

        If cloneCall.ExitCode = 0 Then
            RepoURL.Text = String.Empty
        End If
    End Sub
End Class
