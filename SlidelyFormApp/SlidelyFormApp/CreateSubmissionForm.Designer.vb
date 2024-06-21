<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.TextPhone = New System.Windows.Forms.TextBox()
        Me.TextGithub = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnStopWatch = New System.Windows.Forms.Button()
        Me.lbStopWatch = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Github Link For Task 2"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(400, 88)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(284, 26)
        Me.TextName.TabIndex = 4
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(400, 152)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(284, 26)
        Me.TextEmail.TabIndex = 5
        '
        'TextPhone
        '
        Me.TextPhone.Location = New System.Drawing.Point(400, 217)
        Me.TextPhone.Name = "TextPhone"
        Me.TextPhone.Size = New System.Drawing.Size(284, 26)
        Me.TextPhone.TabIndex = 6
        '
        'TextGithub
        '
        Me.TextGithub.Location = New System.Drawing.Point(400, 268)
        Me.TextGithub.Name = "TextGithub"
        Me.TextGithub.Size = New System.Drawing.Size(284, 26)
        Me.TextGithub.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone Num"
        '
        'BtnStopWatch
        '
        Me.BtnStopWatch.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnStopWatch.Location = New System.Drawing.Point(183, 344)
        Me.BtnStopWatch.Name = "BtnStopWatch"
        Me.BtnStopWatch.Size = New System.Drawing.Size(310, 48)
        Me.BtnStopWatch.TabIndex = 9
        Me.BtnStopWatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.BtnStopWatch.UseVisualStyleBackColor = False
        '
        'lbStopWatch
        '
        Me.lbStopWatch.AutoSize = True
        Me.lbStopWatch.Location = New System.Drawing.Point(572, 361)
        Me.lbStopWatch.Name = "lbStopWatch"
        Me.lbStopWatch.Size = New System.Drawing.Size(71, 20)
        Me.lbStopWatch.TabIndex = 10
        Me.lbStopWatch.Text = "00:00:00"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnSubmit.Location = New System.Drawing.Point(348, 431)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(215, 43)
        Me.BtnSubmit.TabIndex = 11
        Me.BtnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 508)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.lbStopWatch)
        Me.Controls.Add(Me.BtnStopWatch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextGithub)
        Me.Controls.Add(Me.TextPhone)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents TextPhone As TextBox
    Friend WithEvents TextGithub As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnStopWatch As Button
    Friend WithEvents lbStopWatch As Label
    Friend WithEvents BtnSubmit As Button
End Class
