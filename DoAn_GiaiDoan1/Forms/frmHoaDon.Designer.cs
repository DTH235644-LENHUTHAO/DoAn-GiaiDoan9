namespace QuanLyQuanKaraoke.Forms
{
    partial class frmHoaDon
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtPhong = new TextBox();
            txtKhachHang = new TextBox();
            label2 = new Label();
            txtBatDau = new TextBox();
            label3 = new Label();
            txtKetThuc = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtTienDV = new TextBox();
            label5 = new Label();
            txtTienPhong = new TextBox();
            label6 = new Label();
            label8 = new Label();
            cboKhuyenMai = new ComboBox();
            txtGiamGia = new TextBox();
            label7 = new Label();
            txtTongTien = new TextBox();
            label9 = new Label();
            btnTinhTien = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTinhTien);
            groupBox1.Controls.Add(txtKetThuc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBatDau);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhong);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1755, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 69);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 0;
            label1.Text = "Phòng :";
            // 
            // txtPhong
            // 
            txtPhong.Location = new Point(175, 61);
            txtPhong.Name = "txtPhong";
            txtPhong.Size = new Size(223, 44);
            txtPhong.TabIndex = 1;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(687, 61);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(290, 44);
            txtKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 69);
            label2.Name = "label2";
            label2.Size = new Size(202, 36);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng :";
            // 
            // txtBatDau
            // 
            txtBatDau.Location = new Point(341, 153);
            txtBatDau.Name = "txtBatDau";
            txtBatDau.Size = new Size(636, 44);
            txtBatDau.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 161);
            label3.Name = "label3";
            label3.Size = new Size(280, 36);
            label3.TabIndex = 4;
            label3.Text = "Thời gian bắt đầu :";
            // 
            // txtKetThuc
            // 
            txtKetThuc.Location = new Point(341, 230);
            txtKetThuc.Name = "txtKetThuc";
            txtKetThuc.Size = new Size(636, 44);
            txtKetThuc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 238);
            label4.Name = "label4";
            label4.Size = new Size(286, 36);
            label4.TabIndex = 6;
            label4.Text = "Thời gian kết thúc :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtGiamGia);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboKhuyenMai);
            groupBox2.Controls.Add(txtTienDV);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTienPhong);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(11, 364);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1755, 329);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tổng tiền";
            // 
            // txtTienDV
            // 
            txtTienDV.Location = new Point(241, 243);
            txtTienDV.Name = "txtTienDV";
            txtTienDV.Size = new Size(440, 44);
            txtTienDV.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 251);
            label5.Name = "label5";
            label5.Size = new Size(204, 36);
            label5.TabIndex = 6;
            label5.Text = "Tiền dịch vụ :";
            // 
            // txtTienPhong
            // 
            txtTienPhong.Location = new Point(243, 153);
            txtTienPhong.Name = "txtTienPhong";
            txtTienPhong.Size = new Size(438, 44);
            txtTienPhong.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 161);
            label6.Name = "label6";
            label6.Size = new Size(189, 36);
            label6.TabIndex = 4;
            label6.Text = "Tiền phòng :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 69);
            label8.Name = "label8";
            label8.Size = new Size(203, 36);
            label8.TabIndex = 0;
            label8.Text = "Khuyến mãi :";
            // 
            // cboKhuyenMai
            // 
            cboKhuyenMai.FormattingEnabled = true;
            cboKhuyenMai.Location = new Point(243, 66);
            cboKhuyenMai.Name = "cboKhuyenMai";
            cboKhuyenMai.Size = new Size(438, 44);
            cboKhuyenMai.TabIndex = 8;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(916, 108);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(438, 44);
            txtGiamGia.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(712, 116);
            label7.Name = "label7";
            label7.Size = new Size(159, 36);
            label7.TabIndex = 9;
            label7.Text = "Giảm giá :";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(918, 198);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(438, 44);
            txtTongTien.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(712, 206);
            label9.Name = "label9";
            label9.Size = new Size(210, 36);
            label9.TabIndex = 11;
            label9.Text = "TỔNG TIỀN :";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(1297, 64);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(150, 46);
            btnTinhTien.TabIndex = 8;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 990);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoaDon";
            Text = "Hóa đơn";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtKhachHang;
        private Label label2;
        private TextBox txtPhong;
        private Label label1;
        private TextBox txtBatDau;
        private Label label3;
        private TextBox txtKetThuc;
        private Label label4;
        private GroupBox groupBox2;
        private ComboBox cboKhuyenMai;
        private TextBox txtTienDV;
        private Label label5;
        private TextBox txtTienPhong;
        private Label label6;
        private Label label8;
        private Button btnTinhTien;
        private TextBox txtTongTien;
        private Label label9;
        private TextBox txtGiamGia;
        private Label label7;
    }
}