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
        Me.lblx = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.updatetimer = New System.Windows.Forms.Timer(Me.components)
        Me.Speedcontrol = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnpreset = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnopen = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.RGBtimer0 = New System.Windows.Forms.Timer(Me.components)
        Me.RGBtimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RGBtimer = New System.Windows.Forms.Timer(Me.components)
        Me.RGB = New System.Windows.Forms.CheckBox()
        Me.RGBtimerto1 = New System.Windows.Forms.Timer(Me.components)
        Me.RGBtimerto0 = New System.Windows.Forms.Timer(Me.components)
        Me.SuperCancerRGB = New System.Windows.Forms.CheckBox()
        Me.RGBtimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.RGBtimerto2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Speedcontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstartstop
        '
        Me.btnstartstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstartstop.Location = New System.Drawing.Point(1617, 128)
        Me.btnstartstop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnstartstop.Name = "btnstartstop"
        Me.btnstartstop.Size = New System.Drawing.Size(85, 46)
        Me.btnstartstop.TabIndex = 0
        Me.btnstartstop.Text = "Start"
        Me.btnstartstop.UseVisualStyleBackColor = True
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Location = New System.Drawing.Point(1686, 57)
        Me.lblx.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(0, 13)
        Me.lblx.TabIndex = 1
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Location = New System.Drawing.Point(1686, 85)
        Me.lbly.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(0, 13)
        Me.lbly.TabIndex = 2
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(1720, 128)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(85, 46)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'updatetimer
        '
        Me.updatetimer.Interval = 1
        '
        'Speedcontrol
        '
        Me.Speedcontrol.Location = New System.Drawing.Point(1603, 234)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1612, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Speed (delay in ms)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1612, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1791, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "1000"
        '
        'btnpreset
        '
        Me.btnpreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreset.Location = New System.Drawing.Point(1612, 317)
        Me.btnpreset.Name = "btnpreset"
        Me.btnpreset.Size = New System.Drawing.Size(203, 67)
        Me.btnpreset.TabIndex = 8
        Me.btnpreset.Text = "Preset patterns(no work)"
        Me.btnpreset.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnopen
        '
        Me.btnopen.Location = New System.Drawing.Point(1733, 719)
        Me.btnopen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(61, 38)
        Me.btnopen.TabIndex = 11
        Me.btnopen.Text = "open"
        Me.btnopen.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(1624, 719)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 36)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'RGBtimer0
        '
        Me.RGBtimer0.Interval = 90
        '
        'RGBtimer1
        '
        Me.RGBtimer1.Interval = 90
        '
        'RGBtimer
        '
        Me.RGBtimer.Interval = 90
        '
        'RGB
        '
        Me.RGB.AutoSize = True
        Me.RGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGB.Location = New System.Drawing.Point(1624, 425)
        Me.RGB.Name = "RGB"
        Me.RGB.Size = New System.Drawing.Size(92, 35)
        Me.RGB.TabIndex = 12
        Me.RGB.Text = "RGB"
        Me.RGB.UseVisualStyleBackColor = True
        '
        'RGBtimerto1
        '
        Me.RGBtimerto1.Interval = 30
        '
        'RGBtimerto0
        '
        Me.RGBtimerto0.Interval = 30
        '
        'SuperCancerRGB
        '
        Me.SuperCancerRGB.AutoSize = True
        Me.SuperCancerRGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperCancerRGB.Location = New System.Drawing.Point(1617, 480)
        Me.SuperCancerRGB.Name = "SuperCancerRGB"
        Me.SuperCancerRGB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SuperCancerRGB.Size = New System.Drawing.Size(176, 35)
        Me.SuperCancerRGB.TabIndex = 13
        Me.SuperCancerRGB.Text = "Vomit Mode"
        Me.SuperCancerRGB.UseVisualStyleBackColor = True
        '
        'RGBtimer2
        '
        Me.RGBtimer2.Interval = 25
        '
        'RGBtimerto2
        '
        Me.RGBtimerto2.Interval = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1042)
        Me.Controls.Add(Me.SuperCancerRGB)
        Me.Controls.Add(Me.RGB)
        Me.Controls.Add(Me.btnopen)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnpreset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Speedcontrol)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lbly)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.btnstartstop)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Speedcontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnstartstop As Button
    Friend WithEvents lblx As Label
    Friend WithEvents lbly As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents updatetimer As Timer
    Friend WithEvents Speedcontrol As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnpreset As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnopen As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents RGBtimer0 As Timer
    Friend WithEvents RGBtimer1 As Timer
    Friend WithEvents RGBtimer As Timer
    Friend WithEvents RGB As CheckBox
    Friend WithEvents RGBtimerto1 As Timer
    Friend WithEvents RGBtimerto0 As Timer
    Friend WithEvents SuperCancerRGB As CheckBox
    Friend WithEvents RGBtimer2 As Timer
    Friend WithEvents RGBtimerto2 As Timer
End Class
