namespace ProjectDBMS
{
    partial class fLuongNV
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
            this.pTrang = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDanhSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // pTrang
            // 
            this.pTrang.BorderColor = System.Drawing.Color.Gray;
            this.pTrang.BorderRadius = 10;
            this.pTrang.BorderThickness = 1;
            this.pTrang.Location = new System.Drawing.Point(12, 110);
            this.pTrang.Name = "pTrang";
            this.pTrang.Size = new System.Drawing.Size(1100, 656);
            this.pTrang.TabIndex = 0;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.btnDanhSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnDanhSach.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(69)))), ((int)(((byte)(194)))));
            this.btnDanhSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDanhSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDanhSach.FillColor = System.Drawing.Color.Transparent;
            this.btnDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDanhSach.Location = new System.Drawing.Point(35, 66);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(125, 36);
            this.btnDanhSach.TabIndex = 8;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThongKe.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnThongKe.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.Transparent;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThongKe.Location = new System.Drawing.Point(162, 66);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(125, 36);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(913, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Năm";
            // 
            // txtThang
            // 
            this.txtThang.BackColor = System.Drawing.Color.Transparent;
            this.txtThang.BorderColor = System.Drawing.Color.Silver;
            this.txtThang.BorderThickness = 2;
            this.txtThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtThang.ItemHeight = 30;
            this.txtThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtThang.Location = new System.Drawing.Point(911, 41);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(125, 36);
            this.txtThang.StartIndex = 0;
            this.txtThang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtThang.TabIndex = 51;
            this.txtThang.SelectedIndexChanged += new System.EventHandler(this.txtThang_SelectedIndexChanged);
            // 
            // txtNam
            // 
            this.txtNam.BorderColor = System.Drawing.Color.Silver;
            this.txtNam.BorderThickness = 2;
            this.txtNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNam.DefaultText = "2024";
            this.txtNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.ForeColor = System.Drawing.Color.Black;
            this.txtNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Location = new System.Drawing.Point(756, 36);
            this.txtNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PlaceholderText = "Nhập năm";
            this.txtNam.SelectedText = "";
            this.txtNam.Size = new System.Drawing.Size(128, 41);
            this.txtNam.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNam.TabIndex = 50;
            // 
            // fLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 792);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.pTrang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLuongNV";
            this.Text = "fLuongNV";
            this.Load += new System.EventHandler(this.fLuongNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pTrang;
        private Guna.UI2.WinForms.Guna2Button btnDanhSach;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txtThang;
        private Guna.UI2.WinForms.Guna2TextBox txtNam;
    }
}