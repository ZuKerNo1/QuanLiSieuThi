<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KhachHang))
        Me.ViewKhachHang = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.XoaBtn = New System.Windows.Forms.Button()
        Me.LuuBtn = New System.Windows.Forms.Button()
        Me.SuaBtn = New System.Windows.Forms.Button()
        Me.ThemBtn = New System.Windows.Forms.Button()
        Me.mailText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sdtText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dChiText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maKHText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.ViewKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewKhachHang
        '
        Me.ViewKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewKhachHang.Location = New System.Drawing.Point(59, 250)
        Me.ViewKhachHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewKhachHang.Name = "ViewKhachHang"
        Me.ViewKhachHang.RowHeadersWidth = 51
        Me.ViewKhachHang.RowTemplate.Height = 24
        Me.ViewKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewKhachHang.Size = New System.Drawing.Size(677, 229)
        Me.ViewKhachHang.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(250, 25)
        Me.Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(305, 25)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH KHÁCH HÀNG"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.InBtn)
        Me.Panel1.Controls.Add(Me.TimBtn)
        Me.Panel1.Controls.Add(Me.searchText)
        Me.Panel1.Controls.Add(Me.XoaBtn)
        Me.Panel1.Controls.Add(Me.LuuBtn)
        Me.Panel1.Controls.Add(Me.SuaBtn)
        Me.Panel1.Controls.Add(Me.ThemBtn)
        Me.Panel1.Controls.Add(Me.mailText)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.sdtText)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dChiText)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.nameText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.maKHText)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ViewKhachHang)
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 487)
        Me.Panel1.TabIndex = 4
        '
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Location = New System.Drawing.Point(622, 198)
        Me.InBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(114, 37)
        Me.InBtn.TabIndex = 47
        Me.InBtn.Text = "BẢNG BIỂU"
        Me.InBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InBtn.UseVisualStyleBackColor = False
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(376, 203)
        Me.TimBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(114, 37)
        Me.TimBtn.TabIndex = 18
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(59, 214)
        Me.searchText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(236, 23)
        Me.searchText.TabIndex = 17
        '
        'XoaBtn
        '
        Me.XoaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XoaBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XoaBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.XoaBtn.Location = New System.Drawing.Point(542, 148)
        Me.XoaBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XoaBtn.Name = "XoaBtn"
        Me.XoaBtn.Size = New System.Drawing.Size(114, 37)
        Me.XoaBtn.TabIndex = 14
        Me.XoaBtn.Text = "XÓA"
        Me.XoaBtn.UseVisualStyleBackColor = False
        '
        'LuuBtn
        '
        Me.LuuBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LuuBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LuuBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LuuBtn.Location = New System.Drawing.Point(270, 148)
        Me.LuuBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LuuBtn.Name = "LuuBtn"
        Me.LuuBtn.Size = New System.Drawing.Size(114, 37)
        Me.LuuBtn.TabIndex = 13
        Me.LuuBtn.Text = "LƯU"
        Me.LuuBtn.UseVisualStyleBackColor = False
        '
        'SuaBtn
        '
        Me.SuaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SuaBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuaBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.SuaBtn.Location = New System.Drawing.Point(405, 148)
        Me.SuaBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SuaBtn.Name = "SuaBtn"
        Me.SuaBtn.Size = New System.Drawing.Size(114, 37)
        Me.SuaBtn.TabIndex = 12
        Me.SuaBtn.Text = "SỬA"
        Me.SuaBtn.UseVisualStyleBackColor = False
        '
        'ThemBtn
        '
        Me.ThemBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ThemBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ThemBtn.Location = New System.Drawing.Point(136, 148)
        Me.ThemBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ThemBtn.Name = "ThemBtn"
        Me.ThemBtn.Size = New System.Drawing.Size(114, 37)
        Me.ThemBtn.TabIndex = 11
        Me.ThemBtn.Text = "THÊM"
        Me.ThemBtn.UseVisualStyleBackColor = False
        '
        'mailText
        '
        Me.mailText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.mailText.Location = New System.Drawing.Point(376, 98)
        Me.mailText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mailText.Name = "mailText"
        Me.mailText.Size = New System.Drawing.Size(204, 23)
        Me.mailText.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(308, 100)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "E-mail"
        '
        'sdtText
        '
        Me.sdtText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdtText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.sdtText.Location = New System.Drawing.Point(203, 99)
        Me.sdtText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sdtText.Name = "sdtText"
        Me.sdtText.Size = New System.Drawing.Size(92, 23)
        Me.sdtText.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(135, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SĐT"
        '
        'dChiText
        '
        Me.dChiText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dChiText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.dChiText.Location = New System.Drawing.Point(203, 58)
        Me.dChiText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dChiText.Name = "dChiText"
        Me.dChiText.Size = New System.Drawing.Size(377, 23)
        Me.dChiText.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(135, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Địa chỉ"
        '
        'nameText
        '
        Me.nameText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.nameText.Location = New System.Drawing.Point(376, 15)
        Me.nameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(204, 23)
        Me.nameText.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(308, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Họ tên"
        '
        'maKHText
        '
        Me.maKHText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maKHText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.maKHText.Location = New System.Drawing.Point(203, 15)
        Me.maKHText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.maKHText.Name = "maKHText"
        Me.maKHText.Size = New System.Drawing.Size(92, 23)
        Me.maKHText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(135, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã KH"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 78)
        Me.Panel2.TabIndex = 5
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
        'KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 569)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "KhachHang"
        Me.Text = "Form1"
        CType(Me.ViewKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewKhachHang As DataGridView
    Friend WithEvents Title As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mailText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sdtText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dChiText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maKHText As TextBox
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
