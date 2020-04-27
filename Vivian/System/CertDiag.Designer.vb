<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertDiag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertDiag))
        Me.OKButton = New System.Windows.Forms.Button()
        Me.ViewCertButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SecLabel = New System.Windows.Forms.Label()
        Me.SubTitleLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(384, 112)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ViewCertButton
        '
        Me.ViewCertButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewCertButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ViewCertButton.Location = New System.Drawing.Point(285, 112)
        Me.ViewCertButton.Name = "ViewCertButton"
        Me.ViewCertButton.Size = New System.Drawing.Size(93, 23)
        Me.ViewCertButton.TabIndex = 1
        Me.ViewCertButton.Text = "View Certificate"
        Me.ViewCertButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 46)
        Me.Panel1.TabIndex = 30
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(50, 8)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(412, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Secure (Hypertext Transfer Protocol Secure)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPRINGBOARD.My.Resources.Resources.LockIco
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SecLabel
        '
        Me.SecLabel.AutoSize = True
        Me.SecLabel.ForeColor = System.Drawing.Color.White
        Me.SecLabel.Location = New System.Drawing.Point(10, 70)
        Me.SecLabel.Name = "SecLabel"
        Me.SecLabel.Size = New System.Drawing.Size(413, 26)
        Me.SecLabel.TabIndex = 31
        Me.SecLabel.Text = "Your information (for example, passwords or credit cards) are private when sent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "to this site."
        '
        'SubTitleLabel
        '
        Me.SubTitleLabel.AutoSize = True
        Me.SubTitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTitleLabel.ForeColor = System.Drawing.Color.White
        Me.SubTitleLabel.Location = New System.Drawing.Point(10, 51)
        Me.SubTitleLabel.Name = "SubTitleLabel"
        Me.SubTitleLabel.Size = New System.Drawing.Size(234, 17)
        Me.SubTitleLabel.TabIndex = 32
        Me.SubTitleLabel.Text = "Your connection to this site is secure."
        '
        'CertDiag
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 146)
        Me.Controls.Add(Me.SubTitleLabel)
        Me.Controls.Add(Me.SecLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ViewCertButton)
        Me.Controls.Add(Me.OKButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CertDiag"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Site Security"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OKButton As Button
    Friend WithEvents ViewCertButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SecLabel As Label
    Friend WithEvents SubTitleLabel As Label
End Class
