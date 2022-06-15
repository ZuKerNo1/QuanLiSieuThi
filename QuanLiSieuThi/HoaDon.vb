Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class HoaDon
    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub Load_Data()
        DsHoaDon1.Clear()
        OleDbDataAdapter1.Fill(DsHoaDon1)
        maHDText.Enabled = False
    End Sub
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub


    Public Sub xemChiTiet(idHD As Integer)
        Try
            OleDbConnection1.Open()
            Dim sql As String = "select * from ChiTietHoaDon
            INNER JOIN HoaDon ON ChiTietHoaDon.maHD = HoaDon.maHD
            INNER JOIN SanPham ON SanPham.maSP = ChiTietHoaDon.maSP
            where HoaDon.maHD = '" & idHD & "'  "
            OleDbCommand1.CommandText = sql
            OleDbCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            Load_Data()
            MsgBox("Đã mở!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV, SUM(dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan) AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.KhachHang ON dbo.HoaDon.maKH = dbo.KhachHang.maKH INNER JOIN
                  dbo.NhanVien ON dbo.HoaDon.maNV = dbo.NhanVien.maNV INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
WHERE CONCAT(dbo.HoaDon.maHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV) like '%" & valueToSearch & "%'
GROUP BY dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV"
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
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub
End Class