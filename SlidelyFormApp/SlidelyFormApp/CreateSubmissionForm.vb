Imports System.Security

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private stopwatchPaused As Boolean = True
    Private WithEvents timer As New System.Windows.Forms.Timer()
    Public Sub New()
        InitializeComponent()
        timer.Interval = 1000 ' Update every 1 second (1000 milliseconds)
    End Sub
    Private Sub BtnStopWatch_Click(sender As Object, e As EventArgs) Handles BtnStopWatch.Click
        If stopwatchPaused Then
            stopwatch.Start()
            BtnStopWatch.Text = "Pause"
            timer.Start()
        Else
            stopwatch.Stop()
            BtnStopWatch.Text = "Start"
            timer.Stop()
        End If
        stopwatchPaused = Not stopwatchPaused
        UpdateStopwatchDisplay()
    End Sub
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        lbStopWatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim submission As New Submission() With {
            .Name = TextName.Text,
            .Email = TextEmail.Text,
            .Phone = TextPhone.Text,
            .GitHub = TextGithub.Text,
            .Time = stopwatch.Elapsed.ToString("hh\:mm\:ss")
}
        Utils.SubmitSubmission(submission)
        MessageBox.Show("Submission Successful!")
        Me.Close()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            BtnStopWatch.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            BtnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class