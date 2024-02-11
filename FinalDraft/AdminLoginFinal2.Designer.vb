<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginFinal2
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
        Me.AdminLogIn = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.AdminLoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Passwordlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UserIDlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Login = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AdminLogIn.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminLogIn
        '
        Me.AdminLogIn.Controls.Add(Me.AdminLoginBtn)
        Me.AdminLogIn.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.AdminLogIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminLogIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.AdminLogIn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AdminLogIn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.AdminLogIn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.AdminLogIn.Location = New System.Drawing.Point(0, 0)
        Me.AdminLogIn.Name = "AdminLogIn"
        Me.AdminLogIn.ShadowDecoration.Parent = Me.AdminLogIn
        Me.AdminLogIn.Size = New System.Drawing.Size(1274, 794)
        Me.AdminLogIn.TabIndex = 3
        '
        'AdminLoginBtn
        '
        Me.AdminLoginBtn.Animated = True
        Me.AdminLoginBtn.AutoRoundedCorners = True
        Me.AdminLoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.AdminLoginBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AdminLoginBtn.BorderRadius = 21
        Me.AdminLoginBtn.BorderThickness = 1
        Me.AdminLoginBtn.CheckedState.Parent = Me.AdminLoginBtn
        Me.AdminLoginBtn.CustomImages.Parent = Me.AdminLoginBtn
        Me.AdminLoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AdminLoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AdminLoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AdminLoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AdminLoginBtn.DisabledState.Parent = Me.AdminLoginBtn
        Me.AdminLoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.AdminLoginBtn.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AdminLoginBtn.ForeColor = System.Drawing.Color.Black
        Me.AdminLoginBtn.HoverState.Parent = Me.AdminLoginBtn
        Me.AdminLoginBtn.Location = New System.Drawing.Point(547, 663)
        Me.AdminLoginBtn.Name = "AdminLoginBtn"
        Me.AdminLoginBtn.ShadowDecoration.Parent = Me.AdminLoginBtn
        Me.AdminLoginBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.AdminLoginBtn.Size = New System.Drawing.Size(180, 45)
        Me.AdminLoginBtn.TabIndex = 6
        Me.AdminLoginBtn.Text = "User Log In"
        Me.AdminLoginBtn.UseTransparentBackground = True
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.LoginBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Passwordlbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.UserIDlbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Password)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Username)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Login)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(337, 172)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Enabled = True
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(600, 450)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'LoginBtn
        '
        Me.LoginBtn.Animated = True
        Me.LoginBtn.AutoRoundedCorners = True
        Me.LoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoginBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.LoginBtn.BorderRadius = 21
        Me.LoginBtn.BorderThickness = 1
        Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
        Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
        Me.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBtn.DisabledState.Parent = Me.LoginBtn
        Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.HoverState.Parent = Me.LoginBtn
        Me.LoginBtn.Location = New System.Drawing.Point(204, 355)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.Size = New System.Drawing.Size(180, 45)
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "Log In"
        Me.LoginBtn.UseTransparentBackground = True
        '
        'Passwordlbl
        '
        Me.Passwordlbl.BackColor = System.Drawing.Color.Transparent
        Me.Passwordlbl.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordlbl.Location = New System.Drawing.Point(120, 239)
        Me.Passwordlbl.Name = "Passwordlbl"
        Me.Passwordlbl.Size = New System.Drawing.Size(84, 24)
        Me.Passwordlbl.TabIndex = 4
        Me.Passwordlbl.Text = "Password"
        '
        'UserIDlbl
        '
        Me.UserIDlbl.BackColor = System.Drawing.Color.Transparent
        Me.UserIDlbl.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDlbl.Location = New System.Drawing.Point(120, 139)
        Me.UserIDlbl.Name = "UserIDlbl"
        Me.UserIDlbl.Size = New System.Drawing.Size(81, 24)
        Me.UserIDlbl.TabIndex = 3
        Me.UserIDlbl.Text = "Admin ID"
        '
        'Password
        '
        Me.Password.AutoRoundedCorners = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.BorderColor = System.Drawing.Color.White
        Me.Password.BorderRadius = 25
        Me.Password.BorderThickness = 0
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FillColor = System.Drawing.Color.Silver
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoverState.Parent = Me.Password
        Me.Password.Location = New System.Drawing.Point(137, 270)
        Me.Password.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Password.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Password.PlaceholderText = ""
        Me.Password.SelectedText = ""
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(314, 53)
        Me.Password.TabIndex = 2
        Me.Password.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Username
        '
        Me.Username.AutoRoundedCorners = True
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.BorderColor = System.Drawing.Color.White
        Me.Username.BorderRadius = 25
        Me.Username.BorderThickness = 0
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.Parent = Me.Username
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FillColor = System.Drawing.Color.Silver
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.FocusedState.Parent = Me.Username
        Me.Username.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.HoverState.Parent = Me.Username
        Me.Username.Location = New System.Drawing.Point(137, 170)
        Me.Username.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Username.PlaceholderText = ""
        Me.Username.SelectedText = ""
        Me.Username.ShadowDecoration.Parent = Me.Username
        Me.Username.Size = New System.Drawing.Size(314, 53)
        Me.Username.TabIndex = 1
        Me.Username.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.Font = New System.Drawing.Font("Montserrat Black", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(82, 41)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(424, 62)
        Me.Login.TabIndex = 0
        Me.Login.Text = "WELCOME ADMIN"
        '
        'AdminLoginFinal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 794)
        Me.Controls.Add(Me.AdminLogIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminLoginFinal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Log In"
        Me.AdminLogIn.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminLogIn As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents AdminLoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Passwordlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UserIDlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Login As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
