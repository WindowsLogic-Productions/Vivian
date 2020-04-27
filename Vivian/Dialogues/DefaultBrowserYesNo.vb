Public Class DefaultBrowserYesNo
#Region "Load Settings"
    Private Sub DefaultBrowserYesNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load sound settings.
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Dim address As String = Browser.Watermark1.Text
        Process.Start(address)
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
#End Region
End Class