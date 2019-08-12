<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnstartstop = New System.Windows.Forms.Button()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.updatetimer = New System.Windows.Forms.Timer(Me.components)
        Me.Speedcontrol = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Speedcontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstartstop
        '
        Me.btnstartstop.Location = New System.Drawing.Point(1202, 99)
        Me.btnstartstop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnstartstop.Name = "btnstartstop"
        Me.btnstartstop.Size = New System.Drawing.Size(64, 33)
        Me.btnstartstop.TabIndex = 0
        Me.btnstartstop.Text = "Start"
        Me.btnstartstop.UseVisualStyleBackColor = True
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Location = New System.Drawing.Point(1227, 200)
        Me.lblx.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(0, 13)
        Me.lblx.TabIndex = 1
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Location = New System.Drawing.Point(1227, 228)
        Me.lbly.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(0, 13)
        Me.lbly.TabIndex = 2
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(1202, 171)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
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
        Me.Speedcontrol.Location = New System.Drawing.Point(1144, 377)
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
        Me.Label1.Location = New System.Drawing.Point(1192, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Speed"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 647)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Speedcontrol)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lbly)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.btnstartstop)
        Me.Name = "Form1"
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
End Class
