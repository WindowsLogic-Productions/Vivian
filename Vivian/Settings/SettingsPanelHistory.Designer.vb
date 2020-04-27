<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelHistory))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HistoryDeleteAllButton = New System.Windows.Forms.Button()
        Me.HistoryDeleteButton = New System.Windows.Forms.Button()
        Me.OpenHistoryPageButton = New System.Windows.Forms.Button()
        Me.HistoryListBox = New System.Windows.Forms.ListBox()
        Me.HistoryLabel = New System.Windows.Forms.Label()
        Me.HistoryImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.HistoryDeleteAllButton)
        Me.TabPage1.Controls.Add(Me.HistoryDeleteButton)
        Me.TabPage1.Controls.Add(Me.OpenHistoryPageButton)
        Me.TabPage1.Controls.Add(Me.HistoryListBox)
        Me.TabPage1.Controls.Add(Me.HistoryLabel)
        Me.TabPage1.Controls.Add(Me.HistoryImage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "History"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Later"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(377, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Earlier"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SPRINGBOARD.My.Resources.Resources.DirectionArrowDown
        Me.PictureBox2.Location = New System.Drawing.Point(387, 129)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(9, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPRINGBOARD.My.Resources.Resources.DirectionArrowUp
        Me.PictureBox1.Location = New System.Drawing.Point(387, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(9, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'HistoryDeleteAllButton
        '
        Me.HistoryDeleteAllButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.HistoryDeleteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HistoryDeleteAllButton.ForeColor = System.Drawing.Color.White
        Me.HistoryDeleteAllButton.Location = New System.Drawing.Point(328, 150)
        Me.HistoryDeleteAllButton.Name = "HistoryDeleteAllButton"
        Me.HistoryDeleteAllButton.Size = New System.Drawing.Size(75, 23)
        Me.HistoryDeleteAllButton.TabIndex = 8
        Me.HistoryDeleteAllButton.Text = "Delete All"
        Me.HistoryDeleteAllButton.UseVisualStyleBackColor = False
        '
        'HistoryDeleteButton
        '
        Me.HistoryDeleteButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.HistoryDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HistoryDeleteButton.ForeColor = System.Drawing.Color.White
        Me.HistoryDeleteButton.Location = New System.Drawing.Point(247, 150)
        Me.HistoryDeleteButton.Name = "HistoryDeleteButton"
        Me.HistoryDeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.HistoryDeleteButton.TabIndex = 7
        Me.HistoryDeleteButton.Text = "Delete"
        Me.HistoryDeleteButton.UseVisualStyleBackColor = False
        '
        'OpenHistoryPageButton
        '
        Me.OpenHistoryPageButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.OpenHistoryPageButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OpenHistoryPageButton.ForeColor = System.Drawing.Color.White
        Me.OpenHistoryPageButton.Location = New System.Drawing.Point(6, 150)
        Me.OpenHistoryPageButton.Name = "OpenHistoryPageButton"
        Me.OpenHistoryPageButton.Size = New System.Drawing.Size(121, 23)
        Me.OpenHistoryPageButton.TabIndex = 6
        Me.OpenHistoryPageButton.Text = "Open Selected Page"
        Me.OpenHistoryPageButton.UseVisualStyleBackColor = False
        '
        'HistoryListBox
        '
        Me.HistoryListBox.FormattingEnabled = True
        Me.HistoryListBox.Location = New System.Drawing.Point(6, 49)
        Me.HistoryListBox.Name = "HistoryListBox"
        Me.HistoryListBox.Size = New System.Drawing.Size(369, 95)
        Me.HistoryListBox.TabIndex = 3
        '
        'HistoryLabel
        '
        Me.HistoryLabel.AutoSize = True
        Me.HistoryLabel.Location = New System.Drawing.Point(41, 6)
        Me.HistoryLabel.Name = "HistoryLabel"
        Me.HistoryLabel.Size = New System.Drawing.Size(368, 39)
        Me.HistoryLabel.TabIndex = 2
        Me.HistoryLabel.Text = resources.GetString("HistoryLabel.Text")
        '
        'HistoryImage
        '
        Me.HistoryImage.Image = Global.SPRINGBOARD.My.Resources.Resources.HistoryIco
        Me.HistoryImage.Location = New System.Drawing.Point(6, 6)
        Me.HistoryImage.Name = "HistoryImage"
        Me.HistoryImage.Size = New System.Drawing.Size(32, 32)
        Me.HistoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.HistoryImage.TabIndex = 1
        Me.HistoryImage.TabStop = False
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
        Me.TitleLabel.Size = New System.Drawing.Size(281, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "View or modify your history..."
        '
        'SettingsPanelHistory
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
        Me.Name = "SettingsPanelHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > History"
        Me.ToolTip1.SetToolTip(Me, "Back to Settings Panel.")
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents HistoryImage As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryLabel As System.Windows.Forms.Label
    Friend WithEvents HistoryListBox As System.Windows.Forms.ListBox
    Friend WithEvents HistoryDeleteAllButton As System.Windows.Forms.Button
    Friend WithEvents HistoryDeleteButton As System.Windows.Forms.Button
    Friend WithEvents OpenHistoryPageButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
