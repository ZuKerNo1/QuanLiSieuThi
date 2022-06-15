Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class KhachHang
    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub Load_Data()
        DsKhachHang1.Clear()
        OleDbDataAdapter1.Fill(DsKhachHang1)
        maKHText.Enabled = False
    End Sub

    Private Sub KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If maKHText.Text = "" Then
                MsgBox("Không thể sửa khi đang thêm!!!")
            Else
                Try
                    OleDbConnection1.Open()
                    Dim sql As String = "Update KhachHang set tenKH= N'" &
                    nameText.Text & "', diaChiKH= N'" & dChiText.Text & "', SDT= '" &
                    sdtText.Text & "', Email= '" & mailText.Text & "' where maKH = '" & maKHText.Text & "'"
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
    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        maKHText.Text = ""
        maKHText.Enabled = False
        nameText.Text = ""
        dChiText.Text = ""
        sdtText.Text = ""
        mailText.Text = ""
    End Sub

    Private Sub LuuBtn_Click(sender As Object, e As EventArgs) Handles LuuBtn.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If nameText.Text = "" Or dChiText.Text = "" Or
           sdtText.Text = "" Or mailText.Text = "" Then
                MsgBox("Chưa nhập giá trị!!!")
            Else
                Try
                    OleDbConnection1.Open()
                    Dim sql As String = "insert into KhachHang values(N'" &
                    nameText.Text & "', N'" & dChiText.Text & "', '" &
                    sdtText.Text & "', '" &
                    mailText.Text & "')"
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
                Dim sql As String = "delete from KhachHang where maKH = '" & maKHText.Text & "'"
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
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From KhachHang WHERE CONCAT(tenKH, diaChiKH, Email) like '%" & valueToSearch & "%'"
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