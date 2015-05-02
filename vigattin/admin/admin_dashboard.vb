
Public Class admin_dashboard
   
    Public my_username As String
    Public my_user_type As String

    Dim action As New db

    Private Sub admin_dashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        promptclose(e, my_username)

    End Sub
    Private Sub admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        Me.DoubleBuffered = True
        Timer1.Start()
        post_dated.MdiParent = Me
        post_dated.Show()
        post_dated.Hide()

        check_balance.MdiParent = Me
        check_balance.Show()


        lbl_logged_in_as.Text = "Logged in as: " & my_username
        If my_user_type = "masteradmin" Then
            BACKUPToolStripMenuItem.Visible = True

        Else
            BACKUPToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()


    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    lbl_date_time.Text = Now.ToString

    'End Sub

    Private Sub CASHPAYMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASHPAYMENTToolStripMenuItem.Click
        Dim my_forms As New ArrayList
        my_forms.Add(post_dated)
        my_forms.Add(spoiled_checks)
        my_forms.Add(users)
        my_forms.Add(backup_frm)

        action.hide_and_show(my_forms, check_balance)

    End Sub

    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_date_time.Text = Now
        'check if server is busy or ok
        Dim get_server_status As String = action.GetDetails("status", "system_status", " WHERE status IS NOT NULL")
        If get_server_status = "SERVER BUSY" Then
            lbl_server_status.Text = "SERVER BUSY"
            lbl_server_status.ForeColor = Color.Red
            check_balance.btn_refresh.Enabled = False
        ElseIf get_server_status = "SERVER OK" Then
            lbl_server_status.Text = "SERVER OK"
            lbl_server_status.ForeColor = Color.Green
            check_balance.btn_refresh.Enabled = True
        End If

        'auto backup.
        'if txt_server is "" or '127.0.0.1' or localhost
        'then as a server, autobackup. else, if you're not a server. don't autobackup. and you don't have authority to manual backup.
        If Now.ToString("HH:mm:ss") = "14:43:00" Then
            If login_frm.txt_server.Text = "" Or login_frm.txt_server.Text = "localhost" Or login_frm.txt_server.Text = "127.0.0.1" Then
                backup()
                MsgBox("System automatically backed up the database")
            End If
        End If


    End Sub

    Private Sub SPOILEDCHEQUESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SPOILEDCHEQUESToolStripMenuItem.Click
        Dim my_forms As New ArrayList
        my_forms.Add(check_balance)
        my_forms.Add(post_dated)
        my_forms.Add(users)
        my_forms.Add(backup_frm)
        action.hide_and_show(my_forms, spoiled_checks)

    End Sub

    Private Sub POSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_post_dated.Click
        Dim my_forms As New ArrayList
        my_forms.Add(check_balance)
        my_forms.Add(spoiled_checks)
        my_forms.Add(users)
        my_forms.Add(backup_frm)
        action.hide_and_show(my_forms, post_dated)

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.MouseHover

    End Sub

    Private Sub LogoutToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.MouseLeave
        LogoutToolStripMenuItem.ForeColor = Color.White

    End Sub

    Private Sub LogoutToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LogoutToolStripMenuItem.MouseMove
        LogoutToolStripMenuItem.ForeColor = Color.Black

    End Sub

    Private Sub SPOILEDCHEQUESToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SPOILEDCHEQUESToolStripMenuItem.MouseLeave
        SPOILEDCHEQUESToolStripMenuItem.ForeColor = Color.White

    End Sub

    Private Sub SPOILEDCHEQUESToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SPOILEDCHEQUESToolStripMenuItem.MouseMove
        SPOILEDCHEQUESToolStripMenuItem.ForeColor = Color.Black

    End Sub

    Private Sub POSToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_post_dated.MouseLeave
        menu_post_dated.ForeColor = Color.White

    End Sub

    Private Sub POSToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles menu_post_dated.MouseMove
        menu_post_dated.ForeColor = Color.Black

    End Sub

    Private Sub CASHPAYMENTToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CASHPAYMENTToolStripMenuItem.MouseLeave
        CASHPAYMENTToolStripMenuItem.ForeColor = Color.White

    End Sub

    Private Sub CASHPAYMENTToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CASHPAYMENTToolStripMenuItem.MouseMove
        CASHPAYMENTToolStripMenuItem.ForeColor = Color.Black

    End Sub

    Private Sub VIGATTINCHECKBOOKREGISTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VIGATTINCHECKBOOKREGISTERToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VIGATTINCHECKBOOKREGISTERToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.MouseLeave
        ToolStripMenuItem1.ForeColor = Color.White

    End Sub

    Private Sub ToolStripMenuItem1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripMenuItem1.MouseMove
        ToolStripMenuItem1.ForeColor = Color.Black

    End Sub

    Private Sub USERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERSToolStripMenuItem.Click
        Dim my_forms As New ArrayList
        my_forms.Add(post_dated)
        my_forms.Add(spoiled_checks)
        my_forms.Add(check_balance)
        my_forms.Add(backup_frm)
        action.hide_and_show(my_forms, users)

    End Sub

    Private Sub USERSToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles USERSToolStripMenuItem.DropDownItemClicked

    End Sub

    Private Sub USERSToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles USERSToolStripMenuItem.MouseHover

    End Sub

    Private Sub USERSToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles USERSToolStripMenuItem.MouseLeave
        USERSToolStripMenuItem.ForeColor = Color.White

    End Sub

    Private Sub USERSToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles USERSToolStripMenuItem.MouseMove
        USERSToolStripMenuItem.ForeColor = Color.Black

    End Sub

    Private Sub HideTitleBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_toggle_title.Click
        If Panel1.Height = 50 Then
            Panel1.Height = 90
            lbl_number_of_notifications.Top = 46

        Else
            Panel1.Height = 50

            lbl_number_of_notifications.Top = 5
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Panel1.Height = 50 Then
            submenu_toggle_title.Text = "Show title bar"
        Else
            submenu_toggle_title.Text = "Hide title bar"
        End If
    End Sub

    Private Sub BACKUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKUPToolStripMenuItem.Click
        If login_frm.txt_server.Text = "" Or login_frm.txt_server.Text.ToLower = "localhost" Or login_frm.txt_server.Text = "127.0.0.1" Then

        Else
            MsgBox("Cannot use backup system remotely. please use the server for backing and restore operation")
            Exit Sub
        End If

        Dim my_forms As New ArrayList
        my_forms.Add(check_balance)
        my_forms.Add(post_dated)
        my_forms.Add(users)
        my_forms.Add(spoiled_checks)


        action.hide_and_show(my_forms, backup_frm)
    End Sub
    Public Sub backup(Optional ByVal comment As String = "")
        Dim cur_date2 As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim cur_date As String = Now.ToString("yyyy-MM-dd-HH-mm-ss")
        Dim directory As String = ""
        Try

            progressbar_form.Text = "Please wait while the system backs up the database"
            progressbar_form.progress_bar.Style = ProgressBarStyle.Marquee
            progressbar_form.Show()



            Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password= --host=localhost  --databases newdatabase -r database_backup\" & cur_date & ".sql")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'store information to database
        Dim insert_details As New Dictionary(Of String, String)
        insert_details.Add("id", cur_date)
        insert_details.Add("date", cur_date2)
        insert_details.Add("name", cur_date & ".sql")
        insert_details.Add("comment", comment)
        Dim commit_insert As Object = action.insert("backup", insert_details)
        If TypeOf commit_insert Is String Then
            MsgBox(commit_insert)
            Exit Sub
        End If
        progressbar_form.Close()

        MsgBox("System successfully backed up the database")
    End Sub

    Private Sub BACKUPToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BACKUPToolStripMenuItem.MouseLeave
        BACKUPToolStripMenuItem.ForeColor = Color.White

    End Sub

    Private Sub BACKUPToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BACKUPToolStripMenuItem.MouseMove
        BACKUPToolStripMenuItem.ForeColor = Color.Black

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.MouseLeave
        ToolStripMenuItem2.ForeColor = Color.White

    End Sub

    Private Sub ToolStripMenuItem2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripMenuItem2.MouseMove
        ToolStripMenuItem2.ForeColor = Color.Black

    End Sub
End Class