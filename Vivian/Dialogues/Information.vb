Public Class Information
#Region "Load Settings"
    Private Sub Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load sound settings.
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.Info, AudioPlayMode.Background)
        End If

        'If My.Settings.Sounds = 1 Then
        'My.Computer.Audio.Play(My.Resources.Information2, AudioPlayMode.Background)
        'End If

        If My.Settings.Sounds = "OFF" Then
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub
#End Region
End Class