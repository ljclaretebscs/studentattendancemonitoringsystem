Imports MySql.Data.MySqlClient
Imports System.IO

Public Class EditStudent
    Public myid As String
    Private Sub EditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        students()
    End Sub
    Public Sub students()
        Dim sql = "select ID,Student_ID,Student_Full_Name,FirstName,MiddleName,LastName,Section,Year_Level,Facilitator from addstudenttbl"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        BindingSource1.Filter = "Student_Full_Name like '%" & SearchTxt.Text & "'or Student_ID like '%" & SearchTxt.Text & "%'"
    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        If e.ColumnIndex = StudentDataGridView.Columns("EditStud").Index Then
            If StudentDataGridView.CurrentRow.Cells("Facilitator").Value.ToString <> AdminMenu.NameofUserLbl.Text Then
                MessageBox.Show("You Can't Edit This Student Because Your Not the One Who Registered the Student !", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                myid = StudentDataGridView.CurrentRow.Cells("ID").Value.ToString
                Dim load As New MySqlCommand("Select FirstName,MiddleName,LastName,Address,Student_ID,Address,Section,Year_Level,Gender,Name_of_Contact_Person,Phone_Number,Student_Picture from addstudenttbl where ID='" & myid & "'", con)
                con.Open()
                Dim rd = load.ExecuteReader
                If rd.Read Then
                    EditStudentForm.FirstNameTxt.Text = rd(0).ToString
                    EditStudentForm.MiddleNameTxt.Text = rd(1).ToString
                    EditStudentForm.LastNameTxt.Text = rd(2).ToString
                    EditStudentForm.AddressTxt.Text = rd(3).ToString
                    EditStudentForm.StudentIDTxt.Text = rd(4).ToString
                    EditStudentForm.AddressTxt.Text = rd(5).ToString
                    EditStudentForm.SectionCB.Text = rd(6).ToString
                    EditStudentForm.YearLevelCB.Text = rd(7).ToString
                    EditStudentForm.GenderCB.Text = rd(8).ToString
                    EditStudentForm.ContactPersonTxt.Text = rd(9).ToString
                    EditStudentForm.PhoneNumberTxt.Text = rd(10).ToString
                    Dim img As Byte() = rd(11)
                    Dim ms As MemoryStream = New MemoryStream(img)
                    EditStudentForm.PictureBox1.Image = Image.FromStream(ms)
                    con.Close()
                    rd.Close()
                    EditStudentForm.ShowDialog()
                End If
            End If
        End If

    End Sub

    Private Sub LoadStudBtn_Click(sender As Object, e As EventArgs) Handles LoadStudBtn.Click
        Dim sql = "select ID,Student_ID,Student_Full_Name,FirstName,MiddleName,LastName,Section,Year_Level,Facilitator from addstudenttbl where Facilitator='" & AdminMenu.NameofUserLbl.Text & "'"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub
End Class