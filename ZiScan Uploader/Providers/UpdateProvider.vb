Imports System.Net.Http
Imports System.Text.RegularExpressions

Public Class UpdateProvider
    Implements IDisposable

    Private _client As HttpClient

    Sub New()
        _client = New HttpClient()
    End Sub

    Public Async Function Update() As Task(Of String)
        Try
            Dim form As New MultipartFormDataContent()
            Dim response = Await _client.PostAsync("http://pastebin.com/raw/K3kQ9Z44", form)
            Dim content As String = Await response.Content.ReadAsStringAsync()

            Return content
        Catch ex As Exception
            Return "Error!"
        End Try
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        _client.Dispose()
    End Sub

End Class