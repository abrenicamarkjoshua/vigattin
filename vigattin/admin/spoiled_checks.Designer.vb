<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spoiled_checks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(spoiled_checks))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_spoiled = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.list_spoiled = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_check_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_checkdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_payee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_particulars = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1324, 680)
        Me.SplitContainer1.SplitterDistance = 69
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1324, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACTION"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "REFRESH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(158, 19)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(133, 30)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.list_spoiled)
        Me.SplitContainer2.Size = New System.Drawing.Size(1324, 607)
        Me.SplitContainer2.SplitterDistance = 68
        Me.SplitContainer2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_spoiled)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1324, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SUMMARY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(173, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "₱"
        '
        'lbl_spoiled
        '
        Me.lbl_spoiled.AutoSize = True
        Me.lbl_spoiled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_spoiled.ForeColor = System.Drawing.Color.Black
        Me.lbl_spoiled.Location = New System.Drawing.Point(193, 36)
        Me.lbl_spoiled.Name = "lbl_spoiled"
        Me.lbl_spoiled.Size = New System.Drawing.Size(32, 13)
        Me.lbl_spoiled.TabIndex = 8
        Me.lbl_spoiled.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TOTAL SPOILED:"
        '
        'list_spoiled
        '
        Me.list_spoiled.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_spoiled.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.col_date, Me.col_check_no, Me.col_checkdate, Me.col_payee, Me.col_particulars, Me.col_amount})
        Me.list_spoiled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_spoiled.FullRowSelect = True
        Me.list_spoiled.HideSelection = False
        Me.list_spoiled.Location = New System.Drawing.Point(0, 0)
        Me.list_spoiled.Name = "list_spoiled"
        Me.list_spoiled.Size = New System.Drawing.Size(1324, 535)
        Me.list_spoiled.TabIndex = 1
        Me.list_spoiled.UseCompatibleStateImageBehavior = False
        Me.list_spoiled.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
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
        Me.col_payee.Width = 190
        '
        'col_particulars
        '
        Me.col_particulars.Text = "PARTICULARS"
        Me.col_particulars.Width = 219
        '
        'col_amount
        '
        Me.col_amount.Text = "AMOUNT"
        Me.col_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_amount.Width = 131
        '
        'spoiled_checks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vigattin.My.Resources.Resources.brushed_alu
        Me.ClientSize = New System.Drawing.Size(1364, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "spoiled_checks"
        Me.Padding = New System.Windows.Forms.Padding(20, 50, 20, 20)
        Me.Text = "SPOILED CHECKS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents list_spoiled As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_check_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_checkdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_payee As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_particulars As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_spoiled As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
