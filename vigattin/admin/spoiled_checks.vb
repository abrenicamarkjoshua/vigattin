Public Class spoiled_checks
    Dim action As New db

    Private Sub spoiled_checks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        get_spoiled()

    End Sub
    Private Sub get_spoiled()
        list_spoiled.Items.Clear()

        Dim get_spoiled As Object = action.query("SELECT * FROM spoiled")
        If TypeOf get_spoiled Is String Then
            MsgBox(get_spoiled)
            Exit Sub
        End If
        Dim get_spoiled_dt As DataTable = get_spoiled
        progressbar_form.Show()
        progressbar_form.progress_bar.Maximum = get_spoiled_dt.Rows.Count

        For i As Integer = 0 To get_spoiled_dt.Rows.Count - 1
            progressbar_form.progress_bar.Value += 1

            With list_spoiled.Items.Add(get_spoiled_dt.Rows(i).Item("id"))
                .SubItems.Add(get_spoiled_dt.Rows(i).Item("date").ToShortDateString)
                .SubItems.Add(get_spoiled_dt.Rows(i).Item("checkno").ToString)
                .SubItems.Add(get_spoiled_dt.Rows(i).Item("checkdate").ToShortDateString)
                .SubItems.Add(get_spoiled_dt.Rows(i).Item("payee").ToString)
                .SubItems.Add(get_spoiled_dt.Rows(i).Item("particulars").ToString)
                .SubItems.Add(Convert.ToDecimal(get_spoiled_dt.Rows(i).Item("amount")).ToString("N"))
            End With
        Next
        progressbar_form.Close()
        Dim get_spoiled_sum As DataTable = action.query("SELECT SUM(amount) FROM spoiled")
        lbl_spoiled.Text = Convert.ToDecimal(get_spoiled_sum.Rows(0).Item(0)).ToString("N")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        get_spoiled()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If list_spoiled.SelectedItems.Count = 0 Then
            MsgBox("Please select data entry from the list before deleting")
            Exit Sub
        End If

        If (MessageBox.Show("Are you sure you want to delete this record? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            Exit Sub
        End If

        Dim commit_delete As Object = action.delete("spoiled", " WHERE id = '" & list_spoiled.SelectedItems(0).Text & "'")
        If TypeOf commit_delete Is String Then
            MsgBox(commit_delete)
            Exit Sub

        End If
        get_spoiled()

        MsgBox("Deletion successful!")
    End Sub

    Private Sub list_spoiled_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_spoiled.SelectedIndexChanged
        
    End Sub
End Class