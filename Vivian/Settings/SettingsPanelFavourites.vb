Public Class SettingsPanelFavourites
#Region "Load Settings"
    Private Sub SettingsPanelFavourites_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        For Each item As String In My.Settings.Bookmarks
            FavouriteListBox.Items.Add(item)
        Next
    End Sub
#End Region
#Region "Buttons"
    Private Sub OpenFavouritePageButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenFavouritePageButton.Click
        Try
            Browser.QuickStartPanel.Hide()
            CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(FavouriteListBox.SelectedItem)
        Catch
            errordiag.Label1.Text = "Please select an item to open."
            errordiag.ShowDialog()
        End Try
    End Sub

    Private Sub DeleteFavouriteButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteFavouriteButton.Click
        Try
            Try
                Dim item As Integer = My.Settings.Bookmarks.IndexOf(FavouriteListBox.SelectedItem)
                My.Settings.Bookmarks.RemoveAt(item)
                FavouriteListBox.Items.Remove(FavouriteListBox.SelectedItem)
                My.Settings.Save()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteAllFavouriteButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteAllFavouriteButton.Click
        Favouritesyesno.Show()
    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Dispose()
    End Sub
#End Region
#Region "Functions"
    Private Sub FavouriteListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles FavouriteListBox.MouseDoubleClick
        Try
            Browser.QuickStartPanel.Hide()
            CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(FavouriteListBox.SelectedItem)
        Catch
            errordiag.Label1.Text = "Please select an item to open."
            errordiag.ShowDialog()
        End Try
    End Sub
#End Region
End Class