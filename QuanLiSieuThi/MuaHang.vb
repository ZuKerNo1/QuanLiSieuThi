Imports System.Data.SqlClient
Public Class MuaHang
    Private Sub MuaHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_SanPham()
    End Sub

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Dim lenh As String
    Private WithEvents dsSP As BindingManagerBase
    Private Sub Xuat_SanPham()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
From SanPham"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("SanPham")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewSanPham.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsSP = Me.BindingContext(dttable)

        txtMaSP.Text = dsSP.Current("Mã sản phẩm")


    End Sub
End Class