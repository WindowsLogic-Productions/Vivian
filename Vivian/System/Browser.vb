Imports System.Net
Imports mshtml
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Browser
    Dim i As Integer
    Dim int As Integer = 0
    Dim Numtabs As Integer = 0
    Dim url As String
    Dim browser As WebBrowser
    Public Property Target As String

#Region "Load Settings"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'File association
        My.Computer.Registry.ClassesRoot.CreateSubKey(".html").SetValue("", "html", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.ClassesRoot.CreateSubKey("html\shell\open\command").SetValue("", Application.ExecutablePath & " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)

        'Fix compatibility issues.
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", "Vivian.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", "Vivian.vshost.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BEHAVIORS", "Vivian.exe", "1", Microsoft.Win32.RegistryValueKind.DWord)

        'Load sound settings.
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.StartUp, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If

        'Load background settings.
        If My.Settings.DHBHUC = 0 Then
            HubBackground.Image = My.Resources.Background
            QuickStartBackground.Image = My.Resources.Background
        End If

        If My.Settings.DHBHUC = 1 Then
            HubBackground.Image = Nothing
            QuickStartBackground.Image = Nothing
        End If

        If My.Settings.DHBHUC = 2 Then
            HubBackground.Load(My.Settings.CB1)
            QuickStartBackground.Load(My.Settings.CB1)
        End If

        'Load search provider settings.
        If My.Settings.Search = 1 Then
            SettingsPanelGeneral.GoogleSwitch.Checked = True
        End If

        If My.Settings.Search = 2 Then
            SettingsPanelGeneral.BingSwitch.Checked = True
        End If

        If My.Settings.Search = 3 Then
            SettingsPanelGeneral.YahooSwitch.Checked = True
        End If

        'Load private browsing settings.
        If My.Settings.PrivateBrowsing = "ON" Then
            SettingsPanelGeneral.PrivateBrowsingSwitchON.Checked = True
        End If

        If My.Settings.PrivateBrowsing = "OFF" Then
            SettingsPanelGeneral.PrivateBrowsingSwitchOFF.Checked = True
        End If

        'Load stop button settings.
        If My.Settings.StopButton = 1 Then
            StopButton.Enabled = True
        End If

        If My.Settings.StopButton = 0 Then
            StopButton.Enabled = False
        End If

        'Load home button settings.
        If My.Settings.HomeButton = 1 Then
            HomeButton.Enabled = True
        End If

        If My.Settings.HomeButton = 0 Then
            HomeButton.Enabled = False
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            BackButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            ForwardButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            RefreshButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            StopButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            HomeButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            SSLButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            FavouriteButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            CloseTabButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            NewTabButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            MenuButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
        End If

        'Main background parent settings.
        TabControl1.Parent = HubBackground
        NavClusterBackPanel.Parent = HubBackground
        MenuButton.Parent = NavClusterBackPanel
        CloseTabButton.Parent = NavClusterBackPanel
        NewTabButton.Parent = NavClusterBackPanel
        StopButton.Parent = NavClusterBackPanel
        RefreshButton.Parent = NavClusterBackPanel
        FavouriteButton.Parent = NavClusterBackPanel
        HomeButton.Parent = NavClusterBackPanel
        ForwardButton.Parent = NavClusterBackPanel
        BackButton.Parent = NavClusterBackPanel
        SSLButton.Parent = NavClusterBackPanel


        'Quick Start parent settings.
        LogoImage.Parent = QuickStartBackground
        Watermark3.Parent = QuickStartBackground
        QuickStartTopPanel.Parent = QuickStartBackground
        QuickStartBottomPanel.Parent = QuickStartBackground
        ExitQuickStartButton.Parent = QuickStartTopPanel
        QuickStartTitleLabel.Parent = QuickStartTopPanel
        HelpQuickStartButton.Parent = QuickStartTopPanel
        FeedbackQuickStartButton.Parent = QuickStartTopPanel
        QuickStartBottomPanel.Parent = QuickStartBackground
        FavouritesQuickStartButton.Parent = QuickStartBottomPanel
        HistoryQuickStartButton.Parent = QuickStartBottomPanel
        SettingsQuickStartButton.Parent = QuickStartBottomPanel
        DonateQuickStartButton.Parent = QuickStartBottomPanel
        QuickStartCopyrightLabel.Parent = QuickStartBottomPanel

        'Panel Settings
        QuickStartTopPanel.BackColor = Color.FromArgb(200, Color.White)
        QuickStartBottomPanel.BackColor = Color.FromArgb(200, Color.White)
        NavClusterBackPanel.BackColor = Color.FromArgb(100, Color.Black)

        'Load start-up settings.
        If My.Settings.Startup = 0 Then
            Dim Browser As New WebBrowser
            QuickStartPanel.Visible = True
            TabControl1.TabPages.Add("New Page")
            Browser.Name = "Web Browser"
            Browser.Dock = DockStyle.Fill
            TabControl1.SelectedTab.Controls.Add(Browser)
            AddHandler Browser.DocumentCompleted, AddressOf Done
            int = int + 1

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True

            System.Threading.Thread.Sleep(1000)

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("")

            Try
                Dim filename As String
                Dim cmdLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
                If Not cmdLineArgs(0).Length = 0 Then
                    filename = cmdLineArgs(0)
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(filename)
                    TabControl1.SelectedTab.Text = filename
                End If
            Catch

            End Try

            Browser.IsWebBrowserContextMenuEnabled = False
            Browser.ContextMenuStrip = BrowserRightClickMenu
        End If

        If My.Settings.Startup = 1 Then
            SettingsPanel.Show()
            Dim Browser As New WebBrowser
            QuickStartPanel.Visible = False
            TabControl1.TabPages.Add("New Page")
            Browser.Name = "Web Browser"
            Browser.Dock = DockStyle.Fill
            TabControl1.SelectedTab.Controls.Add(Browser)
            AddHandler Browser.DocumentCompleted, AddressOf Done
            int = int + 1

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True

            System.Threading.Thread.Sleep(1000)

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("about:blank")
            Try
                Dim filename As String
                Dim cmdLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
                If Not cmdLineArgs(0).Length = 0 Then
                    filename = cmdLineArgs(0)
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(filename)
                    TabControl1.SelectedTab.Text = filename
                End If
            Catch

            End Try

            Browser.IsWebBrowserContextMenuEnabled = False
            Browser.ContextMenuStrip = BrowserRightClickMenu
        End If

        If My.Settings.Startup = 2 Then
            Dim Browser As New WebBrowser
            QuickStartPanel.Visible = False
            TabControl1.TabPages.Add("New Page")
            Browser.Name = "Web Browser"
            Browser.Dock = DockStyle.Fill
            TabControl1.SelectedTab.Controls.Add(Browser)
            AddHandler Browser.DocumentCompleted, AddressOf Done
            int = int + 1

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True

            System.Threading.Thread.Sleep(1000)

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.Homepage)

            Browser.IsWebBrowserContextMenuEnabled = False
            Browser.ContextMenuStrip = BrowserRightClickMenu
        End If

        'Automatic updates.
        Variables.Update_Settings()
    End Sub
#End Region
#Region "Buttons"
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        url = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
    End Sub

    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        url = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
    End Sub

    Private Sub HomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.Homepage)
        url = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
    End Sub

    Private Sub SSLButton_Click(sender As Object, e As EventArgs) Handles SSLButton.Click
        CertDiag.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavouriteButton.Click
        If Watermark1.Text.Contains("about:blank") Then
            errordiag.Label1.Text = "You cannot pin a blank page."
            errordiag.ShowDialog()
        Else
            Favourite.ShowDialog()
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        url = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        url = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
    End Sub

    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        MainMenu.Show(MenuButton, 0, MenuButton.Height)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabButton.Click
        If TabControl1.TabCount = 1 Then
            Me.Close()
        Else
            close_tab()
            Reopen_RCTM.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabButton.Click
        new_tab()
    End Sub

    Private Sub ZoomOutButton_Click(sender As Object, e As EventArgs) Handles ZoomOutButton.Click
        If InitialZoom <= 10 Then
            ZoomOutButton.Enabled = False
        Else
            ZoomInButton.Enabled = True
            InitialZoom -= 10
            PerformZoom(InitialZoom)
            ZoomLabel.Text = InitialZoom.ToString & "%"
        End If
    End Sub

    Private Sub ZoomInButton_Click(sender As Object, e As EventArgs) Handles ZoomInButton.Click
        If InitialZoom >= 999 Then
            ZoomInButton.Enabled = False
        Else
            ZoomOutButton.Enabled = True
            InitialZoom += 10
            PerformZoom(InitialZoom)
            ZoomLabel.Text = InitialZoom.ToString & "%"
        End If

    End Sub

    Private Sub ZoomLabel_Click(sender As Object, e As EventArgs) Handles ZoomLabel.Click
        ZoomInButton.Enabled = True
        ZoomOutButton.Enabled = True
        InitialZoom = 100
        PerformZoom(InitialZoom)
        ZoomLabel.Text = InitialZoom.ToString & "%"
    End Sub
