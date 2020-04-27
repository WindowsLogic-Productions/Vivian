<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WhatsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhatsNew))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"~Version 10.3.3.1~", "1. Fixed a bug where 'Clear' would not work on the address and search bar.", "2. Fixed a bug where 'Undo' would not work on the address and search bar.", "", "~Version 10.3.3.0~", "1. Fixed a bug where 'Web Studio' would not open WSHD or WSCD files.", "2. Added defined list of formats to the 'Open' option on the main window.", "3. Added 'Undo' and 'Clear' options to the address and search bar.", "", "~Version 10.3.2.0~", "1. Fixed a bug where the title would not update sometimes on the 'About' dialogue" &
                ".", "2. Fixed a bug where 'Web Studio' would not save a document.", "3. Fixed a bug where 'Web Studio' would go behind the main browser window.", "4. Fixed a bug where opening a link in a new window would not work.", "5. Fixed a bug where 'Quick Start' would not show on the title of the main window" &
                " when visible.", "6. Updated 'Pin' user interface.", "7. Updated 'Settings Panel > Updates' user interface.", "8. 'About' dialogue now closes when clicking the 'Software Agreement' link.", "9. Removed end of support message.", "", "~Version 10.3.1.1~", "1. Fixed a bug where opening 'Site Security' when nothing was in the address bar " &
                "caused", "a false encryption status.", "2. Added ability to double-click history items in 'Settings Panel > History'.", "3. Added ability to double-click pinned items 'Settings Panel > Pins'.", "4. Cleaned up code.", "", "~Version 10.3.1.0~", "1. Added 'Save as...', 'Print', 'Copy', 'Select all', 'Word wrap' and 'Font' opti" &
                "ons to 'Source'.", "2. 'Source' no longer has dialogue properties and can now run as a regular sub-wi" &
                "ndow.", "3. Removed unused settings.", "", "~Version 10.3.0.0~", "1. Cleaned up code.", "2. Fixed a bug where the zoom function was not anchored to the corner of the stat" &
                "us bar.", "3. Fixed a bug where the ""No"" button would not work on 'Delete All Save Data?'", "4. Fixed a bug where 'Help' would not work in 'Web Studio'.", "5. Fixed a bug where clicking a link with, ""#"" would cause an exception.", "6. Updated design of 'Quick Start' and main browser window.", "7. Added new default background.", "8. Removed 'Malicious Content Blocker'.", "", "~Version 10.2.2.0~", "1. Fixed a bug in 'Web Studio' where inserting HTML would only work on first line" &
                ".", "2. Fixed some inconsistencies in the user interface.", "3. Fixed a bug where dialogues would not display properly.", "4. Fixed a bug while in 'Quick Start' where it would not close when opening a pag" &
                "e from 'Pins' or 'History' in 'Settings Panel'.", "5. Fixed a bug where the 'View Certificate' button would completely disable, even" &
                " when opening", "the dialogue on a secure/unsecure website.", "6. Added new icon on the 'Donate' button on 'Quick Start'.", "7. Added ability to zoom in, out and reset zoom.", "8. Added ability to delete cookies, temporary internet files and all saved data.", "9. Fixed a bug where the browser wasn't respecting HTTP or HTTPS values. Sites we" &
                "re still", "connecting securely, but you weren't being shown and that was a problem.", "10. 'Automatic Updates' now connects through HTTPS (even though it did server-sid" &
                "e regardless).", "11. Changed icon for 'Web Studio'.", "12. Help is now online only.", "13. Updated malicious content blocker.", "", "~Version 10.2.1.0~", "1. Fixed a bug which caused an exception when searching on a blank page.", "2. Fixed a bug which would allow HTML tags to be used in the CSS editor on 'Web S" &
                "tudio'.", "3. Added unsaved changes dialogue when choosing 'New' or 'Open' from the 'File' m" &
                "enu on", "'Web Studio'.", "4. Icon on 'Site information' now changes depending on what type of site you're o" &
                "n.", "5. Fixed a bug which would show the old icons for 'Site Information' for a few se" &
                "conds while", "loading a page.", "6. Fixed a bug where trying to save would sometimes not work in 'Web Studio'.", "7. Fixed a bug where 'Web Studio' settings would not reset.", "8. Updated help documentation.", "9. Other various bug fixes and performance improvements.", "", "~Version 10.2.0.1~", "1. Fixed a bug which would stop rendering engine from displaying web sites proper" &
                "ly.", "", "~Version 10.2.0.0~", "1. Added new original icon set.", "2. Renamed 'Favourites' to 'Pins'.", "3. Added Basic HTML tag inserting into 'Web Studio'.", "4. Updated malicious website blocker.", "5. Fixed a bug where typing in the address bar would make the browser navigate ra" &
                "ndomly.", "6. Fixed a bug where the 'Close Tab' button would not close the browser properly " &
                "with one tab", "open.", "7. Fixed the 'Web Studio' settings.", "8. Redesigned 'About' dialogue.", "", "~Version 10.1.1.0~", "1. Moved all 'Web Studio' settings to the 'Settings Panel'.", "2. Added new 'Favourite' dialogue.", "3. Added ability to favourite a page from a link.", "4. Bug fixes and performance improvements.", "", "~Version 10.1.0.2~", "1. Updated malicious website blocker.", "2. Cleaned up code.", "", "~Version 10.1.0.1~", "1. Fixed a bug where 'Select All' would not work on the address and search bar.", "2. Fixed a bug where 'Quick Start' would appear even if start-up settings were ch" &
                "anged.", "3. Updated malicious website blocker.", "4. Custom colours now translate to when you hover over a browser button.", "5. Under the hood improvements to make Vivian more usable.", "", "~Version 10.1.0.0~", "1. Updated to .NET Framework 4.6.1. Windows XP and Vista are no longer supported." &
                "", "2. Under the hood improvements to make the application run faster.", "3. Added 'Background Colour' to 'Web Studio' so you can now change the text edito" &
                "r's", "background colour.", "4. Added 'Word Wrap' to 'Web Studio'.", "5. Changed the design of the 'Web Studio Start' dialogue slightly.", "6. Added link to the 'Settings Panel' in 'Web Studio'.", "7. Added a link to the WLP Software Agreement page on the 'About' dialogue.", "8. Moved the website security link next to the address bar.", "9. Fixed a bug where clicking from tab to tab would not update the address or tit" &
                "le bar.", "10. Fixed a bug where selecting more than 30 characters would cause the right cli" &
                "ck menu", "to become bigger than the screen.", "11. Tab text is now locked to 22 characters.", "12. Added a right click menu for the address bar and search bar.", "13. Hovering over an active tab now displays the full document title.", "14. Added 'Select All' to browser right click menu.", "15. Removed 'Cut' from the browser right click menu as it was useless.", "16. Fixed a bug where the 'Paste' right click menu option would not work in the b" &
                "rowser.", "17. The 'Status Bar' is now smaller so it gets in the way less.", "18. 'Update Prompt' no longer displays in the Taskbar.", "19. Fixed a bug on the 'Updater' where it would disappear if there were no new up" &
                "dates.", "", "~Version 10.0.1.1~", "1. Fixed a bug which would cause an exception when searching on any search engine" &
                ".", "2. Fixed a bug which would not allow you to cut, copy and paste the contents of t" &
                "his application", "on another application.", "3. Fixed a bug where creating new CSS or HTML document on 'Web Studio' would not " &
                "work", "properly.", "4. Updated malicious website blocker.", "5. Changed 'About' dialogue sound.", "", "~Version 10.0.1.0~", "1. Fixed a bug where the back button on the 'Web Studio' Settings Panel would not" &
                " work.", "2. Updated the malicious website blocker.", "3. Updated malicious website blocker dialogue to match the style of the applicati" &
                "on.", "4. Added error sound to error dialogues.", "5. Changed default search engine to DuckDuckGo.", "6. The status bar is now smaller allowing for more of your content to be displaye" &
                "d.", "7. Fixed a bug where DuckDuckGo wouldn't search.", "8. Fixed a bug which would not allow the user to change the home page.", "9. Fixed a bug where 'Quick Start' would not resize when resizing or maximising t" &
                "he window.", "10. Fixed a bug where the minimum size of the main window was not set correctly", "11. Fixed a bug where the save dialogue for 'Web Studio' wouldn't show up.", "12. Fixed a bug where fonts and colours would not work when editing CSS.", "13. Saving from the Unsaved Changes dialogue now shows the correct options.", "14. Fixed a bug which prevented menu options from working when editing CSS on Web" &
                " Studio.", "15. Fixed a bug where typing special characters into the address bar would crash " &
                "the application.", "16. Removed messages that appear when changing font or colour on Web Studio.", "", "~Version 10.0.0.0~", "1. Selecting 'Feedback' from the menu or Quick Start now opens the page in the cu" &
                "rrent tab.", "2. Added browser status and link readability.", "3. Added secure document detector.", "4. Disabled IE context menu and added new context menu.", "5. Added tab context menu.", "6. Vivian now closes when there are no more tabs left to close.", "7. Double-clicking a tab now closes it.", "8. Changed name of 'HTML Studio' to 'Web Studio'. (Web Studio now supports CSS as" &
                " well", "as HTML.)", "9. Added 'Site Security' dialogue to provide more information on site encryption." &
                "", "10. Fixed a bug that would make Windows beep when searching for something.", "11. Added a malicious website blocker which scans a site and then redirects back " &
                "to the", "WindowsLogic website if the site is deemed malicious by the scan.", "", "~Version 9.2.0.0~", "1. Fixed a bug where the browser would not record clicking a link.", "2. Changed some text that still said ""Springboard"".", "3. Added help topics.", "4. 'HTML Studio' now shows an unsaved changes dialogue when you've not saved your" &
                " changes.", "5. 'HTML Studio' can now save in two formats; "".html"" and "".hws"".", "", "~Version 9.1.1.0~", "1. Renamed application to Vivian.", "2. Added new icon for menu.", "3. Buttons are now in a flat style.", "", "~Version 9.1.0.2~", "1. Fixed a bug which caused strange behaviour on websites when first loading them" &
                ".", "2. Added 'Donate' button to 'Quick Start'.", "", "~Version 9.1.0.1~", "1. Cleaned up the system to make the application run a little bit faster.", "2. Fixed a bug on 'Settings Panel' where trying to reset all settings would break" &
                " everything.", "3. Changing your background now changes the background on 'Quick Start'.", "", "~Version 9.1.0.0~", "1. Fixed a bug which stopped the menu on HTML Studio from showing.", "2. Fixed a bug on 'Settings Panel > History' where opening nothing would cause an" &
                " exception.", "3. Fixed a bug on 'Settings Panel > Favourites' where opening nothing would cause" &
                " an exception.", "4. Added a dialogue when added a page to favourites.", "5. Stop button and Home button are now disabled by default, added settings to ena" &
                "ble or disable", "them.", "6. Fixed a bug where the 'Settings Panel' would get stuck behind the main window." &
                "", "7. Updated browser engine to version 11001. This fixed a lot of website compatibi" &
                "lity issues.", "", "~Version 9.0.2.1~", "1. Bug fixes.", "", "~Version 9.0.2.0~", "1. Reverted colour scheme back to the original.", "2. Updated icons.", "3. Removed ability to change button colour as it wasn't needed.", "4. Cleaned up and optimised system.", "5. Bug fixes.", "", "~Version 9.0.1.0~", "1. Fixed a bug where the source code would not display the current web page.", "2. Fixed a bug where clicking a tab would not update the URL in the address bar.", "3. Fixed a bug where changing the colour of buttons would not change the browse b" &
                "utton.", "", "~Version 9.0.0.0~", "1. Renamed the entire application to Vivian.", "2. New default colour is ""Indigo"".", "3. Fixed an issue that was causing tooltips to not work on the main window.", "4. Added ability to choose a custom background.", "5. Added 'Quick Start'.", "6. Added 'DuckDuckGo' as an option in the search settings.", "7. Blurb text at the top of windows now stands out more.", "8. Updated design engine to Fusion 4.5.", "9. Bug fixes.", "", "~Version 8.0.0.0.~", "1. Cleaned up entire interface.", "2. Removed sound when opening different parts of the software.", "3. Updated design engine to Fusion 4.0.", "4. Redesigned 'Settings' and renamed it 'Settings Panel'.", "5. Redesigned the main browser window.", "6. New default colour is ""Slate Blue"".", "7. Added ability to change the colour of buttons.", "", "~Version 7.1.0.0.~", "1. Added 'Start-up' to 'Settings'.", "2. Moved 'Private Browsing' to the 'General' tab in 'Settings'.", "3. Moved 'History' and 'Favourites' into 'Settings'.", "4. Redesigned 'HTML Studio'.", "5. Redesigned icons.", "6. Fixed an issue that caused RAM usage to increase more than usual.", "", "~Version 7.0.0.0.~", "1. Redesigned the automatic updater dialogue.", "2. Redesigned the update prompt dialogue.", "3. Updated legal information in the 'About' dialogue.", "4. Fixed sizing on 'What's New?' dialogue.", "5. Fixed sizing on 'About' dialogue.", "", "~Version 6.0.0.2.~", "1. General fixes.", "", "~Version 6.0.0.1.~", "1. Fixed a few bugs.", "", "~Version 6.0.0.0.~", "1. Redesigned the browser user interface so you can see more of your content.", "2. Added 'Favourite Page' button on main user interface.", "3. Moved all options into one simple menu.", "4. Modified colour options and changed colours.", "5. Removed scrolling text.", "6. Cleaned up code and resources.", "7. Fixed 'Stop' button not working.", "8. Added a 'Delete' button to Favourites.", "9. Added a 'Delete All' button to History.", "10. Cleaned up the user interface in the various nooks and crannys.", "11. Changed 'Update Log' to 'What's New?'.", "", "~Version 5.3.0.0.~", "1. Now you can use the enter key on the address bar and search bar.", "2. Fixed homepage not saving properly.", "3. Fixed the 'Send Feedback' window not fitting some displays.", "4. Fixed 'Favourites' duplicating when favouriting a page.", "", "~Version 5.2.0.0.~", "1. Added 'Sounds' option in 'Settings' so that you can switch the sounds on and o" &
                "ff.", "2. Changed the tooltip for the 'Settings' button from 'Preferences' to 'Settings'" &
                ".", "3. Added shortcut keys for 'About' and 'Favourite current page'.", "4. Changed 'New Tab' and 'Close Tab' buttons by adding corresponding images.", "5. Removed application name from every title except main browser.", "6. Updated 'HTML Creation Station' app.", "7. Changed main buttons on the main browser to fit in better.", "", "~Version 5.1.0.0.~", "1. Added 'New Tab' and 'Close Tab' icons.", "2. Reverted 'Exit' icon in file menu.", "3. Bug fixes.", "", "~Version 5.0.2.1.~", "1. Bug fixes.", "2. Changed 'Exit' icon in file menu.", "", "~Version 5.0.0.0.~", "1. Rebuilt entire browser from the ground up.", "2. Added personlisation so you can pick how the browser looks.", "3. Much cleaner and easier to navigate interface.", "4. Cleaned up old or unused code to make your experience much faster and fluent.", "6. New sounds.", "7. Fixed many bugs that were present in version 4.0.0.0"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 312)
        Me.ListBox1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 53)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPRINGBOARD.My.Resources.Resources.UnlockIco
        Me.PictureBox1.Location = New System.Drawing.Point(458, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(378, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "See what's changed in the application..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WhatsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhatsNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What's New?"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
