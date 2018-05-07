<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RepoURL = New System.Windows.Forms.TextBox()
        Me.CloneRepo = New System.Windows.Forms.Button()
        Me.CloneList = New System.Windows.Forms.ListView()
        Me.RepoName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RepoProgress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloneBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'RepoURL
        '
        Me.RepoURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RepoURL.Location = New System.Drawing.Point(22, 394)
        Me.RepoURL.Name = "RepoURL"
        Me.RepoURL.Size = New System.Drawing.Size(650, 35)
        Me.RepoURL.TabIndex = 0
        '
        'CloneRepo
        '
        Me.CloneRepo.Location = New System.Drawing.Point(678, 393)
        Me.CloneRepo.Name = "CloneRepo"
        Me.CloneRepo.Size = New System.Drawing.Size(100, 45)
        Me.CloneRepo.TabIndex = 1
        Me.CloneRepo.Text = "Clone"
        Me.CloneRepo.UseVisualStyleBackColor = True
        '
        'CloneList
        '
        Me.CloneList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RepoName, Me.RepoProgress})
        Me.CloneList.Location = New System.Drawing.Point(22, 12)
        Me.CloneList.Name = "CloneList"
        Me.CloneList.Size = New System.Drawing.Size(756, 375)
        Me.CloneList.TabIndex = 2
        Me.CloneList.UseCompatibleStateImageBehavior = False
        Me.CloneList.View = System.Windows.Forms.View.Details
        '
        'RepoName
        '
        Me.RepoName.Text = "Name"
        Me.RepoName.Width = 255
        '
        'RepoProgress
        '
        Me.RepoProgress.Text = "Progress"
        Me.RepoProgress.Width = 109
        '
        'CloneBackgroundWorker
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CloneList)
        Me.Controls.Add(Me.CloneRepo)
        Me.Controls.Add(Me.RepoURL)
        Me.Name = "MainForm"
        Me.Text = "CloneQueue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RepoURL As TextBox
    Friend WithEvents CloneRepo As Button
    Friend WithEvents CloneList As ListView
    Friend WithEvents RepoName As ColumnHeader
    Friend WithEvents RepoProgress As ColumnHeader
    Friend WithEvents CloneBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
