<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelWebStudio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelWebStudio))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WordWrapGroupBox = New System.Windows.Forms.GroupBox()
        Me.WordWrapBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WordWrapImage = New System.Windows.Forms.PictureBox()
        Me.StartupGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayStartBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartupImage = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FontButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ColourButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.WordWrapGroupBox.SuspendLayout()
        CType(Me.WordWrapImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StartupGroupBox.SuspendLayout()
        CType(Me.StartupImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WordWrapGroupBox)
        Me.TabPage1.Controls.Add(Me.StartupGroupBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WordWrapGroupBox
        '
        Me.WordWrapGroupBox.Controls.Add(Me.WordWrapBox)
        Me.WordWrapGroupBox.Controls.Add(Me.Label2)
        Me.WordWrapGroupBox.Controls.Add(Me.WordWrapImage)
        Me.WordWrapGroupBox.Location = New System.Drawing.Point(6, 79)
        Me.WordWrapGroupBox.Name = "WordWrapGroupBox"
        Me.WordWrapGroupBox.Size = New System.Drawing.Size(397, 67)
        Me.WordWrapGroupBox.TabIndex = 6
        Me.WordWrapGroupBox.TabStop = False
        Me.WordWrapGroupBox.Text = "Word Wrap"
        '
        'WordWrapBox
        '
        Me.WordWrapBox.AutoSize = True
        Me.WordWrapBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.WordWrapBox.Location = New System.Drawing.Point(47, 37)
        Me.WordWrapBox.Name = "WordWrapBox"
        Me.WordWrapBox.Size = New System.Drawing.Size(254, 18)
        Me.WordWrapBox.TabIndex = 5
        Me.WordWrapBox.Text = "Enable word wrap for HTML and CSS editor"
        Me.WordWrapBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Turn word wrapping on and off."
        '
        'WordWrapImage
        '
        Me.WordWrapImage.Image = Global.SPRINGBOARD.My.Resources.Resources.WordWrapIco
        Me.WordWrapImage.Location = New System.Drawing.Point(6, 21)
        Me.WordWrapImage.Name = "WordWrapImage"
        Me.WordWrapImage.Size = New System.Drawing.Size(32, 32)
        Me.WordWrapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WordWrapImage.TabIndex = 3
        Me.WordWrapImage.TabStop = False
        '
        'StartupGroupBox
        '
        Me.StartupGroupBox.Controls.Add(Me.DisplayStartBox)
        Me.StartupGroupBox.Controls.Add(Me.Label1)
        Me.StartupGroupBox.Controls.Add(Me.StartupImage)
        Me.StartupGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.StartupGroupBox.Name = "StartupGroupBox"
        Me.StartupGroupBox.Size = New System.Drawing.Size(397, 67)
        Me.StartupGroupBox.TabIndex = 3
        Me.StartupGroupBox.TabStop = False
        Me.StartupGroupBox.Text = "Start Dialogue"
        '
        'DisplayStartBox
        '
        Me.DisplayStartBox.AutoSize = True
        Me.DisplayStartBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DisplayStartBox.Location = New System.Drawing.Point(47, 37)
        Me.DisplayStartBox.Name = "DisplayStartBox"
        Me.DisplayStartBox.Size = New System.Drawing.Size(209, 18)
        Me.DisplayStartBox.TabIndex = 5
        Me.DisplayStartBox.Text = "Display Web Studio Start dialogue"
        Me.DisplayStartBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Configure the Web Studio start dialogue."
        '
        'StartupImage
        '
        Me.StartupImage.Image = Global.SPRINGBOARD.My.Resources.Resources.StartupIco
        Me.StartupImage.Location = New System.Drawing.Point(6, 21)
        Me.StartupImage.Name = "StartupImage"
        Me.StartupImage.Size = New System.Drawing.Size(32, 32)
        Me.StartupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StartupImage.TabIndex = 3
        Me.StartupImage.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Formatting"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextButton)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 79)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Text Colour"
        '
        'TextButton
        '
        Me.TextButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TextButton.Location = New System.Drawing.Point(295, 50)
        Me.TextButton.Name = "TextButton"
        Me.TextButton.Size = New System.Drawing.Size(96, 23)
        Me.TextButton.TabIndex = 3
        Me.TextButton.Text = "Select Colour..."
        Me.TextButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(347, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Set the colour of the text. This does not change the text colour for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "previewing." &
    ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SPRINGBOARD.My.Resources.Resources.TextColourIco
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FontButton)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font"
        '
        'FontButton
        '
        Me.FontButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FontButton.Location = New System.Drawing.Point(296, 53)
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(96, 23)
        Me.FontButton.TabIndex = 2
        Me.FontButton.Text = "Select Font..."
        Me.FontButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPRINGBOARD.My.Resources.Resources.FontIco
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Set the font you want to use for editing. This does not change the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "font for prev" &
    "iewing."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Editor"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ColourButton)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 60)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background Colour"
        '
        'ColourButton
        '
        Me.ColourButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ColourButton.Location = New System.Drawing.Point(290, 30)
        Me.ColourButton.Name = "ColourButton"
        Me.ColourButton.Size = New System.Drawing.Size(101, 23)
        Me.ColourButton.TabIndex = 5
        Me.ColourButton.Text = "Select Colour..."
        Me.ColourButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Set the background colour of the editor."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SPRINGBOARD.My.Resources.Resources.ColoursIco
        Me.PictureBox3.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 11
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.SPRINGBOARD.My.Resources.Resources.BackIco
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(368, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Set up your Web Studio environment..."
        '
        'SettingsPanelWebStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelWebStudio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Web Studio"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.WordWrapGroupBox.ResumeLayout(False)
        Me.WordWrapGroupBox.PerformLayout()
        CType(Me.WordWrapImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StartupGroupBox.ResumeLayout(False)
        Me.StartupGroupBox.PerformLayout()
        CType(Me.StartupImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents StartupGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StartupImage As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents DisplayStartBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents WordWrapGroupBox As GroupBox
    Friend WithEvents WordWrapBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WordWrapImage As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FontButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColourButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
