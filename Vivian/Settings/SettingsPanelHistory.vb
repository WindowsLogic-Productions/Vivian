Public Class SettingsPanelHistory
#Region "Load Settings"
    Private Sub SettingsPanelHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load History.
        Try

            HistoryListBox.Items.Clear()

            Dim c As Integer = My.Settings.History.Count
            Dim x As Integer
            For x = 0 To c - 1
                HistoryListBox.Items.Add(My.Settings.History.Item(x))
            Next


        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Buttons"
    Private Sub OpenHistoryPageButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenHistoryPageButton.Click
        Try
            Browser.QuickStartPanel.Hide()
            CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(HistoryListBox.SelectedItem)
        Catch
            errordiag.Label1.Text = "Please select an item to open."
            errordiag.ShowDialog()
        End Try
    End Sub

    Private Sub HistoryDeleteButton_Click(sender As System.Object, e As System.EventArgs) Handles HistoryDeleteButton.Click
        Try
            Try
                Dim item As Integer = My.Settings.History.IndexOf(HistoryListBox.SelectedItem)
                My.Settings.History.RemoveAt(item)
                HistoryListBox.Items.Remove(HistoryListBox.SelectedItem)
                My.Settings.Save()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HistoryDeleteAllButton_Click(sender As System.Object, e As System.EventArgs) Handles HistoryDeleteAllButton.Click
        Historyyesno.Show()
    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Dispose()
    End Sub
#End Region
#Region "Functions"
    Private Sub HistoryListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles HistoryListBox.MouseDoubleClick
        Try
            Browser.QuickStartPanel.Hide()
            CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(HistoryListBox.SelectedItem)
        Catch
            errordiag.Label1.Text = "Please select an item to open."
            errordiag.ShowDialog()
        End Try
    End Sub
#End Region
End Class