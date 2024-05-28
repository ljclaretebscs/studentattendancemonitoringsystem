Imports MySql.Data.MySqlClient
Public Class ChangePassword

    Private Sub UpdatePasswordBtn_Click(sender As Object, e As EventArgs) Handles UpdatePasswordBtn.Click
        If String.IsNullOrWhiteSpace(OldPasswordTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(PasswordTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(ConfirmPasswordTxt.Text.Trim()) Then
            MessageBox.Show("All Fields Required !", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf PasswordTxt.Text <> ConfirmPasswordTxt.Text Then
            MessageBox.Show("Password Does Not Match !", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf PasswordTxt.Text.Length <= 8 Then
            MessageBox.Show("Password Contains 9 Characters !", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim finduser As New MySqlCommand("select Username,Password from adminusertbl where Username='" & AdminMenu.NameofUserLbl.Text & "'and Password=md5('" & OldPasswordTxt.Text & "')", con)
            con.Open()
            Dim rd = finduser.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                con.Close()
                Dim updatepassword As New MySqlCommand("Update adminusertbl Set Password=MD5('" & PasswordTxt.Text & "') Where Username='" & AdminMenu.NameofUserLbl.Text & "'", con)
                con.Open()
                updatepassword.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Changed Password Successfully", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                OldPasswordTxt.Text = ""
                PasswordTxt.Text = ""
                ConfirmPasswordTxt.Text = ""
                Close()
            Else
                con.Close()
                rd.Close()
                MessageBox.Show("Wrong Password !", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            con.Close()
            rd.Close()
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub
End Class