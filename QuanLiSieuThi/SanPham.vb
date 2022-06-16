Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class SanPham
    Dim con As SqlConnection = New SqlConnection("Data Source=ADMIN;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub Load_Data()

        maSPText.Enabled = False
    End Sub
    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_SanPham()
    End Sub

    'Hiển thị db NhânViên
    Dim lenh As String
    Private WithEvents dsSP As BindingManagerBase
    Private Sub Xuat_SanPham()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select * from SanPham"
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

        maSPText.Text = dsSP.Current("maSP")
        nameText.Text = dsSP.Current("tenSP")
        giaText.Text = dsSP.Current("donGiaBan")
        soLuongText.Text = dsSP.Current("soLuongCon")

    End Sub

    ' click rows hiển thị db ra màn hình
    Private Sub ViewSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewSanPham.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewSanPham.Rows(e.RowIndex)
        maSPText.Text = selectedGD.Cells(0).Value
        nameText.Text = selectedGD.Cells(1).Value
        giaText.Text = selectedGD.Cells(2).Value
        soLuongText.Text = selectedGD.Cells(3).Value

    End Sub
    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        maSPText.Text = ""
        nameText.Text = ""
        giaText.Text = ""
        soLuongText.Text = ""
    End Sub

    Private Sub LuuBtn_Click(sender As Object, e As EventArgs) Handles LuuBtn.Click
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Đã thêm") = MsgBoxResult.Yes Then
            If maSPText.Text = "" Or nameText.Text = "" Or giaText.Text = "" Or
            soLuongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "insert into SanPham(tenSP, donGiaBan, soLuongCon) values(N'" & nameText.Text & "','" & giaText.Text & "','" & soLuongText.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_SanPham()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        If MsgBox("Bạn có muốn sửa không? ", vbYesNo, "Đã cập nhật") = MsgBoxResult.Yes Then
            If maSPText.Text = "" Or nameText.Text = "" Or giaText.Text = "" Or
            soLuongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "update  SanPham  set tenSP = N'" & nameText.Text & "',donGiaBan = N'" & giaText.Text & "',soLuongCon = '" & soLuongText.Text & "' where maSP = '" & maSPText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_SanPham()
                MsgBox("Cập nhật thành công!")
            End If
        End If
    End Sub

    Private Sub XoaBtn_Click(sender As Object, e As EventArgs) Handles XoaBtn.Click
        If MsgBox("Bạn có muốn xóa không? ", vbYesNo, "Đã xóa") = MsgBoxResult.Yes Then
            If maSPText.Text = "" Or nameText.Text = "" Or giaText.Text = "" Or
            soLuongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "delete  SanPham  where maSP = '" & maSPText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_SanPham()
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From SanPham WHERE CONCAT(maSP, tenSP) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewSanPham.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub
    Private Sub InBtn_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        ReportSanPham.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewSanPham.Width, Me.ViewSanPham.Height)
        ViewSanPham.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewSanPham.Width, Me.ViewSanPham.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub


End Class