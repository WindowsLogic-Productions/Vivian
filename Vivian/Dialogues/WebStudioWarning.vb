Public Class WebStudioWarning
#Region "Load Settings"
    Private Sub WebStudioWarning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If

        SaveButton.Enabled = True

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If HTMLStudio.HTMLText.Visible = True Then
            Dim Save As New SaveFileDialog With {
                .Filter = "WSHD (Web Studio HTML Document) (*.wshd)|*.wshd|HTML (Hyper Text Markup Language) (*.html)|*.html"
            }
            If Save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                HTMLStudio.HTMLText.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
            End If
        ElseIf HTMLStudio.CSSText.Visible = True Then
            Dim Save As New SaveFileDialog With {
                .Filter = "WSCD (Web Studio CSS Document) (*.wscd)|*.wscd|CSS (Cascading Style Sheet) (*.css)|*.css"
            }
            If Save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                HTMLStudio.CSSText.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub DontSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DontSaveButton.Click
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        SaveButton.Enabled = False
        Me.Close()
    End Sub
#End Region
End Class