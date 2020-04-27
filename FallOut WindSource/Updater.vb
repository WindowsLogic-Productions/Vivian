Public Class Updater

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Checking..."
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label1.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/Browser%20Updates.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Button1.Text = ("Done")
                    Label2.Text = ("You already have the latest version.")
                Else
                    Button1.Text = ("Downloading update...")
                    WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/WLP%20Internet%20Browser%20Setup.exe")
                    Label2.Text = ("You now have the latest version.")
                End If
            End If
        End If
    End Sub

    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/Browser%20Updates.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Button1.Text = ("There is a new version available.")
                Label2.Text = ("You may now close this dialog.")
            Else
                Button1.Text = ("Downloading update...")
                WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/WLP%20Internet%20Browser%20Setup.exe")
                Label2.Text = ("You may now close this dialog")
            End If
        End If
    End Sub

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button1.Text = "Checking..."
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()
    End Sub
End Class