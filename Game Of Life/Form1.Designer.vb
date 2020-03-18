<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnstartstop = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.updatetimer = New System.Windows.Forms.Timer(Me.components)
        Me.Speedcontrol = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltimebetween = New System.Windows.Forms.Label()
        Me.btnpreset = New System.Windows.Forms.Button()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tickspeedcalculator = New System.Windows.Forms.Timer(Me.components)
        Me.lbltickspeed = New System.Windows.Forms.Label()
        Me.btnchangemusic = New System.Windows.Forms.Button()
        Me.lstboxsorted = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncancelpresetplacement = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnmusic = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Speedcontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstartstop
        '
        Me.btnstartstop.BackColor = System.Drawing.Color.Transparent
        Me.btnstartstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstartstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstartstop.ForeColor = System.Drawing.Color.Lime
        Me.btnstartstop.Location = New System.Drawing.Point(1604, 185)
        Me.btnstartstop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnstartstop.Name = "btnstartstop"
        Me.btnstartstop.Size = New System.Drawing.Size(101, 67)
        Me.btnstartstop.TabIndex = 0
        Me.btnstartstop.Text = "Start"
        Me.btnstartstop.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Transparent
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Red
        Me.btnreset.Location = New System.Drawing.Point(1756, 185)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(101, 67)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'updatetimer
        '
        Me.updatetimer.Interval = 1
        '
        'Speedcontrol
        '
        Me.Speedcontrol.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Speedcontrol.Location = New System.Drawing.Point(1637, 347)
        Me.Speedcontrol.Maximum = 1000
        Me.Speedcontrol.Minimum = 1
        Me.Speedcontrol.Name = "Speedcontrol"
        Me.Speedcontrol.Size = New System.Drawing.Size(217, 45)
        Me.Speedcontrol.TabIndex = 4
        Me.Speedcontrol.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1612, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Time between updates(ms)"
        '
        'lbltimebetween
        '
        Me.lbltimebetween.AutoSize = True
        Me.lbltimebetween.BackColor = System.Drawing.Color.Transparent
        Me.lbltimebetween.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltimebetween.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimebetween.Location = New System.Drawing.Point(1729, 395)
        Me.lbltimebetween.Name = "lbltimebetween"
        Me.lbltimebetween.Size = New System.Drawing.Size(24, 25)
        Me.lbltimebetween.TabIndex = 6
        Me.lbltimebetween.Text = "1"
        '
        'btnpreset
        '
        Me.btnpreset.BackColor = System.Drawing.Color.Transparent
        Me.btnpreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpreset.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreset.ForeColor = System.Drawing.Color.Black
        Me.btnpreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpreset.Location = New System.Drawing.Point(1455, 682)
        Me.btnpreset.Name = "btnpreset"
        Me.btnpreset.Size = New System.Drawing.Size(321, 128)
        Me.btnpreset.TabIndex = 8
        Me.btnpreset.Text = "Preset patterns"
        Me.btnpreset.UseVisualStyleBackColor = False
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.Color.Transparent
        Me.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnopen.ForeColor = System.Drawing.Color.Yellow
        Me.btnopen.Location = New System.Drawing.Point(1617, 826)
        Me.btnopen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(240, 66)
        Me.btnopen.TabIndex = 11
        Me.btnopen.Text = "Import Grid"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsave.Location = New System.Drawing.Point(1198, 826)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(240, 66)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Export Grid"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label4.Location = New System.Drawing.Point(1623, 436)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Updates per second:"
        '
        'Tickspeedcalculator
        '
        Me.Tickspeedcalculator.Interval = 1000
        '
        'lbltickspeed
        '
        Me.lbltickspeed.AutoSize = True
        Me.lbltickspeed.BackColor = System.Drawing.Color.Transparent
        Me.lbltickspeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltickspeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbltickspeed.Location = New System.Drawing.Point(1854, 436)
        Me.lbltickspeed.Name = "lbltickspeed"
        Me.lbltickspeed.Size = New System.Drawing.Size(0, 25)
        Me.lbltickspeed.TabIndex = 15
        '
        'btnchangemusic
        '
        Me.btnchangemusic.BackColor = System.Drawing.Color.Transparent
        Me.btnchangemusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchangemusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangemusic.ForeColor = System.Drawing.Color.Maroon
        Me.btnchangemusic.Location = New System.Drawing.Point(1617, 29)
        Me.btnchangemusic.Name = "btnchangemusic"
        Me.btnchangemusic.Size = New System.Drawing.Size(113, 64)
        Me.btnchangemusic.TabIndex = 17
        Me.btnchangemusic.Text = "Change Music"
        Me.btnchangemusic.UseVisualStyleBackColor = False
        '
        'lstboxsorted
        '
        Me.lstboxsorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxsorted.FormattingEnabled = True
        Me.lstboxsorted.ItemHeight = 20
        Me.lstboxsorted.Location = New System.Drawing.Point(1029, 54)
        Me.lstboxsorted.Name = "lstboxsorted"
        Me.lstboxsorted.Size = New System.Drawing.Size(532, 464)
        Me.lstboxsorted.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1095, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Loaded usernames this session"
        '
        'btncancelpresetplacement
        '
        Me.btncancelpresetplacement.BackColor = System.Drawing.Color.Transparent
        Me.btncancelpresetplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelpresetplacement.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelpresetplacement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncancelpresetplacement.Location = New System.Drawing.Point(1273, 524)
        Me.btncancelpresetplacement.Name = "btncancelpresetplacement"
        Me.btncancelpresetplacement.Size = New System.Drawing.Size(184, 80)
        Me.btncancelpresetplacement.TabIndex = 21
        Me.btncancelpresetplacement.Text = "Cancel Preset Placement"
        Me.btncancelpresetplacement.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Game_Of_Life.My.Resources.Resources.hammer
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(1577, 612)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnmusic
        '
        Me.btnmusic.BackColor = System.Drawing.Color.Transparent
        Me.btnmusic.BackgroundImage = Global.Game_Of_Life.My.Resources.Resources.music
        Me.btnmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmusic.Location = New System.Drawing.Point(1756, 29)
        Me.btnmusic.Name = "btnmusic"
        Me.btnmusic.Size = New System.Drawing.Size(64, 64)
        Me.btnmusic.TabIndex = 16
        Me.btnmusic.UseMnemonic = False
        Me.btnmusic.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Game_Of_Life.My.Resources.Resources.cancel
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1187, 524)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 22
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game_Of_Life.My.Resources.Resources._76291
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1042)
        Me.Controls.Add(Me.btncancelpresetplacement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstboxsorted)
        Me.Controls.Add(Me.btnchangemusic)
        Me.Controls.Add(Me.btnmusic)
        Me.Controls.Add(Me.lbltickspeed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnopen)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnpreset)
        Me.Controls.Add(Me.lbltimebetween)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Speedcontrol)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnstartstop)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "x"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Speedcontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnstartstop As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents updatetimer As Timer
    Friend WithEvents Speedcontrol As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltimebetween As Label
    Friend WithEvents btnpreset As Button
    Friend WithEvents btnopen As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Tickspeedcalculator As Timer
    Friend WithEvents lbltickspeed As Label
    Friend WithEvents btnmusic As Button
    Friend WithEvents btnchangemusic As Button
    Friend WithEvents lstboxsorted As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btncancelpresetplacement As Button
    Friend WithEvents Button3 As Button
End Class
