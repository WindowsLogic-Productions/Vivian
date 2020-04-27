Public Class Preferences

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load search provider settings
        If My.Settings.Search = 1 Then
            RadioButton1.Checked = True
        End If

        If My.Settings.Search = 2 Then
            RadioButton2.Checked = True
        End If

        If My.Settings.Search = 3 Then
            RadioButton3.Checked = True
        End If

        'Load Homepage settings
        My.Settings.Homepage = TextBox1.Text

        'Load private browsing settings
        If My.Settings.PrivateBrowsing = "ON" Then
            RadioButton4.Checked = True
        End If

        If My.Settings.PrivateBrowsing = "OFF" Then
            RadioButton5.Checked = True
        End If

        'Load personalisation settings.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Save homepage settings.
        If TextBox1.Text = Text Then
            My.Settings.Homepage = TextBox1.Text
        End If

        'Save personalisation settings.
        If CheckBox11.Checked = True Then
            My.Settings.Colour = 0
            Browser.BackColor = Color.Honeydew
        End If

        If CheckBox1.Checked = True Then
            My.Settings.Colour = 1
            Browser.BackColor = Color.LightBlue
        End If

        If CheckBox2.Checked = True Then
            My.Settings.Colour = 2
            Browser.BackColor = Color.Lavender
        End If

        If CheckBox3.Checked = True Then
            My.Settings.Colour = 3
            Browser.BackColor = Color.LightPink()
        End If

        If CheckBox4.Checked = True Then
            My.Settings.Colour = 4
            Browser.BackColor = Color.OrangeRed
        End If

        If CheckBox5.Checked = True Then
            My.Settings.Colour = 5
            Browser.BackColor = Color.Coral
        End If

        If CheckBox6.Checked = True Then
            My.Settings.Colour = 6
            Browser.BackColor = Color.Orange
        End If

        If CheckBox7.Checked = True Then
            My.Settings.Colour = 7
            Browser.BackColor = Color.Goldenrod
        End If

        If CheckBox8.Checked = True Then
            My.Settings.Colour = 8
            Browser.BackColor = Color.YellowGreen
        End If

        If CheckBox9.Checked = True Then
            My.Settings.Colour = 9
            Browser.BackColor = Color.Aquamarine
        End If

        If CheckBox10.Checked = True Then
            My.Settings.Colour = 10
            Browser.BackColor = Color.LightGreen
        End If

        My.Settings.Save()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Favourites.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        History.Show()
    End Sub


    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Settings.Homepage = TextBox1.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.Search = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.Search = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.Search = 3
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Dim colourpicker As New ColorDialog()

        colourpicker.AllowFullOpen = True
        colourpicker.FullOpen = True
        colourpicker.AnyColor = True


    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            My.Settings.PrivateBrowsing = "ON"
        End If
        My.Settings.Save()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            My.Settings.PrivateBrowsing = "OFF"
        End If
        My.Settings.Save()
    End Sub
End Class