Imports MySql.Data.MySqlClient
Public Class Login

    


    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UsernameTxt.Text = "" Then
            WarningLbl.Text = "Username Required !"
        ElseIf PasswordTxt.Text = "" Then
            WarningLbl.Text = "Password Required !"
        Else
            Try
                Dim login As New MySqlCommand("Select Facilitator_FullName from adminusertbl where BINARY Username='" & UsernameTxt.Text & "'and Password=MD5('" & PasswordTxt.Text & "')", con)
                con.Open()
                Dim rd = login.ExecuteReader
                If rd.Read Then
                    AdminMenu.NameofUserLbl.Text = rd(0).ToString
                    con.Close()
                    rd.Close()
                    AdminMenu.Show()
                    Hide()
                    UsernameTxt.Text = ""
                    PasswordTxt.Text = ""
                    WarningLbl.Text = ""
                Else
                    con.Close()
                    rd.Close()
                    WarningLbl.Text = "Wrong Username or Password !"
                End If
            Catch ex As Exception
                con.Close()
                WarningLbl.Text = "Database is Missing Please Contact an Admin to Fix It !"
            End Try
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Exit Application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ScanningAttendance.Show()
        ScanningAttendance.Activate()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If PasswordTxt.UseSystemPasswordChar = True Then
            PasswordTxt.UseSystemPasswordChar = False
        Else
            PasswordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub WarningLbl_Click(sender As Object, e As EventArgs) Handles WarningLbl.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UsernameTxt_TextChanged(sender As Object, e As EventArgs) Handles UsernameTxt.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PasswordTxt_TextChanged(sender As Object, e As EventArgs) Handles PasswordTxt.TextChanged

    End Sub
End Class
