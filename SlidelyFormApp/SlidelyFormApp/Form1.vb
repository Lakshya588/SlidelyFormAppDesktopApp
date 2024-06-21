Public Class Form1
    Private Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles BtnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub BtnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles BtnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            BtnViewSubmissions.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            BtnCreateNewSubmission.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
