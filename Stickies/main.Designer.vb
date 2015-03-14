<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.sks = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddStickyNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GCInvoker = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'sks
        '
        Me.sks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sks.Location = New System.Drawing.Point(0, 0)
        Me.sks.Margin = New System.Windows.Forms.Padding(0)
        Me.sks.Name = "sks"
        Me.sks.Size = New System.Drawing.Size(172, 25)
        Me.sks.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(172, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 25)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "+"
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStickyNoteToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.CMS.Name = "ContextMenuStrip1"
        Me.CMS.Size = New System.Drawing.Size(151, 48)
        '
        'AddStickyNoteToolStripMenuItem
        '
        Me.AddStickyNoteToolStripMenuItem.Name = "AddStickyNoteToolStripMenuItem"
        Me.AddStickyNoteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AddStickyNoteToolStripMenuItem.Text = "Add Sticky Note"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GCInvoker
        '
        Me.GCInvoker.Enabled = True
        Me.GCInvoker.Interval = 60000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(188, 25)
        Me.Controls.Add(Me.sks)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 25)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(48, 25)
        Me.Name = "Main"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stickies"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.ResumeLayout(False)
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sks As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddStickyNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GCInvoker As System.Windows.Forms.Timer

End Class
