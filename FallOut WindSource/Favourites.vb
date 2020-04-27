Public Class Favourites

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item As String In My.Settings.Bookmarks
            Bookmarks.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Bookmarks.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Bookmarks.Clear()
        Bookmarks.Items.Clear()
    End Sub

    Private Sub Bookmarks_DoubleClick(sender As Object, e As EventArgs) Handles Bookmarks.DoubleClick
        CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Bookmarks.SelectedItem)
    End Sub
End Class