﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presetchooser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncenter = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btneditname = New System.Windows.Forms.Button()
        Me.btnsavepreset = New System.Windows.Forms.Button()
        Me.rbtnpreset6 = New System.Windows.Forms.RadioButton()
        Me.rbtnpreset5 = New System.Windows.Forms.RadioButton()
        Me.rbtnpreset4 = New System.Windows.Forms.RadioButton()
        Me.rbtnpreset3 = New System.Windows.Forms.RadioButton()
        Me.rbtnpreset2 = New System.Windows.Forms.RadioButton()
        Me.rbtnpreset1 = New System.Windows.Forms.RadioButton()
        Me.btnresetgrid = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncenter)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btneditname)
        Me.GroupBox1.Controls.Add(Me.btnsavepreset)
        Me.GroupBox1.Controls.Add(Me.rbtnpreset6)
        Me.GroupBox1.Controls.Add(Me.rbtnpreset5)
        Me.GroupBox1.Controls.Add(Me.rbtnpreset4)
        Me.GroupBox1.Controls.Add(Me.rbtnpreset3)
        Me.GroupBox1.Controls.Add(Me.rbtnpreset2)
        Me.GroupBox1.Controls.Add(Me.rbtnpreset1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(1082, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 1037)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Preset"
        '
        'btncenter
        '
        Me.btncenter.Location = New System.Drawing.Point(24, 645)
        Me.btncenter.Name = "btncenter"
        Me.btncenter.Size = New System.Drawing.Size(131, 46)
        Me.btncenter.TabIndex = 10
        Me.btncenter.Text = "Set Center"
        Me.btncenter.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(225, 634)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(125, 69)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save Data to File"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btneditname
        '
        Me.btneditname.Location = New System.Drawing.Point(292, 553)
        Me.btneditname.Name = "btneditname"
        Me.btneditname.Size = New System.Drawing.Size(223, 75)
        Me.btneditname.TabIndex = 7
        Me.btneditname.Text = "Edit Pattern Name"
        Me.btneditname.UseVisualStyleBackColor = True
        '
        'btnsavepreset
        '
        Me.btnsavepreset.Location = New System.Drawing.Point(7, 553)
        Me.btnsavepreset.Name = "btnsavepreset"
        Me.btnsavepreset.Size = New System.Drawing.Size(279, 75)
        Me.btnsavepreset.TabIndex = 6
        Me.btnsavepreset.Text = "Save Current grid to Preset"
        Me.btnsavepreset.UseVisualStyleBackColor = True
        '
        'rbtnpreset6
        '
        Me.rbtnpreset6.AutoSize = True
        Me.rbtnpreset6.Location = New System.Drawing.Point(292, 408)
        Me.rbtnpreset6.Name = "rbtnpreset6"
        Me.rbtnpreset6.Size = New System.Drawing.Size(105, 30)
        Me.rbtnpreset6.TabIndex = 5
        Me.rbtnpreset6.TabStop = True
        Me.rbtnpreset6.Text = "Preset6"
        Me.rbtnpreset6.UseVisualStyleBackColor = True
        '
        'rbtnpreset5
        '
        Me.rbtnpreset5.AutoSize = True
        Me.rbtnpreset5.Location = New System.Drawing.Point(292, 260)
        Me.rbtnpreset5.Name = "rbtnpreset5"
        Me.rbtnpreset5.Size = New System.Drawing.Size(105, 30)
        Me.rbtnpreset5.TabIndex = 4
        Me.rbtnpreset5.TabStop = True
        Me.rbtnpreset5.Text = "Preset5"
        Me.rbtnpreset5.UseVisualStyleBackColor = True
        '
        'rbtnpreset4
        '
        Me.rbtnpreset4.AutoSize = True
        Me.rbtnpreset4.Location = New System.Drawing.Point(292, 104)
        Me.rbtnpreset4.Name = "rbtnpreset4"
        Me.rbtnpreset4.Size = New System.Drawing.Size(105, 30)
        Me.rbtnpreset4.TabIndex = 3
        Me.rbtnpreset4.TabStop = True
        Me.rbtnpreset4.Text = "Preset4"
        Me.rbtnpreset4.UseVisualStyleBackColor = True
        '
        'rbtnpreset3
        '
        Me.rbtnpreset3.AutoSize = True
        Me.rbtnpreset3.Location = New System.Drawing.Point(6, 408)
        Me.rbtnpreset3.Name = "rbtnpreset3"
        Me.rbtnpreset3.Size = New System.Drawing.Size(105, 30)
        Me.rbtnpreset3.TabIndex = 2
        Me.rbtnpreset3.TabStop = True
        Me.rbtnpreset3.Text = "Preset3"
        Me.rbtnpreset3.UseVisualStyleBackColor = True
        '
        'rbtnpreset2
        '
        Me.rbtnpreset2.AutoSize = True
        Me.rbtnpreset2.Location = New System.Drawing.Point(6, 260)
        Me.rbtnpreset2.Name = "rbtnpreset2"
        Me.rbtnpreset2.Size = New System.Drawing.Size(105, 30)
        Me.rbtnpreset2.TabIndex = 1
        Me.rbtnpreset2.TabStop = True
        Me.rbtnpreset2.Text = "Preset2"
        Me.rbtnpreset2.UseVisualStyleBackColor = True
        '
        'rbtnpreset1
        '
        Me.rbtnpreset1.AutoSize = True
        Me.rbtnpreset1.Location = New System.Drawing.Point(6, 104)
        Me.rbtnpreset1.Name = "rbtnpreset1"
        Me.rbtnpreset1.Size = New System.Drawing.Size(105, 30)
        Me.rbtnpreset1.TabIndex = 0
        Me.rbtnpreset1.TabStop = True
        Me.rbtnpreset1.Text = "Preset1"
        Me.rbtnpreset1.UseVisualStyleBackColor = True
        '
        'btnresetgrid
        '
        Me.btnresetgrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnresetgrid.Location = New System.Drawing.Point(335, 925)
        Me.btnresetgrid.Name = "btnresetgrid"
        Me.btnresetgrid.Size = New System.Drawing.Size(125, 69)
        Me.btnresetgrid.TabIndex = 9
        Me.btnresetgrid.Text = "Reset Grid"
        Me.btnresetgrid.UseVisualStyleBackColor = True
        '
        'Presetchooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1042)
        Me.Controls.Add(Me.btnresetgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Presetchooser"
        Me.Text = "Presetchooser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btngrid0 As Button
    Friend WithEvents rbtn1 As RadioButton
    Friend WithEvents btngrid1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnpreset6 As RadioButton
    Friend WithEvents rbtnpreset5 As RadioButton
    Friend WithEvents rbtnpreset4 As RadioButton
    Friend WithEvents rbtnpreset3 As RadioButton
    Friend WithEvents rbtnpreset2 As RadioButton
    Friend WithEvents rbtnpreset1 As RadioButton
    Friend WithEvents btneditname As Button
    Friend WithEvents btnsavepreset As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnresetgrid As Button
    Friend WithEvents btncenter As Button
End Class
