Public Class SettingsPanelWebStudio
#Region "Load Settings"
    Private Sub SettingsPanelWebStudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load Display Start Dialogue settings.
        If My.Settings.wsstart = 0 Then
            DisplayStartBox.Checked = False
        End If

        If My.Settings.wsstart = 1 Then
            DisplayStartBox.Checked = True
        End If

        'Load Word Wrap settings.
        If My.Settings.wswordwrap = 0 Then
            WordWrapBox.Checked = False
        End If

        If My.Settings.wswordwrap = 1 Then
            WordWrapBox.Checked = True
        End If

    End Sub
#End Region
#Region "Settings"
    Private Sub DisplayStartBox_CheckedChanged(sender As Object, e As EventArgs) Handles DisplayStartBox.CheckedChanged

        If DisplayStartBox.Checked = False Then
            My.Settings.wsstart = 0
            My.Settings.Save()
        End If

        If DisplayStartBox.Checked = True Then
            My.Settings.wsstart = 1
            My.Settings.Save()
        End If

    End Sub

    Private Sub WordWrapBox_CheckedChanged(sender As Object, e As EventArgs) Handles WordWrapBox.CheckedChanged
        If WordWrapBox.Checked = False Then
            My.Settings.wswordwrap = 0
            HTMLStudio.HTMLText.WordWrap = False
            My.Settings.Save()
        End If

        If WordWrapBox.Checked = True Then
            My.Settings.wswordwrap = 1
            HTMLStudio.HTMLText.WordWrap = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub FontButton_Click(sender As Object, e As EventArgs) Handles FontButton.Click
        Try
            Dim Font As FontDialog = New FontDialog
            Font.Font = HTMLStudio.HTMLText.Font
            If Font.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                HTMLStudio.HTMLText.Font = Font.Font
                HTMLStudio.CSSText.Font = Font.Font
                My.Settings.wsfont = Font.Font
                My.Settings.Save()
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub TextButton_Click(sender As Object, e As EventArgs) Handles TextButton.Click
        Try
            Dim Colour As ColorDialog = New ColorDialog
            Colour.Color = HTMLStudio.HTMLText.ForeColor
            If Colour.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                HTMLStudio.HTMLText.ForeColor = Colour.Color
                HTMLStudio.CSSText.ForeColor = Colour.Color
                My.Settings.wsfontcolour = Colour.Color
                My.Settings.Save()
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub ColourButton_Click(sender As Object, e As EventArgs) Handles ColourButton.Click
        Try
            Dim Colour As ColorDialog = New ColorDialog
            Colour.Color = HTMLStudio.HTMLText.BackColor
            If Colour.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                HTMLStudio.HTMLText.BackColor = Colour.Color
                HTMLStudio.CSSText.BackColor = Colour.Color
                My.Settings.wsbackcolour = Colour.Color
                My.Settings.Save()
            End If
        Catch ex As Exception : End Try
    End Sub
#End Region
#Region "Other"
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Close()
    End Sub
#End Region
End Class