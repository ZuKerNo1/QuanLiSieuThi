Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class NhanVien
    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub Load_Data()
        DsNhanVien1.Clear()
        OleDbDataAdapter1.Fill(DsNhanVien1)
        maNVText.Enabled = False
    End Sub
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
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

    Private Sub LuuBtn_Click(sender As Object, e As EventArgs) Handles LuuBtn.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If nameText.Text = "" Or sdtText.Text = "" Or mailText.Text = "" Or
                chucVuText.Text = "" Or luongText.Text = "" Then
                MsgBox("Chưa nhập giá trị!!!")
            Else
                Try
                    OleDbConnection1.Open()
                    Dim sql As String = "insert into NhanVien values(N'" & nameText.Text & "',
                    N'" & sdtText.Text & "', '" &
                    mailText.Text & "', '" & chucVuText.Text & "', '" & luongText.Text & "')"
                    OleDbInsertCommand1.CommandText = sql
                    OleDbInsertCommand1.ExecuteNonQuery()
                    OleDbConnection1.Close()
                    Load_Data()
                    MsgBox("Đã thêm!")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub XoaBtn_Click(sender As Object, e As EventArgs) Handles XoaBtn.Click
        If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                OleDbConnection1.Open()
                Dim sql As String = "delete from NhanVien where maNV = '" & maNVText.Text & "'"
                OleDbInsertCommand1.CommandText = sql
                OleDbInsertCommand1.ExecuteNonQuery()
                OleDbConnection1.Close()
                Load_Data()
                MsgBox("Đã xóa!")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If maNVText.Text = "" Then
                MsgBox("Không thể sửa khi đang thêm!!!")
            Else
                Try
                    OleDbConnection1.Open()
                    Dim sql As String = "Update NhanVien set tenNV= N'" &
                    nameText.Text & "', SDT= '" & sdtText.Text & "', 
                    email= '" & mailText.Text & "',chucVu= '" & chucVuText.Text & "' ,luong= '" & luongText.Text & "' where maNV = '" & maNVText.Text & "'"
                    OleDbUpdateCommand1.CommandText = sql
                    OleDbUpdateCommand1.ExecuteNonQuery()
                    OleDbConnection1.Close()
                    Load_Data()
                    MsgBox("Đã sửa!")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From NhanVien WHERE CONCAT(maNV, tenNV, email, chucVu) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
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
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub
End Class