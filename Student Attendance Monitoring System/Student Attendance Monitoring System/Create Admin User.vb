Imports MySql.Data.MySqlClient
Public Class Create_Admin_User

    Private Sub CreateUserBtn_Click(sender As Object, e As EventArgs) Handles CreateUserBtn.Click
        If String.IsNullOrWhiteSpace(FacilitatorNameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(UsernameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(PasswordTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(ConfirmPasswordTxt.Text.Trim()) Then
            MessageBox.Show("All Fields Required !", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf PasswordTxt.Text.Length <= 8 Then
            MessageBox.Show("Password Contains 8 Characters !", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf UsernameTxt.Text.Length <= 8 Then
            MessageBox.Show("Username Contains 9 Characters !", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf PasswordTxt.Text <> ConfirmPasswordTxt.Text Then
            MessageBox.Show("Password Does Not Match !", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim create As New MySqlCommand("insert into adminusertbl(Username,Password,Facilitator_FullName)values('" & UsernameTxt.Text & "',MD5('" & PasswordTxt.Text & "'),'" & FacilitatorNameTxt.Text & "')", con)
                con.Open()
                create.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Admin Created", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PasswordTxt.Text = ""
                UsernameTxt.Text = ""
                ConfirmPasswordTxt.Text = ""
                FacilitatorNameTxt.Text = ""
            Catch ex As Exception
                con.Close()
                MessageBox.Show("Username Already Exist !", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub
End Class