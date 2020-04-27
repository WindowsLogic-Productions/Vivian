Public Class Favourite
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        My.Settings.Bookmarks.Add(URLText.Text)
        SettingsPanelFavourites.FavouriteListBox.Items.Clear()
        Information.Label1.Text = "The specified page has been saved to your pinned sites."
        Information.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Favourite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Set text as current URL.
        URLText.Text = Browser.Watermark1.Text
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FavouritesButton.Click
        SettingsPanelFavourites.Show()
    End Sub
End Class