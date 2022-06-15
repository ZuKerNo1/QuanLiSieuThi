<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhanVien))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.XoaBtn = New System.Windows.Forms.Button()
        Me.LuuBtn = New System.Windows.Forms.Button()
        Me.SuaBtn = New System.Windows.Forms.Button()
        Me.ThemBtn = New System.Windows.Forms.Button()
        Me.mailText = New System.Windows.Forms.TextBox()
        Me.DsNhanVien1 = New QuanLiSieuThi.dsNhanVien()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sdtText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maNVText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chucVuText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.luongText = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChucVuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        CType(Me.DsNhanVien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.NhanVien.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     dbo.NhanVien"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLIRDA11;Data Source=LAPTOP-9TCJRCKI\KVU;Integrated Security=SSPI;In" &
    "itial Catalog=QuanLySieuThi"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QuanLySieuThi"".""dbo"".""NhanVien"" (""tenNV"", ""SDT"", ""email"", ""chucVu"", " &
    """luong"") VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("tenNV", System.Data.OleDb.OleDbType.VarWChar, 0, "tenNV"), New System.Data.OleDb.OleDbParameter("SDT", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarWChar, 0, "email"), New System.Data.OleDb.OleDbParameter("chucVu", System.Data.OleDb.OleDbType.VarWChar, 0, "chucVu"), New System.Data.OleDb.OleDbParameter("luong", System.Data.OleDb.OleDbType.Currency, 0, "luong")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("tenNV", System.Data.OleDb.OleDbType.VarWChar, 0, "tenNV"), New System.Data.OleDb.OleDbParameter("SDT", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarWChar, 0, "email"), New System.Data.OleDb.OleDbParameter("chucVu", System.Data.OleDb.OleDbType.VarWChar, 0, "chucVu"), New System.Data.OleDb.OleDbParameter("luong", System.Data.OleDb.OleDbType.Currency, 0, "luong"), New System.Data.OleDb.OleDbParameter("Original_maNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_tenNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tenNV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_tenNV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tenNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_email", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_chucVu", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "chucVu", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_chucVu", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chucVu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_luong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "luong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_luong", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "luong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_maNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_tenNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tenNV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_tenNV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tenNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_email", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_chucVu", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "chucVu", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_chucVu", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chucVu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_luong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "luong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_luong", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "luong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NhanVien", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("maNV", "maNV"), New System.Data.Common.DataColumnMapping("tenNV", "tenNV"), New System.Data.Common.DataColumnMapping("SDT", "SDT"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("chucVu", "chucVu"), New System.Data.Common.DataColumnMapping("luong", "luong")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1049, 96)
        Me.Panel2.TabIndex = 7
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(354, 33)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(345, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH NHÂN VIÊN"
        '
        'XoaBtn
        '
        Me.XoaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XoaBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XoaBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.XoaBtn.Location = New System.Drawing.Point(720, 230)
        Me.XoaBtn.Name = "XoaBtn"
        Me.XoaBtn.Size = New System.Drawing.Size(152, 46)
        Me.XoaBtn.TabIndex = 28
        Me.XoaBtn.Text = "XÓA"
        Me.XoaBtn.UseVisualStyleBackColor = False
        '
        'LuuBtn
        '
        Me.LuuBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LuuBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LuuBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LuuBtn.Location = New System.Drawing.Point(358, 230)
        Me.LuuBtn.Name = "LuuBtn"
        Me.LuuBtn.Size = New System.Drawing.Size(152, 46)
        Me.LuuBtn.TabIndex = 27
        Me.LuuBtn.Text = "LƯU"
        Me.LuuBtn.UseVisualStyleBackColor = False
        '
        'SuaBtn
        '
        Me.SuaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SuaBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuaBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.SuaBtn.Location = New System.Drawing.Point(538, 230)
        Me.SuaBtn.Name = "SuaBtn"
        Me.SuaBtn.Size = New System.Drawing.Size(152, 46)
        Me.SuaBtn.TabIndex = 26
        Me.SuaBtn.Text = "SỬA"
        Me.SuaBtn.UseVisualStyleBackColor = False
        '
        'ThemBtn
        '
        Me.ThemBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ThemBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ThemBtn.Location = New System.Drawing.Point(179, 230)
        Me.ThemBtn.Name = "ThemBtn"
        Me.ThemBtn.Size = New System.Drawing.Size(152, 46)
        Me.ThemBtn.TabIndex = 25
        Me.ThemBtn.Text = "THÊM"
        Me.ThemBtn.UseVisualStyleBackColor = False
        '
        'mailText
        '
        Me.mailText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.email", True))
        Me.mailText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.mailText.Location = New System.Drawing.Point(362, 167)
        Me.mailText.Name = "mailText"
        Me.mailText.Size = New System.Drawing.Size(270, 27)
        Me.mailText.TabIndex = 24
        '
        'DsNhanVien1
        '
        Me.DsNhanVien1.DataSetName = "dsNhanVien"
        Me.DsNhanVien1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(271, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "E-mail"
        '
        'sdtText
        '
        Me.sdtText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.SDT", True))
        Me.sdtText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdtText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.sdtText.Location = New System.Drawing.Point(130, 169)
        Me.sdtText.Name = "sdtText"
        Me.sdtText.Size = New System.Drawing.Size(122, 27)
        Me.sdtText.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(39, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "SĐT"
        '
        'nameText
        '
        Me.nameText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.tenNV", True))
        Me.nameText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.nameText.Location = New System.Drawing.Point(362, 120)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(270, 27)
        Me.nameText.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(271, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Họ tên"
        '
        'maNVText
        '
        Me.maNVText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.maNV", True))
        Me.maNVText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maNVText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.maNVText.Location = New System.Drawing.Point(130, 121)
        Me.maNVText.Name = "maNVText"
        Me.maNVText.Size = New System.Drawing.Size(122, 27)
        Me.maNVText.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Mã NV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(692, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Chức vụ"
        '
        'chucVuText
        '
        Me.chucVuText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.chucVu", True))
        Me.chucVuText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chucVuText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.chucVuText.Location = New System.Drawing.Point(783, 119)
        Me.chucVuText.Name = "chucVuText"
        Me.chucVuText.Size = New System.Drawing.Size(199, 27)
        Me.chucVuText.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(692, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Lương"
        '
        'luongText
        '
        Me.luongText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.luong", True))
        Me.luongText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luongText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.luongText.Location = New System.Drawing.Point(783, 167)
        Me.luongText.Name = "luongText"
        Me.luongText.Size = New System.Drawing.Size(201, 27)
        Me.luongText.TabIndex = 36
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNVDataGridViewTextBoxColumn, Me.TenNVDataGridViewTextBoxColumn, Me.SDTDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ChucVuDataGridViewTextBoxColumn, Me.LuongDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "NhanVien"
        Me.DataGridView1.DataSource = Me.DsNhanVien1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 377)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 311)
        Me.DataGridView1.TabIndex = 0
        '
        'MaNVDataGridViewTextBoxColumn
        '
        Me.MaNVDataGridViewTextBoxColumn.DataPropertyName = "maNV"
        Me.MaNVDataGridViewTextBoxColumn.HeaderText = "maNV"
        Me.MaNVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaNVDataGridViewTextBoxColumn.Name = "MaNVDataGridViewTextBoxColumn"
        Me.MaNVDataGridViewTextBoxColumn.Width = 125
        '
        'TenNVDataGridViewTextBoxColumn
        '
        Me.TenNVDataGridViewTextBoxColumn.DataPropertyName = "tenNV"
        Me.TenNVDataGridViewTextBoxColumn.HeaderText = "tenNV"
        Me.TenNVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenNVDataGridViewTextBoxColumn.Name = "TenNVDataGridViewTextBoxColumn"
        Me.TenNVDataGridViewTextBoxColumn.Width = 125
        '
        'SDTDataGridViewTextBoxColumn
        '
        Me.SDTDataGridViewTextBoxColumn.DataPropertyName = "SDT"
        Me.SDTDataGridViewTextBoxColumn.HeaderText = "SDT"
        Me.SDTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SDTDataGridViewTextBoxColumn.Name = "SDTDataGridViewTextBoxColumn"
        Me.SDTDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'ChucVuDataGridViewTextBoxColumn
        '
        Me.ChucVuDataGridViewTextBoxColumn.DataPropertyName = "chucVu"
        Me.ChucVuDataGridViewTextBoxColumn.HeaderText = "chucVu"
        Me.ChucVuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ChucVuDataGridViewTextBoxColumn.Name = "ChucVuDataGridViewTextBoxColumn"
        Me.ChucVuDataGridViewTextBoxColumn.Width = 125
        '
        'LuongDataGridViewTextBoxColumn
        '
        Me.LuongDataGridViewTextBoxColumn.DataPropertyName = "luong"
        Me.LuongDataGridViewTextBoxColumn.HeaderText = "luong"
        Me.LuongDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LuongDataGridViewTextBoxColumn.Name = "LuongDataGridViewTextBoxColumn"
        Me.LuongDataGridViewTextBoxColumn.Width = 125
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(357, 310)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(152, 46)
        Me.TimBtn.TabIndex = 40
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(12, 321)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(314, 27)
        Me.searchText.TabIndex = 39
        '
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Image = CType(resources.GetObject("InBtn.Image"), System.Drawing.Image)
        Me.InBtn.Location = New System.Drawing.Point(888, 310)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(152, 46)
        Me.InBtn.TabIndex = 48
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
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 700)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.luongText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chucVuText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.XoaBtn)
        Me.Controls.Add(Me.LuuBtn)
        Me.Controls.Add(Me.SuaBtn)
        Me.Controls.Add(Me.ThemBtn)
        Me.Controls.Add(Me.mailText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sdtText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maNVText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NhanVien"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DsNhanVien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DsNhanVien1 As dsNhanVien
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChucVuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents XoaBtn As Button
    Friend WithEvents LuuBtn As Button
    Friend WithEvents SuaBtn As Button
    Friend WithEvents ThemBtn As Button
    Friend WithEvents mailText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sdtText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maNVText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chucVuText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents luongText As TextBox
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