#End Region
#Region "Menu"
    Private Sub NewTabToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem1.Click
        new_tab()
    End Sub

    Private Sub CloseTabToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem1.Click
        If TabControl1.TabCount > 1 Then
            TabControl1.SelectedTab.Dispose()
            int = int - 1
            Numtabs = Numtabs - 1
            GC.Collect()
        Else
            DirectCast(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate("about:blank")

        End If
    End Sub

    Private Sub NewWindowToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem1.Click
        Dim newform As New Browser
        newform.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim Open As New OpenFileDialog
            Open.Filter = "HTML (Hyper Text Markup Language) (*.html)|*.html|CSS (Cascading Style Sheet) (*.css)|*.css|Portable Network Graphic (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|Graphics Interchange Format (*.gif)|*.gif"
            Open.CheckFileExists = True
            If Open.ShowDialog() = DialogResult.OK Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Open.FileName)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If Watermark1.Text = "about:blank" Then
            errordiag.Label1.Text = "You cannot save a blank page."
            errordiag.ShowDialog()
        Else
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowSaveAsDialog()
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If Watermark1.Text = "about:blank" Then
            errordiag.Label1.Text = "You cannot print a blank page."
            errordiag.ShowDialog()
        Else
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
        End If
    End Sub

    Private Sub SourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceToolStripMenuItem.Click
        Try
            Dim websource As [String] = ("viewsource.txt")
            Dim writer As StreamWriter = File.CreateText(websource)
            writer.Write(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentText)
            writer.Close()
            Dim fileName As String = websource
            Dim reader As TextReader = New StreamReader("viewsource.txt")
            Source.RichTextBox1.Text = reader.ReadToEnd
            reader.Close()
            Source.Show()
        Catch
            errordiag.Label1.Text = "Source code is not available on this page."
            errordiag.ShowDialog()
        End Try
    End Sub

    Private Sub HTMLStudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLStudioToolStripMenuItem.Click
        If My.Settings.wsstart = 1 Then
            WebStudioNew.Show()
        End If

        If My.Settings.wsstart = 0 Then
            HTMLStudio.Show()
            HTMLStudio.HTMLTabs.Show()
            HTMLStudio.HTMLTagsToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub SettingsPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsPanelToolStripMenuItem.Click
        SettingsPanel.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Updater.ShowDialog()
    End Sub

    Private Sub WhatsNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhatsNewToolStripMenuItem.Click
        WhatsNew.ShowDialog()
    End Sub

    Private Sub QuickStartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickStartToolStripMenuItem.Click
        QuickStartPanel.Visible = True
        Timer1.Stop()
        Me.Text = "Quick Start - Vivian"
    End Sub

    Private Sub SendFeedbackToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendFeedbackToolStripMenuItem1.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.windowslogic.co.uk/feedback.php")
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://docs.windowslogic.co.uk/vivian-index.php")
    End Sub

    Private Sub AboutLogiverseNavigator80ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutLogiverseNavigator80ToolStripMenuItem.Click
        Variables.appname = "Vivian"
        About.Text = "About Vivian"
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Dispose()
    End Sub
