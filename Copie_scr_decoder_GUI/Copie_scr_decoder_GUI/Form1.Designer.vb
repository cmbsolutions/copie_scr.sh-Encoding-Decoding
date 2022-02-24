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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.pFile = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImportReadableFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.bEnc = New System.Windows.Forms.Button()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.scEditor = New ScintillaNET.Scintilla()
        Me.pFile.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(19, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Drop file here"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(2, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pick a file"
        Me.Button1.UseVisualStyleBackColor = False
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportReadableFileToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 26)
        '
        'ImportReadableFileToolStripMenuItem
        '
        Me.ImportReadableFileToolStripMenuItem.Name = "ImportReadableFileToolStripMenuItem"
        Me.ImportReadableFileToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ImportReadableFileToolStripMenuItem.Text = "Import readable file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(2, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "En/De-coding secret:"
        '
        'cb1
        '
        Me.cb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"--Auto--", "001BE3AC", "00EBAEBA"})
        Me.cb1.Location = New System.Drawing.Point(2, 192)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(118, 23)
        Me.cb1.TabIndex = 3
        '
        'bEnc
        '
        Me.bEnc.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.bEnc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.bEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEnc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bEnc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bEnc.Location = New System.Drawing.Point(2, 148)
        Me.bEnc.Name = "bEnc"
        Me.bEnc.Size = New System.Drawing.Size(118, 23)
        Me.bEnc.TabIndex = 4
        Me.bEnc.Text = "Encode"
        Me.bEnc.UseVisualStyleBackColor = False
        '
        'sfd
        '
        Me.sfd.DefaultExt = "sh"
        Me.sfd.FileName = "copie_scr.sh"
        Me.sfd.Filter = "Sh Files|*.sh|All Files|*.*"
        Me.sfd.Title = "Save encoded file"
        '
        'scEditor
        '
        Me.scEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scEditor.AutoCMaxHeight = 9
        Me.scEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scEditor.ContextMenuStrip = Me.ContextMenuStrip1
        Me.scEditor.EolMode = ScintillaNET.Eol.Lf
        Me.scEditor.IndentationGuides = ScintillaNET.IndentView.LookBoth
        Me.scEditor.Lexer = ScintillaNET.Lexer.Cpp
        Me.scEditor.Location = New System.Drawing.Point(123, 1)
        Me.scEditor.Name = "scEditor"
        Me.scEditor.Size = New System.Drawing.Size(502, 394)
        Me.scEditor.TabIndex = 5
        Me.scEditor.VirtualSpaceOptions = CType((ScintillaNET.VirtualSpace.RectangularSelection Or ScintillaNET.VirtualSpace.NoWrapLineStart), ScintillaNET.VirtualSpace)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 396)
        Me.Controls.Add(Me.scEditor)
        Me.Controls.Add(Me.bEnc)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pFile)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MinimumSize = New System.Drawing.Size(300, 256)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VW RNS850 & Audi MMI Copie_scr.sh (en/de)coder"
        Me.pFile.ResumeLayout(False)
        Me.pFile.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents pFile As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents bEnc As Button
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ImportReadableFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents scEditor As ScintillaNET.Scintilla
End Class
