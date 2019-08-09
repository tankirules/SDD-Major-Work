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
        Me.btnstartstop = New System.Windows.Forms.Button()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnstartstop
        '
        Me.btnstartstop.Location = New System.Drawing.Point(1157, 123)
        Me.btnstartstop.Name = "btnstartstop"
        Me.btnstartstop.Size = New System.Drawing.Size(96, 51)
        Me.btnstartstop.TabIndex = 0
        Me.btnstartstop.Text = "Start"
        Me.btnstartstop.UseVisualStyleBackColor = True
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Location = New System.Drawing.Point(1194, 278)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(0, 20)
        Me.lblx.TabIndex = 1
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Location = New System.Drawing.Point(1194, 321)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(0, 20)
        Me.lbly.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 692)
        Me.Controls.Add(Me.lbly)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.btnstartstop)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnstartstop As Button
    Friend WithEvents lblx As Label
    Friend WithEvents lbly As Label
End Class
