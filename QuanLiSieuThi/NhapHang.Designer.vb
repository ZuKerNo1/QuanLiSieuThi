﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhapHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhapHang))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DsNhapHang1 = New QuanLiSieuThi.DsNhapHang()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaPNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhapHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DsNhapHang1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ChiTietPhieuNhap", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("maPN", "maPN"), New System.Data.Common.DataColumnMapping("ngayNhapHang", "ngayNhapHang"), New System.Data.Common.DataColumnMapping("tenSP", "tenSP"), New System.Data.Common.DataColumnMapping("soLuongNhap", "soLuongNhap"), New System.Data.Common.DataColumnMapping("donGiaNhap", "donGiaNhap")})})
        '
        'DsNhapHang1
        '
        Me.DsNhapHang1.DataSetName = "DsNhapHang"
        Me.DsNhapHang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPNDataGridViewTextBoxColumn, Me.NgayNhapHangDataGridViewTextBoxColumn, Me.TenSPDataGridViewTextBoxColumn, Me.SoLuongNhapDataGridViewTextBoxColumn, Me.DonGiaNhapDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "ChiTietPhieuNhap"
        Me.DataGridView1.DataSource = Me.DsNhapHang1
        Me.DataGridView1.Location = New System.Drawing.Point(55, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(904, 370)
        Me.DataGridView1.TabIndex = 0
        '
        'MaPNDataGridViewTextBoxColumn
        '
        Me.MaPNDataGridViewTextBoxColumn.DataPropertyName = "maPN"
        Me.MaPNDataGridViewTextBoxColumn.HeaderText = "maPN"
        Me.MaPNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaPNDataGridViewTextBoxColumn.Name = "MaPNDataGridViewTextBoxColumn"
        Me.MaPNDataGridViewTextBoxColumn.Width = 125
        '
        'NgayNhapHangDataGridViewTextBoxColumn
        '
        Me.NgayNhapHangDataGridViewTextBoxColumn.DataPropertyName = "ngayNhapHang"
        Me.NgayNhapHangDataGridViewTextBoxColumn.HeaderText = "ngayNhapHang"
        Me.NgayNhapHangDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgayNhapHangDataGridViewTextBoxColumn.Name = "NgayNhapHangDataGridViewTextBoxColumn"
        Me.NgayNhapHangDataGridViewTextBoxColumn.Width = 125
        '
        'TenSPDataGridViewTextBoxColumn
        '
        Me.TenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP"
        Me.TenSPDataGridViewTextBoxColumn.HeaderText = "tenSP"
        Me.TenSPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenSPDataGridViewTextBoxColumn.Name = "TenSPDataGridViewTextBoxColumn"
        Me.TenSPDataGridViewTextBoxColumn.Width = 125
        '
        'SoLuongNhapDataGridViewTextBoxColumn
        '
        Me.SoLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "soLuongNhap"
        Me.SoLuongNhapDataGridViewTextBoxColumn.HeaderText = "soLuongNhap"
        Me.SoLuongNhapDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SoLuongNhapDataGridViewTextBoxColumn.Name = "SoLuongNhapDataGridViewTextBoxColumn"
        Me.SoLuongNhapDataGridViewTextBoxColumn.Width = 125
        '
        'DonGiaNhapDataGridViewTextBoxColumn
        '
        Me.DonGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "donGiaNhap"
        Me.DonGiaNhapDataGridViewTextBoxColumn.HeaderText = "donGiaNhap"
        Me.DonGiaNhapDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DonGiaNhapDataGridViewTextBoxColumn.Name = "DonGiaNhapDataGridViewTextBoxColumn"
        Me.DonGiaNhapDataGridViewTextBoxColumn.Width = 125
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1045, 96)
        Me.Panel2.TabIndex = 8
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(347, 33)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(357, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH NHẬP HÀNG"
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(400, 146)
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
        Me.searchText.Location = New System.Drawing.Point(55, 157)
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
        Me.InBtn.Location = New System.Drawing.Point(807, 138)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(152, 46)
        Me.InBtn.TabIndex = 46
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
        'NhapHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1052, 700)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NhapHang"
        Me.Text = "Nhập Hàng"
        CType(Me.DsNhapHang1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DsNhapHang1 As DsNhapHang
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaPNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayNhapHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class