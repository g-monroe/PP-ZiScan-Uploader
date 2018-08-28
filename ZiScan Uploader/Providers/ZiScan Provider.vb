Imports System.Net
Imports System.Net.Http
Imports System.Text.RegularExpressions

Public Class ZiScanProvider
    Implements IDisposable

    Private _client As HttpClient

    Sub New()
        Dim handler = New HttpClientHandler() With {
            .AllowAutoRedirect = False,
           .AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
        }

        _client = New HttpClient(handler)
        _client.BaseAddress = New Uri("https://ziscan.com")

        _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml")
        _client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36")
    End Sub

    Public Async Function UploadBytes(filepath As String) As Task(Of Scan)
        Try
            Dim form As New MultipartFormDataContent()

            Dim file As Byte() = System.IO.File.ReadAllBytes(filepath)
            Dim fileName As String = System.IO.Path.GetFileName(filepath)

            form.Add(New ByteArrayContent(file, 0, file.Count()), "file", fileName)
            form.Add(New StringContent("full"), "submit")
            form.Add(New StringContent("57f2d7f809738"), "APC_UPLOAD_PROGRESS")
            Dim response = Await _client.PostAsync(_client.BaseAddress, form)
            Dim content As String = Await response.Content.ReadAsStringAsync()
            Dim img As String = Await GrabScreenshot(_client.BaseAddress.ToString & response.Headers.Location.ToString)
            Return New Scan(content, _client.BaseAddress.ToString & response.Headers.Location.ToString, img)
        Catch ex As Exception
            Return New Scan("Error!", "Error!", "Error!")
        End Try
    End Function
    Public Class Scan
        Public Property Success() As Boolean
        Public Property Img As String
        Public Property antiviruses As Integer = 0
        Public Property detected As Integer = 0
        Public Property Results As String
        Public Property ResultsLink As String
        Public Sub New(content As String, Link As String, Image As String)
            If Not Link = "Error!" Then
                Success = True
                content = content.Replace("[color=green]", "")
                content = content.Replace("[/color]", "")
                content = content.Replace("[color=red]", "Infected")
                Dim report As String = Regex.Split(Regex.Split(content, vbLf & vbLf)(1), vbLf & vbLf)(0)
                Results = report
                Dim lines As String() = report.Split(":")
                For Each line As String In lines
                    If line = " Infected" Then
                        antiviruses += 1
                        detected += 1
                    ElseIf line = " Clean" Then
                        antiviruses += 1
                    End If
                Next
                ResultsLink = Link
                Img = Image
            Else
                Success = False
            End If

        End Sub
    End Class
    Public Async Function GrabScreenshot(url As String) As Task(Of String)
        If String.IsNullOrWhiteSpace(url) Then
            Throw New ArgumentNullException(NameOf(url))
        End If
        Dim response As HttpResponseMessage = Await _client.GetAsync(New Uri(url))
        Dim result As String = Await response.Content.ReadAsStringAsync
        result = Regex.Split(Regex.Split(result, "/screenshot/")(1), ".png")(0)
        Return _client.BaseAddress.ToString & "/screenshot/" & result & ".png"
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
        _client.Dispose()
    End Sub

End Class
