<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check_balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(check_balance))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.group_query = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_query_amount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_query_total_deposit_retrieved = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_query_total_withdraw_retrieved = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_query_total_records_retrieved = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_check_date_day = New System.Windows.Forms.ComboBox()
        Me.cmb_check_date_month = New System.Windows.Forms.ComboBox()
        Me.cmb_check_date_year = New System.Windows.Forms.ComboBox()
        Me.cmb_date_issued_day = New System.Windows.Forms.ComboBox()
        Me.cmb_date_issued_month = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_date_issued_year = New System.Windows.Forms.ComboBox()
        Me.btn_query = New System.Windows.Forms.Button()
        Me.txt_query_name_of_payee = New System.Windows.Forms.ComboBox()
        Me.txt_query_particulars = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_query_type = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_query_check_no = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.group_modify = New System.Windows.Forms.GroupBox()
        Me.txt_name_of_payee = New System.Windows.Forms.ComboBox()
        Me.txt_particulars = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.check_date = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.select_type = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_check_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.date_issued = New System.Windows.Forms.DateTimePicker()
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
        Me.btn_refresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbl_summary_report = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_refresh2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_export = New System.Windows.Forms.ToolStripButton()
        Me.list_balances = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_check_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_checkdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_payee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_particulars = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_deposit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_withdraw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.group_query.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.group_modify.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.list_balances)
        Me.SplitContainer1.Size = New System.Drawing.Size(1332, 680)
        Me.SplitContainer1.SplitterDistance = 150
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.group_query)
        Me.SplitContainer2.Panel1.Controls.Add(Me.group_modify)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1332, 150)
        Me.SplitContainer2.SplitterDistance = 113
        Me.SplitContainer2.TabIndex = 1
        '
        'group_query
        '
        Me.group_query.BackColor = System.Drawing.Color.Transparent
        Me.group_query.Controls.Add(Me.Label17)
        Me.group_query.Controls.Add(Me.txt_query_amount)
        Me.group_query.Controls.Add(Me.GroupBox1)
        Me.group_query.Controls.Add(Me.cmb_check_date_day)
        Me.group_query.Controls.Add(Me.cmb_check_date_month)
        Me.group_query.Controls.Add(Me.cmb_check_date_year)
        Me.group_query.Controls.Add(Me.cmb_date_issued_day)
        Me.group_query.Controls.Add(Me.cmb_date_issued_month)
        Me.group_query.Controls.Add(Me.Label16)
        Me.group_query.Controls.Add(Me.Label15)
        Me.group_query.Controls.Add(Me.cmb_date_issued_year)
        Me.group_query.Controls.Add(Me.btn_query)
        Me.group_query.Controls.Add(Me.txt_query_name_of_payee)
        Me.group_query.Controls.Add(Me.txt_query_particulars)
        Me.group_query.Controls.Add(Me.Label8)
        Me.group_query.Controls.Add(Me.Label10)
        Me.group_query.Controls.Add(Me.cmb_query_type)
        Me.group_query.Controls.Add(Me.Label11)
        Me.group_query.Controls.Add(Me.Label12)
        Me.group_query.Controls.Add(Me.txt_query_check_no)
        Me.group_query.Controls.Add(Me.Label13)
        Me.group_query.Controls.Add(Me.Label14)
        Me.group_query.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_query.Location = New System.Drawing.Point(0, 0)
        Me.group_query.Name = "group_query"
        Me.group_query.Size = New System.Drawing.Size(1332, 113)
        Me.group_query.TabIndex = 0
        Me.group_query.TabStop = False
        Me.group_query.Text = "FILTER"
        Me.group_query.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(318, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "AMOUNT:"
        '
        'txt_query_amount
        '
        Me.txt_query_amount.Location = New System.Drawing.Point(388, 75)
        Me.txt_query_amount.Name = "txt_query_amount"
        Me.txt_query_amount.Size = New System.Drawing.Size(200, 20)
        Me.txt_query_amount.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lbl_query_total_deposit_retrieved)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lbl_query_total_withdraw_retrieved)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbl_query_total_records_retrieved)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(987, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 83)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SUMMARY"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(181, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "₱"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(181, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "₱"
        '
        'lbl_query_total_deposit_retrieved
        '
        Me.lbl_query_total_deposit_retrieved.AutoSize = True
        Me.lbl_query_total_deposit_retrieved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_query_total_deposit_retrieved.Location = New System.Drawing.Point(196, 60)
        Me.lbl_query_total_deposit_retrieved.Name = "lbl_query_total_deposit_retrieved"
        Me.lbl_query_total_deposit_retrieved.Size = New System.Drawing.Size(21, 13)
        Me.lbl_query_total_deposit_retrieved.TabIndex = 5
        Me.lbl_query_total_deposit_retrieved.Text = "<>"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(160, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "TOTAL DEPOSIT RETRIEVED:"
        '
        'lbl_query_total_withdraw_retrieved
        '
        Me.lbl_query_total_withdraw_retrieved.AutoSize = True
        Me.lbl_query_total_withdraw_retrieved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_query_total_withdraw_retrieved.Location = New System.Drawing.Point(196, 43)
        Me.lbl_query_total_withdraw_retrieved.Name = "lbl_query_total_withdraw_retrieved"
        Me.lbl_query_total_withdraw_retrieved.Size = New System.Drawing.Size(21, 13)
        Me.lbl_query_total_withdraw_retrieved.TabIndex = 3
        Me.lbl_query_total_withdraw_retrieved.Text = "<>"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "TOTAL WITHDRAW RETRIEVED:"
        '
        'lbl_query_total_records_retrieved
        '
        Me.lbl_query_total_records_retrieved.AutoSize = True
        Me.lbl_query_total_records_retrieved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_query_total_records_retrieved.Location = New System.Drawing.Point(196, 22)
        Me.lbl_query_total_records_retrieved.Name = "lbl_query_total_records_retrieved"
        Me.lbl_query_total_records_retrieved.Size = New System.Drawing.Size(21, 13)
        Me.lbl_query_total_records_retrieved.TabIndex = 1
        Me.lbl_query_total_records_retrieved.Text = "<>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "TOTAL RECORDS RETRIEVED:"
        '
        'cmb_check_date_day
        '
        Me.cmb_check_date_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_check_date_day.FormattingEnabled = True
        Me.cmb_check_date_day.Items.AddRange(New Object() {""})
        Me.cmb_check_date_day.Location = New System.Drawing.Point(858, 33)
        Me.cmb_check_date_day.Name = "cmb_check_date_day"
        Me.cmb_check_date_day.Size = New System.Drawing.Size(45, 21)
        Me.cmb_check_date_day.TabIndex = 46
        '
        'cmb_check_date_month
        '
        Me.cmb_check_date_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_check_date_month.FormattingEnabled = True
        Me.cmb_check_date_month.Items.AddRange(New Object() {""})
        Me.cmb_check_date_month.Location = New System.Drawing.Point(808, 32)
        Me.cmb_check_date_month.Name = "cmb_check_date_month"
        Me.cmb_check_date_month.Size = New System.Drawing.Size(44, 21)
        Me.cmb_check_date_month.TabIndex = 45
        '
        'cmb_check_date_year
        '
        Me.cmb_check_date_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_check_date_year.FormattingEnabled = True
        Me.cmb_check_date_year.Items.AddRange(New Object() {""})
        Me.cmb_check_date_year.Location = New System.Drawing.Point(711, 32)
        Me.cmb_check_date_year.Name = "cmb_check_date_year"
        Me.cmb_check_date_year.Size = New System.Drawing.Size(91, 21)
        Me.cmb_check_date_year.TabIndex = 44
        '
        'cmb_date_issued_day
        '
        Me.cmb_date_issued_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_date_issued_day.FormattingEnabled = True
        Me.cmb_date_issued_day.Items.AddRange(New Object() {""})
        Me.cmb_date_issued_day.Location = New System.Drawing.Point(248, 38)
        Me.cmb_date_issued_day.Name = "cmb_date_issued_day"
        Me.cmb_date_issued_day.Size = New System.Drawing.Size(45, 21)
        Me.cmb_date_issued_day.TabIndex = 43
        '
        'cmb_date_issued_month
        '
        Me.cmb_date_issued_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_date_issued_month.FormattingEnabled = True
        Me.cmb_date_issued_month.Items.AddRange(New Object() {""})
        Me.cmb_date_issued_month.Location = New System.Drawing.Point(198, 37)
        Me.cmb_date_issued_month.Name = "cmb_date_issued_month"
        Me.cmb_date_issued_month.Size = New System.Drawing.Size(44, 21)
        Me.cmb_date_issued_month.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(727, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "YYYY-MM-DD"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(132, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "YYYY-MM-DD"
        '
        'cmb_date_issued_year
        '
        Me.cmb_date_issued_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_date_issued_year.FormattingEnabled = True
        Me.cmb_date_issued_year.Items.AddRange(New Object() {""})
        Me.cmb_date_issued_year.Location = New System.Drawing.Point(101, 37)
        Me.cmb_date_issued_year.Name = "cmb_date_issued_year"
        Me.cmb_date_issued_year.Size = New System.Drawing.Size(91, 21)
        Me.cmb_date_issued_year.TabIndex = 39
        '
        'btn_query
        '
        Me.btn_query.Location = New System.Drawing.Point(917, 19)
        Me.btn_query.Name = "btn_query"
        Me.btn_query.Size = New System.Drawing.Size(64, 66)
        Me.btn_query.TabIndex = 38
        Me.btn_query.Text = "FILTER"
        Me.btn_query.UseVisualStyleBackColor = True
        '
        'txt_query_name_of_payee
        '
        Me.txt_query_name_of_payee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_query_name_of_payee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_query_name_of_payee.FormattingEnabled = True
        Me.txt_query_name_of_payee.Location = New System.Drawing.Point(721, 63)
        Me.txt_query_name_of_payee.Name = "txt_query_name_of_payee"
        Me.txt_query_name_of_payee.Size = New System.Drawing.Size(188, 21)
        Me.txt_query_name_of_payee.TabIndex = 37
        '
        'txt_query_particulars
        '
        Me.txt_query_particulars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_query_particulars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_query_particulars.FormattingEnabled = True
        Me.txt_query_particulars.Location = New System.Drawing.Point(100, 68)
        Me.txt_query_particulars.Name = "txt_query_particulars"
        Me.txt_query_particulars.Size = New System.Drawing.Size(201, 21)
        Me.txt_query_particulars.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(619, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "NAME OF PAYEE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(619, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "CHECK DATE:"
        '
        'cmb_query_type
        '
        Me.cmb_query_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_query_type.FormattingEnabled = True
        Me.cmb_query_type.Items.AddRange(New Object() {"", "Deposit", "Withdraw", "Spoiled"})
        Me.cmb_query_type.Location = New System.Drawing.Point(388, 47)
        Me.cmb_query_type.Name = "cmb_query_type"
        Me.cmb_query_type.Size = New System.Drawing.Size(200, 21)
        Me.cmb_query_type.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(337, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "TYPE:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(315, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CHECK NO.:"
        '
        'txt_query_check_no
        '
        Me.txt_query_check_no.Location = New System.Drawing.Point(388, 15)
        Me.txt_query_check_no.Name = "txt_query_check_no"
        Me.txt_query_check_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_query_check_no.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "PARTICULARS:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "DATE ISSUED:"
        '
        'group_modify
        '
        Me.group_modify.Controls.Add(Me.txt_name_of_payee)
        Me.group_modify.Controls.Add(Me.txt_particulars)
        Me.group_modify.Controls.Add(Me.Label7)
        Me.group_modify.Controls.Add(Me.Label6)
        Me.group_modify.Controls.Add(Me.txt_amount)
        Me.group_modify.Controls.Add(Me.check_date)
        Me.group_modify.Controls.Add(Me.Label5)
        Me.group_modify.Controls.Add(Me.select_type)
        Me.group_modify.Controls.Add(Me.Label4)
        Me.group_modify.Controls.Add(Me.Label3)
        Me.group_modify.Controls.Add(Me.txt_check_no)
        Me.group_modify.Controls.Add(Me.Label2)
        Me.group_modify.Controls.Add(Me.date_issued)
        Me.group_modify.Controls.Add(Me.Label1)
        Me.group_modify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_modify.Location = New System.Drawing.Point(0, 0)
        Me.group_modify.Name = "group_modify"
        Me.group_modify.Size = New System.Drawing.Size(1332, 113)
        Me.group_modify.TabIndex = 0
        Me.group_modify.TabStop = False
        Me.group_modify.Text = "MODIFY"
        '
        'txt_name_of_payee
        '
        Me.txt_name_of_payee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_name_of_payee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_name_of_payee.FormattingEnabled = True
        Me.txt_name_of_payee.Location = New System.Drawing.Point(1077, 25)
        Me.txt_name_of_payee.Name = "txt_name_of_payee"
        Me.txt_name_of_payee.Size = New System.Drawing.Size(188, 21)
        Me.txt_name_of_payee.TabIndex = 23
        '
        'txt_particulars
        '
        Me.txt_particulars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_particulars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_particulars.FormattingEnabled = True
        Me.txt_particulars.Location = New System.Drawing.Point(100, 60)
        Me.txt_particulars.Name = "txt_particulars"
        Me.txt_particulars.Size = New System.Drawing.Size(201, 21)
        Me.txt_particulars.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(975, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "NAME OF PAYEE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(640, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "AMOUNT:"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(710, 57)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(200, 20)
        Me.txt_amount.TabIndex = 13
        '
        'check_date
        '
        Me.check_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.check_date.Location = New System.Drawing.Point(710, 26)
        Me.check_date.Name = "check_date"
        Me.check_date.Size = New System.Drawing.Size(201, 20)
        Me.check_date.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(619, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CHECK DATE:"
        '
        'select_type
        '
        Me.select_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_type.FormattingEnabled = True
        Me.select_type.Items.AddRange(New Object() {"Deposit", "Withdraw", "Spoiled"})
        Me.select_type.Location = New System.Drawing.Point(388, 56)
        Me.select_type.Name = "select_type"
        Me.select_type.Size = New System.Drawing.Size(200, 21)
        Me.select_type.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TYPE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CHECK NO.:"
        '
        'txt_check_no
        '
        Me.txt_check_no.Location = New System.Drawing.Point(388, 24)
        Me.txt_check_no.Name = "txt_check_no"
        Me.txt_check_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_check_no.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PARTICULARS:"
        '
        'date_issued
        '
        Me.date_issued.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_issued.Location = New System.Drawing.Point(100, 27)
        Me.date_issued.Name = "date_issued"
        Me.date_issued.Size = New System.Drawing.Size(201, 20)
        Me.date_issued.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATE ISSUED:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.vigattin.My.Resources.Resources.menu_bg_a
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_clear_fields, Me.ToolStripSeparator5, Me.btn_add, Me.ToolStripSeparator4, Me.btn_update, Me.ToolStripSeparator2, Me.btn_delete, Me.ToolStripSeparator3, Me.btn_refresh, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator7, Me.lbl_summary_report, Me.ToolStripSeparator6, Me.btn_refresh2, Me.ToolStripSeparator8, Me.btn_export})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1332, 30)
        Me.ToolStrip1.TabIndex = 22
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
        'btn_refresh
        '
        Me.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_refresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(144, 27)
        Me.btn_refresh.Text = "RECALCULATE BALANCE"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(154, 27)
        Me.ToolStripButton2.Text = "SWITCH TO FILTER MODE"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 30)
        '
        'lbl_summary_report
        '
        Me.lbl_summary_report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lbl_summary_report.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_summary_report.ForeColor = System.Drawing.Color.White
        Me.lbl_summary_report.Image = CType(resources.GetObject("lbl_summary_report.Image"), System.Drawing.Image)
        Me.lbl_summary_report.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lbl_summary_report.Name = "lbl_summary_report"
        Me.lbl_summary_report.Size = New System.Drawing.Size(120, 27)
        Me.lbl_summary_report.Text = "SUMMARY REPORT"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'btn_refresh2
        '
        Me.btn_refresh2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_refresh2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_refresh2.ForeColor = System.Drawing.Color.White
        Me.btn_refresh2.Image = CType(resources.GetObject("btn_refresh2.Image"), System.Drawing.Image)
        Me.btn_refresh2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_refresh2.Name = "btn_refresh2"
        Me.btn_refresh2.Size = New System.Drawing.Size(61, 27)
        Me.btn_refresh2.Text = "REFRESH"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 30)
        '
        'btn_export
        '
        Me.btn_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_export.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_export.ForeColor = System.Drawing.Color.White
        Me.btn_export.Image = CType(resources.GetObject("btn_export.Image"), System.Drawing.Image)
        Me.btn_export.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(110, 27)
        Me.btn_export.Text = "EXPORT AS EXCEL"
        '
        'list_balances
        '
        Me.list_balances.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_balances.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.list_balances.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.col_date, Me.col_check_no, Me.col_checkdate, Me.col_payee, Me.col_particulars, Me.col_type, Me.col_deposit, Me.col_withdraw, Me.col_amount})
        Me.list_balances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_balances.FullRowSelect = True
        Me.list_balances.HideSelection = False
        Me.list_balances.Location = New System.Drawing.Point(0, 0)
        Me.list_balances.Name = "list_balances"
        Me.list_balances.RightToLeftLayout = True
        Me.list_balances.Size = New System.Drawing.Size(1332, 526)
        Me.list_balances.TabIndex = 0
        Me.list_balances.UseCompatibleStateImageBehavior = False
        Me.list_balances.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'col_date
        '
        Me.col_date.Text = "DATE ISSUED"
        Me.col_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_date.Width = 109
        '
        'col_check_no
        '
        Me.col_check_no.Text = "CHECK NO."
        Me.col_check_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_check_no.Width = 125
        '
        'col_checkdate
        '
        Me.col_checkdate.Text = "CHECK DATE"
        Me.col_checkdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_checkdate.Width = 91
        '
        'col_payee
        '
        Me.col_payee.Text = "NAME OF PAYEE"
        Me.col_payee.Width = 261
        '
        'col_particulars
        '
        Me.col_particulars.Text = "PARTICULARS"
        Me.col_particulars.Width = 299
        '
        'col_type
        '
        Me.col_type.Text = "TYPE"
        Me.col_type.Width = 0
        '
        'col_deposit
        '
        Me.col_deposit.Text = "DEPOSIT"
        Me.col_deposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_deposit.Width = 87
        '
        'col_withdraw
        '
        Me.col_withdraw.Text = "WITHDRAW"
        Me.col_withdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_withdraw.Width = 136
        '
        'col_amount
        '
        Me.col_amount.Text = "BALANCE"
        Me.col_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_amount.Width = 131
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'check_balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vigattin.My.Resources.Resources.brushed_alu
        Me.ClientSize = New System.Drawing.Size(1372, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "check_balance"
        Me.Padding = New System.Windows.Forms.Padding(20, 50, 20, 20)
        Me.Text = "BALANCE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.group_query.ResumeLayout(False)
        Me.group_query.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.group_modify.ResumeLayout(False)
        Me.group_modify.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents group_modify As System.Windows.Forms.GroupBox
    Friend WithEvents list_balances As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_check_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_checkdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_payee As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_particulars As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_type As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_deposit As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_withdraw As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents date_issued As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents check_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents select_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_check_no As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_particulars As System.Windows.Forms.ComboBox
    Friend WithEvents txt_name_of_payee As System.Windows.Forms.ComboBox
    Friend WithEvents group_query As System.Windows.Forms.GroupBox
    Friend WithEvents txt_query_name_of_payee As System.Windows.Forms.ComboBox
    Friend WithEvents txt_query_particulars As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_query_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_query_check_no As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_query As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_clear_fields As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_update As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmb_check_date_day As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_check_date_month As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_check_date_year As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_date_issued_day As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_date_issued_month As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_date_issued_year As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_query_total_withdraw_retrieved As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_query_total_records_retrieved As System.Windows.Forms.Label
    Friend WithEvents lbl_query_total_deposit_retrieved As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lbl_summary_report As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_export As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_query_amount As System.Windows.Forms.TextBox
    Friend WithEvents btn_refresh2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
End Class
