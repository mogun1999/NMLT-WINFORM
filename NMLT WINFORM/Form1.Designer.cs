
namespace NMLT_WINFORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listHang = new System.Windows.Forms.ListView();
            this.TenHang = new System.Windows.Forms.ColumnHeader();
            this.MaHang = new System.Windows.Forms.ColumnHeader();
            this.HanDung = new System.Windows.Forms.ColumnHeader();
            this.CongTySanXuat = new System.Windows.Forms.ColumnHeader();
            this.NamSX = new System.Windows.Forms.ColumnHeader();
            this.LoaiHang = new System.Windows.Forms.ColumnHeader();
            this.ThemHang = new System.Windows.Forms.Button();
            this.XoaHang = new System.Windows.Forms.Button();
            this.SuaHang = new System.Windows.Forms.Button();
            this.TimHang = new System.Windows.Forms.Button();
            this.TenDSHang = new System.Windows.Forms.Label();
            this.TenDSLHang = new System.Windows.Forms.Label();
            this.listLHang = new System.Windows.Forms.ListView();
            this.TenLHang = new System.Windows.Forms.ColumnHeader();
            this.MaLHang = new System.Windows.Forms.ColumnHeader();
            this.ThemLHang = new System.Windows.Forms.Button();
            this.SuaLHang = new System.Windows.Forms.Button();
            this.XoaLHang = new System.Windows.Forms.Button();
            this.TimLHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listHang
            // 
            this.listHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenHang,
            this.MaHang,
            this.HanDung,
            this.CongTySanXuat,
            this.NamSX,
            this.LoaiHang});
            this.listHang.GridLines = true;
            this.listHang.HideSelection = false;
            this.listHang.Location = new System.Drawing.Point(12, 52);
            this.listHang.MultiSelect = false;
            this.listHang.Name = "listHang";
            this.listHang.Size = new System.Drawing.Size(575, 437);
            this.listHang.TabIndex = 0;
            this.listHang.UseCompatibleStateImageBehavior = false;
            this.listHang.View = System.Windows.Forms.View.Details;
            this.listHang.SelectedIndexChanged += new System.EventHandler(this.listHang_SelectedIndexChanged);
            // 
            // TenHang
            // 
            this.TenHang.Text = "Tên hàng";
            this.TenHang.Width = 90;
            // 
            // MaHang
            // 
            this.MaHang.Text = "Mã hàng";
            this.MaHang.Width = 90;
            // 
            // HanDung
            // 
            this.HanDung.Text = "Hạn dùng";
            this.HanDung.Width = 90;
            // 
            // CongTySanXuat
            // 
            this.CongTySanXuat.Text = "Công ty sản xuất";
            this.CongTySanXuat.Width = 120;
            // 
            // NamSX
            // 
            this.NamSX.Text = "Năm sản xuất";
            this.NamSX.Width = 90;
            // 
            // LoaiHang
            // 
            this.LoaiHang.Text = "Loại hàng";
            this.LoaiHang.Width = 90;
            // 
            // ThemHang
            // 
            this.ThemHang.Location = new System.Drawing.Point(12, 525);
            this.ThemHang.Name = "ThemHang";
            this.ThemHang.Size = new System.Drawing.Size(75, 23);
            this.ThemHang.TabIndex = 1;
            this.ThemHang.Text = "Thêm";
            this.ThemHang.UseVisualStyleBackColor = true;
            this.ThemHang.Click += new System.EventHandler(this.ThemHang_Click);
            // 
            // XoaHang
            // 
            this.XoaHang.Enabled = false;
            this.XoaHang.Location = new System.Drawing.Point(12, 586);
            this.XoaHang.Name = "XoaHang";
            this.XoaHang.Size = new System.Drawing.Size(75, 23);
            this.XoaHang.TabIndex = 2;
            this.XoaHang.Text = "Xóa";
            this.XoaHang.UseVisualStyleBackColor = true;
            this.XoaHang.Click += new System.EventHandler(this.XoaHang_Click);
            // 
            // SuaHang
            // 
            this.SuaHang.Enabled = false;
            this.SuaHang.Location = new System.Drawing.Point(163, 525);
            this.SuaHang.Name = "SuaHang";
            this.SuaHang.Size = new System.Drawing.Size(75, 23);
            this.SuaHang.TabIndex = 3;
            this.SuaHang.Text = "Sửa";
            this.SuaHang.UseVisualStyleBackColor = true;
            this.SuaHang.Click += new System.EventHandler(this.SuaHang_Click);
            // 
            // TimHang
            // 
            this.TimHang.Location = new System.Drawing.Point(163, 586);
            this.TimHang.Name = "TimHang";
            this.TimHang.Size = new System.Drawing.Size(75, 23);
            this.TimHang.TabIndex = 4;
            this.TimHang.Text = "Tìm kiếm";
            this.TimHang.UseVisualStyleBackColor = true;
            this.TimHang.Click += new System.EventHandler(this.TimHang_Click);
            // 
            // TenDSHang
            // 
            this.TenDSHang.AutoSize = true;
            this.TenDSHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenDSHang.Location = new System.Drawing.Point(12, 9);
            this.TenDSHang.Name = "TenDSHang";
            this.TenDSHang.Size = new System.Drawing.Size(150, 28);
            this.TenDSHang.TabIndex = 5;
            this.TenDSHang.Text = "Danh sách hàng";
            // 
            // TenDSLHang
            // 
            this.TenDSLHang.AutoSize = true;
            this.TenDSLHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenDSLHang.Location = new System.Drawing.Point(669, 9);
            this.TenDSLHang.Name = "TenDSLHang";
            this.TenDSLHang.Size = new System.Drawing.Size(187, 28);
            this.TenDSLHang.TabIndex = 6;
            this.TenDSLHang.Text = "Danh sách loại hàng";
            // 
            // listLHang
            // 
            this.listLHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenLHang,
            this.MaLHang});
            this.listLHang.GridLines = true;
            this.listLHang.HideSelection = false;
            this.listLHang.Location = new System.Drawing.Point(669, 52);
            this.listLHang.MultiSelect = false;
            this.listLHang.Name = "listLHang";
            this.listLHang.Size = new System.Drawing.Size(286, 295);
            this.listLHang.TabIndex = 7;
            this.listLHang.UseCompatibleStateImageBehavior = false;
            this.listLHang.View = System.Windows.Forms.View.Details;
            this.listLHang.SelectedIndexChanged += new System.EventHandler(this.listLHang_SelectedIndexChanged);
            // 
            // TenLHang
            // 
            this.TenLHang.Text = "Tên loại hàng";
            this.TenLHang.Width = 140;
            // 
            // MaLHang
            // 
            this.MaLHang.Text = "Mã loại hàng";
            this.MaLHang.Width = 140;
            // 
            // ThemLHang
            // 
            this.ThemLHang.Location = new System.Drawing.Point(669, 365);
            this.ThemLHang.Name = "ThemLHang";
            this.ThemLHang.Size = new System.Drawing.Size(75, 23);
            this.ThemLHang.TabIndex = 8;
            this.ThemLHang.Text = "Thêm";
            this.ThemLHang.UseVisualStyleBackColor = true;
            this.ThemLHang.Click += new System.EventHandler(this.ThemLHang_Click);
            // 
            // SuaLHang
            // 
            this.SuaLHang.Enabled = false;
            this.SuaLHang.Location = new System.Drawing.Point(802, 365);
            this.SuaLHang.Name = "SuaLHang";
            this.SuaLHang.Size = new System.Drawing.Size(75, 23);
            this.SuaLHang.TabIndex = 9;
            this.SuaLHang.Text = "Sửa";
            this.SuaLHang.UseVisualStyleBackColor = true;
            this.SuaLHang.Click += new System.EventHandler(this.SuaLHang_Click);
            // 
            // XoaLHang
            // 
            this.XoaLHang.Enabled = false;
            this.XoaLHang.Location = new System.Drawing.Point(669, 417);
            this.XoaLHang.Name = "XoaLHang";
            this.XoaLHang.Size = new System.Drawing.Size(75, 23);
            this.XoaLHang.TabIndex = 10;
            this.XoaLHang.Text = "Xóa";
            this.XoaLHang.UseVisualStyleBackColor = true;
            this.XoaLHang.Click += new System.EventHandler(this.XoaLHang_Click);
            // 
            // TimLHang
            // 
            this.TimLHang.Location = new System.Drawing.Point(802, 417);
            this.TimLHang.Name = "TimLHang";
            this.TimLHang.Size = new System.Drawing.Size(75, 23);
            this.TimLHang.TabIndex = 11;
            this.TimLHang.Text = "Tìm kiếm";
            this.TimLHang.UseVisualStyleBackColor = true;
            this.TimLHang.Click += new System.EventHandler(this.TimLHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 60);
            this.label1.TabIndex = 12;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimLHang);
            this.Controls.Add(this.XoaLHang);
            this.Controls.Add(this.SuaLHang);
            this.Controls.Add(this.ThemLHang);
            this.Controls.Add(this.listLHang);
            this.Controls.Add(this.TenDSLHang);
            this.Controls.Add(this.TenDSHang);
            this.Controls.Add(this.TimHang);
            this.Controls.Add(this.SuaHang);
            this.Controls.Add(this.XoaHang);
            this.Controls.Add(this.ThemHang);
            this.Controls.Add(this.listHang);
            this.Name = "Form1";
            this.Text = "Quản lí cửa hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listHang;
        private System.Windows.Forms.ColumnHeader TenHang;
        private System.Windows.Forms.ColumnHeader MaHang;
        private System.Windows.Forms.ColumnHeader HanDung;
        private System.Windows.Forms.ColumnHeader CongTySanXuat;
        private System.Windows.Forms.ColumnHeader NamSX;
        private System.Windows.Forms.ColumnHeader LoaiHang;
        private System.Windows.Forms.Button XoaHang;
        private System.Windows.Forms.Button ThemHang;
        private System.Windows.Forms.Button SuaHang;
        private System.Windows.Forms.Button TimHang;
        private System.Windows.Forms.Label TenDSHang;
        private System.Windows.Forms.Label TenDSLHang;
        private System.Windows.Forms.ListView listLHang;
        private System.Windows.Forms.ColumnHeader TenLHang;
        private System.Windows.Forms.ColumnHeader MaLHang;
        private System.Windows.Forms.Button ThemLHang;
        private System.Windows.Forms.Button SuaLHang;
        private System.Windows.Forms.Button XoaLHang;
        private System.Windows.Forms.Button TimLHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

