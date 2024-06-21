<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lb1Name = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.lb1Email = New System.Windows.Forms.Label()
        Me.lb1Phone = New System.Windows.Forms.Label()
        Me.lb1GitHub = New System.Windows.Forms.Label()
        Me.lb1Time = New System.Windows.Forms.Label()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.TextPhone = New System.Windows.Forms.TextBox()
        Me.TextGitHub = New System.Windows.Forms.TextBox()
        Me.TextTime = New System.Windows.Forms.TextBox()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb1Name
        '
        Me.lb1Name.AutoSize = True
        Me.lb1Name.Location = New System.Drawing.Point(116, 93)
        Me.lb1Name.Name = "lb1Name"
        Me.lb1Name.Size = New System.Drawing.Size(51, 20)
        Me.lb1Name.TabIndex = 0
        Me.lb1Name.Text = "Name"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(313, 87)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(248, 26)
        Me.TextName.TabIndex = 1
        '
        'lb1Email
        '
        Me.lb1Email.AutoSize = True
        Me.lb1Email.Location = New System.Drawing.Point(116, 153)
        Me.lb1Email.Name = "lb1Email"
        Me.lb1Email.Size = New System.Drawing.Size(48, 20)
        Me.lb1Email.TabIndex = 2
        Me.lb1Email.Text = "Email"
        '
        'lb1Phone
        '
        Me.lb1Phone.AutoSize = True
        Me.lb1Phone.Location = New System.Drawing.Point(116, 217)
        Me.lb1Phone.Name = "lb1Phone"
        Me.lb1Phone.Size = New System.Drawing.Size(92, 20)
        Me.lb1Phone.TabIndex = 3
        Me.lb1Phone.Text = "Phone Num"
        '
        'lb1GitHub
        '
        Me.lb1GitHub.AutoSize = True
        Me.lb1GitHub.Location = New System.Drawing.Point(116, 282)
        Me.lb1GitHub.Name = "lb1GitHub"
        Me.lb1GitHub.Size = New System.Drawing.Size(169, 20)
        Me.lb1GitHub.TabIndex = 4
        Me.lb1GitHub.Text = "Github Link For Task 2"
        '
        'lb1Time
        '
        Me.lb1Time.AutoSize = True
        Me.lb1Time.Location = New System.Drawing.Point(116, 339)
        Me.lb1Time.Name = "lb1Time"
        Me.lb1Time.Size = New System.Drawing.Size(119, 20)
        Me.lb1Time.TabIndex = 5
        Me.lb1Time.Text = "Stopwatch time"
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(313, 153)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(248, 26)
        Me.TextEmail.TabIndex = 6
        '
        'TextPhone
        '
        Me.TextPhone.Location = New System.Drawing.Point(313, 217)
        Me.TextPhone.Name = "TextPhone"
        Me.TextPhone.Size = New System.Drawing.Size(248, 26)
        Me.TextPhone.TabIndex = 7
        '
        'TextGitHub
        '
        Me.TextGitHub.Location = New System.Drawing.Point(313, 276)
        Me.TextGitHub.Name = "TextGitHub"
        Me.TextGitHub.Size = New System.Drawing.Size(248, 26)
        Me.TextGitHub.TabIndex = 8
        '
        'TextTime
        '
        Me.TextTime.Location = New System.Drawing.Point(313, 333)
        Me.TextTime.Name = "TextTime"
        Me.TextTime.Size = New System.Drawing.Size(248, 26)
        Me.TextTime.TabIndex = 9
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnPrevious.Location = New System.Drawing.Point(50, 401)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(171, 38)
        Me.BtnPrevious.TabIndex = 10
        Me.BtnPrevious.Text = "Previous (CTRL+P)"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnNext.Location = New System.Drawing.Point(251, 400)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(145, 39)
        Me.BtnNext.TabIndex = 11
        Me.BtnNext.Text = "Next (CTRL+N)"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.BtnDelete.Location = New System.Drawing.Point(420, 400)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(235, 38)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete Submissions (CTRL+D)"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 450)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.TextTime)
        Me.Controls.Add(Me.TextGitHub)
        Me.Controls.Add(Me.TextPhone)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.lb1Time)
        Me.Controls.Add(Me.lb1GitHub)
        Me.Controls.Add(Me.lb1Phone)
        Me.Controls.Add(Me.lb1Email)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.lb1Name)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1Name As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents lb1Email As Label
    Friend WithEvents lb1Phone As Label
    Friend WithEvents lb1GitHub As Label
    Friend WithEvents lb1Time As Label
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents TextPhone As TextBox
    Friend WithEvents TextGitHub As TextBox
    Friend WithEvents TextTime As TextBox
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BtnDelete As Button
End Class
