<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup_frm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txt_comment = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_backup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_restore = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.list_backup = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.list_backup)
        Me.SplitContainer1.Size = New System.Drawing.Size(1316, 642)
        Me.SplitContainer1.SplitterDistance = 39
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.vigattin.My.Resources.Resources.menu_bg_a
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txt_comment, Me.btn_backup, Me.ToolStripSeparator5, Me.btn_restore, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 9)
        Me.ToolStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1316, 30)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txt_comment
        '
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(300, 30)
        Me.txt_comment.ToolTipText = "Comments. this field is optional"
        '
        'btn_backup
        '
        Me.btn_backup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_backup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_backup.ForeColor = System.Drawing.Color.White
        Me.btn_backup.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_backup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(58, 27)
        Me.btn_backup.Text = "BACKUP"
        Me.btn_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'btn_restore
        '
        Me.btn_restore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_restore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_restore.ForeColor = System.Drawing.Color.White
        Me.btn_restore.Image = CType(resources.GetObject("btn_restore.Image"), System.Drawing.Image)
        Me.btn_restore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(62, 27)
        Me.btn_restore.Text = "RESTORE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'list_backup
        '
        Me.list_backup.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_backup.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.list_backup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.col_date, Me.col_comment, Me.ColumnHeader1})
        Me.list_backup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_backup.FullRowSelect = True
        Me.list_backup.HideSelection = False
        Me.list_backup.Location = New System.Drawing.Point(0, 0)
        Me.list_backup.Name = "list_backup"
        Me.list_backup.RightToLeftLayout = True
        Me.list_backup.Size = New System.Drawing.Size(1316, 599)
        Me.list_backup.TabIndex = 1
        Me.list_backup.UseCompatibleStateImageBehavior = False
        Me.list_backup.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'col_date
        '
        Me.col_date.Text = "backup date"
        Me.col_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_date.Width = 409
        '
        'col_comment
        '
        Me.col_comment.DisplayIndex = 2
        Me.col_comment.Text = "Comment"
        Me.col_comment.Width = 290
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 3
        Me.ColumnHeader1.Text = "name"
        Me.ColumnHeader1.Width = 229
        '
        'backup_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backup_frm"
        Me.Padding = New System.Windows.Forms.Padding(20, 50, 20, 20)
        Me.Text = "BACKUP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents list_backup As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txt_comment As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btn_backup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_restore As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents col_comment As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
