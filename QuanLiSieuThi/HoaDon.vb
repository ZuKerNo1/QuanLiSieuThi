Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class HoaDon
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub Load_Data()

        maHDText.Enabled = False
    End Sub
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_HoaDon()
    End Sub

    'Hiển thị db Hóa Đơn
    Private WithEvents dsHD As BindingManagerBase
    Private Sub Xuat_HoaDon()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV, sum(dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan) as N'Thành tiền'
FROM     dbo.HoaDon INNER JOIN
				dbo.ChiTietHoaDon ON dbo.HoaDon.maHD = dbo.ChiTietHoaDon.maHD INNER JOIN
				dbo.SanPham ON dbo.SanPham.maSP = dbo.ChiTietHoaDon.maSP INNER JOIN
                  dbo.KhachHang ON dbo.HoaDon.maKH = dbo.KhachHang.maKH INNER JOIN
                  dbo.NhanVien ON dbo.HoaDon.maNV = dbo.NhanVien.maNV
GROUP BY dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("HoaDon")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        DataGridView1.DataSource = dttable
        'khoi tao lien ket voi datatable.
        dsHD = Me.BindingContext(dttable)
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