#End Region
#Region "Quick Start"
    Private Sub Watermark3_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Watermark3.KeyDown
        If e.KeyCode = Keys.Enter Then
            If My.Settings.PrivateBrowsing = "OFF" Then
                If My.Settings.Search = 1 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + Watermark3.Text)
                    My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                    My.Settings.Save()
                    QuickStartPanel.Visible = False
                End If

                If My.Settings.Search = 2 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + Watermark3.Text)
                    My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                    My.Settings.Save()
                    QuickStartPanel.Visible = False
                End If

                If My.Settings.Search = 3 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + Watermark3.Text)
                    My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                    My.Settings.Save()
                    QuickStartPanel.Visible = False
                End If

                If My.Settings.Search = 4 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + Watermark3.Text)
                    My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                    My.Settings.Save()
                    QuickStartPanel.Visible = False
                End If
            End If

            If My.Settings.PrivateBrowsing = "ON" Then
                If My.Settings.Search = 1 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + Watermark3.Text)
                    QuickStartPanel.Visible = False
                End If

                If My.Settings.Search = 2 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + Watermark3.Text)
                    QuickStartPanel.Visible = False
                End If

                If My.Settings.Search = 3 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + Watermark3.Text)
                    QuickStartPanel.Visible = False
                End If

                If My.Settings.Search = 4 Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + Watermark3.Text)
                    QuickStartPanel.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub ExitQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitQuickStartButton.Click
        QuickStartPanel.Visible = False
        Me.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - Vivian"
    End Sub

    Private Sub FavouritesQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavouritesQuickStartButton.Click
        SettingsPanelFavourites.Show()
    End Sub

    Private Sub HistoryQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryQuickStartButton.Click
        SettingsPanelHistory.Show()
    End Sub

    Private Sub SettingsQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsQuickStartButton.Click
        SettingsPanel.Show()
    End Sub

    Private Sub FeedbackQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedbackQuickStartButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.windowslogic.co.uk/feedback.php")
        QuickStartPanel.Hide()
    End Sub

    Private Sub HelpQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpQuickStartButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://docs.windowslogic.co.uk/vivian-index.php")
        QuickStartPanel.Hide()
    End Sub

    Private Sub DonateQuickStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonateQuickStartButton.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.paypal.me/windowslogic")
        QuickStartPanel.Visible = False
    End Sub
