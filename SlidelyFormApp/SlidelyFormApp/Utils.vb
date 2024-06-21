Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class Utils
    Public Shared Async Function GetSubmissions() As Task(Of List(Of Submission))
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync("http://localhost:3000/submissions")
            Return JsonConvert.DeserializeObject(Of List(Of Submission))(response)
        End Using
    End Function

    Public Shared Async Sub SubmitSubmission(submission As Submission)
        Using client As New HttpClient()
            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Await client.PostAsync("http://localhost:3000/submit", content)
        End Using
    End Sub

End Class
