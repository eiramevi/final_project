<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Account_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Account_Management))
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button5 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Button8 = New Button()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        dgv_account = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Label9 = New Label()
        txt_search = New TextBox()
        btn_NewUser = New Button()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button6 = New Button()
        Button7 = New Button()
        cmb_permission = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_account, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(86, 823)
        Panel1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ImageAlign = ContentAlignment.TopLeft
        Label5.Location = New Point(12, 554)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 20)
        Label5.TabIndex = 11
        Label5.Text = "Reports"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(10, 436)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 34)
        Label4.TabIndex = 10
        Label4.Text = "Customer" & vbCrLf & "Ranking"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 34)
        Label3.TabIndex = 9
        Label3.Text = "Purchase " & vbCrLf & "History" & vbCrLf
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopLeft
        Label2.Location = New Point(3, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 34)
        Label2.TabIndex = 8
        Label2.Text = "Customer" & vbCrLf & "Information"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopLeft
        Label1.Location = New Point(1, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.Transparent
        Button5.Image = My.Resources.Resources.customer_ranking
        Button5.Location = New Point(3, 382)
        Button5.Name = "Button5"
        Button5.Size = New Size(80, 81)
        Button5.TabIndex = 7
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Transparent
        Button3.Image = My.Resources.Resources.reports
        Button3.Location = New Point(3, 493)
        Button3.Name = "Button3"
        Button3.Size = New Size(80, 81)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Transparent
        Button4.Image = My.Resources.Resources.purchase_history
        Button4.Location = New Point(3, 256)
        Button4.Name = "Button4"
        Button4.Size = New Size(80, 81)
        Button4.TabIndex = 5
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = My.Resources.Resources.customer_info
        Button2.Location = New Point(3, 138)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 81)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = My.Resources.Resources.dashboard1
        Button1.Location = New Point(3, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 81)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Moccasin
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1114, 78)
        Panel2.TabIndex = 6
        Panel2.Visible = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.Image = My.Resources.Resources.user_icon
        Button8.Location = New Point(1031, 9)
        Button8.Name = "Button8"
        Button8.Size = New Size(77, 60)
        Button8.TabIndex = 3
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(92, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(356, 60)
        Label6.TabIndex = 2
        Label6.Text = "ADMIN PORTAL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.normilogo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        Label7.Location = New Point(407, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(361, 46)
        Label7.TabIndex = 14
        Label7.Text = "Account Management"
        ' 
        ' dgv_account
        ' 
        dgv_account.AllowUserToAddRows = False
        dgv_account.AllowUserToDeleteRows = False
        dgv_account.BackgroundColor = Color.Beige
        dgv_account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_account.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv_account.GridColor = Color.Beige
        dgv_account.Location = New Point(110, 231)
        dgv_account.Name = "dgv_account"
        dgv_account.ReadOnly = True
        dgv_account.RowHeadersWidth = 51
        dgv_account.RowTemplate.Height = 29
        dgv_account.Size = New Size(677, 471)
        dgv_account.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Full Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Email Address"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Password"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Joined"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Permission"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(110, 159)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 28)
        Label9.TabIndex = 19
        Label9.Text = "Search"
        ' 
        ' txt_search
        ' 
        txt_search.BorderStyle = BorderStyle.None
        txt_search.Location = New Point(110, 156)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(191, 38)
        txt_search.TabIndex = 18
        ' 
        ' btn_NewUser
        ' 
        btn_NewUser.BackColor = Color.FromArgb(CByte(235), CByte(152), CByte(78))
        btn_NewUser.FlatAppearance.BorderSize = 0
        btn_NewUser.FlatStyle = FlatStyle.Flat
        btn_NewUser.Image = CType(resources.GetObject("btn_NewUser.Image"), Image)
        btn_NewUser.ImageAlign = ContentAlignment.MiddleLeft
        btn_NewUser.Location = New Point(927, 145)
        btn_NewUser.Name = "btn_NewUser"
        btn_NewUser.Size = New Size(108, 49)
        btn_NewUser.TabIndex = 20
        btn_NewUser.Text = "New user"
        btn_NewUser.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_NewUser.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Image = My.Resources.Resources.icons8_plus_45
        Label8.Location = New Point(927, 167)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 38)
        Label8.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(815, 295)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Full Name"
        TextBox1.Size = New Size(268, 46)
        TextBox1.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(815, 358)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Email Address"
        TextBox2.Size = New Size(268, 46)
        TextBox2.TabIndex = 23
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(815, 418)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Password"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(268, 46)
        TextBox3.TabIndex = 24
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(838, 571)
        Button6.Name = "Button6"
        Button6.Size = New Size(101, 38)
        Button6.TabIndex = 26
        Button6.Text = "Edit"
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(961, 571)
        Button7.Name = "Button7"
        Button7.Size = New Size(101, 38)
        Button7.TabIndex = 27
        Button7.Text = "Delete"
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = False
        ' 
        ' cmb_permission
        ' 
        cmb_permission.FlatStyle = FlatStyle.Popup
        cmb_permission.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_permission.FormattingEnabled = True
        cmb_permission.IntegralHeight = False
        cmb_permission.ItemHeight = 31
        cmb_permission.Items.AddRange(New Object() {"EMPLOYEE", "ADMIN"})
        cmb_permission.Location = New Point(815, 487)
        cmb_permission.Name = "cmb_permission"
        cmb_permission.Size = New Size(268, 39)
        cmb_permission.TabIndex = 28
        ' 
        ' Employee_Account_Management
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(cmb_permission)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(btn_NewUser)
        Controls.Add(Label9)
        Controls.Add(txt_search)
        Controls.Add(dgv_account)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Employee_Account_Management"
        Text = "Employee_Account_Management"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_account, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_account As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_NewUser As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents cmb_permission As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
