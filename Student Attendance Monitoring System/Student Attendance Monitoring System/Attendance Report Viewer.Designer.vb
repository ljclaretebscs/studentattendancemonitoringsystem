<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance_Report_Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance_Report_Viewer))
        Me.attendancetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.studentattendancesystemdbDataSet = New Student_Attendance_Monitoring_System.studentattendancesystemdbDataSet()
        Me.DatePickerAttendance = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.attendancetblTableAdapter = New Student_Attendance_Monitoring_System.studentattendancesystemdbDataSetTableAdapters.attendancetblTableAdapter()
        CType(Me.attendancetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentattendancesystemdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'attendancetblBindingSource
        '
        Me.attendancetblBindingSource.DataMember = "attendancetbl"
        Me.attendancetblBindingSource.DataSource = Me.studentattendancesystemdbDataSet
        '
        'studentattendancesystemdbDataSet
        '
        Me.studentattendancesystemdbDataSet.DataSetName = "studentattendancesystemdbDataSet"
        Me.studentattendancesystemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatePickerAttendance
        '
        Me.DatePickerAttendance.BackColor = System.Drawing.Color.Transparent
        Me.DatePickerAttendance.BaseColor = System.Drawing.Color.Transparent
        Me.DatePickerAttendance.BorderColor = System.Drawing.Color.Transparent
        Me.DatePickerAttendance.CustomFormat = "MMMM-dd-yyyy"
        Me.DatePickerAttendance.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DatePickerAttendance.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatePickerAttendance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickerAttendance.ForeColor = System.Drawing.Color.Black
        Me.DatePickerAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePickerAttendance.Location = New System.Drawing.Point(12, 27)
        Me.DatePickerAttendance.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePickerAttendance.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePickerAttendance.Name = "DatePickerAttendance"
        Me.DatePickerAttendance.OnHoverBaseColor = System.Drawing.Color.White
        Me.DatePickerAttendance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatePickerAttendance.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatePickerAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.DatePickerAttendance.Size = New System.Drawing.Size(181, 30)
        Me.DatePickerAttendance.TabIndex = 2
        Me.DatePickerAttendance.Text = "November-18-2022"
        Me.DatePickerAttendance.Value = New Date(2022, 11, 18, 5, 17, 43, 268)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.attendancetblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Student_Attendance_Monitoring_System.AttendanceReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(780, 558)
        Me.ReportViewer1.TabIndex = 0
        '
        'attendancetblTableAdapter
        '
        Me.attendancetblTableAdapter.ClearBeforeFill = True
        '
        'Attendance_Report_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 633)
        Me.Controls.Add(Me.DatePickerAttendance)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendance_Report_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance_Report_Viewer"
        CType(Me.attendancetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentattendancesystemdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatePickerAttendance As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents attendancetblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents studentattendancesystemdbDataSet As Student_Attendance_Monitoring_System.studentattendancesystemdbDataSet
    Friend WithEvents attendancetblTableAdapter As Student_Attendance_Monitoring_System.studentattendancesystemdbDataSetTableAdapters.attendancetblTableAdapter
End Class
