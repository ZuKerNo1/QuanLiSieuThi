<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SanPham))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DsSanPham1 = New QuanLiSieuThi.DsSanPham()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaBanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.soLuongText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.giaText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maSPText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XoaBtn = New System.Windows.Forms.Button()
        Me.LuuBtn = New System.Windows.Forms.Button()
        Me.SuaBtn = New System.Windows.Forms.Button()
        Me.ThemBtn = New System.Windows.Forms.Button()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DsSanPham1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.SanPham.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     dbo.SanPham"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLIRDA11;Data Source=LAPTOP-9TCJRCKI\KVU;Integrated Security=SSPI;In" &
    "itial Catalog=QuanLySieuThi"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QuanLySieuThi"".""dbo"".""SanPham"" (""maSP"", ""tenSP"", ""donGiaBan"", ""soLuo" &
    "ngCon"") VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("maSP", System.Data.OleDb.OleDbType.VarChar, 0, "maSP"), New System.Data.OleDb.OleDbParameter("tenSP", System.Data.OleDb.OleDbType.VarWChar, 0, "tenSP"), New System.Data.OleDb.OleDbParameter("donGiaBan", System.Data.OleDb.OleDbType.Currency, 0, "donGiaBan"), New System.Data.OleDb.OleDbParameter("soLuongCon", System.Data.OleDb.OleDbType.[Integer], 0, "soLuongCon")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("maSP", System.Data.OleDb.OleDbType.VarChar, 0, "maSP"), New System.Data.OleDb.OleDbParameter("tenSP", System.Data.OleDb.OleDbType.VarWChar, 0, "tenSP"), New System.Data.OleDb.OleDbParameter("donGiaBan", System.Data.OleDb.OleDbType.Currency, 0, "donGiaBan"), New System.Data.OleDb.OleDbParameter("soLuongCon", System.Data.OleDb.OleDbType.[Integer], 0, "soLuongCon"), New System.Data.OleDb.OleDbParameter("Original_maSP", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_tenSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tenSP", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_tenSP", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tenSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_donGiaBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "donGiaBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_donGiaBan", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "donGiaBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_soLuongCon", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "soLuongCon", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_soLuongCon", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "soLuongCon", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_maSP", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_tenSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tenSP", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_tenSP", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tenSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_donGiaBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "donGiaBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_donGiaBan", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "donGiaBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_soLuongCon", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "soLuongCon", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_soLuongCon", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "soLuongCon", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SanPham", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("maSP", "maSP"), New System.Data.Common.DataColumnMapping("tenSP", "tenSP"), New System.Data.Common.DataColumnMapping("donGiaBan", "donGiaBan"), New System.Data.Common.DataColumnMapping("soLuongCon", "soLuongCon")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DsSanPham1
        '
        Me.DsSanPham1.DataSetName = "DsSanPham"
        Me.DsSanPham1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSPDataGridViewTextBoxColumn, Me.TenSPDataGridViewTextBoxColumn, Me.DonGiaBanDataGridViewTextBoxColumn, Me.SoLuongConDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "SanPham"
        Me.DataGridView1.DataSource = Me.DsSanPham1
        Me.DataGridView1.Location = New System.Drawing.Point(120, 408)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(763, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'MaSPDataGridViewTextBoxColumn
        '
        Me.MaSPDataGridViewTextBoxColumn.DataPropertyName = "maSP"
        Me.MaSPDataGridViewTextBoxColumn.HeaderText = "maSP"
        Me.MaSPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaSPDataGridViewTextBoxColumn.Name = "MaSPDataGridViewTextBoxColumn"
        Me.MaSPDataGridViewTextBoxColumn.Width = 125
        '
        'TenSPDataGridViewTextBoxColumn
        '
        Me.TenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP"
        Me.TenSPDataGridViewTextBoxColumn.HeaderText = "tenSP"
        Me.TenSPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenSPDataGridViewTextBoxColumn.Name = "TenSPDataGridViewTextBoxColumn"
        Me.TenSPDataGridViewTextBoxColumn.Width = 125
        '
        'DonGiaBanDataGridViewTextBoxColumn
        '
        Me.DonGiaBanDataGridViewTextBoxColumn.DataPropertyName = "donGiaBan"
        Me.DonGiaBanDataGridViewTextBoxColumn.HeaderText = "donGiaBan"
        Me.DonGiaBanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DonGiaBanDataGridViewTextBoxColumn.Name = "DonGiaBanDataGridViewTextBoxColumn"
        Me.DonGiaBanDataGridViewTextBoxColumn.Width = 125
        '
        'SoLuongConDataGridViewTextBoxColumn
        '
        Me.SoLuongConDataGridViewTextBoxColumn.DataPropertyName = "soLuongCon"
        Me.SoLuongConDataGridViewTextBoxColumn.HeaderText = "soLuongCon"
        Me.SoLuongConDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SoLuongConDataGridViewTextBoxColumn.Name = "SoLuongConDataGridViewTextBoxColumn"
        Me.SoLuongConDataGridViewTextBoxColumn.Width = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1045, 96)
        Me.Panel2.TabIndex = 9
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(357, 35)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(337, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH SẢN PHẨM"
        '
        'soLuongText
        '
        Me.soLuongText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSanPham1, "SanPham.soLuongCon", True))
        Me.soLuongText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soLuongText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.soLuongText.Location = New System.Drawing.Point(565, 173)
        Me.soLuongText.Name = "soLuongText"
        Me.soLuongText.Size = New System.Drawing.Size(270, 27)
        Me.soLuongText.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(438, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Số lượng còn"
        '
        'giaText
        '
        Me.giaText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSanPham1, "SanPham.donGiaBan", True))
        Me.giaText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.giaText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.giaText.Location = New System.Drawing.Point(298, 175)
        Me.giaText.Name = "giaText"
        Me.giaText.Size = New System.Drawing.Size(122, 27)
        Me.giaText.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(207, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Đơn giá"
        '
        'nameText
        '
        Me.nameText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSanPham1, "SanPham.tenSP", True))
        Me.nameText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.nameText.Location = New System.Drawing.Point(565, 116)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(270, 27)
        Me.nameText.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(438, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tên SP"
        '
        'maSPText
        '
        Me.maSPText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSanPham1, "SanPham.maSP", True))
        Me.maSPText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maSPText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.maSPText.Location = New System.Drawing.Point(298, 116)
        Me.maSPText.Name = "maSPText"
        Me.maSPText.Size = New System.Drawing.Size(122, 27)
        Me.maSPText.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(207, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã SP"
        '
        'XoaBtn
        '
        Me.XoaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XoaBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XoaBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.XoaBtn.Location = New System.Drawing.Point(727, 262)
        Me.XoaBtn.Name = "XoaBtn"
        Me.XoaBtn.Size = New System.Drawing.Size(152, 46)
        Me.XoaBtn.TabIndex = 22
        Me.XoaBtn.Text = "XÓA"
        Me.XoaBtn.UseVisualStyleBackColor = False
        '
        'LuuBtn
        '
        Me.LuuBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LuuBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LuuBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LuuBtn.Location = New System.Drawing.Point(365, 262)
        Me.LuuBtn.Name = "LuuBtn"
        Me.LuuBtn.Size = New System.Drawing.Size(152, 46)
        Me.LuuBtn.TabIndex = 21
        Me.LuuBtn.Text = "LƯU"
        Me.LuuBtn.UseVisualStyleBackColor = False
        '
        'SuaBtn
        '
        Me.SuaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SuaBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuaBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.SuaBtn.Location = New System.Drawing.Point(545, 262)
        Me.SuaBtn.Name = "SuaBtn"
        Me.SuaBtn.Size = New System.Drawing.Size(152, 46)
        Me.SuaBtn.TabIndex = 20
        Me.SuaBtn.Text = "SỬA"
        Me.SuaBtn.UseVisualStyleBackColor = False
        '
        'ThemBtn
        '
        Me.ThemBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ThemBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ThemBtn.Location = New System.Drawing.Point(186, 262)
        Me.ThemBtn.Name = "ThemBtn"
        Me.ThemBtn.Size = New System.Drawing.Size(152, 46)
        Me.ThemBtn.TabIndex = 19
        Me.ThemBtn.Text = "THÊM"
        Me.ThemBtn.UseVisualStyleBackColor = False
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(465, 340)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(152, 46)
        Me.TimBtn.TabIndex = 42
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(120, 351)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(314, 27)
        Me.searchText.TabIndex = 41
        '
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Image = CType(resources.GetObject("InBtn.Image"), System.Drawing.Image)
        Me.InBtn.Location = New System.Drawing.Point(727, 340)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(152, 46)
        Me.InBtn.TabIndex = 49
        Me.InBtn.Text = "IN"
        Me.InBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InBtn.UseVisualStyleBackColor = False
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
        'PrintDocument1
        '
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 700)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.XoaBtn)
        Me.Controls.Add(Me.LuuBtn)
        Me.Controls.Add(Me.SuaBtn)
        Me.Controls.Add(Me.ThemBtn)
        Me.Controls.Add(Me.soLuongText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.giaText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maSPText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SanPham"
        Me.Text = "Form1"
        CType(Me.DsSanPham1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DsSanPham1 As DsSanPham
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaBanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents soLuongText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents giaText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maSPText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents XoaBtn As Button
    Friend WithEvents LuuBtn As Button
    Friend WithEvents SuaBtn As Button
    Friend WithEvents ThemBtn As Button
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
