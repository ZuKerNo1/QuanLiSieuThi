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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.XoaBtn = New System.Windows.Forms.Button()
        Me.LuuBtn = New System.Windows.Forms.Button()
        Me.SuaBtn = New System.Windows.Forms.Button()
        Me.ThemBtn = New System.Windows.Forms.Button()
        Me.mailText = New System.Windows.Forms.TextBox()
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
        Me.ViewNhanVien = New System.Windows.Forms.DataGridView()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        CType(Me.ViewNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Title.Size = New System.Drawing.Size(346, 32)
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
        Me.mailText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.mailText.Location = New System.Drawing.Point(362, 167)
        Me.mailText.Name = "mailText"
        Me.mailText.Size = New System.Drawing.Size(270, 27)
        Me.mailText.TabIndex = 24
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
        Me.luongText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luongText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.luongText.Location = New System.Drawing.Point(783, 167)
        Me.luongText.Name = "luongText"
        Me.luongText.Size = New System.Drawing.Size(201, 27)
        Me.luongText.TabIndex = 36
        '
        'ViewNhanVien
        '
        Me.ViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewNhanVien.Location = New System.Drawing.Point(12, 377)
        Me.ViewNhanVien.Name = "ViewNhanVien"
        Me.ViewNhanVien.RowHeadersWidth = 51
        Me.ViewNhanVien.RowTemplate.Height = 24
        Me.ViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewNhanVien.Size = New System.Drawing.Size(1028, 311)
        Me.ViewNhanVien.TabIndex = 0
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
        Me.Controls.Add(Me.ViewNhanVien)
        Me.Name = "NhanVien"
        Me.Text = "Trung_48_Nhom07"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ViewNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewNhanVien As DataGridView
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
