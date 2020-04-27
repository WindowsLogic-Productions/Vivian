Public Class SettingsPanelPersonalise
#Region "Load Settings"
    Private Sub SettingsPanelPersonalise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load background settings.
        If My.Settings.DHBHUC = 0 Then
            HDBSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 1 Then
            HUCSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 2 Then
            RB1.Checked = True
            CB1Button.Enabled = True
            HubBackgroundPicture.Load(My.Settings.CB1)
        End If

        'Load custom colours.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load sound settings.
        If My.Settings.Sounds = "ON" Then
            SoundsSwitchON.Checked = True
        End If

        If My.Settings.Sounds = "OFF" Then
            SoundsSwitchOFF.Checked = True
        End If
    End Sub
#End Region
#Region "Background"
    Private Sub RB1Box_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.Click
        If RB1.Checked = True Then
            CB1Button.Enabled = True
            Try
                HubBackgroundPicture.Load(My.Settings.CB1)
                Browser.HubBackground.Load(My.Settings.CB1)
                Browser.QuickStartBackground.Load(My.Settings.CB1)
                My.Settings.DHBHUC = 2
                My.Settings.Save()
            Catch ex As Exception

            End Try
        End If

        If RB1.Checked = False Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            HubBackgroundPicture.Image = Nothing
        End If

        My.Settings.Save()
    End Sub

    Private Sub CB1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1Button.Click
        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            HubBackgroundPicture.Load(OpenFileDialog1.FileName)
            My.Settings.CB1 = OpenFileDialog1.FileName
            Browser.HubBackground.Load(My.Settings.CB1)
            Information.Label1.Text = "Please re-open this dialogue and choose 'Custom Background' to confirm your selection."
            Information.ShowDialog()
            My.Settings.Save()
        End If
    End Sub

    Private Sub HDBSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDBSwitch.CheckedChanged
        If HDBSwitch.Checked = True Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            RB1.Checked = False
            HubBackgroundPicture.Image = My.Resources.Background
            Browser.HubBackground.Image = My.Resources.Background
            Browser.QuickStartBackground.Image = My.Resources.Background
            My.Settings.Save()
        End If
    End Sub

    Private Sub HUCSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HUCSwitch.CheckedChanged
        If HUCSwitch.Checked = True Then
            My.Settings.DHBHUC = 1
            CB1Button.Enabled = False
            RB1.Checked = False
            HubBackgroundPicture.Image = Nothing
            Browser.HubBackground.Image = Nothing
            Browser.QuickStartBackground.Image = Nothing
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Custom Colours"
    Private Sub CustomColourButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomColourButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.CustomColour = ColorDialog1.Color
            Me.BackColor = My.Settings.CustomColour
            Browser.BackColor = My.Settings.CustomColour
            Browser.BackButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.ForwardButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.RefreshButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.StopButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.HomeButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.SSLButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.FavouriteButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.CloseTabButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.NewTabButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            Browser.MenuButton.FlatAppearance.MouseOverBackColor = My.Settings.CustomColour
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Sounds"
    Private Sub SoundsSwitchON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundsSwitchON.CheckedChanged
        If SoundsSwitchON.Checked = True Then
            My.Settings.Sounds = "ON"
            My.Computer.Audio.Play(My.Resources.Info, AudioPlayMode.Background)
        End If
        My.Settings.Save()
    End Sub

    Private Sub SoundsSwitchOFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundsSwitchOFF.CheckedChanged
        If SoundsSwitchOFF.Checked = True Then
            My.Settings.Sounds = "OFF"
        End If
        My.Settings.Save()
    End Sub
#End Region
#Region "Buttons"
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Dispose()
    End Sub
#End Region
End Class