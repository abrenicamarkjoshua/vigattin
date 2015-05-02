Public Class login_frm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_username.Text = "Mark Joshua R. Abrenica" Then
            MsgBox("Developed this system")
            Exit Sub
        End If
        Dim action As New db
        Dim my_username As String = sanitize(txt_username.Text)
        Dim my_password As String = sanitize(txt_password.Text)
        action.login(my_username, my_password)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()


    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1_Click(sender, e)

        End If
    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub login_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True


        Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (Me.Height / 2) - (Panel1.Height / 2)

    End Sub

    Private Sub btn_login_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_login.MouseLeave
        btn_login.ForeColor = Color.White

    End Sub

    Private Sub btn_login_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_login.MouseMove
        btn_login.ForeColor = Color.Black

    End Sub

    Private Sub btn_exit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_exit.MouseLeave
        btn_exit.ForeColor = Color.White

    End Sub

    Private Sub btn_exit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_exit.MouseMove
        btn_exit.ForeColor = Color.Black

    End Sub
End Class