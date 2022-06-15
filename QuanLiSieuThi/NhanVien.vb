Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class NhanVien
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub Load_Data()

        maNVText.Enabled = False
    End Sub
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_dsNV()
    End Sub


    'Hiển thị db NhânViên

    Private WithEvents dsNV As BindingManagerBase
    Private Sub Xuat_dsNV()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select * from NhanVien"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("NhanVien")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewNhanVien.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsNV = Me.BindingContext(dttable)

        maNVText.Text = dsNV.Current("maNV")
        nameText.Text = dsNV.Current("tenNV")
        sdtText.Text = dsNV.Current("SDT")
        mailText.Text = dsNV.Current("email")
        chucVuText.Text = dsNV.Current("chucVu")
        luongText.Text = dsNV.Current("luong")

    End Sub



    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        maNVText.Text = ""
        maNVText.Enabled = False
        nameText.Text = ""
        sdtText.Text = ""
        mailText.Text = ""
        chucVuText.Text = ""
        luongText.Text = ""
    End Sub


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From NhanVien WHERE CONCAT(maNV, tenNV, email, chucVu) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewNhanVien.DataSource = table
    End Sub
    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub

    Private Sub InBtn_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewNhanVien.Width, Me.ViewNhanVien.Height)
        ViewNhanVien.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewNhanVien.Width, Me.ViewNhanVien.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub
End Class