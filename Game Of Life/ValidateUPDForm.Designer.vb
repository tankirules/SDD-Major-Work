<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidateUPDForm
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnshowhide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnsubmit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnsubmit.Location = New System.Drawing.Point(136, 155)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(68, 37)
        Me.btnsubmit.TabIndex = 5
        Me.btnsubmit.Text = "submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtpassword.Location = New System.Drawing.Point(111, 117)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(138, 23)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(111, 66)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(138, 23)
        Me.txtusername.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(124, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Importing "
        '
        'btnshowhide
        '
        Me.btnshowhide.FlatAppearance.BorderSize = 0
        Me.btnshowhide.Image = Global.Game_Of_Life.My.Resources.Resources.smallereyes
        Me.btnshowhide.Location = New System.Drawing.Point(254, 113)
        Me.btnshowhide.Name = "btnshowhide"
        Me.btnshowhide.Size = New System.Drawing.Size(30, 30)
        Me.btnshowhide.TabIndex = 9
        Me.btnshowhide.UseVisualStyleBackColor = True
        '
        'ValidateUPDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game_Of_Life.My.Resources.Resources.matrixbackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(314, 291)
        Me.Controls.Add(Me.btnshowhide)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ValidateUPDForm"
        Me.Text = "ValidateUPDForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsubmit As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnshowhide As Button
End Class
