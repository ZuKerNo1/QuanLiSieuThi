<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HoaDon))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTaoHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsHoaDon1 = New QuanLiSieuThi.DsHoaDon()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.soLuongText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.giaText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maHDText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tienText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHoaDon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLIRDA11;Data Source=LAPTOP-9TCJRCKI\KVU;Integrated Security=SSPI;In" &
    "itial Catalog=QuanLySieuThi"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HoaDon", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("maHD", "maHD"), New System.Data.Common.DataColumnMapping("ngayTaoHD", "ngayTaoHD"), New System.Data.Common.DataColumnMapping("tenKH", "tenKH"), New System.Data.Common.DataColumnMapping("tenNV", "tenNV"), New System.Data.Common.DataColumnMapping("TongTien", "TongTien")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbCommand3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaHDDataGridViewTextBoxColumn, Me.NgayTaoHDDataGridViewTextBoxColumn, Me.TenKHDataGridViewTextBoxColumn, Me.TenNVDataGridViewTextBoxColumn, Me.TongTienDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "HoaDon"
        Me.DataGridView1.DataSource = Me.DsHoaDon1
        Me.DataGridView1.Location = New System.Drawing.Point(64, 392)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(907, 296)
        Me.DataGridView1.TabIndex = 0
        '
        'MaHDDataGridViewTextBoxColumn
        '
        Me.MaHDDataGridViewTextBoxColumn.DataPropertyName = "maHD"
        Me.MaHDDataGridViewTextBoxColumn.HeaderText = "maHD"
        Me.MaHDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaHDDataGridViewTextBoxColumn.Name = "MaHDDataGridViewTextBoxColumn"
        Me.MaHDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaHDDataGridViewTextBoxColumn.Width = 125
        '
        'NgayTaoHDDataGridViewTextBoxColumn
        '
        Me.NgayTaoHDDataGridViewTextBoxColumn.DataPropertyName = "ngayTaoHD"
        Me.NgayTaoHDDataGridViewTextBoxColumn.HeaderText = "ngayTaoHD"
        Me.NgayTaoHDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgayTaoHDDataGridViewTextBoxColumn.Name = "NgayTaoHDDataGridViewTextBoxColumn"
        Me.NgayTaoHDDataGridViewTextBoxColumn.Width = 125
        '
        'TenKHDataGridViewTextBoxColumn
        '
        Me.TenKHDataGridViewTextBoxColumn.DataPropertyName = "tenKH"
        Me.TenKHDataGridViewTextBoxColumn.HeaderText = "tenKH"
        Me.TenKHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenKHDataGridViewTextBoxColumn.Name = "TenKHDataGridViewTextBoxColumn"
        Me.TenKHDataGridViewTextBoxColumn.Width = 125
        '
        'TenNVDataGridViewTextBoxColumn
        '
        Me.TenNVDataGridViewTextBoxColumn.DataPropertyName = "tenNV"
        Me.TenNVDataGridViewTextBoxColumn.HeaderText = "tenNV"
        Me.TenNVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenNVDataGridViewTextBoxColumn.Name = "TenNVDataGridViewTextBoxColumn"
        Me.TenNVDataGridViewTextBoxColumn.Width = 125
        '
        'TongTienDataGridViewTextBoxColumn
        '
        Me.TongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien"
        Me.TongTienDataGridViewTextBoxColumn.HeaderText = "TongTien"
        Me.TongTienDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TongTienDataGridViewTextBoxColumn.Name = "TongTienDataGridViewTextBoxColumn"
        Me.TongTienDataGridViewTextBoxColumn.ReadOnly = True
        Me.TongTienDataGridViewTextBoxColumn.Width = 125
        '
        'DsHoaDon1
        '
        Me.DsHoaDon1.DataSetName = "DsHoaDon"
        Me.DsHoaDon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1049, 96)
        Me.Panel2.TabIndex = 6
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(366, 33)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(319, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH HÓA ĐƠN"
        '
        'soLuongText
        '
        Me.soLuongText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsHoaDon1, "HoaDon.tenNV", True))
        Me.soLuongText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soLuongText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.soLuongText.Location = New System.Drawing.Point(593, 175)
        Me.soLuongText.Name = "soLuongText"
        Me.soLuongText.Size = New System.Drawing.Size(270, 27)
        Me.soLuongText.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(466, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "NV phụ trách"
        '
        'giaText
        '
        Me.giaText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsHoaDon1, "HoaDon.tenKH", True))
        Me.giaText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.giaText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.giaText.Location = New System.Drawing.Point(593, 117)
        Me.giaText.Name = "giaText"
        Me.giaText.Size = New System.Drawing.Size(270, 27)
        Me.giaText.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(466, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tên KH"
        '
        'nameText
        '
        Me.nameText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsHoaDon1, "HoaDon.ngayTaoHD", True))
        Me.nameText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.nameText.Location = New System.Drawing.Point(291, 175)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(122, 27)
        Me.nameText.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(160, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Ngày tạo HĐ"
        '
        'maHDText
        '
        Me.maHDText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsHoaDon1, "HoaDon.maHD", True))
        Me.maHDText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maHDText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.maHDText.Location = New System.Drawing.Point(291, 117)
        Me.maHDText.Name = "maHDText"
        Me.maHDText.Size = New System.Drawing.Size(122, 27)
        Me.maHDText.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(200, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Mã HĐ"
        '
        'tienText
        '
        Me.tienText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsHoaDon1, "HoaDon.TongTien", True))
        Me.tienText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tienText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tienText.Location = New System.Drawing.Point(291, 227)
        Me.tienText.Name = "tienText"
        Me.tienText.Size = New System.Drawing.Size(270, 27)
        Me.tienText.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(183, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tổng tiền"
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(409, 322)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(152, 46)
        Me.TimBtn.TabIndex = 44
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(64, 333)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(314, 27)
        Me.searchText.TabIndex = 43
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Image = CType(resources.GetObject("InBtn.Image"), System.Drawing.Image)
        Me.InBtn.Location = New System.Drawing.Point(819, 322)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(152, 46)
        Me.InBtn.TabIndex = 45
        Me.InBtn.Text = "IN"
        Me.InBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InBtn.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 700)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.tienText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.soLuongText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.giaText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maHDText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HoaDon"
        Me.Text = "Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHoaDon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents soLuongText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents giaText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maHDText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbCommand3 As OleDb.OleDbCommand
    Friend WithEvents MaHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayTaoHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TongTienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DsHoaDon1 As DsHoaDon
    Friend WithEvents tienText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
