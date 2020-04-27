Public Class Resetyesno
#Region "Load Settings"
    Private Sub Resetyesno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
    Private Sub YesButton_Click(sender As System.Object, e As System.EventArgs) Handles YesButton.Click
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

        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As System.Object, e As System.EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
#End Region
End Class