<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuaHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MuaHang))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.ViewSanPham = New System.Windows.Forms.DataGridView()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.mailText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sdtText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dChiText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.ViewSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 96)
        Me.Panel2.TabIndex = 10
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(399, 34)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(235, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "MUA SẢN PHẨM"
        '
        'ViewSanPham
        '
        Me.ViewSanPham.AllowUserToAddRows = False
        Me.ViewSanPham.AllowUserToDeleteRows = False
        Me.ViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewSanPham.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewSanPham.Location = New System.Drawing.Point(12, 183)
        Me.ViewSanPham.Name = "ViewSanPham"
        Me.ViewSanPham.RowHeadersWidth = 51
        Me.ViewSanPham.RowTemplate.Height = 24
        Me.ViewSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewSanPham.Size = New System.Drawing.Size(772, 247)
        Me.ViewSanPham.TabIndex = 11
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(632, 115)
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
        Me.searchText.Location = New System.Drawing.Point(12, 126)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(593, 27)
        Me.searchText.TabIndex = 41
        '
        'mailText
        '
        Me.mailText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.mailText.Location = New System.Drawing.Point(697, 678)
        Me.mailText.Name = "mailText"
        Me.mailText.Size = New System.Drawing.Size(270, 27)
        Me.mailText.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(606, 680)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "E-mail:"
        '
        'sdtText
        '
        Me.sdtText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdtText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.sdtText.Location = New System.Drawing.Point(695, 630)
        Me.sdtText.Name = "sdtText"
        Me.sdtText.Size = New System.Drawing.Size(272, 27)
        Me.sdtText.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(604, 632)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "SĐT:"
        '
        'dChiText
        '
        Me.dChiText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dChiText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.dChiText.Location = New System.Drawing.Point(695, 580)
        Me.dChiText.Name = "dChiText"
        Me.dChiText.Size = New System.Drawing.Size(272, 27)
        Me.dChiText.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(604, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Địa chỉ:"
        '
        'nameText
        '
        Me.nameText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.nameText.Location = New System.Drawing.Point(695, 530)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(270, 27)
        Me.nameText.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(604, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Họ tên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(602, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 32)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nhập thông tin khách hàng:"
        '
        'btnDangKy
        '
        Me.btnDangKy.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnDangKy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangKy.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDangKy.Location = New System.Drawing.Point(745, 727)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(164, 56)
        Me.btnDangKy.TabIndex = 52
        Me.btnDangKy.Text = "Đăng ký"
        Me.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDangKy.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(46, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 32)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Nhập thông tin sản phẩm:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(169, 580)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(270, 27)
        Me.TextBox3.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(78, 582)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Số lượng:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMaSP.Location = New System.Drawing.Point(169, 530)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(270, 27)
        Me.txtMaSP.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(48, 533)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Mã Sản Phẩm:"
        '
        'MuaHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1033, 830)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnDangKy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mailText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sdtText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dChiText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.ViewSanPham)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MuaHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ViewSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents ViewSanPham As DataGridView
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents mailText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sdtText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dChiText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDangKy As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label10 As Label
End Class
