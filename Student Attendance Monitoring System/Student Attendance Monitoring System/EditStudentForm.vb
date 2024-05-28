Imports MySql.Data.MySqlClient
Imports System.IO

Public Class EditStudentForm

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub EditStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsection()
        loadyearlevel()
    End Sub


    Private Sub UpdateStudentBtn_Click(sender As Object, e As EventArgs) Handles UpdateStudentBtn.Click
        If String.IsNullOrWhiteSpace(FirstNameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(MiddleNameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(LastNameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(StudentIDTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(AddressTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(ContactPersonTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(PhoneNumberTxt.Text.Trim()) Or GenderCB.Text = "" Or YearLevelCB.Text = "" Or SectionCB.Text = "" Then
            MessageBox.Show("All Fields Required !", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim update As New MySqlCommand("update addstudenttbl set FirstName='" & FirstNameTxt.Text & "',MiddleName='" & MiddleNameTxt.Text & "',LastName='" & LastNameTxt.Text & "',Address='" & AddressTxt.Text & "',Student_Full_Name='" & FirstNameTxt.Text + " " + MiddleNameTxt.Text + " " + LastNameTxt.Text & "',Gender='" & GenderCB.Text & "',Section='" & SectionCB.Text & "',Year_Level='" & YearLevelCB.Text & "',Name_of_Contact_Person='" & ContactPersonTxt.Text & "',Phone_Number='" & PhoneNumberTxt.Text & "',Student_Picture=@pic where Student_ID='" & StudentIDTxt.Text & "'", con)
            con.Open()
            update.Parameters.Add("@pic", MySqlDbType.Blob).Value = ms.ToArray()
            update.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Student Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AdminMenu.editstudent()
            Close()
        End If

    End Sub
    Public Sub loadsection()
        Dim sql = "select Section from sectiontbl"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        SectionCB.DataSource = ds.Tables(0)
        SectionCB.DisplayMember = "Section"
        SectionCB.ValueMember = "Section"
    End Sub

    Public Sub loadyearlevel()
        Dim sql = "select Year_Level from yearleveltbl"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        YearLevelCB.DataSource = ds.Tables(0)
        YearLevelCB.DisplayMember = "Year_Level"
        YearLevelCB.ValueMember = "Year_Level"
    End Sub

    Private Sub UploadStudentPictureBtn_Click(sender As Object, e As EventArgs) Handles UploadStudentPictureBtn.Click
        OpenFileDialog1.Filter = "Choose Student Picture(*.JPG;*.PNG;*.JPEG;*.GIF)|*.jpg;*.png;*.jpeg;*.gif"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub DeleteStudentBtn_Click(sender As Object, e As EventArgs) Handles DeleteStudentBtn.Click
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmDelete = DialogResult.Yes Then
            Try
                Dim studentID As Integer = Integer.Parse(StudentIDTxt.Text)

                ' Delete the student from the database
                Dim deleteCmd As New MySqlCommand("DELETE FROM addstudenttbl WHERE Student_ID = @id", con)
                deleteCmd.Parameters.AddWithValue("@id", studentID)
                con.Open()
                deleteCmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Student successfully deleted.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AdminMenu.editstudent()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error deleting student: " + ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Function PictureBox2() As Object
        Throw New NotImplementedException
    End Function

End Class