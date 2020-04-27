Public Class SaveDatayesno
#Region "Load Settings"
    Private Sub SaveDatayesno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Personalisation settings.
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
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Me.Hide()
        Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
        Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
        My.Settings.Startup = 0
        My.Settings.Homepage = "https://windowslogic.co.uk"
        My.Settings.Search = 4
        My.Settings.PrivateBrowsing = "OFF"
        SettingsPanel.BackColor = Color.DodgerBlue
        Browser.BackColor = Color.DodgerBlue
        My.Settings.CustomColour = Color.DodgerBlue
        My.Settings.DHBHUC = 0
        My.Settings.Sounds = "ON"
        My.Settings.Updates = 1
        My.Settings.wsstart = 1
        My.Settings.wswordwrap = 1
        My.Settings.wsfont = New Font("Segoe UI", 8)
        My.Settings.wsfontcolour = Color.Black
        My.Settings.wsbackcolour = Color.White
        My.Settings.History.Clear()
        SettingsPanelHistory.HistoryListBox.Items.Clear()
        SettingsPanelFavourites.FavouriteListBox.Items.Clear()
        Information.Label1.Text = "All save data has been deleted. Vivian ESR will now restart."
        Information.ShowDialog()
        SettingsPanelGeneral.Hide()
        Me.Close()
        Browser.Close()
        Browser.Show()
        SettingsPanelGeneral.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
#End Region
End Class