Public Class SettingsPanelUpdates
#Region "Load Settings"
    Private Sub SettingsPanelUpdates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load custom colours.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load update settings.
        If My.Settings.Updates = 1 Then
            EnableUpdatesSwitch.Checked = True
        End If

        If My.Settings.Updates = 0 Then
            DisableUpdatesSwitch.Checked = True
        End If
    End Sub
#End Region
#Region "Update Settings"
    Private Sub EnableUpdatesSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableUpdatesSwitch.CheckedChanged
        If EnableUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 1
            PictureBox1.Image = My.Resources.GoodGradient
            My.Settings.Save()
        End If
    End Sub

    Private Sub DisableUpdatesSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableUpdatesSwitch.CheckedChanged
        If DisableUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 0
            PictureBox1.Image = My.Resources.BadGradient
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub ManualUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualUpdateButton.Click
        Updater.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Dispose()
    End Sub
#End Region
End Class