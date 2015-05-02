<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_dashboard))
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_date_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_current_form = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.lbl_logged_in_as = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_server_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_number_of_notifications = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.submenu_toggle_title = New System.Windows.Forms.ToolStripMenuItem()
        Me.CASHPAYMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_post_dated = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPOILEDCHEQUESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(12, 687)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(65, 13)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "<username>"
        Me.lbl_username.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_date_time, Me.lbl_current_form, Me.lbl_progress, Me.lbl_logged_in_as, Me.lbl_server_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 726)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1364, 24)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_date_time
        '
        Me.lbl_date_time.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_date_time.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lbl_date_time.Name = "lbl_date_time"
        Me.lbl_date_time.Size = New System.Drawing.Size(74, 19)
        Me.lbl_date_time.Text = "<datetime>"
        '
        'lbl_current_form
        '
        Me.lbl_current_form.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_current_form.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lbl_current_form.Name = "lbl_current_form"
        Me.lbl_current_form.Size = New System.Drawing.Size(96, 19)
        Me.lbl_current_form.Text = "<current_form>"
        '
        'lbl_progress
        '
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(100, 18)
        '
        'lbl_logged_in_as
        '
        Me.lbl_logged_in_as.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_logged_in_as.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lbl_logged_in_as.Name = "lbl_logged_in_as"
        Me.lbl_logged_in_as.Size = New System.Drawing.Size(91, 19)
        Me.lbl_logged_in_as.Text = "<logged in as>"
        '
        'lbl_server_status
        '
        Me.lbl_server_status.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_server_status.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lbl_server_status.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_server_status.Name = "lbl_server_status"
        Me.lbl_server_status.Size = New System.Drawing.Size(99, 19)
        Me.lbl_server_status.Text = "<server status>"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.vigattin.My.Resources.Resources.brushed_alu
        Me.Panel1.Controls.Add(Me.lbl_number_of_notifications)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1364, 90)
        Me.Panel1.TabIndex = 6
        '
        'lbl_number_of_notifications
        '
        Me.lbl_number_of_notifications.AutoSize = True
        Me.lbl_number_of_notifications.BackColor = System.Drawing.Color.Red
        Me.lbl_number_of_notifications.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_number_of_notifications.Location = New System.Drawing.Point(198, 46)
        Me.lbl_number_of_notifications.Name = "lbl_number_of_notifications"
        Me.lbl_number_of_notifications.Size = New System.Drawing.Size(14, 13)
        Me.lbl_number_of_notifications.TabIndex = 3
        Me.lbl_number_of_notifications.Text = "1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.vigattin.My.Resources.Resources.menu_bg_a
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CASHPAYMENTToolStripMenuItem, Me.menu_post_dated, Me.SPOILEDCHEQUESToolStripMenuItem, Me.ToolStripMenuItem1, Me.USERSToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.BACKUPToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 40)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1364, 50)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_toggle_title})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 26)
        '
        'submenu_toggle_title
        '
        Me.submenu_toggle_title.Name = "submenu_toggle_title"
        Me.submenu_toggle_title.Size = New System.Drawing.Size(142, 22)
        Me.submenu_toggle_title.Text = "Hide title bar"
        '
        'CASHPAYMENTToolStripMenuItem
        '
        Me.CASHPAYMENTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CASHPAYMENTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CASHPAYMENTToolStripMenuItem.Name = "CASHPAYMENTToolStripMenuItem"
        Me.CASHPAYMENTToolStripMenuItem.Size = New System.Drawing.Size(111, 46)
        Me.CASHPAYMENTToolStripMenuItem.Text = "CHECK BALANCE"
        '
        'menu_post_dated
        '
        Me.menu_post_dated.Checked = True
        Me.menu_post_dated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_post_dated.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.menu_post_dated.ForeColor = System.Drawing.Color.White
        Me.menu_post_dated.Name = "menu_post_dated"
        Me.menu_post_dated.Size = New System.Drawing.Size(100, 46)
        Me.menu_post_dated.Text = "POST DATED   "
        Me.menu_post_dated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SPOILEDCHEQUESToolStripMenuItem
        '
        Me.SPOILEDCHEQUESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SPOILEDCHEQUESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SPOILEDCHEQUESToolStripMenuItem.Name = "SPOILEDCHEQUESToolStripMenuItem"
        Me.SPOILEDCHEQUESToolStripMenuItem.Size = New System.Drawing.Size(114, 46)
        Me.SPOILEDCHEQUESToolStripMenuItem.Text = "SPOILED CHECKS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 46)
        Me.ToolStripMenuItem1.Text = "VOUCHER"
        '
        'USERSToolStripMenuItem
        '
        Me.USERSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.USERSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        Me.USERSToolStripMenuItem.Size = New System.Drawing.Size(136, 46)
        Me.USERSToolStripMenuItem.Text = "USER MANAGEMENT"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(68, 46)
        Me.LogoutToolStripMenuItem.Text = "LOGOUT"
        '
        'BACKUPToolStripMenuItem
        '
        Me.BACKUPToolStripMenuItem.Checked = True
        Me.BACKUPToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BACKUPToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BACKUPToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BACKUPToolStripMenuItem.Name = "BACKUPToolStripMenuItem"
        Me.BACKUPToolStripMenuItem.Size = New System.Drawing.Size(66, 46)
        Me.BACKUPToolStripMenuItem.Text = "BACKUP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VIGATTIN ACCOUNTING INFORMATION SYSTEM"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Checked = True
        Me.ToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(70, 46)
        Me.ToolStripMenuItem2.Text = "PAYROLL"
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbl_username)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "admin_dashboard"
        Me.Text = "admin_dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CASHPAYMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_post_dated As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_date_time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_current_form As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SPOILEDCHEQUESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents USERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_logged_in_as As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_server_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents submenu_toggle_title As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_number_of_notifications As System.Windows.Forms.Label
    Friend WithEvents BACKUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
