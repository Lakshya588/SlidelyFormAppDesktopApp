Imports System.Security

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from the backend
        submissions = Await Utils.GetSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DisplaySubmission()
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            TextName.Text = submission.Name
            TextEmail.Text = submission.Email
            TextPhone.Text = submission.Phone
            TextGitHub.Text = submission.GitHub
            TextTime.Text = submission.Time
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            BtnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            BtnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

    End Sub
End Class