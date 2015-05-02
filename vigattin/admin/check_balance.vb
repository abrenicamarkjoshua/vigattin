Imports Microsoft.VisualBasic
Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop
Imports System
Imports System.Security.Cryptography
Imports System.Text
Public Class check_balance

    Dim action As New db
    Dim x As Integer = 0
    Dim total_records As Integer
    Dim total_withdraw As Decimal
    Dim total_deposit As Decimal
    Dim total_balance As Decimal
    Dim state As String = "modify"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        date_issued.CustomFormat = "yyyy-MM-dd"
        check_date.CustomFormat = "yyyy-MM-dd"
        ' Add any initialization after the InitializeComponent() call.
        AddHandler adp1.RowUpdated, AddressOf adp1_OnRowUpdated

    End Sub
    Private Sub cheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
5:      Me.DoubleBuffered = True
        Me.WindowState = FormWindowState.Maximized

        get_balances2()
        populate_dropdown()

        For i As Integer = 2000 To Date.Now.Year
            cmb_date_issued_year.Items.Add(i)
            cmb_check_date_year.Items.Add(i)
        Next
        For j As Integer = 1 To 31
            cmb_date_issued_day.Items.Add(j.ToString.PadLeft(2, "0"))
            cmb_check_date_day.Items.Add(j.ToString.PadLeft(2, "0"))
        Next
        For k As Integer = 1 To 12
            cmb_date_issued_month.Items.Add(k.ToString.PadLeft(2, "0"))
            cmb_check_date_month.Items.Add(k.ToString.PadLeft(2, "0"))
        Next
    End Sub
    Private Sub get_balances2()

        list_balances.Items.Clear()
        Dim get_query_result_dt As DataTable = action.query("SELECT * FROM balance ORDER BY date ASC")
        progressbar_form.progress_bar.Maximum = get_query_result_dt.Rows.Count

        For i As Integer = 0 To get_query_result_dt.Rows.Count - 1
            If (progressbar_form.progress_bar.Value < get_query_result_dt.Rows.Count) Then
                progressbar_form.progress_bar.Value += 1
            End If

            With list_balances.Items.Add(get_query_result_dt.Rows(i).Item("id").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("date").ToShortDateString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("checkno").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("checkdate").ToShortDateString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("payee").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("particulars").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("type").ToString)
                .SubItems.Add(Convert.ToDecimal(get_query_result_dt.Rows(i).Item("deposit")).ToString("N"))
                .SubItems.Add(Convert.ToDecimal(get_query_result_dt.Rows(i).Item("withdraw")).ToString("N"))
                .SubItems.Add(Convert.ToDecimal(get_query_result_dt.Rows(i).Item("amount")).ToString("N"))
            End With

        Next
        Dim get_summary As DataTable = action.query("SELECT SUM(withdraw), SUM(deposit) FROM balance")

        If get_summary.Rows(0)(1).ToString = "" Then
            lbl_query_total_deposit_retrieved.Text = "0.00"
        Else
            lbl_query_total_deposit_retrieved.Text = Convert.ToDecimal(get_summary.Rows(0)(1)).ToString("N")
        End If

        If get_summary.Rows(0)(0).ToString = "" Then
            lbl_query_total_withdraw_retrieved.Text = "0.00"
        Else
            lbl_query_total_withdraw_retrieved.Text = Convert.ToDecimal(get_summary.Rows(0)(0)).ToString("N")
        End If

        Dim get_last_balance As Decimal = action.GetDetails("amount", "balance", " WHERE  id = '" & get_query_result_dt.Rows(get_query_result_dt.Rows.Count - 1).Item("id") & "'")
        total_balance = get_last_balance
        progressbar_form.Close()

    End Sub
    'Public adp1 = New Odbc.OdbcDataAdapter()
    Friend WithEvents adp1 As Odbc.OdbcDataAdapter = New Odbc.OdbcDataAdapter()



    Private Sub get_balances()
        'clean errorprovider
        ErrorProvider1.Clear()
        'set system status to server busy
        Dim update_details3 As New Dictionary(Of String, String)
        update_details3.Add("status", "SERVER BUSY")
        Dim commit_update_status As Object = action.update("system_status", update_details3, " WHERE status IS NOT NULL")
        If TypeOf commit_update_status Is String Then
            MsgBox(commit_update_status)
            Exit Sub
        End If

        'set system to busy
        MsgBox("System set to busy")
        admin_dashboard.lbl_server_status.ForeColor = Color.Red
        admin_dashboard.lbl_server_status.Text = "SERVER BUSY"

        'UPDATE AND CORRECT CALCULATION

        Dim get_balance As DataTable = action.query("SELECT * FROM balance ORDER BY date ASC")

        Dim now As String = Date.Now.ToString("yyy-MM-dd")
        Dim current_deposit As Decimal
        Dim current_checkdate As String

        Dim current_withdraw As Decimal
        Dim previous_balance As Decimal
        Dim new_balance As Decimal
        admin_dashboard.lbl_progress.Maximum = get_balance.Rows.Count
        total_records = get_balance.Rows.Count
        Dim get_summary As DataTable = action.query("SELECT SUM(deposit), SUM(withdraw) FROM balance")
        total_deposit = get_summary.Rows(0)(0)
        total_withdraw = get_summary.Rows(0)(1)
        Dim get_total_balance As String = action.GetDetails("amount", "balance", " WHERE id = '" & get_balance.Rows(get_balance.Rows.Count - 1).Item("id") & "'")
        total_balance = get_total_balance
        progressbar_form.Show()
        progressbar_form.progress_bar.Maximum = get_balance.Rows.Count

        Dim affected As Integer = 0


        'begin date correction
        'begin displaying data to listview
        get_balance = action.query("SELECT * FROM balance ORDER BY date ASC")


        Dim my_date As String
        Dim my_date_issued As String
        Dim my_year As String
        Dim my_month As String
        Dim my_day As String
        Dim my_year_issued As String
        Dim my_month_issued As String
        Dim my_day_issued As String


        populate_dropdown()


        lbl_query_total_deposit_retrieved.Text = total_deposit
        lbl_query_total_withdraw_retrieved.Text = total_withdraw

        For i As Integer = 0 To get_balance.Rows.Count - 1

            With list_balances.Items.Add(get_balance.Rows(i).Item("id").ToString)
                .SubItems.Add(get_balance.Rows(i).Item("date").ToShortDateString)
                .SubItems.Add(get_balance.Rows(i).Item("checkno").ToString)
                .SubItems.Add(get_balance.Rows(i).Item("checkdate").ToShortDateString)
                .SubItems.Add(get_balance.Rows(i).Item("payee").ToString)
                .SubItems.Add(get_balance.Rows(i).Item("particulars").ToString)
                .SubItems.Add(get_balance.Rows(i).Item("type").ToString)
                .SubItems.Add(Convert.ToDecimal(get_balance.Rows(i).Item("deposit")).ToString("N"))
                .SubItems.Add(Convert.ToDecimal(get_balance.Rows(i).Item("withdraw")).ToString("N"))
                .SubItems.Add(Convert.ToDecimal(get_balance.Rows(i).Item("amount")).ToString("N"))

                'correct format if not yet corrected
                If get_balance.Rows(i).Item("checkdate").ToString.Substring(2, 1) = "/" Then
                    my_year = get_balance.Rows(i).Item("checkdate").ToString.Substring(6, 4)
                    my_month = get_balance.Rows(i).Item("checkdate").ToString.Substring(0, 2)
                    my_day = get_balance.Rows(i).Item("checkdate").ToString.Substring(3, 2)
                    my_date = (my_year & "-" & my_month & "-" & my_day)

                    Dim my_field_value As New Dictionary(Of String, String)
                    my_field_value.Add("checkdate", my_date)

                    Dim commit_update As Object = action.update("balance", my_field_value, " WHERE date = '" & get_balance.Rows(i).Item("date").ToString & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If

                End If
                If get_balance.Rows(i).Item("date").ToString.Substring(2, 1) = "/" Then
                    my_year_issued = get_balance.Rows(i).Item("date").ToString.Substring(6, 4)
                    my_month_issued = get_balance.Rows(i).Item("date").ToString.Substring(0, 2)
                    my_day_issued = get_balance.Rows(i).Item("date").ToString.Substring(3, 2)
                    my_date_issued = (my_year_issued & "-" & my_month_issued & "-" & my_day_issued)

                    Dim my_field_value As New Dictionary(Of String, String)
                    my_field_value.Add("date", my_date_issued)

                    Dim commit_update As Object = action.update("balance", my_field_value, " WHERE date = '" & get_balance.Rows(i).Item("date").ToString & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If

                End If

            End With

        Next

        'end date correction

        For i As Integer = 0 To get_balance.Rows.Count - 1
            'progress bar


            'MsgBox("check")
            ' admin_dashboard.Timer1_Tick(sender, e)

            'get updated data from previous loop update
            ''Dim get_balance_refresh As DataTable = action.query("SELECT * FROM balance ORDER BY date ASC")
            'Dim get_balance_refresh As DataTable = action.query("SELECT * FROM balance ORDER BY date ASC")

            'get_balance = get_balance_refresh
            'LEARN LINQ
            'start
            If i > 0 Then
                previous_balance = Convert.ToDecimal(get_balance.Rows(i - 1).Item("amount"))
            Else
                previous_balance = 0
            End If
            current_checkdate = Date.Parse(get_balance.Rows(i).Item("checkdate")).ToString("yyy-MM-dd")

            current_deposit = Convert.ToDecimal(get_balance.Rows(i).Item("deposit"))
            current_withdraw = Convert.ToDecimal(get_balance.Rows(i).Item("withdraw"))
            'add current deposit/current withdraw if it is not post dated else, if it is post dated, do not process it
            If current_checkdate > now Then
                current_deposit = 0
                current_withdraw = 0

            End If
            new_balance = previous_balance + current_deposit - current_withdraw

            'optimized. update balance if current amount is not correct
            Dim output As Decimal = Convert.ToDecimal(get_balance.Rows(i).Item("amount"))
            If output <> new_balance Then
                'update current amount
                'Dim update_details As New Dictionary(Of String, String)
                'update_details.Add("amount", new_balance)
                'Dim commit_update As Object = action.update("balance", update_details, " WHERE id = '" & get_balance.Rows(i).Item("id") & "'")
                'If TypeOf commit_update Is String Then
                '    MsgBox(commit_update)
                '    Exit Sub
                '    Exit For

                'End If
                ' Dim new_output As Double = Convert.ToDouble(new_balance)
                get_balance.Rows(i).Item("amount") = new_balance
                affected += 1
            Else
                ' MsgBox("wrong")
            End If
        Next
        'action.da.SelectCommand = New Odbc.OdbcCommand("SELECT * FROM balance ORDER BY date ASC", action.con)
        'Dim cb As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(action.da)

        Dim affected_rows2 As Integer

        Try

            adp1.SelectCommand = New Odbc.OdbcCommand("SELECT * FROM balance ORDER BY date ASC", action.con)

            Dim cb As Odbc.OdbcCommandBuilder = New Odbc.OdbcCommandBuilder(adp1)
            'cb.GetUpdateCommand(True)

            'MessageBox.Show(cb.GetUpdateCommand().CommandText)
            adp1.ContinueUpdateOnError = True
            affected_rows2 = adp1.Update(get_balance)
            get_balance.Clear()
            adp1.Dispose()
            cb.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'RemoveHandler adp1.RowUpdated, AddressOf adp1_OnRowUpdated


        progressbar_form.Close()

        admin_dashboard.lbl_progress.Maximum = 0
        'set system status to server ok
        Dim update_details2 As New Dictionary(Of String, String)
        update_details2.Add("status", "SERVER OK")
        Dim commit_update_status2 As Object = action.update("system_status", update_details2, " WHERE status IS NOT NULL")
        If TypeOf commit_update_status2 Is String Then
            MsgBox(commit_update_status2)
            Exit Sub
        End If

        admin_dashboard.lbl_server_status.Text = "SERVER OK"
        admin_dashboard.lbl_server_status.ForeColor = Color.DarkGreen

        MsgBox("Total updated rows: " & affected.ToString())
        MsgBox("Total updated rows: " & affected_rows2.ToString())

        get_balances2()


    End Sub
    Private Sub adp1_OnRowUpdated(ByVal sender As Object, ByVal args As Odbc.OdbcRowUpdatedEventArgs)
        If (args.Status = UpdateStatus.ErrorsOccurred) Then
            args.Row.RowError = args.Errors.Message
            args.Status = UpdateStatus.SkipCurrentRow
        End If
        admin_dashboard.lbl_progress.Value += 1
        progressbar_form.progress_bar.Value += 1

    End Sub

    Private Sub populate_dropdown()
        txt_particulars.Items.Clear()
        txt_name_of_payee.Items.Clear()
        txt_query_name_of_payee.Items.Clear()
        txt_query_particulars.Items.Clear()

        'populate particulars
        Dim get_particulars As DataTable = action.query("SELECT DISTINCT particulars FROM balance ORDER BY particulars ASC")

        For counter As Integer = 0 To get_particulars.Rows.Count - 1
            txt_particulars.Items.Add(get_particulars.Rows(counter).Item("particulars"))
            txt_query_particulars.Items.Add(get_particulars.Rows(counter).Item("particulars"))
        Next

        'populate payee
        Dim get_payee As DataTable = action.query("SELECT DISTINCT payee FROM balance ORDER BY payee ASC")

        For counter As Integer = 0 To get_payee.Rows.Count - 1

            txt_name_of_payee.Items.Add(get_payee.Rows(counter).Item("payee"))
            txt_query_name_of_payee.Items.Add(get_payee.Rows(counter).Item("payee"))
        Next

        btn_refresh.Enabled = True
    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub check_balance_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        admin_dashboard.lbl_current_form.Text = Me.Text

    End Sub

    Private Sub list_balances_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_balances.Click
        action.get_list_balances(list_balances.SelectedItems(0).Text)
    End Sub

    Private Sub list_balances_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles list_balances.ColumnClick
        Dim sort As String = ""
        Select Case e.Column
            Case 1
                list_balances.Items.Clear()
                query_list(" ORDER BY date")
            Case 2
                list_balances.Items.Clear()
                query_list(" ORDER BY checkno")

        End Select

    End Sub



    Private Sub list_balances_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_balances.SelectedIndexChanged
        Dim str As String
        For Each itm As ListViewItem In list_balances.SelectedItems
            If itm.Selected Then
                action.get_list_balances(itm.Text)
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btn_clear_fields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CLEARFIELDSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ADDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub REFRESHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_clear_fields_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear_fields.Click

        date_issued.Text = ""
        txt_amount.Text = ""
        txt_check_no.Text = ""
        txt_name_of_payee.Text = ""
        txt_particulars.Text = ""
        select_type.Text = ""
        check_date.Text = ""
        list_balances.SelectedItems.Clear()

        ErrorProvider1.Clear()

        cmb_check_date_day.Text = ""
        cmb_check_date_month.Text = ""
        cmb_check_date_year.Text = ""
        cmb_date_issued_day.Text = ""
        cmb_date_issued_month.Text = ""
        cmb_date_issued_year.Text = ""
        cmb_query_type.Text = ""
        lbl_query_total_deposit_retrieved.Text = ""
        lbl_query_total_records_retrieved.Text = ""
        lbl_query_total_withdraw_retrieved.Text = ""
        txt_query_check_no.Text = ""
        txt_query_name_of_payee.Text = ""
        txt_query_particulars.Text = ""
        txt_query_amount.Text = ""

    End Sub
    Private Sub clear_everything()

        date_issued.Text = ""
        txt_amount.Text = ""
        txt_check_no.Text = ""
        txt_name_of_payee.Text = ""
        txt_particulars.Text = ""
        select_type.Text = ""
        check_date.Text = ""
        list_balances.SelectedItems.Clear()
        ErrorProvider1.Clear()

        cmb_check_date_day.Text = ""
        cmb_check_date_month.Text = ""
        cmb_check_date_year.Text = ""
        cmb_date_issued_day.Text = ""
        cmb_date_issued_month.Text = ""
        cmb_date_issued_year.Text = ""
        cmb_query_type.Text = ""
        lbl_query_total_deposit_retrieved.Text = ""
        lbl_query_total_records_retrieved.Text = ""
        lbl_query_total_withdraw_retrieved.Text = ""
        txt_query_check_no.Text = ""
        txt_query_name_of_payee.Text = ""
        txt_query_particulars.Text = ""
        txt_query_amount.Text = ""

    End Sub
    Private Sub btn_add_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        'check for blank fields
        Dim required_fields As New ArrayList
        required_fields.Add(txt_amount)
        required_fields.Add(txt_name_of_payee)
        required_fields.Add(txt_particulars)
        required_fields.Add(select_type)
        Dim commit_check As Boolean = action.check_field(ErrorProvider1, required_fields)
        If commit_check = False Then
            MsgBox("PLEASE FILL OUT REQUIRED FIELDS BEFORE PROCEEDING")
            Exit Sub
        End If

        'check date must not be less or before than check issued
        If check_date.Text < date_issued.Text Then
            MsgBox("CHECK DATE CANNOT BE LESS OR BEFORE CHECK ISSUED")
            Exit Sub
        End If

        'check no. must not be duplicated
        Dim parameters As New Dictionary(Of String, String)
        parameters.Add("checkno", sanitize(txt_check_no.Text))
        Dim try_if_existing As Boolean = action.try_if_existing3(parameters, "balance", "id")
        If try_if_existing = True Then
            MsgBox("Check no already exist! please input different check number")
            Exit Sub
        End If

        'prompt for insertion
        If (MessageBox.Show("Are you sure you want to insert this record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If


        'proceed to insertion
        Dim insert_details As New Dictionary(Of String, String)
        insert_details.Add("date", sanitize(date_issued.Text))
        insert_details.Add("checkno", sanitize(txt_check_no.Text))
        insert_details.Add("payee", sanitize(txt_name_of_payee.Text))
        insert_details.Add("checkdate", sanitize(check_date.Text))


        insert_details.Add("particulars", sanitize(txt_particulars.Text))
        insert_details.Add("type", sanitize(select_type.Text))


        Select Case select_type.Text
            Case "Deposit"
                insert_details.Add("deposit", txt_amount.Text)

                'commit update. dead end
                Dim commit_insert As Object = action.insert("balance", insert_details)
                If TypeOf commit_insert Is String Then
                    MsgBox(commit_insert)
                    Exit Sub
                End If

            Case "Withdraw"

                insert_details.Add("withdraw", txt_amount.Text)

                'commit update. dead end
                Dim commit_insert As Object = action.insert("balance", insert_details)
                If TypeOf commit_insert Is String Then
                    MsgBox(commit_insert)
                    Exit Sub
                End If
            Case "Spoiled"
                insert_details.Add("amount", txt_amount.Text)
                'commit update. dead end
                Dim commit_insert As Object = action.insert("spoiled", insert_details)
                If TypeOf commit_insert Is String Then
                    MsgBox(commit_insert)
                    Exit Sub
                End If


        End Select

        'Record action
        Dim insert_details_log As New Dictionary(Of String, String)
        insert_details_log.Add("username", admin_dashboard.my_username)
        insert_details_log.Add("action", "user inserted data to checkbook balance: date issued is: " & date_issued.Text & ", checkno is: " & txt_check_no.Text & ", checkdate is: " & check_date.Text & ", payee is: " & txt_name_of_payee.Text & ", particular is: " & txt_particulars.Text & ", type is: " & select_type.Text & ", amount is: " & txt_amount.Text)
        insert_details_log.Add("datetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Dim commit_record As Object = action.insert("log", insert_details_log)
        If TypeOf commit_record Is String Then
            MsgBox(commit_record)
            Exit Sub
        End If

        MsgBox("Record inserted successfully!")
        clear_everything()
        get_balances2()


    End Sub

    Private Sub btn_update_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        Dim update_details As New Dictionary(Of String, String)
        If state = "modify" Then
            Dim required_fields As New ArrayList
            required_fields.Add(txt_amount)
            required_fields.Add(txt_name_of_payee)
            required_fields.Add(txt_particulars)
            required_fields.Add(select_type)
            Dim commit_check As Boolean = action.check_field(ErrorProvider1, required_fields)
            If commit_check = False Then
                MsgBox("PLEASE FILL OUT REQUIRED FIELDS BEFORE PROCEEDING")
                Exit Sub
            End If


            If list_balances.SelectedItems.Count = 0 Then
                MsgBox("Please select data entry from the list before updating")
                Exit Sub
            End If

            If (MessageBox.Show("Are you sure you want to update this record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If



            update_details.Add("date", sanitize(date_issued.Text))
            update_details.Add("checkno", sanitize(txt_check_no.Text))
            update_details.Add("checkdate", sanitize(check_date.Text))
            update_details.Add("payee", sanitize(txt_name_of_payee.Text))
            update_details.Add("particulars", sanitize(txt_particulars.Text))
            update_details.Add("type", sanitize(select_type.Text))
            Select Case select_type.Text
                Case "Deposit"
                    update_details.Add("deposit", txt_amount.Text)
                    update_details.Add("withdraw", "0")

                    'commit update. dead end
                    Dim commit_update As Object = action.update("balance", update_details, " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If

                Case "Withdraw"
                    update_details.Add("deposit", "0")
                    update_details.Add("withdraw", txt_amount.Text)

                    'commit update. dead end
                    Dim commit_update As Object = action.update("balance", update_details, " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If
                Case "Spoiled"
                    update_details.Add("amount", txt_amount.Text)
                    'commit update. dead end
                    Dim commit_update As Object = action.insert("spoiled", update_details)
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If

                    'delete this record from the balance table because it is moved to spoiled table
                    Dim commit_delete As Object = action.delete("balance", " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If
                    MsgBox("Record moved to spoiled checks")
            End Select



        ElseIf state = "query" Then
            Dim required_fields As New ArrayList
            required_fields.Add(cmb_check_date_year)
            required_fields.Add(cmb_check_date_month)
            required_fields.Add(cmb_check_date_day)

            required_fields.Add(cmb_date_issued_year)
            required_fields.Add(cmb_date_issued_month)
            required_fields.Add(cmb_date_issued_day)

            required_fields.Add(txt_query_name_of_payee)
            required_fields.Add(txt_query_particulars)
            required_fields.Add(cmb_query_type)

            Dim commit_check As Boolean = action.check_field(ErrorProvider1, required_fields)
            If commit_check = False Then
                MsgBox("PLEASE FILL OUT REQUIRED FIELDS BEFORE PROCEEDING")
                Exit Sub
            End If


            If list_balances.SelectedItems.Count = 0 Then
                MsgBox("Please select data entry from the list before updating")
                Exit Sub
            End If

            If (MessageBox.Show("Are you sure you want to update this record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If





            update_details.Add("date", cmb_date_issued_year.Text & "-" & cmb_date_issued_month.Text & "-" & cmb_date_issued_day.Text)
            update_details.Add("checkno", sanitize(txt_query_check_no.Text))
            update_details.Add("checkdate", cmb_check_date_year.Text & "-" & cmb_check_date_month.Text & "-" & cmb_check_date_day.Text)
            update_details.Add("payee", sanitize(txt_query_name_of_payee.Text))
            update_details.Add("particulars", sanitize(txt_query_particulars.Text))
            update_details.Add("type", sanitize(cmb_query_type.Text))
            Select Case cmb_query_type.Text
                Case "Deposit"
                    update_details.Add("deposit", txt_query_amount.Text)
                    update_details.Add("withdraw", "0")

                    'commit update. dead end
                    Dim commit_update As Object = action.update("balance", update_details, " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If

                Case "Withdraw"
                    update_details.Add("deposit", "0")
                    update_details.Add("withdraw", txt_query_amount.Text)

                    'commit update. dead end
                    Dim commit_update As Object = action.update("balance", update_details, " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If
                Case "Spoiled"
                    update_details.Add("amount", txt_query_amount.Text)
                    'commit update. dead end
                    Dim commit_update As Object = action.insert("spoiled", update_details)
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If

                    'delete this record from the balance table because it is moved to spoiled table
                    Dim commit_delete As Object = action.delete("balance", " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
                    If TypeOf commit_update Is String Then
                        MsgBox(commit_update)
                        Exit Sub
                    End If
                    MsgBox("Record moved to spoiled checks")
            End Select



        Else
            MsgBox("error")
            Exit Sub
        End If



        Dim memory_selected = list_balances.SelectedItems(0).Text

        MsgBox("Record updated successfully!")
        get_balances2()



    End Sub

    Private Sub btn_delete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If list_balances.SelectedItems.Count = 0 Then
            MsgBox("Please select data entry from the list before deleting")
            Exit Sub
        End If
        'get master admin's password
        Dim md5_me As MD5 = MD5.Create
        Dim get_admin_password As String = action.GetDetails("password", "user", " WHERE user_type = 'masteradmin'")
        Dim admin_password As String = action.GetMd5Hash(md5_me, "try")

        'prompt for deletion if user_type is not 'masteradmin'
        If admin_dashboard.my_user_type <> "masteradmin" Then
            Dim message, title, defaultValue As String
            Dim myValue As Object
            message = "ENTER ADMIN'S PASSWORD TO proceed"
            ' Set title.
            title = "Prompt for deletion"
            defaultValue = "Please enter password"   ' Set default value.
            Do
                myValue = InputBox(message, title, defaultValue)
                If action.GetMd5Hash(md5_me, myValue) <> admin_password And myValue <> "" Then
                    MsgBox("Wrong password")
                End If
            Loop Until action.GetMd5Hash(md5_me, myValue) = admin_password Or myValue = ""
            If myValue = "" Then
                Exit Sub
            End If

        End If



        If (MessageBox.Show("Are you sure you want to delete this record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If

        Dim commit_delete As Object = action.delete("balance", " WHERE id = '" & list_balances.SelectedItems(0).Text & "'")
        If TypeOf commit_delete Is String Then
            MsgBox(commit_delete)
            Exit Sub

        End If

        'record action
        Dim insert_details As New Dictionary(Of String, String)
        insert_details.Add("username", admin_dashboard.my_username)
        insert_details.Add("action", "deleted record from balance. id is: " & list_balances.SelectedItems(0).Text & ", date issued is: " & list_balances.SelectedItems(0).SubItems(1).Text & ", checkno is: " & list_balances.SelectedItems(0).SubItems(2).Text & ", checkdate is: " & list_balances.SelectedItems(0).SubItems(3).Text & ", payee is: " & list_balances.SelectedItems(0).SubItems(4).Text & ", particular is: " & list_balances.SelectedItems(0).SubItems(5).Text & ", type is: " & list_balances.SelectedItems(0).SubItems(6).Text & ", deposit is: " & list_balances.SelectedItems(0).SubItems(7).Text & ", withdraw is: " & list_balances.SelectedItems(0).SubItems(8).Text)
        insert_details.Add("datetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Dim commit_insert As Object = action.insert("log", insert_details)
        If TypeOf commit_insert Is String Then
            MsgBox(commit_insert)
            Exit Sub
        End If
        MsgBox("Deletion successful!")
        get_balances2()

    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        If (MessageBox.Show("This will recalculate the database. It can be slow depending on the database size. are you sure you want to refresh? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If
     
        get_balances()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        btn_clear_fields_Click_1(sender, e)
        If ToolStripButton2.Text = "SWITCH TO FILTER MODE" Then
            group_query.Location = group_modify.Location
            group_query.Visible = True
            group_modify.Visible = False
            ToolStripButton2.Text = "SWITCH TO MODIFY MODE"
            lbl_summary_report.Enabled = False
            btn_add.Enabled = False

            btn_refresh.Enabled = True
            list_balances.Items.Clear()
            lbl_query_total_deposit_retrieved.Text = ""
            lbl_query_total_records_retrieved.Text = ""
            lbl_query_total_withdraw_retrieved.Text = ""
            state = "query"

            ToolStripButton2.ForeColor = Color.White
        ElseIf ToolStripButton2.Text = "SWITCH TO MODIFY MODE" Then
            group_query.Visible = False
            group_modify.Visible = True
            ToolStripButton2.Text = "SWITCH TO FILTER MODE"

            lbl_summary_report.Enabled = True

            btn_add.Enabled = True

            btn_refresh.Enabled = True

            get_balances2()
            state = "modify"

            ToolStripButton2.ForeColor = Color.Navy
        End If



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_query.Click
        list_balances.Items.Clear()
        query_list(" ORDER BY date")



    End Sub
    Private Sub query_list(ByVal order_by As String)
        Dim date_issued_year As String = cmb_date_issued_year.Text
        Dim date_issued_month As String = cmb_date_issued_month.Text
        Dim date_issued_day As String = cmb_date_issued_day.Text

        If date_issued_year = "" Then
            date_issued_year = "%"
        End If

        If date_issued_month = "" Then
            date_issued_month = "%"
        End If

        If date_issued_day = "" Then
            date_issued_day = "%"
        End If

        Dim add0 As String = "WHERE date LIKE '" & date_issued_year & "-" & date_issued_month & "-" & date_issued_day & "'"

        Dim add1 As String
        Dim particulars As String = txt_query_particulars.Text
        If sanitize(particulars) = "" Then
            add1 = ""
        Else
            add1 = " AND particulars like '%" & particulars & "%'"
        End If


        Dim add2 As String
        Dim checkno As String = txt_query_check_no.Text
        If sanitize(checkno) = "" Then
            add2 = ""
        Else
            add2 = " AND checkno = '" & checkno & "'"
        End If

        Dim add3 As String
        Dim type As String = cmb_query_type.Text
        If sanitize(type) = "" Then
            add3 = ""
        Else
            add3 = " AND type = '" & type & "'"
        End If

        Dim check_date_year As String = cmb_check_date_year.Text
        Dim check_date_month As String = cmb_check_date_month.Text
        Dim check_date_day As String = cmb_check_date_day.Text

        If check_date_year = "" Then
            check_date_year = "%"
        End If

        If check_date_month = "" Then
            check_date_month = "%"
        End If

        If check_date_day = "" Then
            check_date_day = "%"
        End If

        Dim add4 As String = " AND checkdate LIKE '" & check_date_year & "-" & check_date_month & "-" & check_date_day & "'"


        Dim add5 As String
        Dim payee As String = txt_query_name_of_payee.Text
        If sanitize(payee) = "" Then
            add5 = ""
        Else
            add5 = " AND payee like '%" & payee & "%'"
        End If
        Dim query_string As String = ("SELECT * FROM balance " & add0 & add1 & add2 & add3 & add4 & add5 & order_by)
        Dim get_summary As DataTable = action.query("SELECT SUM(withdraw), SUM(deposit) FROM balance " & add0 & add1 & add2 & add3 & add4 & add5)

        If get_summary.Rows(0)(1).ToString = "" Then
            lbl_query_total_deposit_retrieved.Text = "0.00"
        Else
            lbl_query_total_deposit_retrieved.Text = Convert.ToDecimal(get_summary.Rows(0)(1)).ToString("N")
        End If

        If get_summary.Rows(0)(0).ToString = "" Then
            lbl_query_total_withdraw_retrieved.Text = "0.00"
        Else
            lbl_query_total_withdraw_retrieved.Text = Convert.ToDecimal(get_summary.Rows(0)(0)).ToString("N")
        End If

        Dim get_last_balance As Decimal = Convert.ToDecimal(lbl_query_total_deposit_retrieved.Text) - Convert.ToDecimal(lbl_query_total_withdraw_retrieved.Text)
        total_balance = get_last_balance



        'MsgBox(query_string)
        Dim get_query_result As Object = action.query(query_string)
        If TypeOf get_query_result Is String Then
            MsgBox(get_query_result)
            Exit Sub
        End If
        progressbar_form.Show()
        Dim get_query_result_dt As DataTable = get_query_result

        lbl_query_total_records_retrieved.Text = get_query_result_dt.Rows.Count
        progressbar_form.progress_bar.Maximum = get_query_result_dt.Rows.Count


        For i As Integer = 0 To get_query_result_dt.Rows.Count - 1
            progressbar_form.progress_bar.Value += 1
            With list_balances.Items.Add(get_query_result_dt.Rows(i).Item("id").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("date").ToShortDateString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("checkno").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("checkdate").ToShortDateString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("payee").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("particulars").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("type").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("deposit").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("withdraw").ToString)
                .SubItems.Add(get_query_result_dt.Rows(i).Item("amount").ToString)
            End With

        Next
        progressbar_form.Close()
        If get_query_result_dt.Rows.Count = 1 Then
            MsgBox("Query retrieved " & get_query_result_dt.Rows.Count & " result")

        ElseIf get_query_result_dt.Rows.Count > 0 Then
            MsgBox("Query retrieved " & get_query_result_dt.Rows.Count & " results")
        Else
            MsgBox("Query retrieved 0 results")

        End If

    End Sub
    Private Sub lbl_summary_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_summary_report.Click
        MsgBox("TOTAL NUMBER OF RECORDS: ₱" & total_records.ToString("N") & vbNewLine & _
                "TOTAL DEPOSITS (including pending deposits) ₱ " & total_deposit.ToString("N") & vbNewLine & _
                "TOTAL WITHDRAW (including pending withdraws) ₱ " & total_withdraw.ToString("N") & vbNewLine & _
                "TOTAL BALANCE (including pending checks) ₱ " & (total_deposit - total_withdraw).ToString("N")
                )
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        
        SaveFileDialog1.Title = "Save Excel File"
        SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        SaveFileDialog1.ShowDialog()
        ''exit if no file selected
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        'create objects to interface to Excel
        'If Windows.Forms.DialogResult.Cancel Then
        '    Exit Sub
        'End If
        progressbar_form.Show()
        progressbar_form.Text = "PLEASE WAIT WHILE THE SYSTEM EXPORTS THE DATA"

        'SaveFileDialog1.FileName = "print_" & lbl_student_id.Text

        Dim xls As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet
        'create a workbook and get reference to first worksheet
        xls.Workbooks.Add()
        book = xls.ActiveWorkbook
        sheet = book.ActiveSheet
        'step through rows and columns and copy data to worksheet
        Dim row As Integer = 2
        Dim col As Integer = 1
        sheet.Cells(1, 1) = "ID"
        sheet.Cells(1, 2) = "DATE ISSUED"
        sheet.Cells(1, 3) = "CHECK NO."
        sheet.Cells(1, 4) = "CHECK DATE"
        sheet.Cells(1, 5) = "NAME OF PAYEE"
        sheet.Cells(1, 6) = "PARTICULARS"
        sheet.Cells(1, 7) = "TYPE"
        sheet.Cells(1, 8) = "DEPOSIT"
        sheet.Cells(1, 9) = "WITHDRAW"
        sheet.Cells(1, 10) = "BALANCE"

       
        progressbar_form.progress_bar.Maximum = list_balances.Items.Count
        admin_dashboard.lbl_progress.Maximum = list_balances.Items.Count

        For Each item As ListViewItem In list_balances.Items
            admin_dashboard.lbl_progress.Value += 1
            progressbar_form.progress_bar.Value += 1
            For i As Integer = 0 To item.SubItems.Count - 1
                sheet.Cells(row, col) = item.SubItems(i).Text
                col = col + 1
            Next
            row += 1
            col = 1
        Next

        sheet.Cells(row, 7) = "total Withdraw"
        sheet.Cells(row, 9) = lbl_query_total_withdraw_retrieved.Text
        row += 1
        sheet.Cells(row, 7) = "total Deposit"
        sheet.Cells(row, 8) = lbl_query_total_deposit_retrieved.Text
        row += 1
        sheet.Cells(row, 7) = "total Balance"
        sheet.Cells(row, 10) = total_balance.ToString("N")
        Try
            'save the workbook and clean up
            book.SaveAs(SaveFileDialog1.FileName)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        xls.Workbooks.Close()
        xls.Quit()
        releaseObject(sheet)
        releaseObject(book)
        releaseObject(xls)
        admin_dashboard.lbl_progress.Value = 0
        progressbar_form.Close()
        MsgBox("Export successful!")

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btn_clear_fields_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_clear_fields.MouseLeave
        btn_clear_fields.ForeColor = Color.White

    End Sub

    Private Sub btn_clear_fields_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_clear_fields.MouseMove
        btn_clear_fields.ForeColor = Color.Black

    End Sub

    Private Sub btn_update_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_update.MouseLeave
        btn_update.ForeColor = Color.White

    End Sub

    Private Sub btn_update_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_update.MouseMove
        btn_update.ForeColor = Color.Black
    End Sub

    Private Sub btn_delete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_delete.MouseLeave
        btn_delete.ForeColor = Color.White

    End Sub

    Private Sub btn_delete_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_delete.MouseMove
        btn_delete.ForeColor = Color.Black

    End Sub

    Private Sub btn_refresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_refresh.MouseLeave
        btn_refresh.ForeColor = Color.White

    End Sub

    Private Sub btn_refresh_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_refresh.MouseMove
        btn_refresh.ForeColor = Color.Black

    End Sub

    Private Sub ToolStripButton2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.MouseLeave
        If ToolStripButton2.Text = "SWITCH TO FILTER MODE" Then

            ToolStripButton2.ForeColor = Color.White
        ElseIf ToolStripButton2.Text = "SWITCH TO MODIFY MODE" Then
            ToolStripButton2.ForeColor = Color.Navy
        End If

    End Sub

    Private Sub ToolStripButton2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButton2.MouseMove
        ToolStripButton2.ForeColor = Color.Black

    End Sub

    Private Sub lbl_summary_report_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_summary_report.MouseLeave
        lbl_summary_report.ForeColor = Color.White

    End Sub

    Private Sub lbl_summary_report_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_summary_report.MouseMove
        lbl_summary_report.ForeColor = Color.Black

    End Sub

    Private Sub btn_export_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_export.MouseLeave
        btn_export.ForeColor = Color.White

    End Sub

    Private Sub btn_export_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_export.MouseMove
        btn_export.ForeColor = Color.Black

    End Sub

    Private Sub btn_add_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_add.MouseLeave
        btn_add.ForeColor = Color.White

    End Sub

    Private Sub btn_add_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_add.MouseMove
        btn_add.ForeColor = Color.Black

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub btn_refresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh2.Click
        btn_clear_fields_Click_1(sender, e)
        get_balances2()

    End Sub

    Private Sub btn_refresh2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_refresh2.MouseLeave
        btn_refresh2.ForeColor = Color.White

    End Sub

    Private Sub btn_refresh2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_refresh2.MouseMove
        btn_refresh2.ForeColor = Color.Black

    End Sub
End Class