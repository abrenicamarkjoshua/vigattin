Public Class users
    Dim action As New db

    Private Sub users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        get_log("ORDER BY datetime DESC")
        get_users()
        Me.WindowState = FormWindowState.Maximized
        If admin_dashboard.my_user_type <> "masteradmin" Then
            btn_delete_filter.Enabled = False

        End If
    End Sub
    Private Sub get_users()
        list_users.Items.Clear()

        Dim get_users_dt As DataTable = action.query("SELECT * FROM user")
        For i As Integer = 0 To get_users_dt.Rows.Count - 1
            With list_users.Items.Add(get_users_dt.Rows(i).Item("username"))
                .SubItems.add(get_users_dt.Rows(i).Item("user_type"))
                .SubItems.add(get_users_dt.Rows(i).Item("login_status"))

            End With
        Next
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub get_log(ByVal order_by As String, Optional ByVal where As String = "")
        list_log.Items.Clear()

        Dim get_log_dt As DataTable = action.query("SELECT * FROM log " & where & " " & order_by)
        For i As Integer = 0 To get_log_dt.Rows.Count - 1
            With list_log.Items.Add(get_log_dt.Rows(i).Item("username"))
                .SubItems.Add(get_log_dt.Rows(i).Item("action"))
                .SubItems.Add(get_log_dt.Rows(i).Item("datetime").ToString)


            End With
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filter_username.Click
        get_log("WHERE username like '%" & sanitize(query_username.Text) & "%' ORDER BY datetime DESC")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_clear_fields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear_fields.Click
        txt_username.Text = ""
        txt_password.Text = ""
        txt_username.Text = ""
        ErrorProvider1.Clear()
        list_users.SelectedItems.Clear()
        list_log.SelectedItems.Clear()

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        ErrorProvider1.Clear()

        'check for empty fields
        Dim required_fields As New ArrayList
        required_fields.Add(txt_username)
        required_fields.Add(txt_password)
        required_fields.Add(txt_account_type)
        Dim check_fields As Boolean = action.check_field(ErrorProvider1, required_fields)
        If check_fields = False Then
            MsgBox("Please fill up required fields before proceding")
            Exit Sub
        End If
        Dim insert_details As New Dictionary(Of String, String)
        insert_details.Add("username", sanitize(txt_username.Text))
        insert_details.Add("password", sanitize(txt_password.Text))
        insert_details.Add("user_type", sanitize(txt_account_type.Text))
        Dim commit_insert As Object = action.insert("user", insert_details)
        If TypeOf commit_insert Is String Then
            MsgBox(commit_insert)
            Exit Sub
        End If

        MsgBox("user added successfully")


        'Record action
        Dim insert_details_log As New Dictionary(Of String, String)
        insert_details_log.Add("username", admin_dashboard.my_username)
        insert_details_log.Add("action", "added user: " & sanitize(txt_username.Text))
        insert_details_log.Add("datetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Dim commit_record As Object = action.insert("log", insert_details_log)
        If TypeOf commit_record Is String Then
            MsgBox(commit_record)
            Exit Sub
        End If

        btn_clear_fields_Click(sender, e)
        'update lists
        ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub btn_clear_fields_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_clear_fields.MouseLeave
        btn_clear_fields.ForeColor = Color.White

    End Sub

    Private Sub btn_clear_fields_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_clear_fields.MouseMove
        btn_clear_fields.ForeColor = Color.Black

    End Sub

    Private Sub btn_add_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_add.MouseLeave
        btn_add.ForeColor = Color.White

    End Sub

    Private Sub btn_add_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_add.MouseMove
        btn_add.ForeColor = Color.Black

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        If list_users.SelectedItems.Count = 0 Then
            MsgBox("Please select user first from the list before proceding")
            Exit Sub
        End If
        'check for empty fields
        Dim required_fields As New ArrayList
        required_fields.Add(txt_username)
        required_fields.Add(txt_password)
        required_fields.Add(txt_account_type)
        Dim check_fields As Boolean = action.check_field(ErrorProvider1, required_fields)
        If check_fields = False Then
            MsgBox("Please fill up required fields before proceding")
            Exit Sub
        End If

        'prompt for deletion
        If (MessageBox.Show("Are you sure you want to update " & list_users.SelectedItems(0).Text & "'s record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If

        'proceed
        Dim update_details As New Dictionary(Of String, String)
        update_details.Add("username", sanitize(txt_username.Text))
        update_details.Add("password", sanitize(txt_password.Text))
        update_details.Add("user_type", txt_account_type.Text)
        Dim commit_update As Object = action.update("user", update_details, " WHERE username = '" & list_users.SelectedItems(0).Text & "'")
        If TypeOf commit_update Is String Then
            MsgBox(commit_update)
            Exit Sub
        End If
        MsgBox("Update of user information successful")

        'Record action
        Dim insert_details_log As New Dictionary(Of String, String)
        insert_details_log.Add("username", admin_dashboard.my_username)
        insert_details_log.Add("action", "updated user: " & list_users.SelectedItems(0).Text & ". From username: " & list_users.SelectedItems(0).Text & " to " & sanitize(txt_username.Text) & " and user type " & list_users.SelectedItems(0).SubItems(1).Text & " to " & txt_account_type.Text)
        insert_details_log.Add("datetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Dim commit_record As Object = action.insert("log", insert_details_log)
        If TypeOf commit_record Is String Then
            MsgBox(commit_record)
            Exit Sub
        End If

        btn_clear_fields_Click(sender, e)
        'update lists
        ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub btn_update_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_update.MouseLeave
        btn_update.ForeColor = Color.White

    End Sub

    Private Sub btn_update_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_update.MouseMove
        btn_update.ForeColor = Color.Black

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If list_users.SelectedItems.Count = 0 Then
            MsgBox("Please select user first from the list before proceding")
            Exit Sub
        End If

        If list_users.SelectedItems(0).SubItems(2).Text = "yes" Then
            MsgBox("Cannot delete account while online. Please log out that account before proceding")
            Exit Sub
        End If

        If (MessageBox.Show("Are you sure you want to delete " & list_users.SelectedItems(0).Text & "'s record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If

        Dim commit_delete As Object = action.delete("user", " WHERE username = '" & list_users.SelectedItems(0).Text & "'")
        If TypeOf commit_delete Is String Then
            MsgBox(commit_delete)
            Exit Sub
        End If
        MsgBox("user deleted successfully")


        'record action to log
        Dim insert_details As New Dictionary(Of String, String)
        insert_details.Add("username", admin_dashboard.my_username)
        insert_details.Add("action", "deleted user " & list_users.SelectedItems(0).Text)
        insert_details.Add("datetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Dim commit_record As Object = action.insert("log", insert_details)
        If TypeOf commit_record Is String Then
            MsgBox(commit_record)
            Exit Sub

        End If
        btn_clear_fields_Click(sender, e)
        'update lists
        ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub btn_delete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_delete.MouseLeave
        btn_delete.ForeColor = Color.White

    End Sub

    Private Sub btn_delete_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_delete.MouseMove
        btn_delete.ForeColor = Color.Black

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        get_log("ORDER BY datetime DESC")
        get_users()

    End Sub

    Private Sub ToolStripButton1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.MouseLeave
        ToolStripButton1.ForeColor = Color.White

    End Sub

    Private Sub ToolStripButton1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButton1.MouseMove
        ToolStripButton1.ForeColor = Color.Black

    End Sub

    Private Sub list_users_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_users.Click
        action.retriev_users()


    End Sub

    Private Sub list_users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_users.SelectedIndexChanged
        Dim str As String
        For Each itm As ListViewItem In list_users.SelectedItems
            If itm.Selected Then
                action.retriev_users()
            End If
        Next
    End Sub

    Private Sub btn_delete_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_filter.Click
        If (MessageBox.Show("All logs in the list will be deleted. Are you sure you want to delete them? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If
        Dim commit_delete As Object = action.query("DELETE FROM log WHERE username like '%" & sanitize(query_username.Text) & "%'")
        If TypeOf commit_delete Is String Then
            MsgBox(commit_delete)
            Exit Sub
        End If
        MsgBox("Log successfully deleted!")
        get_log(" ORDER BY datetime DESC")
        query_username.Text = ""
    End Sub
End Class