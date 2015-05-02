Public Class post_dated
    Dim action As New db

    Private Sub post_dated_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        get_pending_withdraws()
    End Sub
    Private Sub get_pending_withdraws()
        'clear the lists first
        list_pending_deposits.Items.Clear()
        list_pending_withdraws.Items.Clear()
        lbl_notification.Items.Clear()
        Dim notification_number As Integer = 0

        'get pending withdraws and populate the lists
        Dim get_pending_withdraws As Object = action.query("SELECT * FROM balance WHERE checkdate > CURDATE() AND type = 'Withdraw'")
        If TypeOf get_pending_withdraws Is String Then
            MsgBox(get_pending_withdraws)
            Exit Sub
        End If

        Dim get_pending_withdraws_dt As DataTable = get_pending_withdraws
        'show progress bar if records are too many
        progressbar_form.Show()
        progressbar_form.Text = "PLEASE WAIT WHILE SYSTEM FETCH PENDING WITHDRAWS"
        progressbar_form.progress_bar.Maximum = get_pending_withdraws_dt.Rows.Count

        For i As Integer = 0 To get_pending_withdraws_dt.Rows.Count - 1
            progressbar_form.progress_bar.Value += 1
            'if current checkdate is due tomorrow, add notification
            If Date.Parse(get_pending_withdraws_dt.Rows(i).Item("checkdate")).AddDays(-1) = Date.Now.ToShortDateString Then
                notification_number += 1
                lbl_notification.Items.Add("Check  No. '" & get_pending_withdraws_dt.Rows(i).Item("checkno").ToString & "' is scheduled tomorrow. Details: type 'DEPOSIT', payee '" & get_pending_withdraws_dt.Rows(i).Item("payee") & "' amount '" & Convert.ToDecimal(get_pending_withdraws_dt.Rows(i).Item("withdraw")).ToString("N") & "'" & vbNewLine)
            End If

            With list_pending_withdraws.Items.Add(get_pending_withdraws_dt.Rows(i).Item("id"))
                .SubItems.Add(get_pending_withdraws_dt.Rows(i).Item("date").ToShortDateString)
                .SubItems.Add(get_pending_withdraws_dt.Rows(i).Item("checkno").ToString)
                .SubItems.Add(get_pending_withdraws_dt.Rows(i).Item("checkdate").ToShortDateString)
                .SubItems.Add(get_pending_withdraws_dt.Rows(i).Item("payee").ToString)
                .SubItems.Add(get_pending_withdraws_dt.Rows(i).Item("particulars").ToString)
                .SubItems.Add(Convert.ToDecimal(get_pending_withdraws_dt.Rows(i).Item("withdraw")).ToString("N"))
            End With
        Next
        progressbar_form.Close()


        'get pending deposits
        Dim get_pending_deposit As Object = action.query("SELECT * FROM balance WHERE checkdate > CURDATE() AND type = 'Deposit'")
        If TypeOf get_pending_deposit Is String Then
            MsgBox(get_pending_deposit)
            Exit Sub
        End If
        Dim get_pending_deposit_dt As DataTable = get_pending_deposit
        'Show progress bar
        progressbar_form.Show()
        progressbar_form.progress_bar.Maximum = get_pending_deposit_dt.Rows.Count

        For i As Integer = 0 To get_pending_deposit_dt.Rows.Count - 1
            progressbar_form.progress_bar.Value += 1

            'if current checkdate is due tomorrow, add notification
            If Date.Parse(get_pending_deposit_dt.Rows(i).Item("checkdate")).AddDays(-1) = Date.Now.ToShortDateString Then
                notification_number += 1
                lbl_notification.Items.Add("Check  No. '" & get_pending_deposit_dt.Rows(i).Item("checkno").ToString & "' is scheduled tomorrow. Details: type 'DEPOSIT', payee '" & get_pending_deposit_dt.Rows(i).Item("payee") & "' amount '" & Convert.ToDecimal(get_pending_deposit_dt.Rows(i).Item("deposit")).ToString("N") & "'" & vbNewLine)

            End If
            With list_pending_deposits.Items.Add(get_pending_deposit_dt.Rows(i).Item("id"))
                .SubItems.Add(get_pending_deposit_dt.Rows(i).Item("date").ToShortDateString)
                .SubItems.Add(get_pending_deposit_dt.Rows(i).Item("checkno").ToString)
                .SubItems.Add(get_pending_deposit_dt.Rows(i).Item("checkdate").ToShortDateString)
                .SubItems.Add(get_pending_deposit_dt.Rows(i).Item("payee").ToString)
                .SubItems.Add(get_pending_deposit_dt.Rows(i).Item("particulars").ToString)
                .SubItems.Add(Convert.ToDecimal(get_pending_deposit.Rows(i).Item("deposit")).ToString("N"))
            End With
        Next
        progressbar_form.Close()

        'get the summary
        Dim get_summary_deposit As DataTable = action.query("SELECT SUM(deposit) FROM balance WHERE checkdate > CURDATE() and type = 'Deposit'")
        Dim get_summary_withdraw As DataTable = action.query("SELECT SUM(withdraw) FROM balance WHERE checkdate > CURDATE() and type = 'Withdraw'")

        If get_summary_deposit.Rows(0).Item(0).ToString = "" Then
            lbl_pending_deposits.Text = "0.00"
        Else
            lbl_pending_deposits.Text = Convert.ToDecimal(get_summary_deposit.Rows(0).Item(0)).ToString("N")

        End If

        If get_summary_withdraw.Rows(0).Item(0).ToString = "" Then
            lbl_pending_withdraw.Text = "0.00"
        Else
            lbl_pending_withdraw.Text = Convert.ToDecimal(get_summary_withdraw.Rows(0).Item(0)).ToString("N")

        End If

        If notification_number > 0 Then
            admin_dashboard.lbl_number_of_notifications.Text = notification_number
        Else
            admin_dashboard.lbl_number_of_notifications.Text = ""

        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        get_pending_withdraws()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class