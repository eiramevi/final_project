<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRanking
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
        Panel2 = New Panel()
        Button8 = New Button()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
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
        cmb_year = New ComboBox()
        cmb_month = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        dgv_rank = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txt_search = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgv_rank, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1114, 78)
        Panel2.TabIndex = 3
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
        Panel1.TabIndex = 4
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
        ' cmb_year
        ' 
        cmb_year.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_year.FormattingEnabled = True
        cmb_year.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        cmb_year.Location = New Point(955, 94)
        cmb_year.Name = "cmb_year"
        cmb_year.Size = New Size(134, 36)
        cmb_year.TabIndex = 9
        ' 
        ' cmb_month
        ' 
        cmb_month.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_month.FormattingEnabled = True
        cmb_month.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        cmb_month.Location = New Point(803, 94)
        cmb_month.Name = "cmb_month"
        cmb_month.Size = New Size(134, 36)
        cmb_month.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(722, 94)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 28)
        Label8.TabIndex = 7
        Label8.Text = "FILTER:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        Label7.Location = New Point(89, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(304, 46)
        Label7.TabIndex = 13
        Label7.Text = "Customer Ranking"
        ' 
        ' dgv_rank
        ' 
        dgv_rank.AllowUserToAddRows = False
        dgv_rank.AllowUserToDeleteRows = False
        dgv_rank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_rank.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgv_rank.Location = New Point(72, 148)
        dgv_rank.Name = "dgv_rank"
        dgv_rank.ReadOnly = True
        dgv_rank.RowHeadersWidth = 51
        dgv_rank.RowTemplate.Height = 29
        dgv_rank.Size = New Size(886, 568)
        dgv_rank.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Rank"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Customer Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Total Amount Spent (This Month)"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Number of Items Purchased"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' txt_search
        ' 
        txt_search.BorderStyle = BorderStyle.None
        txt_search.Location = New Point(9, 14)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(191, 38)
        txt_search.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(9, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 28)
        Label9.TabIndex = 9
        Label9.Text = "Search"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        Label10.Location = New Point(361, 76)
        Label10.Name = "Label10"
        Label10.Size = New Size(273, 46)
        Label10.TabIndex = 10
        Label10.Text = "September 2023"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(txt_search)
        Panel3.Controls.Add(dgv_rank)
        Panel3.Location = New Point(92, 161)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(988, 830)
        Panel3.TabIndex = 12
        ' 
        ' AdminRanking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(Label7)
        Controls.Add(Panel3)
        Controls.Add(cmb_year)
        Controls.Add(cmb_month)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "AdminRanking"
        Text = "AdminRanking"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgv_rank, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents cmb_year As ComboBox
    Friend WithEvents cmb_month As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_rank As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
End Class
