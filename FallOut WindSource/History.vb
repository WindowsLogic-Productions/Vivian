Public Class History

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ListBox1.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                Dim item As Integer = My.Settings.History.IndexOf(ListBox1.SelectedItem)
                My.Settings.History.RemoveAt(item)
                ListBox1.Items.Remove(ListBox1.SelectedItem)
                My.Settings.Save()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ListBox1.Items.Clear()

            Dim c As Integer = My.Settings.History.Count
            Dim x As Integer
            For x = 0 To c - 1
                ListBox1.Items.Add(My.Settings.History.Item(x))
            Next


        Catch ex As Exception

        End Try
    End Sub
End Class