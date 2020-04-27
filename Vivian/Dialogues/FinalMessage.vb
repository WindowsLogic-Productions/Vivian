Public Class FinalMessage
    Private Sub FinalMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.About, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class