#End Region
#Region "Functions"

    Private Sub InternetBrowserTitle()
        If QuickStartPanel.Visible = True Then
            Timer1.Stop()
            Me.Text = "Quick Start - Vivian"
        Else
            Me.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - Vivian"
        End If
    End Sub

    Private Sub Watermark1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Watermark1.GotFocus
        Timer1.Stop()
    End Sub

    Private Sub Watermark1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Watermark1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                If My.Settings.PrivateBrowsing = "OFF" Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Watermark1.Text)
                    InternetBrowserTitle()
                    My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                    My.Settings.Save()
                End If

                If My.Settings.PrivateBrowsing = "ON" Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Watermark1.Text)
                    InternetBrowserTitle()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Watermark2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Watermark2.GotFocus
        Timer1.Stop()
    End Sub

    Private Sub Watermark3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Watermark3.GotFocus
        Timer1.Stop()
    End Sub

    Private Sub Watermark2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Watermark2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                If My.Settings.PrivateBrowsing = "OFF" Then
                    If My.Settings.Search = 1 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + Watermark2.Text)
                        My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                        My.Settings.Save()
                        Timer1.Start()
                    End If

                    If My.Settings.Search = 2 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + Watermark2.Text)
                        My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                        My.Settings.Save()
                        Timer1.Start()
                    End If

                    If My.Settings.Search = 3 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + Watermark2.Text)
                        My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                        My.Settings.Save()
                        Timer1.Start()
                    End If

                    If My.Settings.Search = 4 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + Watermark2.Text)
                        My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                        My.Settings.Save()
                        Timer1.Start()
                    End If
                End If

                If My.Settings.PrivateBrowsing = "ON" Then
                    If My.Settings.Search = 1 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + Watermark2.Text)
                        Timer1.Start()
                    End If

                    If My.Settings.Search = 2 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + Watermark2.Text)
                        Timer1.Start()
                    End If

                    If My.Settings.Search = 3 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + Watermark2.Text)
                        Timer1.Start()
                    End If

                    If My.Settings.Search = 4 Then
                        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + Watermark2.Text)
                        Timer1.Start()
                    End If
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub New_tab()
        Dim NewBrowser As New WebBrowser
        Dim NewTab As New TabPage
        NewBrowser.Tag = NewTab
        NewTab.Tag = NewBrowser
        TabControl1.TabPages.Add(NewTab)
        NewTab.Controls.Add(NewBrowser)
        NewBrowser.Dock = DockStyle.Fill
        Watermark1.Text = ""
        NewBrowser.Navigate(Watermark1.Text)
        AddHandler NewBrowser.DocumentCompleted, AddressOf Done
        Numtabs = Numtabs + 1
        TabControl1.SelectTab(Numtabs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.Homepage)
        Timer1.Start()
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).IsWebBrowserContextMenuEnabled = False
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ContextMenuStrip = BrowserRightClickMenu
    End Sub

    Private Sub Close_tab()
        If TabControl1.TabCount > 1 Then
            My.Settings.urlstore = Watermark1.Text
            TabControl1.SelectedTab.Dispose()
            int = int - 1
            Numtabs = Numtabs - 1
            GC.Collect()
        Else
            DirectCast(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate("about:blank")

        End If

        url = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
    End Sub

    Private Sub Done(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

        'Shorten tab text.
        If CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle.Length > 22 Then
            Dim source As String = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Dim cutdown As String = source.Substring(0, 22)
            TabControl1.SelectedTab.Text = cutdown & "..."
        Else
            TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        End If

        'Detect secure document.
        If Watermark1.Text.Contains("https://") Then
            SSLButton.Image = My.Resources.LockIco

        ElseIf Watermark1.Text.Contains("http://") Then
            SSLButton.Image = My.Resources.UnlockIco

        ElseIf Watermark1.Text.Contains("about:blank") Then
            SSLButton.Image = My.Resources.NewIco
        End If

        Try
            Watermark1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            InternetBrowserTitle()
            Timer1.Stop()
        Catch ex As Exception
        End Try

        Try
            SettingsPanelHistory.HistoryListBox.Items.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            If ListBox.NoMatches Then
            Else
                SettingsPanelHistory.HistoryListBox.Items.Remove(1)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Link(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)

        LinkClicked()
    End Sub

    Private Sub LinkClicked()

        If My.Settings.PrivateBrowsing = "OFF" Then
            Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
            Dim url As String = link.GetAttribute("href")

            My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            My.Settings.Save()
            Timer1.Start()
        End If

        If My.Settings.PrivateBrowsing = "ON" Then
            Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
            Dim url As String = link.GetAttribute("href")

            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(url)
            Timer1.Start()
        End If

    End Sub

    Dim InitialZoom As Integer = 100
    Public Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum
    Private Enum ExecOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Public Sub PerformZoom(ByVal Value As Integer)
        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            MyWeb = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, CObj(Value), CObj(IntPtr.Zero))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Navigating()

        StatusText.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).StatusText

        'Detect secure document.
        If Watermark1.Text.Contains("https://") Then
            SSLButton.Image = My.Resources.LockIco

        ElseIf Watermark1.Text.Contains("http://") Then
            SSLButton.Image = My.Resources.UnlockIco

        ElseIf Watermark1.Text.Contains("about:blank") Then
            SSLButton.Image = My.Resources.NewIco
            If QuickStartPanel.Visible = True Then
                Me.Text = "Quick Start - Vivian"
            ElseIf QuickStartPanel.Visible = False Then
                Me.Text = "about:blank - Vivian"
            End If
            '
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - Vivian"
        Watermark1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        If CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle.Length > 22 Then
            Dim source As String = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Dim cutdown As String = source.Substring(0, 22)
            TabControl1.SelectedTab.Text = cutdown & "..."
        Else
            TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        End If

        'Detect secure document.
        If Watermark1.Text.Contains("https://") Then
            SSLButton.Image = My.Resources.LockIco

        ElseIf Watermark1.Text.Contains("http://") Then
            SSLButton.Image = My.Resources.UnlockIco
        End If
    End Sub

    Private Sub StatusUpdater_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusUpdater.Tick
        Navigating()
    End Sub

    Private Sub TabControl1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseDoubleClick
        If TabControl1.TabCount = 1 Then
            Me.Close()
        Else
            Close_tab()
            Reopen_RCTM.Enabled = True
        End If
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub
#End Region
#Region "Right Click Tab Menu"
    Private Sub NewTab_RCTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTab_RCTM.Click
        New_tab()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTab_RCTM.Click
        If TabControl1.TabCount = 1 Then
            Me.Close()
        Else
            Close_tab()
            Reopen_RCTM.Enabled = True
        End If
    End Sub

    Private Sub DuplicateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Duplicate_RCTM.Click
        My.Settings.dupestore = Watermark1.Text
        New_tab()
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.dupestore)
        My.Settings.dupestore = ""
    End Sub

    Private Sub ReopenClosedTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reopen_RCTM.Click
        If Watermark1.Text = "about:blank" Or My.Settings.urlstore = "" Then
            Reopen_RCTM.Enabled = False
        Else
            New_tab()
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.urlstore)
            My.Settings.urlstore = ""
            Reopen_RCTM.Enabled = False
        End If
    End Sub

    Private Sub RightClickTabMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RightClickTabMenu.Opening
        If My.Settings.urlstore = "" Then
            Reopen_RCTM.Enabled = False
        Else
            Reopen_RCTM.Enabled = True
        End If
    End Sub
