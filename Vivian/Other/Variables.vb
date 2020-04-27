﻿Public Class Variables
#Region "Shared Variables"
    Public Shared ver As String = My.Application.Info.Version.ToString & " (January 2020)"
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName
    Public Shared appname As String = "Vivian"
    Public Shared vertext As String = "https://u.windowslogic.co.uk/VIVIAN/VIVIAN.txt"
    Public Shared setup As String = "https://u.windowslogic.co.uk/VIVIAN/Vivian%20Setup.exe"

    Public Shared Sub ParseVariables(input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user).Replace("%appname%", Variables.appname)
    End Sub
#End Region
#Region "Updater"
    Public Shared Sub Update_Settings()
        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then

                Else
                    UpdaterPrompt.ShowDialog()
                End If

            Catch
                errordiag.Show()
                errordiag.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
End Class
