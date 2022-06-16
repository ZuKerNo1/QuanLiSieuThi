<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.passLB = New System.Windows.Forms.Label()
        Me.emailLB = New System.Windows.Forms.Label()
        Me.passText = New System.Windows.Forms.TextBox()
        Me.emailText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(85, 42)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(391, 64)
        Me.Panel7.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(76, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 55)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Đăng nhập"
        '
        'passLB
        '
        Me.passLB.AutoSize = True
        Me.passLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLB.ForeColor = System.Drawing.SystemColors.Window
        Me.passLB.Location = New System.Drawing.Point(154, 257)
        Me.passLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passLB.Name = "passLB"
        Me.passLB.Size = New System.Drawing.Size(91, 23)
        Me.passLB.TabIndex = 8
        Me.passLB.Text = "Mật khẩu"
        '
        'emailLB
        '
        Me.emailLB.AutoSize = True
        Me.emailLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLB.ForeColor = System.Drawing.SystemColors.Window
        Me.emailLB.Location = New System.Drawing.Point(154, 169)
        Me.emailLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLB.Name = "emailLB"
        Me.emailLB.Size = New System.Drawing.Size(58, 23)
        Me.emailLB.TabIndex = 7
        Me.emailLB.Text = "Email"
        '
        'passText
        '
        Me.passText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passText.Location = New System.Drawing.Point(158, 288)
        Me.passText.Margin = New System.Windows.Forms.Padding(4)
        Me.passText.Name = "passText"
        Me.passText.Size = New System.Drawing.Size(256, 30)
        Me.passText.TabIndex = 6
        Me.passText.UseSystemPasswordChar = True
        '
        'emailText
        '
        Me.emailText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailText.Location = New System.Drawing.Point(158, 200)
        Me.emailText.Margin = New System.Windows.Forms.Padding(4)
        Me.emailText.Name = "emailText"
        Me.emailText.Size = New System.Drawing.Size(256, 30)
        Me.emailText.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(81, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 56)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Đăng nhập"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(291, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 56)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Đăng ký"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 487)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.passLB)
        Me.Controls.Add(Me.emailLB)
        Me.Controls.Add(Me.passText)
        Me.Controls.Add(Me.emailText)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents passLB As Label
    Friend WithEvents emailLB As Label
    Friend WithEvents passText As TextBox
    Friend WithEvents emailText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
