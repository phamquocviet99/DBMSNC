namespace DACSDL
{
    partial class Form1
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
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnsanpham = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btndoanhthu = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnbaohanh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(20, 3);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(142, 74);
            this.btnthongke.TabIndex = 0;
            this.btnthongke.Text = "THỐNG KÊ";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnsanpham
            // 
            this.btnsanpham.Location = new System.Drawing.Point(20, 83);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(142, 74);
            this.btnsanpham.TabIndex = 1;
            this.btnsanpham.Text = "SẢN PHẨM";
            this.btnsanpham.UseVisualStyleBackColor = true;
            this.btnsanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.Location = new System.Drawing.Point(20, 163);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(142, 74);
            this.btnkhachhang.TabIndex = 2;
            this.btnkhachhang.Text = "KHÁCH HÀNG";
            this.btnkhachhang.UseVisualStyleBackColor = true;
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(20, 403);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(142, 74);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "CẬP NHẬT";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btndoanhthu
            // 
            this.btndoanhthu.Location = new System.Drawing.Point(20, 323);
            this.btndoanhthu.Name = "btndoanhthu";
            this.btndoanhthu.Size = new System.Drawing.Size(142, 74);
            this.btndoanhthu.TabIndex = 4;
            this.btndoanhthu.Text = "DOANH THU";
            this.btndoanhthu.UseVisualStyleBackColor = true;
            this.btndoanhthu.Click += new System.EventHandler(this.btndoanhthu_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Location = new System.Drawing.Point(20, 243);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(142, 74);
            this.btnnhanvien.TabIndex = 5;
            this.btnnhanvien.Text = "NHÂN VIÊN";
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnbaohanh);
            this.panel1.Controls.Add(this.btnnhanvien);
            this.panel1.Controls.Add(this.btndoanhthu);
            this.panel1.Controls.Add(this.btncapnhat);
            this.panel1.Controls.Add(this.btnkhachhang);
            this.panel1.Controls.Add(this.btnsanpham);
            this.panel1.Controls.Add(this.btnthongke);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 564);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 619);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnbaohanh
            // 
            this.btnbaohanh.Location = new System.Drawing.Point(20, 483);
            this.btnbaohanh.Name = "btnbaohanh";
            this.btnbaohanh.Size = new System.Drawing.Size(142, 74);
            this.btnbaohanh.TabIndex = 6;
            this.btnbaohanh.Text = "BẢO HÀNH";
            this.btnbaohanh.UseVisualStyleBackColor = true;
            this.btnbaohanh.Click += new System.EventHandler(this.btnbaohanh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnkhachhang;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btndoanhthu;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button btnsanpham;
        private System.Windows.Forms.Button btnbaohanh;
    }
}

