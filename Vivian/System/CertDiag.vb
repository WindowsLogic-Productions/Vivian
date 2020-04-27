Public Class CertDiag
    Private Sub CertDiag_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If Browser.Watermark1.Text.Contains("https://") Then
            PictureBox1.Image = My.Resources.LockIco
            TitleLabel.Text = "Secure (Hypertext Transfer Protocol Secure)"
            SubTitleLabel.Text = "Your connection to this site is secure."
            SecLabel.Text = "Your information (for example, passwords or credit cards) are private when sent" & vbNewLine & "to this site."
            ViewCertButton.Enabled = True
        ElseIf Browser.Watermark1.Text.Contains("http://") Then
            PictureBox1.Image = My.Resources.UnlockIco
            TitleLabel.Text = "Not Secure (Hypertext Transfer Protocol)"
            SubTitleLabel.Text = "Your connection to this site is not secure."
            SecLabel.Text = "Your information (for example, passwords or credit cards) are not private when sent" & vbNewLine & "to this site."
            ViewCertButton.Enabled = True
        End If

        If Browser.Watermark1.Text = "about:blank" Then
            PictureBox1.Image = My.Resources.NewIco
            TitleLabel.Text = "Blank Document"
            SubTitleLabel.Text = "You are on a blank page."
            SecLabel.Text = "There is no data on this page."
            ViewCertButton.Enabled = False
        End If

        If Browser.Watermark1.Text = "" Then
            Me.Close()
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub ViewCertButton_Click(sender As Object, e As EventArgs) Handles ViewCertButton.Click
        CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub
End Class