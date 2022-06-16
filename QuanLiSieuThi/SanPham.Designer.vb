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
        Me.ViewSanPham = New System.Windows.Forms.DataGridView()
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
        CType(Me.ViewSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewSanPham
        '
        Me.ViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewSanPham.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewSanPham.Location = New System.Drawing.Point(120, 408)
        Me.ViewSanPham.Name = "ViewSanPham"
        Me.ViewSanPham.RowHeadersWidth = 51
        Me.ViewSanPham.RowTemplate.Height = 24
        Me.ViewSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewSanPham.Size = New System.Drawing.Size(763, 280)
        Me.ViewSanPham.TabIndex = 0
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
        Me.Title.Size = New System.Drawing.Size(338, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH SẢN PHẨM"
        '
        'soLuongText
        '
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
        Me.Controls.Add(Me.ViewSanPham)
        Me.Name = "SanPham"
        Me.Text = "Trung_48_Nhom07"
        CType(Me.ViewSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewSanPham As DataGridView
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
