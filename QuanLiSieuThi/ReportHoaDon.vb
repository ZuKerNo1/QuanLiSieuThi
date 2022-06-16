Imports System.Data.SqlClient
Public Class ReportHoaDon
    Private Sub ReportHoaDon_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As New DataTable
        Using con As New SqlConnection("Data Source=ADMIN;Initial Catalog=QuanLySieuThi;Integrated Security=True")
            con.Open()
            Using cmd As New SqlCommand("select * from HoaDon", con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
            End Using
        End Using
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\AD\Desktop\QuanLiSieuThi\QuanLiSieuThi\HoaDon.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class