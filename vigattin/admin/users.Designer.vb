<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(users))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_account_type = New System.Windows.Forms.ComboBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_clear_fields = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_update = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_delete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.list_users = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_delete_filter = New System.Windows.Forms.Button()
        Me.btn_filter_username = New System.Windows.Forms.Button()
        Me.query_username = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.list_log = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1316, 672)
        Me.SplitContainer1.SplitterDistance = 158
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.SplitContainer2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1316, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USERS"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txt_account_type)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txt_password)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txt_username)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.list_users)
        Me.SplitContainer2.Size = New System.Drawing.Size(1310, 139)
        Me.SplitContainer2.SplitterDistance = 468
        Me.SplitContainer2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ACCOUNT TYPE:"
        '
        'txt_account_type
        '
        Me.txt_account_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_account_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_account_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_account_type.FormattingEnabled = True
        Me.txt_account_type.Items.AddRange(New Object() {"accounting"})
        Me.txt_account_type.Location = New System.Drawing.Point(120, 67)
        Me.txt_account_type.Name = "txt_account_type"
        Me.txt_account_type.Size = New System.Drawing.Size(301, 21)
        Me.txt_account_type.TabIndex = 37
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(121, 41)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(300, 20)
        Me.txt_password.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "PASSWORD:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(121, 15)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(300, 20)
        Me.txt_username.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "USERNAME:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.vigattin.My.Resources.Resources.menu_bg_a
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_clear_fields, Me.ToolStripSeparator5, Me.btn_add, Me.ToolStripSeparator4, Me.btn_update, Me.ToolStripSeparator2, Me.btn_delete, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 109)
        Me.ToolStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(468, 30)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_clear_fields
        '
        Me.btn_clear_fields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_clear_fields.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_clear_fields.ForeColor = System.Drawing.Color.White
        Me.btn_clear_fields.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_clear_fields.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clear_fields.Name = "btn_clear_fields"
        Me.btn_clear_fields.Size = New System.Drawing.Size(87, 27)
        Me.btn_clear_fields.Text = "CLEAR FIELDS"
        Me.btn_clear_fields.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'btn_add
        '
        Me.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(37, 27)
        Me.btn_add.Text = "ADD"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'btn_update
        '
        Me.btn_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(57, 27)
        Me.btn_update.Text = "UPDATE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'btn_delete
        '
        Me.btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(51, 27)
        Me.btn_delete.Text = "DELETE"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(61, 27)
        Me.ToolStripButton1.Text = "REFRESH"
        '
        'list_users
        '
        Me.list_users.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_users.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.list_users.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.list_users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_users.FullRowSelect = True
        Me.list_users.HideSelection = False
        Me.list_users.Location = New System.Drawing.Point(0, 0)
        Me.list_users.Name = "list_users"
        Me.list_users.RightToLeftLayout = True
        Me.list_users.Size = New System.Drawing.Size(838, 139)
        Me.list_users.TabIndex = 1
        Me.list_users.UseCompatibleStateImageBehavior = False
        Me.list_users.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "USERNAME"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ACCOUNT TYPE"
        Me.ColumnHeader2.Width = 185
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "LOGGIN STATUS"
        Me.ColumnHeader3.Width = 112
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SplitContainer3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1316, 510)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USERS LOG TRAIL"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.list_log)
        Me.SplitContainer3.Size = New System.Drawing.Size(1310, 491)
        Me.SplitContainer3.SplitterDistance = 69
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btn_delete_filter)
        Me.GroupBox3.Controls.Add(Me.btn_filter_username)
        Me.GroupBox3.Controls.Add(Me.query_username)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1310, 69)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FILTER"
        '
        'btn_delete_filter
        '
        Me.btn_delete_filter.Location = New System.Drawing.Point(339, 33)
        Me.btn_delete_filter.Name = "btn_delete_filter"
        Me.btn_delete_filter.Size = New System.Drawing.Size(77, 23)
        Me.btn_delete_filter.TabIndex = 48
        Me.btn_delete_filter.Text = "DELETE"
        Me.btn_delete_filter.UseVisualStyleBackColor = True
        '
        'btn_filter_username
        '
        Me.btn_filter_username.Location = New System.Drawing.Point(256, 33)
        Me.btn_filter_username.Name = "btn_filter_username"
        Me.btn_filter_username.Size = New System.Drawing.Size(77, 23)
        Me.btn_filter_username.TabIndex = 46
        Me.btn_filter_username.Text = "FILTER"
        Me.btn_filter_username.UseVisualStyleBackColor = True
        '
        'query_username
        '
        Me.query_username.Location = New System.Drawing.Point(50, 36)
        Me.query_username.Name = "query_username"
        Me.query_username.Size = New System.Drawing.Size(200, 20)
        Me.query_username.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "USERNAME:"
        '
        'list_log
        '
        Me.list_log.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_log.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.list_log.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.list_log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_log.FullRowSelect = True
        Me.list_log.HideSelection = False
        Me.list_log.Location = New System.Drawing.Point(0, 0)
        Me.list_log.Name = "list_log"
        Me.list_log.RightToLeftLayout = True
        Me.list_log.Size = New System.Drawing.Size(1310, 418)
        Me.list_log.TabIndex = 2
        Me.list_log.UseCompatibleStateImageBehavior = False
        Me.list_log.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "USERNAME"
        Me.ColumnHeader4.Width = 229
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ACTION DETAILS"
        Me.ColumnHeader6.Width = 335
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DATE AND TIME"
        Me.ColumnHeader7.Width = 169
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = ""
        Me.ColumnHeader8.Width = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vigattin.My.Resources.Resources.brushed_alu
        Me.ClientSize = New System.Drawing.Size(1356, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "users"
        Me.Padding = New System.Windows.Forms.Padding(20, 50, 20, 20)
        Me.Text = "users"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents list_users As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_clear_fields As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_update As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_account_type As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents query_username As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents list_log As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_filter_username As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_delete_filter As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
