﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "The computer will caculate the cost of your fencing."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "5) Now select the caculate button. "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "If at any time you enter somethink wrong click the clear button and start over ag" & _
            "ain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "3) Enter the length of your garden"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "2) Select the type of fencing you would like."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "1) Select the shape of your garden."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Follow the instructions below for help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Help"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(378, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "4) Enter the width of your garden (only if the shape of your garden is rectangle)" & _
            "."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 522)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
