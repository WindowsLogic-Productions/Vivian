<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ZoomLabel = New System.Windows.Forms.Label()
        Me.ExitQuickStartButton = New System.Windows.Forms.Button()
        Me.CloseTabButton = New System.Windows.Forms.Button()
        Me.NewTabButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.FavouriteButton = New System.Windows.Forms.Button()
        Me.SSLButton = New System.Windows.Forms.Button()
        Me.ZoomOutButton = New System.Windows.Forms.Button()
        Me.ZoomInButton = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewTabToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuickStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SendFeedbackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutLogiverseNavigator80ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.RightClickTabMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewTab_RCTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTab_RCTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Duplicate_RCTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Reopen_RCTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickStartPanel = New System.Windows.Forms.Panel()
        Me.QuickStartBottomPanel = New System.Windows.Forms.Panel()
        Me.DonateQuickStartButton = New System.Windows.Forms.Button()
        Me.QuickStartCopyrightLabel = New System.Windows.Forms.Label()
        Me.SettingsQuickStartButton = New System.Windows.Forms.Button()
        Me.HistoryQuickStartButton = New System.Windows.Forms.Button()
        Me.FavouritesQuickStartButton = New System.Windows.Forms.Button()
        Me.LogoImage = New System.Windows.Forms.PictureBox()
        Me.Watermark3 = New SPRINGBOARD.Watermark()
        Me.SearchBarRightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cut_SCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy_SCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste_SCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteGo_SCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAll_SCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickStartTopPanel = New System.Windows.Forms.Panel()
        Me.HelpQuickStartButton = New System.Windows.Forms.Button()
        Me.FeedbackQuickStartButton = New System.Windows.Forms.Button()
        Me.QuickStartTitleLabel = New System.Windows.Forms.Label()
        Me.QuickStartBackground = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.StatusPanel = New System.Windows.Forms.Panel()
        Me.StatusText = New System.Windows.Forms.Label()
        Me.BrowserRightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenLink_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLinkWindow_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenDefaultBrowser_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveLink_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Favourite_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyLink_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.Copy_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchFor_RCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressBarRightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cut_ACM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy_ACM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste_ACM = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteGo_ACM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAll_ACM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HubBackground = New System.Windows.Forms.PictureBox()
        Me.NavClusterBackPanel = New System.Windows.Forms.Panel()
        Me.Watermark2 = New SPRINGBOARD.Watermark()
        Me.Watermark1 = New SPRINGBOARD.Watermark()
        Me.MainMenu.SuspendLayout()
        Me.RightClickTabMenu.SuspendLayout()
        Me.QuickStartPanel.SuspendLayout()
        Me.QuickStartBottomPanel.SuspendLayout()
        CType(Me.LogoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchBarRightClickMenu.SuspendLayout()
        Me.QuickStartTopPanel.SuspendLayout()
        CType(Me.QuickStartBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusPanel.SuspendLayout()
        Me.BrowserRightClickMenu.SuspendLayout()
        Me.AddressBarRightClickMenu.SuspendLayout()
        CType(Me.HubBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavClusterBackPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ZoomLabel
        '
        Me.ZoomLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomLabel.AutoSize = True
        Me.ZoomLabel.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoomLabel.Location = New System.Drawing.Point(973, 1)
        Me.ZoomLabel.Name = "ZoomLabel"
        Me.ZoomLabel.Size = New System.Drawing.Size(24, 11)
        Me.ZoomLabel.TabIndex = 3
        Me.ZoomLabel.Text = "100%"
        Me.ToolTip1.SetToolTip(Me.ZoomLabel, "Reset Zoom")
        '
        'ExitQuickStartButton
        '
        Me.ExitQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitQuickStartButton.FlatAppearance.BorderSize = 0
        Me.ExitQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitQuickStartButton.ForeColor = System.Drawing.Color.White
        Me.ExitQuickStartButton.Image = Global.SPRINGBOARD.My.Resources.Resources.BackIco
        Me.ExitQuickStartButton.Location = New System.Drawing.Point(12, 9)
        Me.ExitQuickStartButton.Name = "ExitQuickStartButton"
        Me.ExitQuickStartButton.Size = New System.Drawing.Size(36, 36)
        Me.ExitQuickStartButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ExitQuickStartButton, "Exit Quick Start.")
        Me.ExitQuickStartButton.UseVisualStyleBackColor = False
        '
        'CloseTabButton
        '
        Me.CloseTabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseTabButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseTabButton.FlatAppearance.BorderSize = 0
        Me.CloseTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CloseTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.CloseTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseTabButton.ForeColor = System.Drawing.Color.White
        Me.CloseTabButton.Image = Global.SPRINGBOARD.My.Resources.Resources.CloseTabIco
        Me.CloseTabButton.Location = New System.Drawing.Point(910, 0)
        Me.CloseTabButton.Name = "CloseTabButton"
        Me.CloseTabButton.Size = New System.Drawing.Size(36, 36)
        Me.CloseTabButton.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.CloseTabButton, "Close Tab")
        Me.CloseTabButton.UseVisualStyleBackColor = False
        '
        'NewTabButton
        '
        Me.NewTabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewTabButton.BackColor = System.Drawing.Color.Transparent
        Me.NewTabButton.FlatAppearance.BorderSize = 0
        Me.NewTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.NewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewTabButton.ForeColor = System.Drawing.Color.White
        Me.NewTabButton.Image = Global.SPRINGBOARD.My.Resources.Resources.NewTabIco
        Me.NewTabButton.Location = New System.Drawing.Point(946, 0)
        Me.NewTabButton.Name = "NewTabButton"
        Me.NewTabButton.Size = New System.Drawing.Size(36, 36)
        Me.NewTabButton.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.NewTabButton, "New Tab")
        Me.NewTabButton.UseVisualStyleBackColor = False
        '
        'MenuButton
        '
        Me.MenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.ForeColor = System.Drawing.Color.White
        Me.MenuButton.Image = Global.SPRINGBOARD.My.Resources.Resources.Menu
        Me.MenuButton.Location = New System.Drawing.Point(982, 0)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(26, 36)
        Me.MenuButton.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.MenuButton, "Menu")
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Transparent
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Image = Global.SPRINGBOARD.My.Resources.Resources.HomeIco
        Me.HomeButton.Location = New System.Drawing.Point(140, 0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(36, 36)
        Me.HomeButton.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.HomeButton, "Home")
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'ForwardButton
        '
        Me.ForwardButton.BackColor = System.Drawing.Color.Transparent
        Me.ForwardButton.FlatAppearance.BorderSize = 0
        Me.ForwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ForwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForwardButton.ForeColor = System.Drawing.Color.White
        Me.ForwardButton.Image = Global.SPRINGBOARD.My.Resources.Resources.ForwardIco
        Me.ForwardButton.Location = New System.Drawing.Point(35, 0)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Forward")
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.SPRINGBOARD.My.Resources.Resources.BackIco
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.Transparent
        Me.StopButton.FlatAppearance.BorderSize = 0
        Me.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.ForeColor = System.Drawing.Color.White
        Me.StopButton.Image = Global.SPRINGBOARD.My.Resources.Resources.StopIco
        Me.StopButton.Location = New System.Drawing.Point(105, 0)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(36, 36)
        Me.StopButton.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.StopButton, "Stop")
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButton.FlatAppearance.BorderSize = 0
        Me.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.ForeColor = System.Drawing.Color.White
        Me.RefreshButton.Image = Global.SPRINGBOARD.My.Resources.Resources.RefreshIco
        Me.RefreshButton.Location = New System.Drawing.Point(70, 0)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(36, 36)
        Me.RefreshButton.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.RefreshButton, "Refresh")
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'FavouriteButton
        '
        Me.FavouriteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavouriteButton.BackColor = System.Drawing.Color.Transparent
        Me.FavouriteButton.FlatAppearance.BorderSize = 0
        Me.FavouriteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FavouriteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.FavouriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FavouriteButton.ForeColor = System.Drawing.Color.White
        Me.FavouriteButton.Image = Global.SPRINGBOARD.My.Resources.Resources.Pin
        Me.FavouriteButton.Location = New System.Drawing.Point(591, 0)
        Me.FavouriteButton.Name = "FavouriteButton"
        Me.FavouriteButton.Size = New System.Drawing.Size(36, 36)
        Me.FavouriteButton.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.FavouriteButton, "Pin a web site...")
        Me.FavouriteButton.UseVisualStyleBackColor = False
        '
        'SSLButton
        '
        Me.SSLButton.BackColor = System.Drawing.Color.Transparent
        Me.SSLButton.FlatAppearance.BorderSize = 0
        Me.SSLButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SSLButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.SSLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SSLButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSLButton.ForeColor = System.Drawing.Color.White
        Me.SSLButton.Image = Global.SPRINGBOARD.My.Resources.Resources.LockIco
        Me.SSLButton.Location = New System.Drawing.Point(176, 0)
        Me.SSLButton.Name = "SSLButton"
        Me.SSLButton.Size = New System.Drawing.Size(36, 36)
        Me.SSLButton.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.SSLButton, "Site Information")
        Me.SSLButton.UseVisualStyleBackColor = False
        '
        'ZoomOutButton
        '
        Me.ZoomOutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomOutButton.FlatAppearance.BorderSize = 0
        Me.ZoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZoomOutButton.Image = Global.SPRINGBOARD.My.Resources.Resources.minus
        Me.ZoomOutButton.Location = New System.Drawing.Point(959, 0)
        Me.ZoomOutButton.Name = "ZoomOutButton"
        Me.ZoomOutButton.Size = New System.Drawing.Size(13, 13)
        Me.ZoomOutButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ZoomOutButton, "Zoom Out")
        Me.ZoomOutButton.UseVisualStyleBackColor = True
        '
        'ZoomInButton
        '
        Me.ZoomInButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomInButton.FlatAppearance.BorderSize = 0
        Me.ZoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZoomInButton.Image = Global.SPRINGBOARD.My.Resources.Resources.Plus
        Me.ZoomInButton.Location = New System.Drawing.Point(995, 0)
        Me.ZoomInButton.Name = "ZoomInButton"
        Me.ZoomInButton.Size = New System.Drawing.Size(13, 13)
        Me.ZoomInButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ZoomInButton, "Zoom In")
        Me.ZoomInButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem1, Me.CloseTabToolStripMenuItem1, Me.NewWindowToolStripMenuItem1, Me.ToolStripSeparator1, Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintToolStripMenuItem, Me.ToolStripSeparator3, Me.SourceToolStripMenuItem, Me.HTMLStudioToolStripMenuItem, Me.ToolStripSeparator8, Me.SettingsPanelToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.WhatsNewToolStripMenuItem, Me.ToolStripSeparator11, Me.QuickStartToolStripMenuItem, Me.ToolStripSeparator4, Me.SendFeedbackToolStripMenuItem1, Me.TestToolStripMenuItem, Me.AboutLogiverseNavigator80ToolStripMenuItem, Me.ToolStripSeparator12, Me.ExitToolStripMenuItem1})
        Me.MainMenu.Name = "ContextMenuStrip1"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu.Size = New System.Drawing.Size(196, 654)
        '
        'NewTabToolStripMenuItem1
        '
        Me.NewTabToolStripMenuItem1.Image = Global.SPRINGBOARD.My.Resources.Resources.NewTabIco
        Me.NewTabToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewTabToolStripMenuItem1.Name = "NewTabToolStripMenuItem1"
        Me.NewTabToolStripMenuItem1.Size = New System.Drawing.Size(195, 38)
        Me.NewTabToolStripMenuItem1.Text = "New tab"
        '
        'CloseTabToolStripMenuItem1
        '
        Me.CloseTabToolStripMenuItem1.Image = Global.SPRINGBOARD.My.Resources.Resources.CloseTabIco
        Me.CloseTabToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CloseTabToolStripMenuItem1.Name = "CloseTabToolStripMenuItem1"
        Me.CloseTabToolStripMenuItem1.Size = New System.Drawing.Size(195, 38)
        Me.CloseTabToolStripMenuItem1.Text = "Close tab"
        '
        'NewWindowToolStripMenuItem1
        '
        Me.NewWindowToolStripMenuItem1.Image = Global.SPRINGBOARD.My.Resources.Resources.NewWindowIco
        Me.NewWindowToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewWindowToolStripMenuItem1.Name = "NewWindowToolStripMenuItem1"
        Me.NewWindowToolStripMenuItem1.Size = New System.Drawing.Size(195, 38)
        Me.NewWindowToolStripMenuItem1.Text = "New window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.Open
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.SaveIco
        Me.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.SaveAsToolStripMenuItem.Text = "Save as..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.Print
        Me.PrintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'SourceToolStripMenuItem
        '
        Me.SourceToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.HTMLIco
        Me.SourceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SourceToolStripMenuItem.Name = "SourceToolStripMenuItem"
        Me.SourceToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.SourceToolStripMenuItem.Text = "Source"
        '
        'HTMLStudioToolStripMenuItem
        '
        Me.HTMLStudioToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.WebStudioIco
        Me.HTMLStudioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HTMLStudioToolStripMenuItem.Name = "HTMLStudioToolStripMenuItem"
        Me.HTMLStudioToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.HTMLStudioToolStripMenuItem.Text = "Web Studio"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(192, 6)
        '
        'SettingsPanelToolStripMenuItem
        '
        Me.SettingsPanelToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.SettingsIco
        Me.SettingsPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem.Name = "SettingsPanelToolStripMenuItem"
        Me.SettingsPanelToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.SettingsPanelToolStripMenuItem.Text = "Settings Panel..."
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.UpdateIco
        Me.CheckForUpdatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates..."
        '
        'WhatsNewToolStripMenuItem
        '
        Me.WhatsNewToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.ChangesIco
        Me.WhatsNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WhatsNewToolStripMenuItem.Name = "WhatsNewToolStripMenuItem"
        Me.WhatsNewToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.WhatsNewToolStripMenuItem.Text = "What's new?"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(192, 6)
        '
        'QuickStartToolStripMenuItem
        '
        Me.QuickStartToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.VivianIco
        Me.QuickStartToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuickStartToolStripMenuItem.Name = "QuickStartToolStripMenuItem"
        Me.QuickStartToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.QuickStartToolStripMenuItem.Text = "Quick Start"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'SendFeedbackToolStripMenuItem1
        '
        Me.SendFeedbackToolStripMenuItem1.Image = Global.SPRINGBOARD.My.Resources.Resources.FeedbackIco
        Me.SendFeedbackToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendFeedbackToolStripMenuItem1.Name = "SendFeedbackToolStripMenuItem1"
        Me.SendFeedbackToolStripMenuItem1.Size = New System.Drawing.Size(195, 38)
        Me.SendFeedbackToolStripMenuItem1.Text = "Send feedback..."
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.Quest
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.TestToolStripMenuItem.Text = "Help..."
        '
        'AboutLogiverseNavigator80ToolStripMenuItem
        '
        Me.AboutLogiverseNavigator80ToolStripMenuItem.Image = Global.SPRINGBOARD.My.Resources.Resources.InfoIco
        Me.AboutLogiverseNavigator80ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutLogiverseNavigator80ToolStripMenuItem.Name = "AboutLogiverseNavigator80ToolStripMenuItem"
        Me.AboutLogiverseNavigator80ToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.AboutLogiverseNavigator80ToolStripMenuItem.Text = "About Vivian..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(192, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.SPRINGBOARD.My.Resources.Resources.ExitIco
        Me.ExitToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(195, 38)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.ContextMenuStrip = Me.RightClickTabMenu
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 678)
        Me.TabControl1.TabIndex = 30
        '
        'RightClickTabMenu
        '
        Me.RightClickTabMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTab_RCTM, Me.CloseTab_RCTM, Me.ToolStripSeparator5, Me.Duplicate_RCTM, Me.ToolStripSeparator6, Me.Reopen_RCTM})
        Me.RightClickTabMenu.Name = "ContextMenuStrip2"
        Me.RightClickTabMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.RightClickTabMenu.Size = New System.Drawing.Size(156, 104)
        '
        'NewTab_RCTM
        '
        Me.NewTab_RCTM.Name = "NewTab_RCTM"
        Me.NewTab_RCTM.Size = New System.Drawing.Size(155, 22)
        Me.NewTab_RCTM.Text = "New tab"
        '
        'CloseTab_RCTM
        '
        Me.CloseTab_RCTM.Name = "CloseTab_RCTM"
        Me.CloseTab_RCTM.Size = New System.Drawing.Size(155, 22)
        Me.CloseTab_RCTM.Text = "Close tab"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(152, 6)
        '
        'Duplicate_RCTM
        '
        Me.Duplicate_RCTM.Name = "Duplicate_RCTM"
        Me.Duplicate_RCTM.Size = New System.Drawing.Size(155, 22)
        Me.Duplicate_RCTM.Text = "Duplicate"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(152, 6)
        '
        'Reopen_RCTM
        '
        Me.Reopen_RCTM.Name = "Reopen_RCTM"
        Me.Reopen_RCTM.Size = New System.Drawing.Size(155, 22)
        Me.Reopen_RCTM.Text = "Reopen last tab"
        '
        'QuickStartPanel
        '
        Me.QuickStartPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuickStartPanel.Controls.Add(Me.QuickStartBottomPanel)
        Me.QuickStartPanel.Controls.Add(Me.LogoImage)
        Me.QuickStartPanel.Controls.Add(Me.Watermark3)
        Me.QuickStartPanel.Controls.Add(Me.QuickStartTopPanel)
        Me.QuickStartPanel.Controls.Add(Me.QuickStartBackground)
        Me.QuickStartPanel.Location = New System.Drawing.Point(0, 0)
        Me.QuickStartPanel.Name = "QuickStartPanel"
        Me.QuickStartPanel.Size = New System.Drawing.Size(1008, 729)
        Me.QuickStartPanel.TabIndex = 55
        '
        'QuickStartBottomPanel
        '
        Me.QuickStartBottomPanel.BackColor = System.Drawing.Color.White
        Me.QuickStartBottomPanel.Controls.Add(Me.DonateQuickStartButton)
        Me.QuickStartBottomPanel.Controls.Add(Me.QuickStartCopyrightLabel)
        Me.QuickStartBottomPanel.Controls.Add(Me.SettingsQuickStartButton)
        Me.QuickStartBottomPanel.Controls.Add(Me.HistoryQuickStartButton)
        Me.QuickStartBottomPanel.Controls.Add(Me.FavouritesQuickStartButton)
        Me.QuickStartBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.QuickStartBottomPanel.Location = New System.Drawing.Point(0, 664)
        Me.QuickStartBottomPanel.Name = "QuickStartBottomPanel"
        Me.QuickStartBottomPanel.Size = New System.Drawing.Size(1008, 65)
        Me.QuickStartBottomPanel.TabIndex = 56
        '
        'DonateQuickStartButton
        '
        Me.DonateQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.DonateQuickStartButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DonateQuickStartButton.FlatAppearance.BorderSize = 2
        Me.DonateQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DonateQuickStartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonateQuickStartButton.ForeColor = System.Drawing.Color.Black
        Me.DonateQuickStartButton.Image = Global.SPRINGBOARD.My.Resources.Resources.Donate
        Me.DonateQuickStartButton.Location = New System.Drawing.Point(396, 12)
        Me.DonateQuickStartButton.Name = "DonateQuickStartButton"
        Me.DonateQuickStartButton.Size = New System.Drawing.Size(124, 44)
        Me.DonateQuickStartButton.TabIndex = 7
        Me.DonateQuickStartButton.Text = "Donate"
        Me.DonateQuickStartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DonateQuickStartButton.UseVisualStyleBackColor = False
        '
        'QuickStartCopyrightLabel
        '
        Me.QuickStartCopyrightLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuickStartCopyrightLabel.AutoSize = True
        Me.QuickStartCopyrightLabel.BackColor = System.Drawing.Color.Transparent
        Me.QuickStartCopyrightLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickStartCopyrightLabel.Location = New System.Drawing.Point(600, 19)
        Me.QuickStartCopyrightLabel.Name = "QuickStartCopyrightLabel"
        Me.QuickStartCopyrightLabel.Size = New System.Drawing.Size(399, 30)
        Me.QuickStartCopyrightLabel.TabIndex = 6
        Me.QuickStartCopyrightLabel.Text = "© 2014 - 2020 WindowsLogic Productions"
        '
        'SettingsQuickStartButton
        '
        Me.SettingsQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsQuickStartButton.FlatAppearance.BorderSize = 0
        Me.SettingsQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsQuickStartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsQuickStartButton.ForeColor = System.Drawing.Color.Black
        Me.SettingsQuickStartButton.Image = Global.SPRINGBOARD.My.Resources.Resources.SettingsIco
        Me.SettingsQuickStartButton.Location = New System.Drawing.Point(260, 12)
        Me.SettingsQuickStartButton.Name = "SettingsQuickStartButton"
        Me.SettingsQuickStartButton.Size = New System.Drawing.Size(130, 44)
        Me.SettingsQuickStartButton.TabIndex = 5
        Me.SettingsQuickStartButton.Text = "Settings"
        Me.SettingsQuickStartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SettingsQuickStartButton.UseVisualStyleBackColor = False
        '
        'HistoryQuickStartButton
        '
        Me.HistoryQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.HistoryQuickStartButton.FlatAppearance.BorderSize = 0
        Me.HistoryQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryQuickStartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryQuickStartButton.ForeColor = System.Drawing.Color.Black
        Me.HistoryQuickStartButton.Image = Global.SPRINGBOARD.My.Resources.Resources.HistoryIco
        Me.HistoryQuickStartButton.Location = New System.Drawing.Point(133, 12)
        Me.HistoryQuickStartButton.Name = "HistoryQuickStartButton"
        Me.HistoryQuickStartButton.Size = New System.Drawing.Size(121, 44)
        Me.HistoryQuickStartButton.TabIndex = 4
        Me.HistoryQuickStartButton.Text = "History"
        Me.HistoryQuickStartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.HistoryQuickStartButton.UseVisualStyleBackColor = False
        '
        'FavouritesQuickStartButton
        '
        Me.FavouritesQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.FavouritesQuickStartButton.FlatAppearance.BorderSize = 0
        Me.FavouritesQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FavouritesQuickStartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FavouritesQuickStartButton.ForeColor = System.Drawing.Color.Black
        Me.FavouritesQuickStartButton.Image = Global.SPRINGBOARD.My.Resources.Resources.Pin
        Me.FavouritesQuickStartButton.Location = New System.Drawing.Point(12, 12)
        Me.FavouritesQuickStartButton.Name = "FavouritesQuickStartButton"
        Me.FavouritesQuickStartButton.Size = New System.Drawing.Size(115, 44)
        Me.FavouritesQuickStartButton.TabIndex = 3
        Me.FavouritesQuickStartButton.Text = "Pins"
        Me.FavouritesQuickStartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FavouritesQuickStartButton.UseVisualStyleBackColor = False
        '
        'LogoImage
        '
        Me.LogoImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoImage.BackColor = System.Drawing.Color.Transparent
        Me.LogoImage.Image = Global.SPRINGBOARD.My.Resources.Resources.Vivian_2x
        Me.LogoImage.Location = New System.Drawing.Point(379, 196)
        Me.LogoImage.Name = "LogoImage"
        Me.LogoImage.Size = New System.Drawing.Size(250, 250)
        Me.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoImage.TabIndex = 53
        Me.LogoImage.TabStop = False
        '
        'Watermark3
        '
        Me.Watermark3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Watermark3.ContextMenuStrip = Me.SearchBarRightClickMenu
        Me.Watermark3.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watermark3.Location = New System.Drawing.Point(327, 497)
        Me.Watermark3.markcolour = System.Drawing.Color.Gray
        Me.Watermark3.Name = "Watermark3"
        Me.Watermark3.Size = New System.Drawing.Size(355, 35)
        Me.Watermark3.TabIndex = 56
        Me.Watermark3.Watermarktext = "Specify a search query."
        '
        'SearchBarRightClickMenu
        '
        Me.SearchBarRightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripSeparator17, Me.Cut_SCM, Me.Copy_SCM, Me.Paste_SCM, Me.PasteGo_SCM, Me.ToolStripSeparator16, Me.SelectAll_SCM, Me.ClearToolStripMenuItem})
        Me.SearchBarRightClickMenu.Name = "AddressBarRightClickMenu"
        Me.SearchBarRightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SearchBarRightClickMenu.Size = New System.Drawing.Size(145, 170)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(141, 6)
        '
        'Cut_SCM
        '
        Me.Cut_SCM.Name = "Cut_SCM"
        Me.Cut_SCM.Size = New System.Drawing.Size(144, 22)
        Me.Cut_SCM.Text = "Cut"
        '
        'Copy_SCM
        '
        Me.Copy_SCM.Name = "Copy_SCM"
        Me.Copy_SCM.Size = New System.Drawing.Size(144, 22)
        Me.Copy_SCM.Text = "Copy"
        '
        'Paste_SCM
        '
        Me.Paste_SCM.Name = "Paste_SCM"
        Me.Paste_SCM.Size = New System.Drawing.Size(144, 22)
        Me.Paste_SCM.Text = "Paste"
        '
        'PasteGo_SCM
        '
        Me.PasteGo_SCM.Name = "PasteGo_SCM"
        Me.PasteGo_SCM.Size = New System.Drawing.Size(144, 22)
        Me.PasteGo_SCM.Text = "Paste and go"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAll_SCM
        '
        Me.SelectAll_SCM.Name = "SelectAll_SCM"
        Me.SelectAll_SCM.Size = New System.Drawing.Size(144, 22)
        Me.SelectAll_SCM.Text = "Select all"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'QuickStartTopPanel
        '
        Me.QuickStartTopPanel.BackColor = System.Drawing.Color.White
        Me.QuickStartTopPanel.Controls.Add(Me.HelpQuickStartButton)
        Me.QuickStartTopPanel.Controls.Add(Me.FeedbackQuickStartButton)
        Me.QuickStartTopPanel.Controls.Add(Me.ExitQuickStartButton)
        Me.QuickStartTopPanel.Controls.Add(Me.QuickStartTitleLabel)
        Me.QuickStartTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.QuickStartTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.QuickStartTopPanel.Name = "QuickStartTopPanel"
        Me.QuickStartTopPanel.Size = New System.Drawing.Size(1008, 53)
        Me.QuickStartTopPanel.TabIndex = 55
        '
        'HelpQuickStartButton
        '
        Me.HelpQuickStartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.HelpQuickStartButton.FlatAppearance.BorderSize = 0
        Me.HelpQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpQuickStartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpQuickStartButton.ForeColor = System.Drawing.Color.Black
        Me.HelpQuickStartButton.Location = New System.Drawing.Point(588, 5)
        Me.HelpQuickStartButton.Name = "HelpQuickStartButton"
        Me.HelpQuickStartButton.Size = New System.Drawing.Size(182, 44)
        Me.HelpQuickStartButton.TabIndex = 8
        Me.HelpQuickStartButton.Text = "Where do I start?"
        Me.HelpQuickStartButton.UseVisualStyleBackColor = False
        '
        'FeedbackQuickStartButton
        '
        Me.FeedbackQuickStartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FeedbackQuickStartButton.BackColor = System.Drawing.Color.Transparent
        Me.FeedbackQuickStartButton.FlatAppearance.BorderSize = 0
        Me.FeedbackQuickStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FeedbackQuickStartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeedbackQuickStartButton.ForeColor = System.Drawing.Color.Black
        Me.FeedbackQuickStartButton.Location = New System.Drawing.Point(776, 5)
        Me.FeedbackQuickStartButton.Name = "FeedbackQuickStartButton"
        Me.FeedbackQuickStartButton.Size = New System.Drawing.Size(228, 44)
        Me.FeedbackQuickStartButton.TabIndex = 7
        Me.FeedbackQuickStartButton.Text = "Tell us what you think"
        Me.FeedbackQuickStartButton.UseVisualStyleBackColor = False
        '
        'QuickStartTitleLabel
        '
        Me.QuickStartTitleLabel.AutoSize = True
        Me.QuickStartTitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.QuickStartTitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickStartTitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.QuickStartTitleLabel.Name = "QuickStartTitleLabel"
        Me.QuickStartTitleLabel.Size = New System.Drawing.Size(177, 30)
        Me.QuickStartTitleLabel.TabIndex = 2
        Me.QuickStartTitleLabel.Text = "Vivian Quick Start"
        '
        'QuickStartBackground
        '
        Me.QuickStartBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuickStartBackground.Image = Global.SPRINGBOARD.My.Resources.Resources.Background
        Me.QuickStartBackground.Location = New System.Drawing.Point(0, 0)
        Me.QuickStartBackground.Name = "QuickStartBackground"
        Me.QuickStartBackground.Size = New System.Drawing.Size(1008, 729)
        Me.QuickStartBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuickStartBackground.TabIndex = 57
        Me.QuickStartBackground.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'StatusUpdater
        '
        Me.StatusUpdater.Enabled = True
        Me.StatusUpdater.Interval = 1
        '
        'StatusPanel
        '
        Me.StatusPanel.BackColor = System.Drawing.Color.White
        Me.StatusPanel.Controls.Add(Me.ZoomLabel)
        Me.StatusPanel.Controls.Add(Me.ZoomOutButton)
        Me.StatusPanel.Controls.Add(Me.ZoomInButton)
        Me.StatusPanel.Controls.Add(Me.StatusText)
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusPanel.Location = New System.Drawing.Point(0, 716)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(1008, 13)
        Me.StatusPanel.TabIndex = 56
        '
        'StatusText
        '
        Me.StatusText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusText.AutoSize = True
        Me.StatusText.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusText.Location = New System.Drawing.Point(1, 1)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(25, 11)
        Me.StatusText.TabIndex = 0
        Me.StatusText.Text = "Done"
        '
        'BrowserRightClickMenu
        '
        Me.BrowserRightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenLink_RCM, Me.OpenLinkWindow_RCM, Me.ToolStripSeparator7, Me.OpenDefaultBrowser_RCM, Me.ToolStripSeparator10, Me.SaveLink_RCM, Me.Favourite_RCM, Me.CopyLink_RCM, Me.ToolStripSeparator9, Me.Copy_RCM, Me.Paste_RCM, Me.ToolStripSeparator13, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator14, Me.SearchFor_RCM})
        Me.BrowserRightClickMenu.Name = "ContextMenuStrip2"
        Me.BrowserRightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BrowserRightClickMenu.Size = New System.Drawing.Size(281, 254)
        '
        'OpenLink_RCM
        '
        Me.OpenLink_RCM.Name = "OpenLink_RCM"
        Me.OpenLink_RCM.Size = New System.Drawing.Size(280, 22)
        Me.OpenLink_RCM.Text = "Open link in new tab"
        '
        'OpenLinkWindow_RCM
        '
        Me.OpenLinkWindow_RCM.Name = "OpenLinkWindow_RCM"
        Me.OpenLinkWindow_RCM.Size = New System.Drawing.Size(280, 22)
        Me.OpenLinkWindow_RCM.Text = "Open link in new window"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(277, 6)
        '
        'OpenDefaultBrowser_RCM
        '
        Me.OpenDefaultBrowser_RCM.Name = "OpenDefaultBrowser_RCM"
        Me.OpenDefaultBrowser_RCM.Size = New System.Drawing.Size(280, 22)
        Me.OpenDefaultBrowser_RCM.Text = "Open current page in default browser..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(277, 6)
        '
        'SaveLink_RCM
        '
        Me.SaveLink_RCM.Name = "SaveLink_RCM"
        Me.SaveLink_RCM.Size = New System.Drawing.Size(280, 22)
        Me.SaveLink_RCM.Text = "Save link as..."
        '
        'Favourite_RCM
        '
        Me.Favourite_RCM.Name = "Favourite_RCM"
        Me.Favourite_RCM.Size = New System.Drawing.Size(280, 22)
        Me.Favourite_RCM.Text = "Add link to pinned sites..."
        '
        'CopyLink_RCM
        '
        Me.CopyLink_RCM.Name = "CopyLink_RCM"
        Me.CopyLink_RCM.Size = New System.Drawing.Size(280, 22)
        Me.CopyLink_RCM.Text = "Copy link address"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(277, 6)
        '
        'Copy_RCM
        '
        Me.Copy_RCM.Name = "Copy_RCM"
        Me.Copy_RCM.Size = New System.Drawing.Size(280, 22)
        Me.Copy_RCM.Text = "Copy"
        '
        'Paste_RCM
        '
        Me.Paste_RCM.Name = "Paste_RCM"
        Me.Paste_RCM.Size = New System.Drawing.Size(280, 22)
        Me.Paste_RCM.Text = "Paste"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(277, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(277, 6)
        '
        'SearchFor_RCM
        '
        Me.SearchFor_RCM.Name = "SearchFor_RCM"
        Me.SearchFor_RCM.Size = New System.Drawing.Size(280, 22)
        Me.SearchFor_RCM.Text = "Search for"
        '
        'AddressBarRightClickMenu
        '
        Me.AddressBarRightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem1, Me.ToolStripSeparator18, Me.Cut_ACM, Me.Copy_ACM, Me.Paste_ACM, Me.PasteGo_ACM, Me.ToolStripSeparator15, Me.SelectAll_ACM, Me.ClearToolStripMenuItem2})
        Me.AddressBarRightClickMenu.Name = "AddressBarRightClickMenu"
        Me.AddressBarRightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.AddressBarRightClickMenu.Size = New System.Drawing.Size(145, 170)
        '
        'UndoToolStripMenuItem1
        '
        Me.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1"
        Me.UndoToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem1.Text = "Undo"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(141, 6)
        '
        'Cut_ACM
        '
        Me.Cut_ACM.Name = "Cut_ACM"
        Me.Cut_ACM.Size = New System.Drawing.Size(144, 22)
        Me.Cut_ACM.Text = "Cut"
        '
        'Copy_ACM
        '
        Me.Copy_ACM.Name = "Copy_ACM"
        Me.Copy_ACM.Size = New System.Drawing.Size(144, 22)
        Me.Copy_ACM.Text = "Copy"
        '
        'Paste_ACM
        '
        Me.Paste_ACM.Name = "Paste_ACM"
        Me.Paste_ACM.Size = New System.Drawing.Size(144, 22)
        Me.Paste_ACM.Text = "Paste"
        '
        'PasteGo_ACM
        '
        Me.PasteGo_ACM.Name = "PasteGo_ACM"
        Me.PasteGo_ACM.Size = New System.Drawing.Size(144, 22)
        Me.PasteGo_ACM.Text = "Paste and go"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAll_ACM
        '
        Me.SelectAll_ACM.Name = "SelectAll_ACM"
        Me.SelectAll_ACM.Size = New System.Drawing.Size(144, 22)
        Me.SelectAll_ACM.Text = "Select all"
        '
        'ClearToolStripMenuItem2
        '
        Me.ClearToolStripMenuItem2.Name = "ClearToolStripMenuItem2"
        Me.ClearToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.ClearToolStripMenuItem2.Text = "Clear"
        '
        'HubBackground
        '
        Me.HubBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HubBackground.Image = Global.SPRINGBOARD.My.Resources.Resources.Background
        Me.HubBackground.Location = New System.Drawing.Point(0, 0)
        Me.HubBackground.Name = "HubBackground"
        Me.HubBackground.Size = New System.Drawing.Size(1008, 729)
        Me.HubBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HubBackground.TabIndex = 43
        Me.HubBackground.TabStop = False
        '
        'NavClusterBackPanel
        '
        Me.NavClusterBackPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavClusterBackPanel.Controls.Add(Me.BackButton)
        Me.NavClusterBackPanel.Controls.Add(Me.SSLButton)
        Me.NavClusterBackPanel.Controls.Add(Me.FavouriteButton)
        Me.NavClusterBackPanel.Controls.Add(Me.RefreshButton)
        Me.NavClusterBackPanel.Controls.Add(Me.StopButton)
        Me.NavClusterBackPanel.Controls.Add(Me.ForwardButton)
        Me.NavClusterBackPanel.Controls.Add(Me.Watermark2)
        Me.NavClusterBackPanel.Controls.Add(Me.HomeButton)
        Me.NavClusterBackPanel.Controls.Add(Me.Watermark1)
        Me.NavClusterBackPanel.Controls.Add(Me.MenuButton)
        Me.NavClusterBackPanel.Controls.Add(Me.CloseTabButton)
        Me.NavClusterBackPanel.Controls.Add(Me.NewTabButton)
        Me.NavClusterBackPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavClusterBackPanel.Name = "NavClusterBackPanel"
        Me.NavClusterBackPanel.Size = New System.Drawing.Size(1008, 36)
        Me.NavClusterBackPanel.TabIndex = 58
        '
        'Watermark2
        '
        Me.Watermark2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Watermark2.ContextMenuStrip = Me.SearchBarRightClickMenu
        Me.Watermark2.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watermark2.Location = New System.Drawing.Point(627, 1)
        Me.Watermark2.markcolour = System.Drawing.Color.Gray
        Me.Watermark2.Name = "Watermark2"
        Me.Watermark2.Size = New System.Drawing.Size(283, 35)
        Me.Watermark2.TabIndex = 41
        Me.Watermark2.Watermarktext = "Specify a search query."
        '
        'Watermark1
        '
        Me.Watermark1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Watermark1.ContextMenuStrip = Me.AddressBarRightClickMenu
        Me.Watermark1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watermark1.Location = New System.Drawing.Point(212, 1)
        Me.Watermark1.markcolour = System.Drawing.Color.Gray
        Me.Watermark1.Name = "Watermark1"
        Me.Watermark1.Size = New System.Drawing.Size(379, 35)
        Me.Watermark1.TabIndex = 40
        Me.Watermark1.Watermarktext = "Specify a website address."
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.QuickStartPanel)
        Me.Controls.Add(Me.NavClusterBackPanel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusPanel)
        Me.Controls.Add(Me.HubBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 736)
        Me.Name = "Browser"
        Me.Text = "Vivian"
        Me.MainMenu.ResumeLayout(False)
        Me.RightClickTabMenu.ResumeLayout(False)
        Me.QuickStartPanel.ResumeLayout(False)
        Me.QuickStartPanel.PerformLayout()
        Me.QuickStartBottomPanel.ResumeLayout(False)
        Me.QuickStartBottomPanel.PerformLayout()
        CType(Me.LogoImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchBarRightClickMenu.ResumeLayout(False)
        Me.QuickStartTopPanel.ResumeLayout(False)
        Me.QuickStartTopPanel.PerformLayout()
        CType(Me.QuickStartBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        Me.BrowserRightClickMenu.ResumeLayout(False)
        Me.AddressBarRightClickMenu.ResumeLayout(False)
        CType(Me.HubBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavClusterBackPanel.ResumeLayout(False)
        Me.NavClusterBackPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewTabToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLStudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhatsNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SendFeedbackToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutLogiverseNavigator80ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Watermark2 As SPRINGBOARD.Watermark
    Friend WithEvents Watermark1 As SPRINGBOARD.Watermark
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HubBackground As System.Windows.Forms.PictureBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents FavouriteButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents NewTabButton As System.Windows.Forms.Button
    Friend WithEvents CloseTabButton As System.Windows.Forms.Button
    Friend WithEvents SettingsPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickStartPanel As System.Windows.Forms.Panel
    Friend WithEvents QuickStartBottomPanel As System.Windows.Forms.Panel
    Friend WithEvents FeedbackQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents QuickStartCopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents SettingsQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents HistoryQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents FavouritesQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents Watermark3 As SPRINGBOARD.Watermark
    Friend WithEvents QuickStartTopPanel As System.Windows.Forms.Panel
    Friend WithEvents ExitQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents QuickStartTitleLabel As System.Windows.Forms.Label
    Friend WithEvents QuickStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents QuickStartBackground As System.Windows.Forms.PictureBox
    Friend WithEvents LogoImage As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents HelpQuickStartButton As System.Windows.Forms.Button
    Friend WithEvents StatusUpdater As System.Windows.Forms.Timer
    Friend WithEvents StatusPanel As System.Windows.Forms.Panel
    Friend WithEvents StatusText As System.Windows.Forms.Label
    Friend WithEvents BrowserRightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenLinkWindow_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickTabMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseTab_RCTM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTab_RCTM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenLink_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveLink_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyLink_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Duplicate_RCTM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Reopen_RCTM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Copy_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Paste_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchFor_RCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDefaultBrowser_RCM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents SSLButton As Button
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents AddressBarRightClickMenu As ContextMenuStrip
    Friend WithEvents Cut_ACM As ToolStripMenuItem
    Friend WithEvents Copy_ACM As ToolStripMenuItem
    Friend WithEvents Paste_ACM As ToolStripMenuItem
    Friend WithEvents PasteGo_ACM As ToolStripMenuItem
    Friend WithEvents SelectAll_ACM As ToolStripMenuItem
    Friend WithEvents SearchBarRightClickMenu As ContextMenuStrip
    Friend WithEvents Cut_SCM As ToolStripMenuItem
    Friend WithEvents Copy_SCM As ToolStripMenuItem
    Friend WithEvents Paste_SCM As ToolStripMenuItem
    Friend WithEvents PasteGo_SCM As ToolStripMenuItem
    Friend WithEvents SelectAll_SCM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents Favourite_RCM As ToolStripMenuItem
    Friend WithEvents ZoomOutButton As Button
    Friend WithEvents ZoomInButton As Button
    Friend WithEvents ZoomLabel As Label
    Friend WithEvents NavClusterBackPanel As Panel
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem2 As ToolStripMenuItem
End Class
