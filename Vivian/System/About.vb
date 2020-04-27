Class About
#Region "Load Settings"
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sound
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.About, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load version number and licence.
        Variables.ParseVariables(VerInfo)
        Variables.ParseVariables(Copyright)
    End Sub
#End Region
#Region "Other"
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub MoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreButton.Click
        Dedicate.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.windowslogic.co.uk/appagreement.php")
        Me.Close()
    End Sub
#End Region
End Class