#End Region
#Region "Right Click Browser Menu"

    Private Sub RightClickMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BrowserRightClickMenu.Opening
        Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        If url = "" Then
            OpenLink_RCM.Enabled = False
            OpenLinkWindow_RCM.Enabled = False
            SaveLink_RCM.Enabled = False
            CopyLink_RCM.Enabled = False
            Favourite_RCM.Enabled = False
        Else
            OpenLink_RCM.Enabled = True
            OpenLinkWindow_RCM.Enabled = True
            SaveLink_RCM.Enabled = True
            CopyLink_RCM.Enabled = True
            Favourite_RCM.Enabled = True
        End If

        Try
            Dim domDocument As IHTMLDocument2 = DirectCast(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.DomDocument, IHTMLDocument2)
            Dim selection As IHTMLSelectionObject = domDocument.selection
            If selection IsNot Nothing Then
                Dim range As IHTMLTxtRange = DirectCast(selection.createRange, IHTMLTxtRange)
                If range.text = "" Then
                    SearchFor_RCM.Enabled = False
                    SearchFor_RCM.Text = "Nothing to search for..."
                    Copy_RCM.Enabled = False
                Else
                    Copy_RCM.Enabled = True
                    SearchFor_RCM.Enabled = True
                    My.Settings.searchfor = range.text
                    Dim source As String = My.Settings.searchfor
                    Dim cutdown As String = source.Substring(0, 30)
                    SearchFor_RCM.Text = "Search for " & "'" & cutdown & "'" & "..."
                End If
            End If
        Catch
            SearchFor_RCM.Enabled = False
            Copy_RCM.Enabled = False
        End Try

        If (CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document IsNot Nothing) Then
            Dim elem As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
            Dim NameStr As String = elem.GetAttribute("name")
            If Clipboard.ContainsData(DataFormats.Text) = False Or NameStr = "" Or NameStr = "" And Clipboard.ContainsData(DataFormats.Text) = False Then
                Paste_RCM.Enabled = False
            Else
                Paste_RCM.Enabled = True
            End If
        End If
    End Sub

    Private Sub OpenLink_RCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLink_RCM.Click
        Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
        Dim url As String = link.GetAttribute("href")
        New_tab()
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(url)
    End Sub

    Private Sub TestToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLinkWindow_RCM.Click
        Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        My.Settings.urlstore = url
        Dim NewWindow As New Browser
        NewWindow.Show()
        NewWindow.QuickStartPanel.Hide()
        CType(NewWindow.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(url)
        My.Settings.urlstore = ""
    End Sub

    Private Sub OpenDefaultBrowser_Click(sender As Object, e As EventArgs) Handles OpenDefaultBrowser_RCM.Click
        DefaultBrowserYesNo.ShowDialog()
    End Sub

    Private Sub SaveLink_RCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveLink_RCM.Click
        Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
        Dim url As String = link.GetAttribute("href")
        Dim SaveLink As New SaveFileDialog With {
            .FileName = "url",
            .Filter = "HTML Files (*.html)|*.html"
        }
        With SaveLink
            .AddExtension = True
            .OverwritePrompt = True
            .ValidateNames = True
            .DefaultExt = "html"
            .ShowHelp = True
            If SaveLink.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.WriteAllText(.FileName, My.Settings.urlsave1 & url & My.Settings.urlsave2, False)
                Catch
                    errordiag.Label1.Text = "There has been an error while writing the file."
                    errordiag.ShowDialog()
                End Try
            End If
        End With

    End Sub

    Private Sub CopyLink_RCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyLink_RCM.Click
        Clipboard.SetText(StatusText.Text)
    End Sub

    Private Sub Copy_RCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_RCM.Click
        Clipboard.SetText(My.Settings.searchfor)
    End Sub

    Private Sub Paste_RCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste_RCM.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Paste", True, vbNull)
    End Sub

    Private Sub SearchFor_RCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchFor_RCM.Click
        If My.Settings.PrivateBrowsing = "OFF" Then
            If My.Settings.Search = 1 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + My.Settings.searchfor)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
                QuickStartPanel.Visible = False
            End If

            If My.Settings.Search = 2 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + My.Settings.searchfor)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
                QuickStartPanel.Visible = False
            End If

            If My.Settings.Search = 3 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + My.Settings.searchfor)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
                QuickStartPanel.Visible = False
            End If

            If My.Settings.Search = 4 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + My.Settings.searchfor)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
                QuickStartPanel.Visible = False
            End If
        End If

        If My.Settings.PrivateBrowsing = "ON" Then
            If My.Settings.Search = 1 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + My.Settings.searchfor)
                QuickStartPanel.Visible = False
            End If

            If My.Settings.Search = 2 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + My.Settings.searchfor)
                QuickStartPanel.Visible = False
            End If

            If My.Settings.Search = 3 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + My.Settings.searchfor)
                QuickStartPanel.Visible = False
            End If

            If My.Settings.Search = 4 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + My.Settings.searchfor)
                QuickStartPanel.Visible = False
            End If
        End If
    End Sub

    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        Watermark1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Me.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - Vivian"
        If CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle.Length > 22 Then
            Dim source As String = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Dim cutdown As String = source.Substring(0, 22)
            TabControl1.SelectedTab.Text = cutdown & "..."
        Else
            TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        End If

        'Detect secure document.
        If Watermark1.Text.Contains("https://") Then
            SSLButton.Image = My.Resources.LockIco

        ElseIf Watermark1.Text.Contains("http://") Then
            SSLButton.Image = My.Resources.UnlockIco

        ElseIf Watermark1.Text.Contains("about:blank") Then
            SSLButton.Image = My.Resources.NewIco
            Me.Text = "about:blank - Vivian"
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("SelectAll", True, vbNull)
    End Sub

    Private Sub TabControl1_MouseHover(sender As Object, e As EventArgs) Handles TabControl1.MouseHover
        ToolTip1.SetToolTip(TabControl1, CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
    End Sub
#End Region
#Region "Address Bar Right Click Menu"
    Private Sub AddressBarRightClickMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddressBarRightClickMenu.Opening
        If Watermark1.SelectionLength = 0 Then
            Cut_ACM.Enabled = False
            Copy_ACM.Enabled = False
        Else
            Cut_ACM.Enabled = True
            Copy_ACM.Enabled = True
        End If

        If Watermark1.Text.Length = 0 Then
            SelectAll_ACM.Enabled = False
        Else
            SelectAll_ACM.Enabled = True
        End If

        If Clipboard.ContainsText = False Then
            Paste_ACM.Enabled = False
            PasteGo_ACM.Enabled = False
        Else
            Paste_SCM.Enabled = True
            PasteGo_ACM.Enabled = True
        End If
    End Sub

    Private Sub Cut_ACM_Click(sender As Object, e As EventArgs) Handles Cut_ACM.Click
        Clipboard.SetText(Watermark1.Text)
        Watermark1.Clear()
    End Sub

    Private Sub Copy_ACM_Click(sender As Object, e As EventArgs) Handles Copy_ACM.Click
        Clipboard.SetText(Watermark1.Text)
    End Sub

    Private Sub Paste_ACM_Click(sender As Object, e As EventArgs) Handles Paste_ACM.Click
        Watermark1.Text = Clipboard.GetText()
    End Sub

    Private Sub PasteGo_ACM_Click(sender As Object, e As EventArgs) Handles PasteGo_ACM.Click
        Watermark1.Text = Clipboard.GetText()
        Try

            If My.Settings.PrivateBrowsing = "OFF" Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Watermark1.Text)
                InternetBrowserTitle()
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If

            If My.Settings.PrivateBrowsing = "ON" Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Watermark1.Text)
                InternetBrowserTitle()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SelectAll_ACM_Click(sender As Object, e As EventArgs) Handles SelectAll_ACM.Click
        Watermark1.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem1.Click
        Watermark1.Undo()
    End Sub

    Private Sub ClearToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem2.Click
        Watermark1.Clear()
    End Sub
