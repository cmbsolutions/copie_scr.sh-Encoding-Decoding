﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.pFile = New System.Windows.Forms.Panel()
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.pFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Drop file here"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pick a file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "copie_scr"
        Me.ofd.Filter = "Shell files|*.sh|All files|*.*"
        Me.ofd.Title = "Pick a file"
        '
        'pFile
        '
        Me.pFile.AllowDrop = True
        Me.pFile.BackColor = System.Drawing.Color.Transparent
        Me.pFile.BackgroundImage = Global.Copie_scr_decoder_GUI.My.Resources.Resources.border
        Me.pFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pFile.Controls.Add(Me.Label1)
        Me.pFile.Location = New System.Drawing.Point(2, 26)
        Me.pFile.Name = "pFile"
        Me.pFile.Size = New System.Drawing.Size(118, 116)
        Me.pFile.TabIndex = 0
        '
        'rtb
        '
        Me.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb.Location = New System.Drawing.Point(126, 2)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(281, 141)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 145)
        Me.Controls.Add(Me.pFile)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rtb)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(425, 184)
        Me.MinimumSize = New System.Drawing.Size(425, 184)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decoder"
        Me.pFile.ResumeLayout(False)
        Me.pFile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents pFile As Panel
    Friend WithEvents rtb As RichTextBox
End Class