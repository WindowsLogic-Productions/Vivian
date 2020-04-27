<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPanelGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelGeneral))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PrivateBrowsingGroupBox = New System.Windows.Forms.GroupBox()
        Me.PrivateBrowsingImage = New System.Windows.Forms.PictureBox()
        Me.PrivateBrowsingLabel = New System.Windows.Forms.Label()
        Me.PrivateBrowsingSwitchOFF = New System.Windows.Forms.RadioButton()
        Me.PrivateBrowsingSwitchON = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.DuckDuckGoSwitch = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchImage = New System.Windows.Forms.PictureBox()
        Me.YahooSwitch = New System.Windows.Forms.RadioButton()
        Me.BingSwitch = New System.Windows.Forms.RadioButton()
        Me.GoogleSwitch = New System.Windows.Forms.RadioButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StartupGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartupImage = New System.Windows.Forms.PictureBox()
        Me.HomepageSwitch = New System.Windows.Forms.RadioButton()
        Me.SettingsSwitch = New System.Windows.Forms.RadioButton()
        Me.BlankPageSwitch = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DelSaveButton = New System.Windows.Forms.Button()
        Me.DelTempButton = New System.Windows.Forms.Button()
        Me.DelCookieButton = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HomeButtonCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomepageTextBox = New System.Windows.Forms.TextBox()
        Me.StopButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.StopButtonCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PrivateBrowsingGroupBox.SuspendLayout()
        CType(Me.PrivateBrowsingImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SearchGroupBox.SuspendLayout()
        CType(Me.SearchImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.StartupGroupBox.SuspendLayout()
        CType(Me.StartupImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StopButtonGroupBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.SPRINGBOARD.My.Resources.Resources.BackIco
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(252, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change general settings..."
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
        Me.Panel1.TabIndex = 9
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PrivateBrowsingGroupBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Browsing"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PrivateBrowsingGroupBox
        '
        Me.PrivateBrowsingGroupBox.Controls.Add(Me.PrivateBrowsingImage)
        Me.PrivateBrowsingGroupBox.Controls.Add(Me.PrivateBrowsingLabel)
        Me.PrivateBrowsingGroupBox.Controls.Add(Me.PrivateBrowsingSwitchOFF)
        Me.PrivateBrowsingGroupBox.Controls.Add(Me.PrivateBrowsingSwitchON)
        Me.PrivateBrowsingGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.PrivateBrowsingGroupBox.Name = "PrivateBrowsingGroupBox"
        Me.PrivateBrowsingGroupBox.Size = New System.Drawing.Size(397, 85)
        Me.PrivateBrowsingGroupBox.TabIndex = 4
        Me.PrivateBrowsingGroupBox.TabStop = False
        Me.PrivateBrowsingGroupBox.Text = "Private Browsing"
        '
        'PrivateBrowsingImage
        '
        Me.PrivateBrowsingImage.Image = Global.SPRINGBOARD.My.Resources.Resources.DisallowIco
        Me.PrivateBrowsingImage.Location = New System.Drawing.Point(6, 21)
        Me.PrivateBrowsingImage.Name = "PrivateBrowsingImage"
        Me.PrivateBrowsingImage.Size = New System.Drawing.Size(32, 32)
        Me.PrivateBrowsingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PrivateBrowsingImage.TabIndex = 8
        Me.PrivateBrowsingImage.TabStop = False
        '
        'PrivateBrowsingLabel
        '
        Me.PrivateBrowsingLabel.AutoSize = True
        Me.PrivateBrowsingLabel.Location = New System.Drawing.Point(44, 21)
        Me.PrivateBrowsingLabel.Name = "PrivateBrowsingLabel"
        Me.PrivateBrowsingLabel.Size = New System.Drawing.Size(352, 39)
        Me.PrivateBrowsingLabel.TabIndex = 7
        Me.PrivateBrowsingLabel.Text = "If Private Browsing is enabled, your search history will not be saved" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "but your s" &
    "earch results will still be monitored or stored by your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Internet Service Provid" &
    "er."
        '
        'PrivateBrowsingSwitchOFF
        '
        Me.PrivateBrowsingSwitchOFF.AutoSize = True
        Me.PrivateBrowsingSwitchOFF.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PrivateBrowsingSwitchOFF.Location = New System.Drawing.Point(119, 63)
        Me.PrivateBrowsingSwitchOFF.Name = "PrivateBrowsingSwitchOFF"
        Me.PrivateBrowsingSwitchOFF.Size = New System.Drawing.Size(69, 18)
        Me.PrivateBrowsingSwitchOFF.TabIndex = 7
        Me.PrivateBrowsingSwitchOFF.Text = "Disable"
        Me.PrivateBrowsingSwitchOFF.UseVisualStyleBackColor = True
        '
        'PrivateBrowsingSwitchON
        '
        Me.PrivateBrowsingSwitchON.AutoSize = True
        Me.PrivateBrowsingSwitchON.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PrivateBrowsingSwitchON.Location = New System.Drawing.Point(47, 63)
        Me.PrivateBrowsingSwitchON.Name = "PrivateBrowsingSwitchON"
        Me.PrivateBrowsingSwitchON.Size = New System.Drawing.Size(66, 18)
        Me.PrivateBrowsingSwitchON.TabIndex = 6
        Me.PrivateBrowsingSwitchON.Text = "Enable"
        Me.PrivateBrowsingSwitchON.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SearchGroupBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.DuckDuckGoSwitch)
        Me.SearchGroupBox.Controls.Add(Me.Label3)
        Me.SearchGroupBox.Controls.Add(Me.SearchImage)
        Me.SearchGroupBox.Controls.Add(Me.YahooSwitch)
        Me.SearchGroupBox.Controls.Add(Me.BingSwitch)
        Me.SearchGroupBox.Controls.Add(Me.GoogleSwitch)
        Me.SearchGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Size = New System.Drawing.Size(397, 66)
        Me.SearchGroupBox.TabIndex = 2
        Me.SearchGroupBox.TabStop = False
        Me.SearchGroupBox.Text = "Search Settings"
        '
        'DuckDuckGoSwitch
        '
        Me.DuckDuckGoSwitch.AutoSize = True
        Me.DuckDuckGoSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DuckDuckGoSwitch.Location = New System.Drawing.Point(248, 37)
        Me.DuckDuckGoSwitch.Name = "DuckDuckGoSwitch"
        Me.DuckDuckGoSwitch.Size = New System.Drawing.Size(98, 18)
        Me.DuckDuckGoSwitch.TabIndex = 6
        Me.DuckDuckGoSwitch.TabStop = True
        Me.DuckDuckGoSwitch.Text = "DuckDuckGo"
        Me.DuckDuckGoSwitch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Set your provider for the search fields on the main window."
        '
        'SearchImage
        '
        Me.SearchImage.Image = Global.SPRINGBOARD.My.Resources.Resources.SearchIco
        Me.SearchImage.Location = New System.Drawing.Point(6, 21)
        Me.SearchImage.Name = "SearchImage"
        Me.SearchImage.Size = New System.Drawing.Size(32, 32)
        Me.SearchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SearchImage.TabIndex = 3
        Me.SearchImage.TabStop = False
        '
        'YahooSwitch
        '
        Me.YahooSwitch.AutoSize = True
        Me.YahooSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.YahooSwitch.Location = New System.Drawing.Point(180, 37)
        Me.YahooSwitch.Name = "YahooSwitch"
        Me.YahooSwitch.Size = New System.Drawing.Size(62, 18)
        Me.YahooSwitch.TabIndex = 5
        Me.YahooSwitch.TabStop = True
        Me.YahooSwitch.Text = "Yahoo"
        Me.YahooSwitch.UseVisualStyleBackColor = True
        '
        'BingSwitch
        '
        Me.BingSwitch.AutoSize = True
        Me.BingSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BingSwitch.Location = New System.Drawing.Point(119, 37)
        Me.BingSwitch.Name = "BingSwitch"
        Me.BingSwitch.Size = New System.Drawing.Size(55, 18)
        Me.BingSwitch.TabIndex = 4
        Me.BingSwitch.TabStop = True
        Me.BingSwitch.Text = "Bing"
        Me.BingSwitch.UseVisualStyleBackColor = True
        '
        'GoogleSwitch
        '
        Me.GoogleSwitch.AutoSize = True
        Me.GoogleSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GoogleSwitch.Location = New System.Drawing.Point(44, 37)
        Me.GoogleSwitch.Name = "GoogleSwitch"
        Me.GoogleSwitch.Size = New System.Drawing.Size(69, 18)
        Me.GoogleSwitch.TabIndex = 3
        Me.GoogleSwitch.TabStop = True
        Me.GoogleSwitch.Text = "Google"
        Me.GoogleSwitch.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.StartupGroupBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Start-up"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'StartupGroupBox
        '
        Me.StartupGroupBox.Controls.Add(Me.Label1)
        Me.StartupGroupBox.Controls.Add(Me.StartupImage)
        Me.StartupGroupBox.Controls.Add(Me.HomepageSwitch)
        Me.StartupGroupBox.Controls.Add(Me.SettingsSwitch)
        Me.StartupGroupBox.Controls.Add(Me.BlankPageSwitch)
        Me.StartupGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.StartupGroupBox.Name = "StartupGroupBox"
        Me.StartupGroupBox.Size = New System.Drawing.Size(397, 67)
        Me.StartupGroupBox.TabIndex = 3
        Me.StartupGroupBox.TabStop = False
        Me.StartupGroupBox.Text = "Start-up Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Set how you want Vivian to start."
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
        'HomepageSwitch
        '
        Me.HomepageSwitch.AutoSize = True
        Me.HomepageSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HomepageSwitch.Location = New System.Drawing.Point(249, 37)
        Me.HomepageSwitch.Name = "HomepageSwitch"
        Me.HomepageSwitch.Size = New System.Drawing.Size(87, 18)
        Me.HomepageSwitch.TabIndex = 2
        Me.HomepageSwitch.TabStop = True
        Me.HomepageSwitch.Text = "Homepage"
        Me.HomepageSwitch.UseVisualStyleBackColor = True
        '
        'SettingsSwitch
        '
        Me.SettingsSwitch.AutoSize = True
        Me.SettingsSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SettingsSwitch.Location = New System.Drawing.Point(139, 37)
        Me.SettingsSwitch.Name = "SettingsSwitch"
        Me.SettingsSwitch.Size = New System.Drawing.Size(104, 18)
        Me.SettingsSwitch.TabIndex = 1
        Me.SettingsSwitch.TabStop = True
        Me.SettingsSwitch.Text = "Settings Panel"
        Me.SettingsSwitch.UseVisualStyleBackColor = True
        '
        'BlankPageSwitch
        '
        Me.BlankPageSwitch.AutoSize = True
        Me.BlankPageSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BlankPageSwitch.Location = New System.Drawing.Point(44, 37)
        Me.BlankPageSwitch.Name = "BlankPageSwitch"
        Me.BlankPageSwitch.Size = New System.Drawing.Size(87, 18)
        Me.BlankPageSwitch.TabIndex = 0
        Me.BlankPageSwitch.TabStop = True
        Me.BlankPageSwitch.Text = "Quick Start"
        Me.BlankPageSwitch.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(409, 179)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Content"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DelSaveButton)
        Me.GroupBox3.Controls.Add(Me.DelTempButton)
        Me.GroupBox3.Controls.Add(Me.DelCookieButton)
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 167)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Content Settings"
        '
        'DelSaveButton
        '
        Me.DelSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DelSaveButton.Location = New System.Drawing.Point(110, 126)
        Me.DelSaveButton.Name = "DelSaveButton"
        Me.DelSaveButton.Size = New System.Drawing.Size(176, 23)
        Me.DelSaveButton.TabIndex = 11
        Me.DelSaveButton.Text = "Delete Save Data"
        Me.DelSaveButton.UseVisualStyleBackColor = True
        '
        'DelTempButton
        '
        Me.DelTempButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DelTempButton.Location = New System.Drawing.Point(110, 97)
        Me.DelTempButton.Name = "DelTempButton"
        Me.DelTempButton.Size = New System.Drawing.Size(176, 23)
        Me.DelTempButton.TabIndex = 10
        Me.DelTempButton.Text = "Delete Temporary Internet Files"
        Me.DelTempButton.UseVisualStyleBackColor = True
        '
        'DelCookieButton
        '
        Me.DelCookieButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DelCookieButton.Location = New System.Drawing.Point(110, 68)
        Me.DelCookieButton.Name = "DelCookieButton"
        Me.DelCookieButton.Size = New System.Drawing.Size(176, 23)
        Me.DelCookieButton.TabIndex = 9
        Me.DelCookieButton.Text = "Delete Cookies"
        Me.DelCookieButton.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SPRINGBOARD.My.Resources.Resources.WebStudioIco
        Me.PictureBox4.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(307, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "If the browser is running slow or websites are not loading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "properly, you can del" &
    "ete your data here."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.StopButtonGroupBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(409, 179)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HomeButtonCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.HomepageTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 88)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Home Button"
        '
        'HomeButtonCheckBox
        '
        Me.HomeButtonCheckBox.AutoSize = True
        Me.HomeButtonCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HomeButtonCheckBox.Location = New System.Drawing.Point(44, 62)
        Me.HomeButtonCheckBox.Name = "HomeButtonCheckBox"
        Me.HomeButtonCheckBox.Size = New System.Drawing.Size(139, 18)
        Me.HomeButtonCheckBox.TabIndex = 13
        Me.HomeButtonCheckBox.Text = "Enable Home Button"
        Me.HomeButtonCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 39)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "With modern Internet browsers, the Home button is hidden by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default since most b" &
    "rowsers now have start pages. You can" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "re-enable the Home button and set your ho" &
    "mepage here."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPRINGBOARD.My.Resources.Resources.HomeIco
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'HomepageTextBox
        '
        Me.HomepageTextBox.Enabled = False
        Me.HomepageTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomepageTextBox.Location = New System.Drawing.Point(183, 60)
        Me.HomepageTextBox.Name = "HomepageTextBox"
        Me.HomepageTextBox.Size = New System.Drawing.Size(208, 22)
        Me.HomepageTextBox.TabIndex = 14
        '
        'StopButtonGroupBox
        '
        Me.StopButtonGroupBox.Controls.Add(Me.StopButtonCheckBox)
        Me.StopButtonGroupBox.Controls.Add(Me.Label5)
        Me.StopButtonGroupBox.Controls.Add(Me.PictureBox2)
        Me.StopButtonGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.StopButtonGroupBox.Name = "StopButtonGroupBox"
        Me.StopButtonGroupBox.Size = New System.Drawing.Size(397, 73)
        Me.StopButtonGroupBox.TabIndex = 3
        Me.StopButtonGroupBox.TabStop = False
        Me.StopButtonGroupBox.Text = "Stop Button"
        '
        'StopButtonCheckBox
        '
        Me.StopButtonCheckBox.AutoSize = True
        Me.StopButtonCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StopButtonCheckBox.Location = New System.Drawing.Point(44, 50)
        Me.StopButtonCheckBox.Name = "StopButtonCheckBox"
        Me.StopButtonCheckBox.Size = New System.Drawing.Size(133, 18)
        Me.StopButtonCheckBox.TabIndex = 12
        Me.StopButtonCheckBox.Text = "Enable Stop Button"
        Me.StopButtonCheckBox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "If you're on a slower network, it may be worth showing the stop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "button so you ca" &
    "n stop a slow loading page to refresh it."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SPRINGBOARD.My.Resources.Resources.StopIco
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'SettingsPanelGeneral
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
        Me.Name = "SettingsPanelGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > General"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.PrivateBrowsingGroupBox.ResumeLayout(False)
        Me.PrivateBrowsingGroupBox.PerformLayout()
        CType(Me.PrivateBrowsingImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        CType(Me.SearchImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.StartupGroupBox.ResumeLayout(False)
        Me.StartupGroupBox.PerformLayout()
        CType(Me.StartupImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StopButtonGroupBox.ResumeLayout(False)
        Me.StopButtonGroupBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PrivateBrowsingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PrivateBrowsingImage As System.Windows.Forms.PictureBox
    Friend WithEvents PrivateBrowsingLabel As System.Windows.Forms.Label
    Friend WithEvents PrivateBrowsingSwitchOFF As System.Windows.Forms.RadioButton
    Friend WithEvents PrivateBrowsingSwitchON As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SearchGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchImage As System.Windows.Forms.PictureBox
    Friend WithEvents YahooSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents BingSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents GoogleSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents StartupGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartupImage As System.Windows.Forms.PictureBox
    Friend WithEvents HomepageSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents SettingsSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents BlankPageSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DuckDuckGoSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HomeButtonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HomepageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StopButtonGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents StopButtonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DelSaveButton As Button
    Friend WithEvents DelTempButton As Button
    Friend WithEvents DelCookieButton As Button
End Class
