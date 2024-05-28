Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Ports
Public Class ScanningAttendance
    'Declare Variable
    Dim CAMERA As VideoCaptureDevice
    Dim reader As New QRCodeDecoder
    Dim bmp As Bitmap
    Dim globalsms As String
    Private Sub ScanningAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opening Camera
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()
        End If

    End Sub
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        'captured pic and set to bitmap
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Scanner_Tick(sender As Object, e As EventArgs) Handles Scanner.Tick
        'Scanning Qr Code
        Try

            If AttendanceCB.Text = "Time In" Then
                Dim id As String
                reader = New QRCodeDecoder
                id = reader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
                StudentIDTxt.Text = id
                'Read Student Info
                Dim r As New MySqlCommand("select Student_Full_Name,Section,Year_Level,Phone_Number,Student_Picture,Facilitator from addstudenttbl where Student_ID='" & StudentIDTxt.Text & "'", con)
                con.Open()
                Dim rd = r.ExecuteReader
                If rd.Read Then
                    Dim fullname = rd(0).ToString
                    StudentNameTxt.Text = rd(0).ToString
                    Dim section = rd(1).ToString
                    Dim Yearlevel = rd(2).ToString
                    Dim pnumber = rd(3).ToString
                    Dim img As Byte() = rd(4)
                    Dim ms As MemoryStream = New MemoryStream(img)
                    PictureBox2.Image = Image.FromStream(ms)
                    Dim facilitator = rd(5).ToString
                    rd.Close()
                    con.Close()
                    Dim rdd As New MySqlCommand("Select * from attendancetbl where Student_ID='" & StudentIDTxt.Text & "'and Student_Name='" & fullname & "'and Attendance_Date='" & DateLbl.Text & "'", con)
                    con.Open()
                    Dim rd2 = rdd.ExecuteReader
                    If rd2.HasRows Then
                        rd2.Close()
                        StudentIDTxt.Text = "YOU ARE ALREADY TIME IN!"
                        StudentNameTxt.Text = ""
                        PictureBox2.Image = Nothing
                        My.Computer.Audio.Play(My.Resources.windows_error__1_, AudioPlayMode.Background)
                        con.Close()
                    Else
                        rd2.Close()
                        con.Close()
                        Dim save As New MySqlCommand("Insert into Attendancetbl(Student_Name,Student_ID,Section,Year_Level,TimeIn,TimeOut,Attendance_Date,Facilitator)values('" & fullname & "','" & StudentIDTxt.Text & "','" & section & "','" & Yearlevel & "','" & TimeLbl.Text & "','No Time Out Record','" & DateLbl.Text & "','" & facilitator & "')", con)
                        con.Open()
                        save.ExecuteNonQuery()
                        My.Computer.Audio.Play(My.Resources.timein, AudioPlayMode.Background)
                        con.Close()
                        Try
                            globalsms = fullname + " Has Successfully Time In Today " + vbNewLine + "Date: " + DateTime.Now.ToString("hh:mm:ss tt MMMM-dd-yyyy") + vbNewLine + "From University of Caloocan City - Congressional Campus"
                            Dim SerialPort As New SerialPort
                            SerialPort.PortName = "COM9"
                            SerialPort.BaudRate = 9600
                        SerialPort.Parity = Parity.None
                            SerialPort.StopBits = StopBits.One
                        SerialPort.DataBits = 8
                        SerialPort.Handshake = Handshake.RequestToSend
                        SerialPort.DtrEnable = True
                        SerialPort.RtsEnable = True
                        SerialPort.NewLine = vbCrLf
                        SerialPort.Open()

                        If SerialPort.IsOpen = True Then
                            SerialPort.Write("AT" & vbCrLf)
                            SerialPort.Write("AT+CMGF=1" & vbCrLf)
                            SerialPort.Write("AT+CMGS=" & Chr(34) & (pnumber) & Chr(34) & vbCrLf)
                                SerialPort.Write(globalsms & Chr(26))
                            End If
                            SerialPort.Close()
                        Catch ex As Exception
                            WarningLbl.Text = "SMS Not Available Change Modem COMPORT to COM256 and Disconnect and Connect the Device Again"
                        End Try
                    End If
                Else
                    con.Close()
                    rd.Close()
                    StudentIDTxt.Text = "No ID Detected"
                    My.Computer.Audio.Play(My.Resources.windows_error__1_, AudioPlayMode.Background)
                    PictureBox2.Image = Nothing
                    StudentNameTxt.Text = ""
                    WarningLbl.Text = ""
                End If
            ElseIf AttendanceCB.Text = "Time Out" Then
                Dim id As String
                reader = New QRCodeDecoder
                id = reader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
                StudentIDTxt.Text = id

                Dim r As New MySqlCommand("select Student_Full_Name,Section,Year_Level,Phone_Number,Student_Picture,Facilitator from addstudenttbl where Student_ID='" & StudentIDTxt.Text & "'", con)
                con.Open()
                Dim rd = r.ExecuteReader
                If rd.Read Then
                    Dim fullname = rd(0).ToString
                    StudentNameTxt.Text = rd(0).ToString
                    Dim section = rd(1).ToString
                    Dim Yearlevel = rd(2).ToString
                    Dim pnumber = rd(3).ToString
                    Dim img As Byte() = rd(4)
                    Dim ms As MemoryStream = New MemoryStream(img)
                    PictureBox2.Image = Image.FromStream(ms)
                    rd.Close()
                    con.Close()
                    Dim rdd As New MySqlCommand("Select * from attendancetbl where Student_ID='" & StudentIDTxt.Text & "'and Student_Name='" & fullname & "'and Attendance_Date='" & DateLbl.Text & "'", con)
                    con.Open()
                    Dim rd2 = rdd.ExecuteReader
                    If rd2.HasRows Then
                 
                        rd2.Close()
                        con.Close()
                        Dim save As New MySqlCommand("Update Attendancetbl set TimeOut='" & TimeLbl.Text & "'where Student_ID='" & StudentIDTxt.Text & "'and Attendance_Date='" & DateLbl.Text & "'", con)
                        con.Open()
                        save.ExecuteNonQuery()
                        My.Computer.Audio.Play(My.Resources.timein, AudioPlayMode.Background)
                        con.Close()
                        Try
                            globalsms = fullname + " Has Successfully Time Out Today " + vbNewLine + "Date: " + DateTime.Now.ToString("hh:mm:ss tt MMMM-dd-yyyy") + vbNewLine + "From University of Caloocan City - Congressional Campus"
                            Dim SerialPort As New SerialPort
                            SerialPort.PortName = "COM9"
                            SerialPort.BaudRate = 9600
                        SerialPort.Parity = Parity.None
                            SerialPort.StopBits = StopBits.One
                        SerialPort.DataBits = 8
                        SerialPort.Handshake = Handshake.RequestToSend
                        SerialPort.DtrEnable = True
                        SerialPort.RtsEnable = True
                        SerialPort.NewLine = vbCrLf
                        SerialPort.Open()

                        If SerialPort.IsOpen = True Then
                            SerialPort.Write("AT" & vbCrLf)
                            SerialPort.Write("AT+CMGF=1" & vbCrLf)
                            SerialPort.Write("AT+CMGS=" & Chr(34) & (pnumber) & Chr(34) & vbCrLf)
                                SerialPort.Write(globalsms & Chr(26))
                        End If
                        Catch ex As Exception
                            WarningLbl.Text = "SMS Not Available Change Modem COMPORT to COM9 and Disconnect and Connect the Device Again"
                        End Try
                    Else
                        rd2.Close()
                        StudentIDTxt.Text = "No Time In "
                        StudentNameTxt.Text = ""
                        PictureBox2.Image = Nothing
                        My.Computer.Audio.Play(My.Resources.windows_error__1_, AudioPlayMode.Background)
                        WarningLbl.Text = ""
                        con.Close()
                    End If
                Else
                    con.Close()
                    rd.Close()
                    StudentIDTxt.Text = "No ID Detected"
                    My.Computer.Audio.Play(My.Resources.windows_error__1_, AudioPlayMode.Background)
                    PictureBox2.Image = Nothing
                    StudentNameTxt.Text = ""
                End If
            End If
        Catch ex As Exception
            Scanner.Start()
            StudentIDTxt.Text = ""
            StudentNameTxt.Text = ""
            PictureBox2.Image = Nothing
        End Try


    End Sub
    Private Sub timedate_Tick(sender As Object, e As EventArgs) Handles timedate.Tick
        TimeLbl.Text = DateTime.Now.ToString("hh:mm:ss tt")
        DateLbl.Text = DateTime.Now.ToString("MMMM-dd-yyyy")
    End Sub
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Try
            CAMERA.Stop()
            Close()
        Catch ex As Exception
            Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class