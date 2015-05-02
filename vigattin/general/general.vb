Imports System
Imports System.Security.Cryptography
Imports System.Text
Module general

    Public Sub closeall()

        login_frm.Dispose()
        admin_dashboard.Dispose()

    End Sub
 
    Public Sub validate_input(ByVal my_type As String, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal rules As ArrayList, ByVal limit As Integer, ByRef mytextbox As TextBox)
        Dim mylength As Integer = mytextbox.Text.Count
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        ElseIf mylength >= limit Then
            e.Handled = True
            Exit Sub
        End If

        Select Case my_type
            Case "string"
                Dim status As String = "special character and number"
                For Each rule As String In rules
                    If Char.IsLetter(e.KeyChar) = True Or e.KeyChar = ControlChars.Back Then
                        e.KeyChar = UCase(e.KeyChar)
                        e.Handled = False
                        status = "clear"
                        Exit For
                    ElseIf Char.IsNumber(e.KeyChar) = True Then
                        e.Handled = True
                        Exit For
                    ElseIf e.KeyChar = rule Then
                        e.Handled = False
                        status = "clear"
                        Exit For
                    End If

                Next
                If status = "special character and number" Then
                    e.Handled = True
                    mytextbox.Focus()
                    MsgBox("Special characters and numbers are not allowed in this text field")
                    mytextbox.Focus()
                End If

            Case "integer"
                Dim status As String = "special character and string"
                For Each rule As String In rules
                    If Char.IsLetter(e.KeyChar) = True Then
                        e.Handled = True
                        Exit For
                    ElseIf Char.IsNumber(e.KeyChar) = True Or e.KeyChar = ControlChars.Back Then
                        e.Handled = False
                        status = "clear"
                        Exit For
                    ElseIf e.KeyChar = rule Then
                        e.Handled = False
                        status = "clear"
                        Exit For
                    End If
                Next
                If status = "special character and string" Then
                    e.Handled = True
                    mytextbox.Focus()
                    MsgBox("special characters and letters are not allowed in this text field")
                    mytextbox.Focus()
                End If
            Case "alphanumeric"
                Dim status As String = "special character"
                For Each rule As String In rules
                    If Char.IsLetterOrDigit(e.KeyChar) = True Or e.KeyChar = ControlChars.Back Then
                        e.KeyChar = UCase(e.KeyChar)
                        e.Handled = False
                        status = "clear"
                        Exit For
                    ElseIf e.KeyChar = rule Then
                        e.Handled = False
                        status = "clear"
                        Exit For
                    End If

                Next
                If status = "special character" Then
                    e.Handled = True
                    'MsgBox("Special characters are not allowed in this text field")
                    mytextbox.Focus()
                End If

        End Select
    End Sub

    Public Sub clear_controls(ByRef my_controls As ArrayList, ByRef myform As Form)
        For Each my_control As Control In my_controls
            my_control.Text = ""
        Next
    End Sub
    Public Sub promptclose2(ByVal e As System.Windows.Forms.FormClosingEventArgs, ByVal form_name As String)
        If (MessageBox.Show("Are you sure you want to close this window '" + form_name + "'? ", "Confirm close program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Public Sub promptclose(ByVal e As System.Windows.Forms.FormClosingEventArgs, ByVal username As String)
        If (MessageBox.Show(username & ", are you sure you want to log out? ", "Confirm close program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else

            e.Cancel = False
            Dim action As New db
            action.logout(username)


        End If
    End Sub
    Public Function sanitize(ByVal var_string As String) As String
        Dim sanitizedstring As String = Trim(var_string).Replace("  ", " ").Replace("\", "\\").Replace("'", "`")
        Return sanitizedstring
    End Function
    Public Sub clear(ByRef form As Form)

        For Each control As Object In form.Controls
            'level 0
            If TypeOf (control) Is System.Windows.Forms.TextBox Or TypeOf (control) Is System.Windows.Forms.ComboBox Then
                control.Text = ""

            End If

            'level 1 (group box)
            If TypeOf control Is System.Windows.Forms.GroupBox Then
                Dim mygroupbox As GroupBox = control
                mygroupbox.Parent = form
                'level 0 -> level 0
                For Each sub_control As Control In mygroupbox.Controls
                    If TypeOf sub_control Is Windows.Forms.TextBox Or TypeOf sub_control Is Windows.Forms.ComboBox Then
                        sub_control.Text = ""
                    End If

                Next
            End If

            'level 2 (tab control)
            If TypeOf control Is System.Windows.Forms.TabControl Then
                Dim mytabcontrol As TabControl = control
                mytabcontrol.Parent = form

                For Each sub_control As Object In mytabcontrol.Controls
                    'level 2 -> level 0
                    If TypeOf sub_control Is Windows.Forms.TextBox Then
                        sub_control.Text = ""
                    End If
                    'level 2 -> level 1
                    If TypeOf sub_control Is TabPage Then
                        Dim mytabpage As TabPage = sub_control
                        mytabpage.Parent = control

                        'level 2 -> level 1 -> level 0
                        For Each mycontrol As Control In mytabpage.Controls
                            If TypeOf mycontrol Is TextBox Then
                                mycontrol.Text = ""
                            End If
                            If TypeOf mycontrol Is Label Then
                                mycontrol.Text = ""
                            End If
                            'level 2 -> level 2-> level 1 -> level 0
                            If TypeOf mycontrol Is GroupBox Then

                                For Each sub_sub_control As Object In mycontrol.Controls
                                    If TypeOf sub_sub_control Is Windows.Forms.TextBox Then
                                        sub_sub_control.Text = ""
                                    End If
                                Next
                            End If
                            'extra
                            If TypeOf mycontrol Is TabPage Then
                                For Each mysub_control As Control In mycontrol.Controls
                                    If TypeOf mysub_control Is TextBox Then
                                        mysub_control.Text = ""
                                    End If

                                Next
                            End If


                        Next
                        For Each sub_sub_control As Object In mytabpage.Controls
                            If TypeOf sub_sub_control Is GroupBox Then
                                Dim mygroupbox As GroupBox = sub_sub_control
                                mygroupbox.Parent = sub_control

                                For Each sub_sub_sub_control As Control In mygroupbox.Controls
                                    If TypeOf sub_control Is Windows.Forms.TextBox Then
                                        sub_sub_sub_control.Text = ""
                                    End If
                                Next
                            End If
                        Next
                    End If
                    If TypeOf sub_control Is System.Windows.Forms.GroupBox Then
                        Dim mygroupbox As GroupBox = control
                        mygroupbox.Parent = form

                        For Each sub_sub_control As Control In mygroupbox.Controls
                            If TypeOf sub_sub_control Is Windows.Forms.TextBox Then
                                sub_control.Text = ""
                            End If
                        Next
                    End If
                Next
            End If
        Next

    End Sub
    Public Sub field_validate(ByVal myform As Form.ControlCollection, ByRef myerrorprovider As ErrorProvider)
        Dim varreturn As Boolean

        For Each c As Control In myform
            If TypeOf c Is TextBox Then
                If (CType(c, TextBox).Text.Trim() = String.Empty) Then
                    myerrorprovider.SetError(c, "Required field.")

                    Exit For
                Else 'If (CType(c, TextBox).Text.Trim()  String.Empty) Then
                    myerrorprovider.SetError(c, String.Empty)
                    varreturn = False

                End If
            End If
        Next

    End Sub
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

    Public Sub show_login()
        login_frm.txt_password.Text = ""

        login_frm.Show()

    End Sub

End Module
