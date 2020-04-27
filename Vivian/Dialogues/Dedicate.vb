Public Class Dedicate
#Region "Load Settings"
    Private Sub Dedicate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub
#End Region
End Class