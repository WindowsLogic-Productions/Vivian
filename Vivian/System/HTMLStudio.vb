Public Class HTMLStudio
#Region "Load Settings"
    Private Sub Form5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.TopMost = False

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            StudioMenu.BackColor = My.Settings.CustomColour
        End If

        'Load word wrap settings.
        If My.Settings.wswordwrap = 0 Then
            HTMLText.WordWrap = False
            CSSText.WordWrap = False
        End If

        If My.Settings.wswordwrap = 1 Then
            HTMLText.WordWrap = True
            CSSText.WordWrap = True
        End If

        'Load font settings.
        HTMLText.Font = My.Settings.wsfont
        CSSText.Font = My.Settings.wsfont
        HTMLText.ForeColor = My.Settings.wsfontcolour
        CSSText.ForeColor = My.Settings.wsfontcolour

    End Sub
#End Region
#Region "HTML Conversion"
    Private Sub HTMLText_TextChanged(sender As Object, e As EventArgs) Handles HTMLText.TextChanged
        WebBrowser1.DocumentText = HTMLText.Text
    End Sub
#End Region
#Region "File"
    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        WebStudioWarning.CloseButton.Enabled = False
        Me.Close()
        WebStudioNew.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        WebStudioWarning.CloseButton.Enabled = False
        Me.Close()
        WebStudioNew.Show()
        WebStudioNew.OpenButton.PerformClick()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click

        If HTMLText.Text = "" And CSSText.Text = "" Then
            errordiag.Show()
            errordiag.Label1.Text = "You cannot save a blank document."
        Else
            If HTMLText.Visible = True Then
                Dim Save As New SaveFileDialog
                Save.Filter = "WSHD (Web Studio HTML Document) (*.wshd)|*.wshd|HTML (Hyper Text Markup Language) (*.html)|*.html"
                If Save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    HTMLText.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
                End If
            ElseIf CSSText.Visible = True Then
                Dim Save As New SaveFileDialog
                Save.Filter = "WSCD (Web Studio CSS Document) (*.wscd)|*.wscd|CSS (Cascading Style Sheet) (*.css)|*.css"
                If Save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    CSSText.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
                End If
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region
#Region "Insert"
#Region "HTML"
#Region "Basic HTML"
    Private Sub DocumentTypeDOCTYPEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentTypeDOCTYPEToolStripMenuItem.Click
        Clipboard.SetText("<!DOCTYPE sample>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineHTMLDocumenthtmlhtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineHTMLDocumenthtmlhtmlToolStripMenuItem.Click
        Clipboard.SetText("<html>" + vbNewLine + "</html>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineDocumentInformationheadheadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineDocumentInformationheadheadToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<head>" + vbNewLine + "</head>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineDocumentTitletitletitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineDocumentTitletitletitleToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<title>Sample</title>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineDocumentBodybodybodyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineDocumentBodybodybodyToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<body>" + vbNewLine + "</body>")
        HTMLText.Paste()
    End Sub

    Private Sub Heading1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Heading1ToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<h1>Sample</h1>")
        HTMLText.Paste()
    End Sub

    Private Sub Heading2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Heading2ToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<h2>Sample</h2>")
        HTMLText.Paste()
    End Sub

    Private Sub Heading3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Heading3ToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<h3>Sample</h3>")
        HTMLText.Paste()
    End Sub

    Private Sub Heading4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Heading4ToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<h4>Sample</h4>")
        HTMLText.Paste()
    End Sub

    Private Sub Heading5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Heading5ToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<h5>Sample</h5>")
        HTMLText.Paste()
    End Sub

    Private Sub Heading6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Heading6ToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<h6>Sample</h6>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineParagraphppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineParagraphppToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<p>Sample</p>")
        HTMLText.Paste()
    End Sub

    Private Sub InsertSingleLineBreakbrbrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertSingleLineBreakbrbrToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<br>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineThematicChangehrhrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineThematicChangehrhrToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<hr>")
        HTMLText.Paste()
    End Sub

    Private Sub DefineCommentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineCommentToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<!--Sample-->")
        HTMLText.Paste()
    End Sub
#End Region
#Region "Formatting"

#End Region
#End Region
#Region "CSS"
#End Region
#End Region
#Region "Edit Menu"
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        HTMLText.Undo()
        CSSText.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        HTMLText.Redo()
        CSSText.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        HTMLText.Cut()
        CSSText.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        HTMLText.Copy()
        CSSText.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        HTMLText.Paste()
        CSSText.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        HTMLText.SelectAll()
        CSSText.SelectAll()
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllToolStripMenuItem.Click
        HTMLText.Clear()
        CSSText.Clear()
    End Sub

    Private Sub WebStudioSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebStudioSettingsToolStripMenuItem.Click
        SettingsPanelWebStudio.Show()
    End Sub
#End Region
#Region "Help Menu"
    Private Sub HelpAndSupportCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpAndSupportCentreToolStripMenuItem.Click
        CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://docs.windowslogic.co.uk/vivian-studio.php")
        Dim res = TaskbarFlash.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 5)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.VerInfo.Text = "Web Studio " & Variables.ver
        About.Text = "About Web Studio"
        About.ShowDialog()
    End Sub
#End Region
#Region "Other"
    Private Sub HTMLStudio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If HTMLText.Text = "" And CSSText.Text = "" Then
            Me.Dispose()
        Else
            WebStudioWarning.ShowDialog()
            WebStudioWarning.CloseButton.Enabled = True
            e.Cancel = True
        End If

        If WebStudioWarning.SaveButton.Enabled = True Then
            e.Cancel = False
        End If

        If WebStudioWarning.SaveButton.Enabled = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DefinesAClientsideScriptscriptscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinesAClientsideScriptscriptscriptToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<script></script>")
        HTMLText.Paste()
    End Sub

    Private Sub DefinesAnAlternateContentForUsersThatDoNotSupportClientsideScriptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinesAnAlternateContentForUsersThatDoNotSupportClientsideScriptsToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<noscript></noscript>")
        HTMLText.Paste()
    End Sub

    Private Sub DefinesContainerForExternalNonHTMLApplicationembedembedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinesContainerForExternalNonHTMLApplicationembedembedToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<!DOCTYPE sample>")
        HTMLText.Paste()
    End Sub

    Private Sub DefinesEmbeddedObjectobjectobjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinesEmbeddedObjectobjectobjectToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<!DOCTYPE sample>")
        HTMLText.Paste()
    End Sub

    Private Sub DefinesParameterOfObjectparamparamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinesParameterOfObjectparamparamToolStripMenuItem.Click
        HTMLText.Select()
        Clipboard.SetText("<!DOCTYPE sample>")
        HTMLText.Paste()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RightClickMenu.Opening
    End Sub
#End Region
End Class