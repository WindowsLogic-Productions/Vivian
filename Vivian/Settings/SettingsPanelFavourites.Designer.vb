<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelFavourites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelFavourites))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DeleteAllFavouriteButton = New System.Windows.Forms.Button()
        Me.DeleteFavouriteButton = New System.Windows.Forms.Button()
        Me.OpenFavouritePageButton = New System.Windows.Forms.Button()
        Me.FavouriteListBox = New System.Windows.Forms.ListBox()
        Me.FavouritesLabel = New System.Windows.Forms.Label()
        Me.FavouritesImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FavouritesImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DeleteAllFavouriteButton)
        Me.TabPage1.Controls.Add(Me.DeleteFavouriteButton)
        Me.TabPage1.Controls.Add(Me.OpenFavouritePageButton)
        Me.TabPage1.Controls.Add(Me.FavouriteListBox)
        Me.TabPage1.Controls.Add(Me.FavouritesLabel)
        Me.TabPage1.Controls.Add(Me.FavouritesImage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pins"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DeleteAllFavouriteButton
        '
        Me.DeleteAllFavouriteButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteAllFavouriteButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteAllFavouriteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteAllFavouriteButton.Location = New System.Drawing.Point(328, 150)
        Me.DeleteAllFavouriteButton.Name = "DeleteAllFavouriteButton"
        Me.DeleteAllFavouriteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteAllFavouriteButton.TabIndex = 8
        Me.DeleteAllFavouriteButton.Text = "Delete All"
        Me.DeleteAllFavouriteButton.UseVisualStyleBackColor = False
        '
        'DeleteFavouriteButton
        '
        Me.DeleteFavouriteButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteFavouriteButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteFavouriteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteFavouriteButton.Location = New System.Drawing.Point(247, 150)
        Me.DeleteFavouriteButton.Name = "DeleteFavouriteButton"
        Me.DeleteFavouriteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteFavouriteButton.TabIndex = 7
        Me.DeleteFavouriteButton.Text = "Delete"
        Me.DeleteFavouriteButton.UseVisualStyleBackColor = False
        '
        'OpenFavouritePageButton
        '
        Me.OpenFavouritePageButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.OpenFavouritePageButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OpenFavouritePageButton.ForeColor = System.Drawing.Color.White
        Me.OpenFavouritePageButton.Location = New System.Drawing.Point(6, 150)
        Me.OpenFavouritePageButton.Name = "OpenFavouritePageButton"
        Me.OpenFavouritePageButton.Size = New System.Drawing.Size(121, 23)
        Me.OpenFavouritePageButton.TabIndex = 6
        Me.OpenFavouritePageButton.Text = "Open Selected Page"
        Me.OpenFavouritePageButton.UseVisualStyleBackColor = False
        '
        'FavouriteListBox
        '
        Me.FavouriteListBox.FormattingEnabled = True
        Me.FavouriteListBox.Location = New System.Drawing.Point(6, 48)
        Me.FavouriteListBox.Name = "FavouriteListBox"
        Me.FavouriteListBox.Size = New System.Drawing.Size(397, 95)
        Me.FavouriteListBox.TabIndex = 3
        '
        'FavouritesLabel
        '
        Me.FavouritesLabel.AutoSize = True
        Me.FavouritesLabel.Location = New System.Drawing.Point(40, 6)
        Me.FavouritesLabel.Name = "FavouritesLabel"
        Me.FavouritesLabel.Size = New System.Drawing.Size(368, 39)
        Me.FavouritesLabel.TabIndex = 2
        Me.FavouritesLabel.Text = resources.GetString("FavouritesLabel.Text")
        '
        'FavouritesImage
        '
        Me.FavouritesImage.Image = Global.SPRINGBOARD.My.Resources.Resources.Pin
        Me.FavouritesImage.Location = New System.Drawing.Point(6, 6)
        Me.FavouritesImage.Name = "FavouritesImage"
        Me.FavouritesImage.Size = New System.Drawing.Size(32, 32)
        Me.FavouritesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FavouritesImage.TabIndex = 1
        Me.FavouritesImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
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
        Me.TitleLabel.Size = New System.Drawing.Size(330, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "View or modify your pinned sites..."
        '
        'SettingsPanelFavourites
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
        Me.Name = "SettingsPanelFavourites"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Pins"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.FavouritesImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents FavouritesImage As System.Windows.Forms.PictureBox
    Friend WithEvents FavouritesLabel As System.Windows.Forms.Label
    Friend WithEvents FavouriteListBox As System.Windows.Forms.ListBox
    Friend WithEvents DeleteAllFavouriteButton As System.Windows.Forms.Button
    Friend WithEvents DeleteFavouriteButton As System.Windows.Forms.Button
    Friend WithEvents OpenFavouritePageButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
