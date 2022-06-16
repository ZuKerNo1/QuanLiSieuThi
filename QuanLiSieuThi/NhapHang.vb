Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class NhapHang
    Dim con As SqlConnection = New SqlConnection("Data Source=ADMIN;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub NhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT dbo.PhieuNhap.maPN, dbo.PhieuNhap.ngayNhapHang, dbo.SanPham.tenSP, dbo.ChiTietPhieuNhap.soLuongNhap,dbo.ChiTietPhieuNhap.donGiaNhap
FROM     dbo.ChiTietPhieuNhap INNER JOIN
                  dbo.PhieuNhap ON dbo.ChiTietPhieuNhap.maPN = dbo.PhieuNhap.maPN INNER JOIN
                  dbo.SanPham ON dbo.ChiTietPhieuNhap.maSP = dbo.SanPham.maSP
WHERE CONCAT(dbo.PhieuNhap.maPN, dbo.SanPham.tenSP) like '%" & valueToSearch & "%'
group by dbo.PhieuNhap .maPN, dbo.PhieuNhap .ngayNhapHang, dbo.SanPham.tenSP, dbo.ChiTietPhieuNhap.soLuongNhap, dbo.ChiTietPhieuNhap.donGiaNhap"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        ReportNhapHang.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub
End Class