Imports System.IO
Imports Microsoft.Win32
Imports ZiScan_Uploader

Public Class Main
    Dim File As String = ""
    Dim UpdateLink As String = ""
    Public Sub CreateContextMenu()
        'Move EXE to known "safe" Directory.
        Dim newPath As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Ziscan Uploader\"
        Dim newpathEXE As String = newPath & "Ziscan Uploader.exe"
        Dim myApp As String = Application.ExecutablePath
        'Check if Directory Exists
        If Not Directory.Exists(newPath) Then
            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
                'Create new Path
                IO.Directory.CreateDirectory(newPath)
                'Copy EXE to new Path.
                IO.File.Copy(myApp, newpathEXE)
                'Create Registry
                My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\*\shell\Ziscan Upload")
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\*\shell\Ziscan Upload", "Icon", newpathEXE)
                My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\*\shell\Ziscan Upload\Command")
                Dim CommandReg As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\*\shell\Ziscan Upload\Command", True)
                CommandReg.SetValue("", Chr(34) & newpathEXE & Chr(34) & " " & Chr(34) & "%1" & Chr(34))
            Else
                MessageBox.Show("To create the registry for the application; We ask you to run the application in admin for the first time running Ziscan Uploader.", "Please run application as Admin!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Public Async Function CheckUpdate() As Task(Of Boolean)
        Using Updater = New UpdateProvider
            Dim response = Await (Updater.Update)
            If Not response.Contains("http") Then
                Return False
            Else
                UpdateLink = response
                Return True
            End If
        End Using
    End Function
    Private Async Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim screenSize As Size = Screen.PrimaryScreen.WorkingArea.Size
        Dim screenLocation As Point = Screen.PrimaryScreen.WorkingArea.Location
        Dim formSize As Size = Me.Size
        Me.Location = New Point(screenLocation.X + (screenSize.Width - formSize.Width), screenLocation.Y + (screenSize.Height - formSize.Height))

        CreateContextMenu()
        'Get File Path
        For Each sArg As String In My.Application.CommandLineArgs
            File &= sArg & ""
        Next
        If File = "" Then
            Environment.Exit(0)
        End If
        'Check For Update.
        If Await CheckUpdate() Then
            Alert.Type = sNotification.Types.Warning
            Alert.Refresh()
            btnUpdate.Visible = True
        End If
        'Check File Path.
        If Not File = "" Then
            'Upload Image
            Using Scan As New ZiScanProvider
                Dim response As ZiScanProvider.Scan = Await (Scan.UploadBytes(File))
                'Error Uploading Image
                If Not response.ResultsLink.Contains("http") Then
                    tbLink.Text = "Error!"
                    tbImage.Text = "Error!"
                    Alert.Type = sNotification.Types.Error_
                Else
                    'Successful Upload
                    tbLink.LeftButtonClickable = True
                    tbLink.RightButtonClickable = True
                    tbLink.Text = response.ResultsLink
                    tbImage.Text = response.Img
                    lblResults.Text = response.detected & "/" & response.antiviruses
                    lblResults.Refresh()
                    tbImage.LeftButtonClickable = True
                    tbImage.RightButtonClickable = True
                    Alert.Type = sNotification.Types.Success
                    Alert.Refresh()
                End If
            End Using
        End If
    End Sub

    Private Sub SButton1_ButtonClicked(Checked As Boolean) Handles SButton1.ButtonClicked
        Environment.Exit(0)
    End Sub

    Private Sub tbLink_LeftbtnClicked(Type As sTextbox._Type, data As String) Handles tbLink.LeftbtnClicked
        My.Computer.Clipboard.SetText(tbLink.Text)
        Environment.Exit(0)
    End Sub

    Private Sub tbLink_RightbtnClicked(Type As sTextbox._Type, data As String) Handles tbLink.RightbtnClicked
        If tbLink.Text.Contains("http") Then
            Process.Start(tbLink.Text)
            Environment.Exit(0)
        End If
    End Sub
    Private Sub tbImage_LeftbtnClicked(Type As sTextbox._Type, data As String) Handles tbImage.LeftbtnClicked
        My.Computer.Clipboard.SetText(tbLink.Text)
        Environment.Exit(0)
    End Sub

    Private Sub tbImage_RightbtnClicked(Type As sTextbox._Type, data As String) Handles tbImage.RightbtnClicked
        If tbImage.Text.Contains("http") Then
            Process.Start(tbImage.Text)
            Environment.Exit(0)
        End If
    End Sub
    Private Sub btnUpdate_ButtonClicked(Checked As Boolean) Handles btnUpdate.ButtonClicked
        If UpdateLink.Contains("http") Then
            Process.Start(UpdateLink)
            Environment.Exit(0)
        End If
    End Sub
End Class
