Imports QRCoder

Public Class GenerateQrCode

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub CreateQRcodeBtn_Click(sender As Object, e As EventArgs) Handles CreateQRcodeBtn.Click
        If String.IsNullOrWhiteSpace(AddStudent.StudentIDTxt.Text.Trim()) Then
            MessageBox.Show("Student ID Required !", "Generate Qr Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim gen As New QRCodeGenerator
            Dim data = gen.CreateQrCode(AddStudent.StudentIDTxt.Text, QRCodeGenerator.ECCLevel.Q)
            Dim qrcode As New QRCode(data)
            PictureBox1.Image = qrcode.GetGraphic(6)
        End If
       
    End Sub

    Private Sub SaveQrcodeBtn_Click(sender As Object, e As EventArgs) Handles SaveQrcodeBtn.Click
        SaveFileQrcode.FileName = AddStudent.StudentIDTxt.Text
        If SaveFileQrcode.FileName = "" Then
            MessageBox.Show("No Qrcode Uploaded Please Create New One !", "Save Qr Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            SaveFileQrcode.FileName = AddStudent.StudentIDTxt.Text + ".png"
            Dim pic As Image
            pic = PictureBox1.Image
            SaveFileQrcode.ShowDialog()
            pic.Save(SaveFileQrcode.FileName.ToString)
            
        End If
    End Sub
End Class