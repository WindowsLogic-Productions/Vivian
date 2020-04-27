Public Class TIFyesno
#Region "Load Settings"
    Private Sub TIFyesno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
        Information.Label1.Text = "All temporary Internet files have been deleted."
        Information.ShowDialog()
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
#End Region
End Class