#End Region
#Region "Search Bar Right Click Menu"
    Private Sub SearchBarRightClickMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SearchBarRightClickMenu.Opening
        If Watermark2.SelectionLength = 0 Then
            Cut_SCM.Enabled = False
            Copy_SCM.Enabled = False
        Else
            Cut_SCM.Enabled = True
            Copy_SCM.Enabled = True
        End If

        If Watermark2.Text.Length = 0 Then
            SelectAll_SCM.Enabled = False
        Else
            SelectAll_SCM.Enabled = True
        End If

        If Clipboard.ContainsText = False Then
            Paste_SCM.Enabled = False
            PasteGo_SCM.Enabled = False
        Else
            Paste_SCM.Enabled = True
            PasteGo_SCM.Enabled = True
        End If
    End Sub

    Private Sub Cut_SCM_Click(sender As Object, e As EventArgs) Handles Cut_SCM.Click
        Clipboard.SetText(Watermark2.Text)
        Watermark2.Clear()
    End Sub

    Private Sub Copy_SCM_Click(sender As Object, e As EventArgs) Handles Copy_SCM.Click
        Clipboard.SetText(Watermark2.Text)
    End Sub

    Private Sub Paste_SCM_Click(sender As Object, e As EventArgs) Handles Paste_SCM.Click
        Watermark2.Text = Clipboard.GetText()
    End Sub

    Private Sub PasteGo_SCM_Click(sender As Object, e As EventArgs) Handles PasteGo_SCM.Click
        Watermark2.Text = Clipboard.GetText()
        If My.Settings.PrivateBrowsing = "OFF" Then
            If My.Settings.Search = 1 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + Watermark2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If

            If My.Settings.Search = 2 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + Watermark2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If

            If My.Settings.Search = 3 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + Watermark2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If

            If My.Settings.Search = 4 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + Watermark2.Text)
                My.Settings.History.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                My.Settings.Save()
            End If
        End If

        If My.Settings.PrivateBrowsing = "ON" Then
            If My.Settings.Search = 1 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" + Watermark2.Text)
            End If

            If My.Settings.Search = 2 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + Watermark2.Text)
            End If

            If My.Settings.Search = 3 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://uk.search.yahoo.com/search?q=" + Watermark2.Text)
            End If

            If My.Settings.Search = 4 Then
                CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + Watermark2.Text)
            End If
        End If
    End Sub

    Private Sub SelectAll_SCM_Click(sender As Object, e As EventArgs) Handles SelectAll_SCM.Click
        Watermark2.SelectAll()
    End Sub

    Private Sub AddLinkToFavouritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Favourite_RCM.Click
        Dim link As HtmlElement = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        Favourite.Show()
        Favourite.URLText.Text = url
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Watermark2.Undo()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Watermark2.Clear()
    End Sub
#End Region
End Class
