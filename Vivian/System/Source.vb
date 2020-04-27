Imports System.Drawing.Text

Public Class Source
#Region "Load Settings"
    Private Sub Source_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If

        If RichTextBox1.Text = "<HTML></HTML>" Then
            errordiag.Label1.Text = "Source code is not available on this page."
            errordiag.ShowDialog()
            Me.Dispose()
        End If
        Me.Text = "Website Source - " & "(" & CType(Browser.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString() & ")"
    End Sub
#End Region
#Region "Menu"
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim Save As New SaveFileDialog
        Save.Filter = "TXT (Text Document) (*.txt)|*.txt|HTML (Hyper Text Markup Language) (*.html)|*.html"
        If Save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked = True Then
            RichTextBox1.WordWrap = Enabled = True
        Else
            RichTextBox1.WordWrap = Enabled = False
        End If

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim Font As FontDialog = New FontDialog
            Font.Font = RichTextBox1.Font
            If Font.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = Font.Font
                My.Settings.wsfont = Font.Font
                My.Settings.Save()
            End If
        Catch ex As Exception : End Try
    End Sub
#End Region
#Region "Functions"
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Segoe UI", 8, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, 100, 100)
    End Sub
#End Region
End Class