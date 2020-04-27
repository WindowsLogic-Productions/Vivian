Public Class WhatsNew
#Region "Load Settings"
    Private Sub UpdateLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.ListBox1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
End Class