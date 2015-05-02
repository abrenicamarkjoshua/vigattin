Imports System.Data.Odbc
Imports System.Text.RegularExpressions
Imports System
Imports System.Security.Cryptography
Imports System.Text
Public Class db

    '    Dim _ConnectionString = "Driver={MySQL ODBC 3.51 Driver};" & String.Format("Server={0};Database=" + "{1};User={2};password={3};Option=3;", "sql3.freesqldatabase.com", "sql336550", "sql336550", "uW4*qD9*")
    'Dim server As String = login_frm.txt_server.Text
    Public con As New OdbcConnection
    Public da As New OdbcDataAdapter
    Dim dt As New DataTable

    Public Function query(ByVal var_query As String)
        da.Dispose()
        dt.Dispose()
        con.Close()
        Try
            Dim constr As String = "Driver={MySQL ODBC 5.3 UNICODE Driver};Server=" & login_frm.txt_server.Text & ";Database=newdatabase;User=root;Password=;Option=3;"
            'con.ConnectionString = "Driver={MySQL ODBC 3.51 Driver};Server=" & login_frm.txt_server.Text & ";Database=newdatabase;User=username;password=nunaoppa;Option=3;"
            con.ConnectionString = constr

            con.Open()

            dt = New DataTable
            da = New OdbcDataAdapter(var_query, con)
            da.Fill(dt)
            Return dt
            'Return var_query

        Catch ex As Exception
            Return ex.Message.ToString + Environment.NewLine + "Please make sure that the address you provided is correct and that the database server is configured properly!"
        End Try

    End Function
    Public Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash. 
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes 
        ' and create a string. 
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data  
        ' and format each one as a hexadecimal string. 
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string. 
        Return sBuilder.ToString()

    End Function 'GetMd5Hash
    Public Sub clearmemory()
        da.Dispose()
        dt.Dispose()
        con.Close()
    End Sub

    

    Public Function delete(ByVal table As String, ByVal where_clause As String)
        Dim sql_query As String = String.Format("DELETE FROM {0} {1}", table, where_clause)
        Return query(sql_query)
        'debug
        'Return sql_query
        clearmemory()
    End Function

    Public Function update(ByVal table As String, ByVal field_value As Dictionary(Of String, String), ByVal where_clause As String)
        Dim var_fields As String = ""
        Dim var_values As String = ""
        Dim insert_field_value As String = ""
        For Each result As KeyValuePair(Of String, String) In field_value
            If result.Key.ToString = "password" Then
                insert_field_value += "`" + result.Key.ToString + "` = md5('" + result.Value.ToString + "'),"
            
            ElseIf result.Key.ToString = "misc_fee_date_payed" Then
                insert_field_value += "`" + result.Key.ToString + "` = NOW(),"

            Else
                insert_field_value += "`" + result.Key.ToString + "` = '" + result.Value.ToString + "',"
            End If

        Next
        insert_field_value = insert_field_value.Trim().Remove(insert_field_value.Length - 1)

        Try
            Dim sql_query As String = String.Format("UPDATE {0} SET {1} {2}", table, insert_field_value, where_clause)
            'debug
            query(sql_query)
            Return dt
            'Return sql_query
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
        'debug

        clearmemory()
    End Function
    Public Sub retriev_users()
        users.txt_username.Text = users.list_users.SelectedItems(0).Text
        users.txt_account_type.Text = users.list_users.SelectedItems(0).SubItems(1).Text

    End Sub
    Public Sub get_list_balances(ByRef my_id As String)
        'MsgBox(my_id)
        'display in modify mode
        Dim get_data As DataTable = query("SELECT * FROM balance WHERE id = '" & my_id & "'")

        check_balance.date_issued.Text = get_data.Rows(0).Item("date")
        check_balance.txt_particulars.Text = get_data.Rows(0).Item("particulars")
        check_balance.txt_check_no.Text = get_data.Rows(0).Item("checkno")
        check_balance.select_type.Text = get_data.Rows(0).Item("type")
        check_balance.check_date.Text = get_data.Rows(0).Item("checkdate")
        check_balance.txt_name_of_payee.Text = get_data.Rows(0).Item("payee")
        Dim get_amount As String
        Select Case get_data.Rows(0).Item("type")
            Case "Deposit"
                get_amount = get_data.Rows(0).Item("deposit")
            Case "Withdraw"
                get_amount = get_data.Rows(0).Item("withdraw")
        End Select
        check_balance.txt_amount.Text = get_amount
        check_balance.txt_query_amount.Text = get_amount

        check_balance.txt_name_of_payee.Text = get_data.Rows(0).Item("payee")

        'display items in query mode
        check_balance.cmb_date_issued_year.Text = Date.Parse(get_data.Rows(0).Item("date")).ToString("yyy")
        check_balance.cmb_date_issued_month.Text = Date.Parse(get_data.Rows(0).Item("date")).ToString("MM")
        check_balance.cmb_date_issued_day.Text = Date.Parse(get_data.Rows(0).Item("date")).ToString("dd")
        check_balance.cmb_check_date_year.Text = Date.Parse(get_data.Rows(0).Item("checkdate")).ToString("yyy")
        check_balance.cmb_check_date_month.Text = Date.Parse(get_data.Rows(0).Item("checkdate")).ToString("MM")
        check_balance.cmb_check_date_day.Text = Date.Parse(get_data.Rows(0).Item("checkdate")).ToString("dd")
        check_balance.txt_particulars.Text = get_data.Rows(0).Item("particulars")
        check_balance.txt_query_check_no.Text = get_data.Rows(0).Item("checkno")
        check_balance.cmb_query_type.Text = get_data.Rows(0).Item("type")
        check_balance.check_date.Text = get_data.Rows(0).Item("checkdate")
        check_balance.txt_query_name_of_payee.Text = get_data.Rows(0).Item("payee")
        check_balance.txt_query_particulars.Text = get_data.Rows(0).Item("particulars")
        Select Case get_data.Rows(0).Item("type")
            Case "Deposit"
                get_amount = get_data.Rows(0).Item("deposit")
            Case "Withdraw"
                get_amount = get_data.Rows(0).Item("withdraw")
        End Select
      

        check_balance.txt_query_name_of_payee.Text = get_data.Rows(0).Item("payee")

    End Sub
    Public Sub login(ByVal username As String, ByVal password As String)

        Dim get_result As Object = query("SELECT * FROM user WHERE username = '" + username + "' AND password = left(md5('" + password + "') ,32)")
        If TypeOf get_result Is String Then
            MsgBox(get_result)
            MsgBox("Please make sure that you're database server is running and configured correctly")
            Exit Sub
        Else
            Dim result As DataTable = get_result

            If result.Rows.Count > 0 Then
                'set_login_status(username, "yes")
                'Select Case result.Rows(0).Item("status")
                '    Case 1
                '        Select Case result.Rows(0).Item("UserLevel")
                '            Case "Admin"
                login_frm.Hide()
                login_frm.Hide()
                admin_dashboard.my_username = username
                admin_dashboard.my_user_type = result.Rows(0).Item("user_type")
                admin_dashboard.Show()
                admin_dashboard.lbl_username.Text = username
                Dim insert_values As New Dictionary(Of String, String)
                insert_values.Add("username", username)
                insert_values.Add("action", "logged in")

                insert_values.Add("datetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))

                Dim commit_insert As Object = insert("log", insert_values)
                If TypeOf commit_insert Is String Then
                    MsgBox(commit_insert)
                    Exit Sub
                End If

                set_login_status(username, "yes")


                '        End Select
                '    Case 2
                'MsgBox("Account not yet activated by the admin")
                'End Select
            Else
                MsgBox("Login details not found in database. Failed logging you in")

            End If

        End If

    End Sub

    Public Sub set_login_status(ByVal username As String, ByVal status As String)
        Dim update_details As New Dictionary(Of String, String)
        update_details.Add("login_status", status)
        Dim result As Object = update("user", update_details, " WHERE username = '" + username + "'")
        If TypeOf result Is String Then
            MsgBox(result)
            Exit Sub
        End If
    End Sub

    Public Function insert(ByVal table As String, ByVal field_value As Dictionary(Of String, String))
        Dim var_fields As String = ""
        Dim var_values As String = ""

        For Each get_value As KeyValuePair(Of String, String) In field_value
            If get_value.Key.ToString = "password" Then
                var_fields += "`" + get_value.Key.ToString + "`,"
                var_values += "md5('" + get_value.Value.ToString + "'),"

            ElseIf get_value.Key.ToString = "date_payed" Then
                var_fields += "`date_payed`,"
                var_values += "NOW(),"

            Else
                var_fields += "`" + get_value.Key.ToString + "`,"
                var_values += "'" + get_value.Value + "',"

            End If

        Next
        var_fields = var_fields.Trim().Remove(var_fields.Length - 1)
        var_values = var_values.Trim().Remove(var_values.Length - 1)

        Dim sql As String = String.Format("INSERT INTO {0}({1}) VALUES ({2})", table, var_fields, var_values)
        'If there Then 's error in querying
        Dim result As Object = query(sql)
        If TypeOf result Is String Then
            Dim error_message As String = result
            Return error_message
        Else
            Return result
        End If

        'Debug
        'Return sql

        clearmemory()

    End Function
    
    Public Function register(ByVal field_value As Dictionary(Of String, String), ByVal table As String)
        Dim var_fields As String = ""
        Dim var_values As String = ""

        For Each result As KeyValuePair(Of String, String) In field_value
            var_fields += "`" + result.Key.ToString + "`,"
            If result.Key.ToString = "password" Then
                var_values += "md5('" + result.Value.ToString + "'),"
            Else
                var_values += "'" + result.Value.ToString + "',"
            End If
        Next
        var_fields = var_fields.Trim().Remove(var_fields.Length - 1)
        var_values = var_values.Trim().Remove(var_values.Length - 1)

        Dim sql As String = String.Format("INSERT INTO {0}({1}) VALUES ({2})", table, var_fields, var_values)

        Return query(sql)

    End Function
    Public Function try_if_existing3(ByVal field_value As Dictionary(Of String, String), ByVal table As String, ByVal count_column As String)

        Dim var_fields As String = ""
        Dim var_values As String = ""
        Dim insert_field_value As String = ""

        For Each result As KeyValuePair(Of String, String) In field_value

            insert_field_value &= "`" & result.Key.ToString & "` = '" & result.Value & "' AND "
        Next
        insert_field_value = insert_field_value.Trim().Remove(insert_field_value.Length - 4)
        Dim var_my_query As String = "SELECT count(" + count_column + ") FROM " + table + " WHERE " + insert_field_value + ""
        Dim my_result As Object = query(var_my_query)
        If TypeOf my_result Is String Then
            Return my_result
        ElseIf TypeOf my_result Is DataTable Then
            Dim my_result2 As DataTable = my_result
            If Convert.ToInt16(my_result2.Rows(0).Item(0)) > 0 Then
                Return True
            Else
                Return False
            End If
        End If
        'Return var_my_query
    End Function


    Public Function try_if_existing2(ByVal field_value As Dictionary(Of String, String), ByVal table As String, ByVal count_column As String)
        Dim var_fields As String = ""
        Dim var_values As String = ""
        Dim insert_field_value As String = ""
        For Each result As KeyValuePair(Of String, String) In field_value

            insert_field_value += "`" + result.Key.ToString + "` = '" + result.Value.ToString + "' AND "
        Next
        insert_field_value = insert_field_value.Trim().Remove(insert_field_value.Length - 4)
        Dim var_my_query As String = "SELECT count(" + count_column + ") FROM " + table + " WHERE " + insert_field_value + ""
        Dim my_result As Object = query(var_my_query)
        Return my_result
        'Return var_my_query
    End Function
    'Public Function try_if_existing(ByVal field_value As Dictionary(Of String, String), ByVal table As String)
    '    Dim var_fields As String = ""
    '    Dim var_values As String = ""
    '    Dim insert_field_value As String = ""
    '    For Each result As KeyValuePair(Of String, String) In field_value

    '        insert_field_value += "`" + result.Key.ToString + "` = '" + result.Value.ToString + "' AND "
    '    Next
    '    insert_field_value = insert_field_value.Trim().Remove(insert_field_value.Length - 4)
    '    Dim var_my_query As String = "SELECT count(id) FROM " + table + " WHERE " + insert_field_value + ""
    '    Dim my_result As Object = query(var_my_query)
    '    Return my_result
    '    'Return var_my_query
    'End Function

    Public Function GetDetails(ByVal item As String, ByVal table As String, ByVal where_clause As String)
        Dim result As Object = query("SELECT " + item + " FROM " + table + " " + where_clause + "")
        If TypeOf result Is String Then
            Return result
        Else
            Return result.Rows(0).Item(item).ToString
        End If

    End Function
    Public Sub hide_and_show(ByRef array_forms As ArrayList, ByVal show_form As Form)
        For Each forms As Form In array_forms
            forms.Hide()
        Next
        show_form.MdiParent = admin_dashboard
        show_form.WindowState = FormWindowState.Maximized
        show_form.Show()
        admin_dashboard.lbl_current_form.Text = "CURRENT MODULE: " & show_form.Text
        
    End Sub
    Public Sub logout(ByVal username As String)
        set_login_status(username, "no")
        show_login()

    End Sub
    Public Function check_field(ByRef errorprovider As ErrorProvider, ByVal my_fields As ArrayList)
        Dim return_value As Boolean = True
        For Each item As Control In my_fields
            If String.IsNullOrEmpty(sanitize(item.Text)) Then
                errorprovider.SetError(item, "This field is required")
                return_value = False
            End If
            
        Next
        Return return_value
    End Function
    Public Function must_be_number(ByRef errorprovider As ErrorProvider, ByVal my_fields As ArrayList)
        Dim return_value As Boolean = True
        For Each item As Control In my_fields
            If IsNumeric(sanitize(item.Text)) = False Then
                errorprovider.SetError(item, "This field must be numeric")
                return_value = False
            End If

        Next
        Return return_value
    End Function
    Public Function getdata(ByVal item As String, ByVal mydatatable As DataTable)
        Return mydatatable.Rows(0).Item(item)
    End Function


    Public Sub insert_to_student_balance(ByVal student_id As String, ByVal name As String)

        '''''insert to accounting clearance `student_balance` details
        Dim my_field_value As New Dictionary(Of String, String)
        my_field_value.Add("student_id", student_id)
        my_field_value.Add("name", name)
        'register student's accounting clearance account
        Dim myresult2 As Object = insert("student_balance", my_field_value)
        'check for system bug
        If TypeOf myresult2 Is String Then
            'throw error if there's any
            MsgBox(myresult2)
            Exit Sub
        Else
            'throw confirmation
            ' MsgBox("Student successfully created clearance account")

        End If
        '''''end register to accounting clearance `student_balance` table


    End Sub
    Public Sub update_student_balance(ByVal student_id As String, ByVal orig_amount As Decimal, ByVal amount_paid As Decimal, ByVal remaining_balance As Decimal, ByVal total_penalty As Decimal, ByVal new_balance As Decimal)

        '''''insert to accounting clearance `student_balance` details
        Dim my_field_value As New Dictionary(Of String, String)
        my_field_value.Add("orig_balance", orig_amount.ToString)
        my_field_value.Add("amount_paid", amount_paid.ToString)
        my_field_value.Add("remaining_balance", remaining_balance.ToString)
        my_field_value.Add("total_penalty", total_penalty.ToString)
        my_field_value.Add("new_balance", new_balance.ToString)

        'register student's accounting clearance account
        Dim myresult2 As Object = update("student_balance", my_field_value, " WHERE student_id = '" & student_id & "'")
        'check for system bug
        If TypeOf myresult2 Is String Then
            'throw error if there's any
            MsgBox(myresult2)
            Exit Sub
        Else
            'throw confirmation
            MsgBox("Student clearance account successfully updated")

        End If
        '''''end register to accounting clearance `student_balance` table


    End Sub

    
   
   
   
End Class
