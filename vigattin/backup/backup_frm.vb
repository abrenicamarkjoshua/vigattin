Imports System.IO
Public Class backup_frm
    Dim action As New db

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_comment.Click

    End Sub

    Private Sub btn_clear_fields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_backup.Click
        If (MessageBox.Show("This will backup the database. Please click 'yes' to confirm", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If

        Dim comment As String = sanitize(txt_comment.Text)
        admin_dashboard.backup(comment)
        txt_comment.Text = ""
        get_backup()
    End Sub
    Private Sub get_backup()
        list_backup.Items.Clear()
        Dim get_backup_dt As DataTable = action.query("SELECT * FROM backup ORDER BY date DESC")
        For i As Integer = 0 To get_backup_dt.Rows.Count - 1
            With list_backup.Items.Add(get_backup_dt.Rows(i).Item("id"))

                .SubItems.Add(get_backup_dt.Rows(i).Item("date").ToString())
                .SubItems.Add(get_backup_dt.Rows(i).Item("comment"))
                .SubItems.Add(get_backup_dt.Rows(i).Item("name").ToString())

            End With
        Next
    End Sub

    Private Sub backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        get_backup()

    End Sub

    Private Sub btn_restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restore.Click
        If list_backup.SelectedItems.Count = 0 Then
            MsgBox("Please select restore points from the list before proceding")
            Exit Sub
        End If
        If (MessageBox.Show("This will restore the database " & list_backup.SelectedItems(0).SubItems(1).Text & ". Please click 'yes' to confirm", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If
        Try
            'Process.Start("C:\xampp\mysql\bin\mysqlimport.exe", "-u username -p  ""newdatabase"" < """ & Application.StartupPath & "\database_backup\" & list_backup.SelectedItems.Item(0).SubItems(3).Text & "")

            'MessageBox.Show("-u username -p nunaoppa newdatabase < " & Application.StartupPath & "\database_backup\" & list_backup.SelectedItems.Item(0).SubItems(3).Text & ".sql")
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root --password= -h localhost ""newdatabase"" < """ + Application.StartupPath & "\database_backup\" & list_backup.SelectedItems.Item(0).SubItems(3).Text + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class