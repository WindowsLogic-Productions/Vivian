Public Class Favouritesyesno
#Region "Load Settings"
    Private Sub Favouritesareyousure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Sound
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        My.Settings.Bookmarks.Clear()
        SettingsPanelFavourites.FavouriteListBox.Items.Clear()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Dispose()
    End Sub
#End Region
End Class