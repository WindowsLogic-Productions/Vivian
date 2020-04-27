Public Class SettingsPanelGeneral
#Region "Load Settings"
    Private Sub SettingsPanelGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load start-up settings
        If My.Settings.Startup = 0 Then
            BlankPageSwitch.Checked = True
        End If

        If My.Settings.Startup = 1 Then
            SettingsSwitch.Checked = True
        End If

        If My.Settings.Startup = 2 Then
            HomepageSwitch.Checked = True
        End If

        'Load search provider settings
        If My.Settings.Search = 1 Then
            GoogleSwitch.Checked = True
        End If

        If My.Settings.Search = 2 Then
            BingSwitch.Checked = True
        End If

        If My.Settings.Search = 3 Then
            YahooSwitch.Checked = True
        End If

        If My.Settings.Search = 4 Then
            DuckDuckGoSwitch.Checked = True
        End If

        'Load Homepage settings
        HomepageTextBox.Text = My.Settings.Homepage
        My.Settings.Homepage = HomepageTextBox.Text

        'Load private browsing settings
        If My.Settings.PrivateBrowsing = "ON" Then
            PrivateBrowsingSwitchON.Checked = True
        End If

        If My.Settings.PrivateBrowsing = "OFF" Then
            PrivateBrowsingSwitchOFF.Checked = True
        End If

        'Load stop button settings.
        If My.Settings.StopButton = 0 Then
            StopButtonCheckBox.Checked = False
        End If

        If My.Settings.StopButton = 1 Then
            StopButtonCheckBox.Checked = True
        End If

        'Load home button settings.
        If My.Settings.HomeButton = 0 Then
            HomeButtonCheckBox.Checked = False
            HomepageTextBox.Enabled = False
        End If

        If My.Settings.HomeButton = 1 Then
            HomeButtonCheckBox.Checked = True
            HomepageTextBox.Enabled = True
        End If
    End Sub
#End Region
#Region "Start-up"
    Private Sub BlankPageSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankPageSwitch.CheckedChanged
        If BlankPageSwitch.Checked = True Then
            My.Settings.Startup = 0
        End If
    End Sub

    Private Sub SettingsSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsSwitch.CheckedChanged
        If SettingsSwitch.Checked = True Then
            My.Settings.Startup = 1
        End If
    End Sub

    Private Sub HomepageSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomepageSwitch.CheckedChanged
        If HomepageSwitch.Checked = True Then
            My.Settings.Startup = 2
        End If
    End Sub
#End Region
#Region "Homepage"
    Private Sub HomepageTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomepageTextBox.TextChanged
        My.Settings.Homepage = HomepageTextBox.Text
        My.Settings.Save()
    End Sub
#End Region
#Region "Search"
    Private Sub GoogleSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleSwitch.CheckedChanged
        My.Settings.Search = 1
    End Sub

    Private Sub BingSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingSwitch.CheckedChanged
        My.Settings.Search = 2
    End Sub

    Private Sub YahooSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YahooSwitch.CheckedChanged
        My.Settings.Search = 3
    End Sub

    Private Sub DuckDuckGoSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuckDuckGoSwitch.checkedchanged
        My.Settings.Search = 4
    End Sub
#End Region
#Region "Browsing"
    Private Sub PrivateBrowsingSwitchON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivateBrowsingSwitchON.CheckedChanged
        If PrivateBrowsingSwitchON.Checked = True Then
            My.Settings.PrivateBrowsing = "ON"
        End If
        My.Settings.Save()
    End Sub

    Private Sub PrivateBrowsingSwitchOFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivateBrowsingSwitchOFF.CheckedChanged
        If PrivateBrowsingSwitchOFF.Checked = True Then
            My.Settings.PrivateBrowsing = "OFF"
        End If
        My.Settings.Save()
    End Sub
#End Region
#Region "Other"
    Private Sub StopButtonCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButtonCheckBox.CheckedChanged
        If StopButtonCheckBox.Checked = False Then
            Browser.StopButton.Enabled = False
            My.Settings.StopButton = 0
        End If

        If StopButtonCheckBox.Checked = True Then
            Browser.StopButton.Enabled = True
            My.Settings.StopButton = 1
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButtonCheckBox.CheckedChanged
        If HomeButtonCheckBox.Checked = False Then
            Browser.HomeButton.Enabled = False
            HomepageTextBox.Enabled = False
            My.Settings.HomeButton = 0
        End If

        If HomeButtonCheckBox.Checked = True Then
            Browser.HomeButton.Enabled = True
            HomepageTextBox.Enabled = True
            My.Settings.HomeButton = 1
        End If
    End Sub

#End Region
#Region "Buttons"
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Dispose()
    End Sub

    Private Sub DelCookieButton_Click(sender As Object, e As EventArgs) Handles DelCookieButton.Click
        Cookiesyesno.ShowDialog()
    End Sub

    Private Sub DelTempButton_Click(sender As Object, e As EventArgs) Handles DelTempButton.Click
        TIFyesno.ShowDialog()
    End Sub

    Private Sub DelSaveButton_Click(sender As Object, e As EventArgs) Handles DelSaveButton.Click
        SaveDatayesno.ShowDialog()
    End Sub

#End Region
End Class