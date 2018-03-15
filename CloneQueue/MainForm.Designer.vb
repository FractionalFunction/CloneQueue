<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RepoURL = New System.Windows.Forms.TextBox()
        Me.CloneRepo = New System.Windows.Forms.Button()
        Me.CloneList = New System.Windows.Forms.ListBox()
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
        Me.CloneList.FormattingEnabled = True
        Me.CloneList.ItemHeight = 25
        Me.CloneList.Items.AddRange(New Object() {"Example.git"})
        Me.CloneList.Location = New System.Drawing.Point(22, 23)
        Me.CloneList.Name = "CloneList"
        Me.CloneList.Size = New System.Drawing.Size(756, 354)
        Me.CloneList.TabIndex = 2
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
    Friend WithEvents CloneList As ListBox
End Class
