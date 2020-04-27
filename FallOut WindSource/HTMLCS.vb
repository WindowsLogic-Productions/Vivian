Public Class Form5

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown

        Dim seletionlength As Integer = RichTextBox1.SelectionLength
        Dim selectionstart As Integer = RichTextBox1.SelectionStart
        Dim letter As String = String.Empty
        Do Until letter = " " Or RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionStart -= 1
            RichTextBox1.SelectionLength += 1
            letter = RichTextBox1.Text.Substring(RichTextBox1.SelectionStart, 1)
        Loop

        If RichTextBox1.SelectedText = "<html>" Or RichTextBox1.SelectedText = " <html>" Then
            RichTextBox1.SelectionColor = Color.Purple
        ElseIf RichTextBox1.SelectedText = "</html>" Or RichTextBox1.SelectedText = " </html>" Then
            RichTextBox1.SelectionColor = Color.Purple
        ElseIf RichTextBox1.SelectedText = "<body>" Or RichTextBox1.SelectedText = " <body>" Then
            RichTextBox1.SelectionColor = Color.Green

        ElseIf RichTextBox1.SelectedText = "</body>" Or RichTextBox1.SelectedText = " </body>" Then
            RichTextBox1.SelectionColor = Color.Green
        ElseIf RichTextBox1.SelectedText = "<title>" Or RichTextBox1.SelectedText = " <title>" Then
            RichTextBox1.SelectionColor = Color.Red
        ElseIf RichTextBox1.SelectedText = "</title>" Or RichTextBox1.SelectedText = " </title>" Then
            RichTextBox1.SelectionColor = Color.Red
        ElseIf RichTextBox1.SelectedText = "<head>" Or RichTextBox1.SelectedText = " <head>" Then
            RichTextBox1.SelectionColor = Color.Orange
        ElseIf RichTextBox1.SelectedText = "</head>" Or RichTextBox1.SelectedText = " </head>" Then
            RichTextBox1.SelectionColor = Color.Orange
        ElseIf RichTextBox1.SelectedText = "<tagname>" Or RichTextBox1.SelectedText = " <tagname>" Then
            RichTextBox1.SelectionColor = Color.DarkCyan
        ElseIf RichTextBox1.SelectedText = "</tagname>" Then
            RichTextBox1.SelectionColor = Color.DarkCyan
        End If

        RichTextBox1.SelectionStart = selectionstart
        RichTextBox1.SelectionLength = 1
        RichTextBox1.SelectionColor = Color.Black

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Dim newform As New Form5
        newform.Show()
    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "HWS Files (*.hws*)|*.hws"
        If Open.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(Open.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim Save As New SaveFileDialog
        Save.Filter = "HWS Files (*.hws*)|*.hws"
        If Save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        MsgBox("Please note that this does not change the font of the text when previewing.", MsgBoxStyle.Information, "Information")
        Try
            Dim Font As FontDialog = New FontDialog
            Font.Font = RichTextBox1.Font
            If Font.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = Font.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        MsgBox("Please note that this does not change the colour of the text when previewing.", MsgBoxStyle.Information, "Information")
        Try
            Dim Colour As ColorDialog = New ColorDialog
            Colour.Color = RichTextBox1.ForeColor
            If Colour.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = Colour.Color
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
End Class