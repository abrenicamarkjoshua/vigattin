<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class post_dated
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(post_dated))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_notification = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_pending_deposits = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_pending_withdraw = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.list_pending_deposits = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_check_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_checkdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_payee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_particulars = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_deposit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.list_pending_withdraws = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1316, 672)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_pending_deposits)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_pending_withdraw)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1316, 215)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SUMMARY"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_notification)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1310, 118)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Notification"
        '
        'lbl_notification
        '
        Me.lbl_notification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_notification.FormattingEnabled = True
        Me.lbl_notification.Location = New System.Drawing.Point(3, 16)
        Me.lbl_notification.Name = "lbl_notification"
        Me.lbl_notification.Size = New System.Drawing.Size(1304, 99)
        Me.lbl_notification.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(173, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "₱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(173, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "₱"
        '
        'lbl_pending_deposits
        '
        Me.lbl_pending_deposits.AutoSize = True
        Me.lbl_pending_deposits.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pending_deposits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pending_deposits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_pending_deposits.Location = New System.Drawing.Point(193, 53)
        Me.lbl_pending_deposits.Name = "lbl_pending_deposits"
        Me.lbl_pending_deposits.Size = New System.Drawing.Size(32, 13)
        Me.lbl_pending_deposits.TabIndex = 4
        Me.lbl_pending_deposits.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(48, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PENDING DEPOSITS: "
        '
        'lbl_pending_withdraw
        '
        Me.lbl_pending_withdraw.AutoSize = True
        Me.lbl_pending_withdraw.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pending_withdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pending_withdraw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_pending_withdraw.Location = New System.Drawing.Point(193, 25)
        Me.lbl_pending_withdraw.Name = "lbl_pending_withdraw"
        Me.lbl_pending_withdraw.Size = New System.Drawing.Size(32, 13)
        Me.lbl_pending_withdraw.TabIndex = 2
        Me.lbl_pending_withdraw.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(32, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENDING WITHDRAWS: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1183, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1316, 453)
        Me.SplitContainer2.SplitterDistance = 206
        Me.SplitContainer2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.list_pending_deposits)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1316, 206)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PENDING DEPOSITS"
        '
        'list_pending_deposits
        '
        Me.list_pending_deposits.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_pending_deposits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.col_date, Me.col_check_no, Me.col_checkdate, Me.col_payee, Me.col_particulars, Me.col_deposit})
        Me.list_pending_deposits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_pending_deposits.FullRowSelect = True
        Me.list_pending_deposits.HideSelection = False
        Me.list_pending_deposits.Location = New System.Drawing.Point(3, 16)
        Me.list_pending_deposits.Name = "list_pending_deposits"
        Me.list_pending_deposits.Size = New System.Drawing.Size(1310, 187)
        Me.list_pending_deposits.TabIndex = 1
        Me.list_pending_deposits.UseCompatibleStateImageBehavior = False
        Me.list_pending_deposits.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'col_date
        '
        Me.col_date.Text = "DATE ISSUED"
        Me.col_date.Width = 109
        '
        'col_check_no
        '
        Me.col_check_no.Text = "CHECK NO."
        Me.col_check_no.Width = 125
        '
        'col_checkdate
        '
        Me.col_checkdate.Text = "CHECK DATE"
        Me.col_checkdate.Width = 91
        '
        'col_payee
        '
        Me.col_payee.Text = "NAME OF PAYEE"
        Me.col_payee.Width = 177
        '
        'col_particulars
        '
        Me.col_particulars.Text = "PARTICULARS"
        Me.col_particulars.Width = 153
        '
        'col_deposit
        '
        Me.col_deposit.Text = "DEPOSIT"
        Me.col_deposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_deposit.Width = 87
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.list_pending_withdraws)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1316, 243)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PENDING WITHDRAWS"
        '
        'list_pending_withdraws
        '
        Me.list_pending_withdraws.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_pending_withdraws.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.list_pending_withdraws.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_pending_withdraws.FullRowSelect = True
        Me.list_pending_withdraws.HideSelection = False
        Me.list_pending_withdraws.Location = New System.Drawing.Point(3, 16)
        Me.list_pending_withdraws.Name = "list_pending_withdraws"
        Me.list_pending_withdraws.Size = New System.Drawing.Size(1310, 224)
        Me.list_pending_withdraws.TabIndex = 1
        Me.list_pending_withdraws.UseCompatibleStateImageBehavior = False
        Me.list_pending_withdraws.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DATE ISSUED"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CHECK NO."
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CHECK DATE"
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NAME OF PAYEE"
        Me.ColumnHeader5.Width = 177
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PARTICULARS"
        Me.ColumnHeader6.Width = 153
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DEPOSIT"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 87
        '
        'post_dated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vigattin.My.Resources.Resources.brushed_alu
        Me.ClientSize = New System.Drawing.Size(1356, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "post_dated"
        Me.Padding = New System.Windows.Forms.Padding(20, 50, 20, 20)
        Me.Text = "PENDING CHECKS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_pending_deposits As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_pending_withdraw As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents list_pending_deposits As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_check_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_checkdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_payee As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_particulars As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_deposit As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents list_pending_withdraws As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_notification As System.Windows.Forms.ListBox
End Class
