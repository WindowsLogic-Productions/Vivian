<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPanelPersonalise
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelPersonalise))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.HubBackgroundBox = New System.Windows.Forms.GroupBox()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.HUCSwitch = New System.Windows.Forms.RadioButton()
        Me.HDBSwitch = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB1Button = New System.Windows.Forms.Button()
        Me.HubBackgroundPicture = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CustomColourBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CustomColourLabel = New System.Windows.Forms.Label()
        Me.CustomColourButton = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SoundBox = New System.Windows.Forms.GroupBox()
        Me.SoundsSwitchOFF = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SoundsSwitchON = New System.Windows.Forms.RadioButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.HubBackgroundBox.SuspendLayout()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.CustomColourBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SoundBox.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 53)
        Me.Panel1.TabIndex = 6
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.SPRINGBOARD.My.Resources.Resources.BackIco
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(283, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Personalise your experience..."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(536, 204)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.HubBackgroundBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(528, 178)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Backgrounds"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HubBackgroundBox
        '
        Me.HubBackgroundBox.Controls.Add(Me.RB1)
        Me.HubBackgroundBox.Controls.Add(Me.HUCSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.HDBSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.Label1)
        Me.HubBackgroundBox.Controls.Add(Me.CB1Button)
        Me.HubBackgroundBox.Controls.Add(Me.HubBackgroundPicture)
        Me.HubBackgroundBox.Location = New System.Drawing.Point(9, 8)
        Me.HubBackgroundBox.Name = "HubBackgroundBox"
        Me.HubBackgroundBox.Size = New System.Drawing.Size(510, 151)
        Me.HubBackgroundBox.TabIndex = 4
        Me.HubBackgroundBox.TabStop = False
        Me.HubBackgroundBox.Text = "Vivian Background"
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RB1.Location = New System.Drawing.Point(220, 125)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(136, 18)
        Me.RB1.TabIndex = 24
        Me.RB1.TabStop = True
        Me.RB1.Text = "Custom background"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'HUCSwitch
        '
        Me.HUCSwitch.AutoSize = True
        Me.HUCSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HUCSwitch.Location = New System.Drawing.Point(220, 102)
        Me.HUCSwitch.Name = "HUCSwitch"
        Me.HUCSwitch.Size = New System.Drawing.Size(90, 18)
        Me.HUCSwitch.TabIndex = 23
        Me.HUCSwitch.TabStop = True
        Me.HUCSwitch.Text = "User colour"
        Me.HUCSwitch.UseVisualStyleBackColor = True
        '
        'HDBSwitch
        '
        Me.HDBSwitch.AutoSize = True
        Me.HDBSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HDBSwitch.Location = New System.Drawing.Point(220, 79)
        Me.HDBSwitch.Name = "HDBSwitch"
        Me.HDBSwitch.Size = New System.Drawing.Size(135, 18)
        Me.HDBSwitch.TabIndex = 22
        Me.HDBSwitch.TabStop = True
        Me.HDBSwitch.Text = "Default background"
        Me.HDBSwitch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 52)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Enabling the background will disable the default" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "background or colour. When pick" &
    "ing a background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make sure you have set up a dedicated folder that " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vivian can" &
    " read the file from."
        '
        'CB1Button
        '
        Me.CB1Button.BackColor = System.Drawing.Color.MidnightBlue
        Me.CB1Button.Enabled = False
        Me.CB1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB1Button.ForeColor = System.Drawing.Color.White
        Me.CB1Button.Location = New System.Drawing.Point(440, 122)
        Me.CB1Button.Name = "CB1Button"
        Me.CB1Button.Size = New System.Drawing.Size(64, 23)
        Me.CB1Button.TabIndex = 20
        Me.CB1Button.Text = "Browse..."
        Me.CB1Button.UseVisualStyleBackColor = False
        '
        'HubBackgroundPicture
        '
        Me.HubBackgroundPicture.Location = New System.Drawing.Point(6, 21)
        Me.HubBackgroundPicture.Name = "HubBackgroundPicture"
        Me.HubBackgroundPicture.Size = New System.Drawing.Size(208, 125)
        Me.HubBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HubBackgroundPicture.TabIndex = 2
        Me.HubBackgroundPicture.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CustomColourBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(528, 178)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colours"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CustomColourBox
        '
        Me.CustomColourBox.Controls.Add(Me.PictureBox2)
        Me.CustomColourBox.Controls.Add(Me.CheckBox1)
        Me.CustomColourBox.Controls.Add(Me.CustomColourLabel)
        Me.CustomColourBox.Controls.Add(Me.CustomColourButton)
        Me.CustomColourBox.Location = New System.Drawing.Point(6, 6)
        Me.CustomColourBox.Name = "CustomColourBox"
        Me.CustomColourBox.Size = New System.Drawing.Size(516, 57)
        Me.CustomColourBox.TabIndex = 7
        Me.CustomColourBox.TabStop = False
        Me.CustomColourBox.Text = "Background Colour"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SPRINGBOARD.My.Resources.Resources.ColoursIco
        Me.PictureBox2.Location = New System.Drawing.Point(6, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(44, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(142, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Enable custom colours"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'CustomColourLabel
        '
        Me.CustomColourLabel.AutoSize = True
        Me.CustomColourLabel.Location = New System.Drawing.Point(41, 18)
        Me.CustomColourLabel.Name = "CustomColourLabel"
        Me.CustomColourLabel.Size = New System.Drawing.Size(230, 13)
        Me.CustomColourLabel.TabIndex = 7
        Me.CustomColourLabel.Text = "Set your own colour by clicking the button."
        '
        'CustomColourButton
        '
        Me.CustomColourButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.CustomColourButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomColourButton.ForeColor = System.Drawing.Color.White
        Me.CustomColourButton.Location = New System.Drawing.Point(352, 18)
        Me.CustomColourButton.Name = "CustomColourButton"
        Me.CustomColourButton.Size = New System.Drawing.Size(158, 32)
        Me.CustomColourButton.TabIndex = 6
        Me.CustomColourButton.Text = "Select your colour..."
        Me.CustomColourButton.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SoundBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(528, 178)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sounds"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SoundBox
        '
        Me.SoundBox.Controls.Add(Me.SoundsSwitchOFF)
        Me.SoundBox.Controls.Add(Me.Label2)
        Me.SoundBox.Controls.Add(Me.SoundsSwitchON)
        Me.SoundBox.Controls.Add(Me.PictureBox7)
        Me.SoundBox.Location = New System.Drawing.Point(6, 6)
        Me.SoundBox.Name = "SoundBox"
        Me.SoundBox.Size = New System.Drawing.Size(516, 61)
        Me.SoundBox.TabIndex = 4
        Me.SoundBox.TabStop = False
        Me.SoundBox.Text = "Sounds"
        '
        'SoundsSwitchOFF
        '
        Me.SoundsSwitchOFF.AutoSize = True
        Me.SoundsSwitchOFF.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SoundsSwitchOFF.Location = New System.Drawing.Point(116, 35)
        Me.SoundsSwitchOFF.Name = "SoundsSwitchOFF"
        Me.SoundsSwitchOFF.Size = New System.Drawing.Size(69, 18)
        Me.SoundsSwitchOFF.TabIndex = 6
        Me.SoundsSwitchOFF.TabStop = True
        Me.SoundsSwitchOFF.Text = "Disable"
        Me.SoundsSwitchOFF.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Below you can turn the sounds on or off."
        '
        'SoundsSwitchON
        '
        Me.SoundsSwitchON.AutoSize = True
        Me.SoundsSwitchON.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SoundsSwitchON.Location = New System.Drawing.Point(44, 35)
        Me.SoundsSwitchON.Name = "SoundsSwitchON"
        Me.SoundsSwitchON.Size = New System.Drawing.Size(66, 18)
        Me.SoundsSwitchON.TabIndex = 5
        Me.SoundsSwitchON.TabStop = True
        Me.SoundsSwitchON.Text = "Enable"
        Me.SoundsSwitchON.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.SPRINGBOARD.My.Resources.Resources.MusicIco
        Me.PictureBox7.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SettingsPanelPersonalise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(560, 275)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelPersonalise"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Personalise"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.HubBackgroundBox.ResumeLayout(False)
        Me.HubBackgroundBox.PerformLayout()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.CustomColourBox.ResumeLayout(False)
        Me.CustomColourBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SoundBox.ResumeLayout(False)
        Me.SoundBox.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CustomColourBox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CustomColourLabel As System.Windows.Forms.Label
    Friend WithEvents CustomColourButton As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SoundBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents SoundsSwitchOFF As System.Windows.Forms.RadioButton
    Friend WithEvents SoundsSwitchON As System.Windows.Forms.RadioButton
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog2 As System.Windows.Forms.ColorDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents HubBackgroundBox As System.Windows.Forms.GroupBox
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents HUCSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents HDBSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB1Button As System.Windows.Forms.Button
    Friend WithEvents HubBackgroundPicture As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
