Public Class SettingsPanel
#Region "Load Settings"
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub GeneralSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralSettingsButton.Click
        SettingsPanelGeneral.Show()
        Me.Dispose()
    End Sub

    Private Sub PersonaliseSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaliseSettingsButton.Click
        SettingsPanelPersonalise.Show()
        Me.Dispose()
    End Sub

    Private Sub UpdatesSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatesSettingsButton.Click
        SettingsPanelUpdates.Show()
        Me.Dispose()
    End Sub

    Private Sub HistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorySettingsButton.Click
        SettingsPanelHistory.Show()
        Me.Dispose()
    End Sub

    Private Sub FavouritesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavouritesSettingsButton.Click
        SettingsPanelFavourites.Show()
        Me.Dispose()
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        Resetyesno.ShowDialog()
    End Sub

    Private Sub WebStudioSettingsButton_Click(sender As Object, e As EventArgs) Handles WebStudioSettingsButton.Click
        SettingsPanelWebStudio.Show()
        Me.Dispose()
    End Sub
#End Region
End Class