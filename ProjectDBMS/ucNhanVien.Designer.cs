namespace ProjectDBMS
{
    partial class ucNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblSTT = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.Label();
            this.btnAvt = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblSTT
            // 
            this.lblSTT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(18, 7);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(25, 25);
            this.lblSTT.TabIndex = 1;
            this.lblSTT.Text = "1";
            this.lblSTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(105, 6);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(157, 25);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.Text = "Nguyenx Văn An";
            this.txtHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPB.Location = new System.Drawing.Point(450, 6);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(151, 25);
            this.txtTenPB.TabIndex = 3;
            this.txtTenPB.Text = "Phòng 1";
            this.txtTenPB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(268, 6);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(157, 25);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.Text = "0987654321";
            this.txtSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(628, 7);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(191, 25);
            this.txtTenCV.TabIndex = 5;
            this.txtTenCV.Text = "Trưởng phòng";
            this.txtTenCV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAvt
            // 
            this.btnAvt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvt.ForeColor = System.Drawing.Color.White;
            this.btnAvt.Location = new System.Drawing.Point(68, 4);
            this.btnAvt.Name = "btnAvt";
            this.btnAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvt.Size = new System.Drawing.Size(30, 30);
            this.btnAvt.TabIndex = 6;
            this.btnAvt.Text = "N";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnChiTiet.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChiTiet.Image = global::ProjectDBMS.Properties.Resources.icons8_edit_50;
            this.btnChiTiet.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnChiTiet.ImageRotate = 0F;
            this.btnChiTiet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChiTiet.Location = new System.Drawing.Point(851, 4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChiTiet.Size = new System.Drawing.Size(30, 30);
            this.btnChiTiet.TabIndex = 9;
            this.btnChiTiet.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = global::ProjectDBMS.Properties.Resources.icons8_delete_50;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(899, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 10;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnAvt);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSTT);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(950, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label txtTenPB;
        private System.Windows.Forms.Label txtTenCV;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnChiTiet;
        public Guna.UI2.WinForms.Guna2CircleButton btnAvt;
    }
}
