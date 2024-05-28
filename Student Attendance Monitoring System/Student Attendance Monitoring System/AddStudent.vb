Imports QRCoder
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class AddStudent

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub SaveStudentBtn_Click(sender As Object, e As EventArgs) Handles SaveStudentBtn.Click
        If String.IsNullOrWhiteSpace(FirstNameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(LastNameTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(StudentIDTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(AddressTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(ContactPersonTxt.Text.Trim()) Or String.IsNullOrWhiteSpace(PhoneNumberTxt.Text.Trim()) Or GenderCB.Text = "" Or YearLevelCB.Text = "" Or SectionCB.Text = "" Then
            MessageBox.Show("All Fields Required !", "Save Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ms As New MemoryStream
                Dim ms2 As New MemoryStream
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
                PictureBox1.Image.Save(ms2, PictureBox1.Image.RawFormat)
                Dim insert As New MySqlCommand("insert into addstudenttbl(Qrcode,FirstName,MiddleName,LastName,Student_Full_Name,Section,Year_Level,Gender,Name_of_Contact_Person,Phone_Number,Address,Student_ID,Facilitator,Student_Picture)values(@pic,'" & FirstNameTxt.Text & "','" & MiddleNameTxt.Text & "','" & LastNameTxt.Text & "','" & FirstNameTxt.Text + " " + MiddleNameTxt.Text + " " + LastNameTxt.Text & "','" & SectionCB.Text & "','" & YearLevelCB.Text & "','" & GenderCB.Text & "','" & ContactPersonTxt.Text & "','" & PhoneNumberTxt.Text & "','" & AddressTxt.Text & "','" & StudentIDTxt.Text & "','" & AdminMenu.NameofUserLbl.Text & "',@pic2)", con)
                con.Open()
                insert.Parameters.Add("@pic", MySqlDbType.Blob).Value = ms.ToArray()
                insert.Parameters.Add("@pic2", MySqlDbType.Blob).Value = ms2.ToArray()
                insert.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Student Registered", "Save Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FirstNameTxt.Text = ""
                MiddleNameTxt.Text = ""
                LastNameTxt.Text = ""
                AddressTxt.Text = ""
                StudentIDTxt.Text = ""
                OpenFileDialog.FileName = ""
                PhoneNumberTxt.Text = ""
                GenderCB.Text = ""
                PhoneNumberTxt.Text = ""
                ContactPersonTxt.Text = ""
                SectionCB.Text = ""
                YearLevelCB.Text = ""
                PictureBox2.Image = My.Resources.barcode
                PictureBox1.Image = My.Resources.user
                AdminMenu.searchstudent()
            Catch ex As Exception
                con.Close()
                MessageBox.Show("Student ID Already Exist ! or Student Picture is Limited in 1mb Only !", "Save Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub



    Private Sub GenerateBtn_Click(sender As Object, e As EventArgs) Handles GenerateBtn.Click
        GenerateQrCode.Show()
        GenerateQrCode.Activate()
    End Sub

    Private Sub UploadQrCodeBtn_Click(sender As Object, e As EventArgs) Handles UploadQrCodeBtn.Click
        OpenFileDialog.Filter = "Choose QRCODE Picture(*.JPG;*.PNG;*.JPEG;*.GIF)|*.jpg;*.png;*.jpeg;*.gif"
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsection()
        loadyearlevel()
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

    Private Sub StudentIDTxt_TextChanged(sender As Object, e As EventArgs) Handles StudentIDTxt.TextChanged
        Dim currentYear As Integer = DateTime.Now.Year
        Dim studentID As String = currentYear.ToString() + "0001"
        Dim count As Integer = 1
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM addstudenttbl WHERE Student_ID LIKE '%" & currentYear.ToString() & "%'", con)
        con.Open()
        count = cmd.ExecuteScalar() + 1
        con.Close()
        studentID = currentYear.ToString() + count.ToString().PadLeft(4, "0"c)
        StudentIDTxt.Text = studentID
    End Sub

    Private Sub YearLevelCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearLevelCB.SelectedIndexChanged

    End Sub
End Class