<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BtnViewSubmissions = New System.Windows.Forms.Button()
        Me.BtnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnViewSubmissions
        '
        Me.BtnViewSubmissions.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnViewSubmissions.Location = New System.Drawing.Point(100, 103)
        Me.BtnViewSubmissions.Name = "BtnViewSubmissions"
        Me.BtnViewSubmissions.Size = New System.Drawing.Size(279, 78)
        Me.BtnViewSubmissions.TabIndex = 0
        Me.BtnViewSubmissions.Text = "View Submissions (CTRL+V)"
        Me.BtnViewSubmissions.UseVisualStyleBackColor = False
        '
        'BtnCreateNewSubmission
        '
        Me.BtnCreateNewSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnCreateNewSubmission.Location = New System.Drawing.Point(408, 103)
        Me.BtnCreateNewSubmission.Name = "BtnCreateNewSubmission"
        Me.BtnCreateNewSubmission.Size = New System.Drawing.Size(265, 78)
        Me.BtnCreateNewSubmission.TabIndex = 1
        Me.BtnCreateNewSubmission.Text = "Create New Submission (CTRL+N)"
        Me.BtnCreateNewSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 268)
        Me.Controls.Add(Me.BtnCreateNewSubmission)
        Me.Controls.Add(Me.BtnViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateNewSubmission As Button
End Class
