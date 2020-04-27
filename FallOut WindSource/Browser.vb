Imports System.Net

Public Class Browser
    Dim i As Integer
    Dim int As Integer = 0
    Dim Numtabs As Integer = 0


    Private Function IsPopupWindow() As Boolean
        On Error Resume Next
        If CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement.TagName = "BODY" Or CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement.TagName = "IFRAME" Then
            IsPopupWindow = True
        Else
            IsPopupWindow = False
        End If
    End Function

    Private Sub webbrowser1_NewWindow2(ppDisp As Object, Cancel As Boolean)
        Cancel = IsPopupWindow()
        If Cancel = False Then
            Me.Show()
        End If
    End Sub


    Private Sub new_tab()
        Dim NewBrowser As New WebBrowser
        Dim NewTab As New TabPage
        NewBrowser.Tag = NewTab
        NewTab.Tag = NewBrowser
        TabControl1.TabPages.Add(NewTab)
        NewTab.Controls.Add(NewBrowser)
        NewBrowser.Dock = DockStyle.Fill
        TextBox1.Text = ""
        NewBrowser.Navigate(TextBox1.Text)
        AddHandler NewBrowser.DocumentCompleted, AddressOf Done
        Numtabs = Numtabs + 1
        TabControl1.SelectTab(Numtabs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.Homepage)

    End Sub


    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        TextBox1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString

        History.ListBox1.Items.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        If ListBox.NoMatches Then
        Else
            History.ListBox1.Items.Remove(1)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        new_tab()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load search provider settings.
        If My.Settings.Search = 1 Then
            Preferences.RadioButton1.Checked = True
        End If

        If My.Settings.Search = 2 Then
            Preferences.RadioButton2.Checked = True
        End If

        If My.Settings.Search = 3 Then
            Preferences.RadioButton3.Checked = True
        End If

        'Load private browsing settings.
        If My.Settings.PrivateBrowsing = "ON" Then
            Preferences.RadioButton4.Checked = True
        End If

        If My.Settings.PrivateBrowsing = "OFF" Then
            Preferences.RadioButton5.Checked = True
        End If

        'Load personalisation settings.
        If My.Settings.Colour = 0 Then
            Me.BackColor = Color.Honeydew
        End If

        If My.Settings.Colour = 1 Then
            Me.BackColor = Color.LightBlue
        End If

        If My.Settings.Colour = 2 Then
            Me.BackColor = Color.Lavender
        End If

        If My.Settings.Colour = 3 Then
            Me.BackColor = Color.LightPink
        End If

        If My.Settings.Colour = 4 Then
            Me.BackColor = Color.OrangeRed
        End If

        If My.Settings.Colour = 5 Then
            Me.BackColor = Color.Coral
        End If

        If My.Settings.Colour = 6 Then
            Me.BackColor = Color.Orange
        End If

        If My.Settings.Colour = 7 Then
            Me.BackColor = Color.Goldenrod
        End If

        If My.Settings.Colour = 8 Then
            Me.BackColor = Color.YellowGreen
        End If

        If My.Settings.Colour = 9 Then
            Me.BackColor = Color.Aquamarine
        End If

        If My.Settings.Colour = 10 Then
            Me.BackColor = Color.LightGreen
        End If

        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1

        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True

        System.Threading.Thread.Sleep(1000)

        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.Homepage)

        'Automatic updates.
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/Browser%20Updates.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You have the latest version.", MsgBoxStyle.Information, "WLP Internet Browser (5.0.0.0)")
        ElseIf MsgBox("There is an update available, would you like to get the update?", MsgBoxStyle.YesNo, "WLP Internet Browser (5.0.0.0)") = MsgBoxResult.Yes Then
            Updater.ShowDialog()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub Link(sender As Object, e As Windows.Forms.WebBrowser)
        LinkClicked()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
            Numtabs = Numtabs - 1
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Preferences.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.PrivateBrowsing = "OFF" Then
            If My.Settings.Search = 1 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + TextBox2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If

            If My.Settings.Search = 2 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + TextBox2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If

            If My.Settings.Search = 3 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + TextBox2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If
        End If

        If My.Settings.PrivateBrowsing = "ON" Then
            If My.Settings.Search = 1 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + TextBox2.Text)
            End If

            If My.Settings.Search = 2 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + TextBox2.Text)
            End If

            If My.Settings.Search = 3 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + TextBox2.Text)
            End If
        End If
    End Sub

    Private Sub LinkClicked()
        Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(url)


    End Sub

    Private Sub FavouriteCurrentPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavouriteCurrentPageToolStripMenuItem.Click
        My.Settings.Bookmarks.Add(CType(Me.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        Favourites.Bookmarks.Items.Clear()

        For Each item As String In My.Settings.Bookmarks
            Favourites.Bookmarks.Items.Add(item)
        Next
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub HTMLPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLPropertiesToolStripMenuItem.Click
        CType(Me.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub OpenFavouritesMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFavouritesMenuToolStripMenuItem.Click
        Favourites.Show()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newform As New Browser
        newform.Show()
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        new_tab()
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
            Numtabs = Numtabs - 1
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Try
            Dim open As New OpenFileDialog
            open.ShowDialog()
            open.Title = "Open Local Webpage"
            open.CheckFileExists = True
            open.Filter = "All Files(*.*)|*.*"
            Try
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(open.FileName)

            Catch ex As Exception
                'Do nothing on Exception
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceToolStripMenuItem.Click
        Dim client As New WebClient
        Dim url As String
        Dim newform2 As New System.Windows.Forms.Form
        Dim textboxx1 As New RichTextBox
        Dim menubar As New MenuStrip
        url = TextBox1.Text
        Dim source As String = client.DownloadString(New Uri(url))
        newform2.Controls.Add(textboxx1)
        textboxx1.Multiline = True
        textboxx1.Dock = DockStyle.Fill
        url = textboxx1.Text
        textboxx1.Text = source
        newform2.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        newform2.Width = "900"
        newform2.Height = "700"
        newform2.Text = "Website Source " & "(" & TextBox1.Text & ")"
        newform2.ShowIcon = False
        newform2.Show()
    End Sub

    Private Sub HistoryListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        History.Show()
    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowSaveAsDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.Homepage)
    End Sub

    Private Sub HistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem1.Click
        History.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Left -= 5
        If Label3.Left <= -2596 Then
            Label3.Left = 2596
        End If
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        If My.Settings.PrivateBrowsing = "OFF" Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(TextBox1.Text)
            My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            My.Settings.Save()

        End If

        If My.Settings.PrivateBrowsing = "ON" Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(TextBox1.Text)
        Else
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Updater.Show()
    End Sub

    Private Sub UpdateLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLogToolStripMenuItem.Click
        UpdateLog.show()
    End Sub

    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/Browser%20Updates.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MsgBox("You have the latest version.", MsgBoxStyle.Information, "WLP Internet Browser (5.0.0.0)")

        Else

            MsgBox("There is an update available", MsgBoxStyle.Information, "WLP Internet Browser (5.0.0.0)")
            System.Diagnostics.Process.Start("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/WLP%20Browser%20Updates/WLP%20Internet%20Browser%20Setup.exe")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
