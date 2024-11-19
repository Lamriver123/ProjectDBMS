namespace ProjectDBMS
{
    partial class fDanhSachLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSX = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuongNow = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDSLuong = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // cbCV
            // 
            this.cbCV.AutoCompleteCustomSource.AddRange(new string[] {
            "Phòng 1",
            "Phòng 2",
            "Phòng 3"});
            this.cbCV.BackColor = System.Drawing.Color.Transparent;
            this.cbCV.BorderRadius = 10;
            this.cbCV.BorderThickness = 0;
            this.cbCV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCV.DropDownHeight = 300;
            this.cbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCV.IntegralHeight = false;
            this.cbCV.ItemHeight = 30;
            this.cbCV.Location = new System.Drawing.Point(310, 16);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(190, 36);
            this.cbCV.TabIndex = 16;
            this.cbCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbCV.SelectedIndexChanged += new System.EventHandler(this.cbCV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(875, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sắp xếp : ";
            // 
            // cbSX
            // 
            this.cbSX.BackColor = System.Drawing.Color.Transparent;
            this.cbSX.BorderRadius = 10;
            this.cbSX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSX.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSX.ItemHeight = 30;
            this.cbSX.Items.AddRange(new object[] {
            "Lương tăng dần",
            "Lương giảm dần"});
            this.cbSX.Location = new System.Drawing.Point(952, 14);
            this.cbSX.Name = "cbSX";
            this.cbSX.Size = new System.Drawing.Size(132, 36);
            this.cbSX.TabIndex = 14;
            this.cbSX.SelectedIndexChanged += new System.EventHandler(this.cbSX_SelectedIndexChanged);
            // 
            // cbPB
            // 
            this.cbPB.AutoCompleteCustomSource.AddRange(new string[] {
            "Phòng 1",
            "Phòng 2",
            "Phòng 3"});
            this.cbPB.BackColor = System.Drawing.Color.Transparent;
            this.cbPB.BorderRadius = 10;
            this.cbPB.BorderThickness = 0;
            this.cbPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPB.ItemHeight = 30;
            this.cbPB.Location = new System.Drawing.Point(169, 16);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(123, 36);
            this.cbPB.TabIndex = 13;
            this.cbPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbPB.SelectedIndexChanged += new System.EventHandler(this.cbPB_SelectedIndexChanged);
            // 
            // btnLuongNow
            // 
            this.btnLuongNow.BackColor = System.Drawing.Color.Transparent;
            this.btnLuongNow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnLuongNow.BorderRadius = 10;
            this.btnLuongNow.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuongNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuongNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuongNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuongNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuongNow.FillColor = System.Drawing.Color.Transparent;
            this.btnLuongNow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuongNow.ForeColor = System.Drawing.Color.DimGray;
            this.btnLuongNow.Location = new System.Drawing.Point(43, 16);
            this.btnLuongNow.Name = "btnLuongNow";
            this.btnLuongNow.Size = new System.Drawing.Size(125, 36);
            this.btnLuongNow.TabIndex = 12;
            this.btnLuongNow.Text = "Lương tháng này";
            this.btnLuongNow.Click += new System.EventHandler(this.btnLuongNow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(957, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Chi tiết";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "MaNV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(603, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ tên nhân viên";
            // 
            // pnlDSLuong
            // 
            this.pnlDSLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDSLuong.AutoScroll = true;
            this.pnlDSLuong.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDSLuong.Location = new System.Drawing.Point(48, 98);
            this.pnlDSLuong.Name = "pnlDSLuong";
            this.pnlDSLuong.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDSLuong.Size = new System.Drawing.Size(995, 541);
            this.pnlDSLuong.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số tiền lương nhận được";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTimKiem.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Image = global::ProjectDBMS.Properties.Resources.icons8_search_50;
            this.btnTimKiem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTimKiem.ImageRotate = 0F;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.IndicateFocus = true;
            this.btnTimKiem.Location = new System.Drawing.Point(775, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Size = new System.Drawing.Size(30, 30);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.UseTransparentBackground = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(597, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Tìm nhân viên...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(165, 38);
            this.txtSearch.TabIndex = 25;
            // 
            // fDanhSachLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 656);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlDSLuong);
            this.Controls.Add(this.cbCV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSX);
            this.Controls.Add(this.cbPB);
            this.Controls.Add(this.btnLuongNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDanhSachLuong";
            this.Text = "fDanhSachLuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbCV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSX;
        private Guna.UI2.WinForms.Guna2ComboBox cbPB;
        private Guna.UI2.WinForms.Guna2Button btnLuongNow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel pnlDSLuong;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}