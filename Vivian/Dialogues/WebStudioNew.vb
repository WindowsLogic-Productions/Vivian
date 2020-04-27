Public Class WebStudioNew
#Region "Load Settings"
    Private Sub WebStudioNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Custom colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

    End Sub
#End Region
#Region "Buttons"
    Private Sub HTMLButton_Click(sender As Object, e As EventArgs) Handles HTMLButton.Click
        HTMLStudio.Show()
        HTMLStudio.HTMLTabs.Show()
        HTMLStudio.CSSText.Hide()
        HTMLStudio.HTMLTagsToolStripMenuItem.Enabled = True
        HTMLStudio.Text = "Web Studio - HTML Editor"
        HTMLStudio.Focus()
        Me.Close()
    End Sub

    Private Sub CSSButton_Click(sender As Object, e As EventArgs) Handles CSSButton.Click
        HTMLStudio.Show()
        HTMLStudio.CSSText.Show()
        HTMLStudio.HTMLTabs.Hide()
        HTMLStudio.HTMLTagsToolStripMenuItem.Enabled = False
        HTMLStudio.Text = "Web Studio - CSS Editor"
        Me.Close()
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "WSHD (Web Studio HTML Document) (*.wshd)|*.wshd|WSCD (Web Studio CSS Document) (*.wscd)|*.wscd|HTML (Hyper Text Markup Language) (*.html)|*.html|CSS (Cascading Style Sheet) (*.css)|*.css"
        If Open.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Open.FileName.Contains("html") Or Open.FileName.Contains("wshd") Then
                HTMLStudio.Show()
                HTMLStudio.CSSText.Hide()
                HTMLStudio.HTMLTabs.Show()
                HTMLStudio.HTMLText.LoadFile(Open.FileName, RichTextBoxStreamType.PlainText)
                Me.Close()
            ElseIf Open.FileName.Contains("css") Or Open.FileName.Contains("wscd") Then
                HTMLStudio.Show()
                HTMLStudio.CSSText.Show()
                HTMLStudio.HTMLTabs.Hide()
                HTMLStudio.CSSText.LoadFile(Open.FileName, RichTextBoxStreamType.PlainText)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsPanelWebStudio.Show()
    End Sub
#End Region
End Class