using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmThongTinPhanMem : Form
    {
        public frmThongTinPhanMem()
        {
            InitializeComponent();
        }

        private void frmThongTinPhanMem_Load(object sender, EventArgs e)
        {

            lblTenPM.Text = "PHẦN MỀM QUẢN LÝ QUÁN KARAOKE THE SCREAM";
            lblVersion.Text = "Phiên bản: 1.0.0 - Demo" ;
            lblTacGia.Text = "Sinh viên: Lê Nhựt Hào";
            lblLop.Text = "Thuộc : Khoa CNTT Trường Đại Học An Giang, lớp DH24TH1";
            lblGiaoVien.Text = "GVHD: Huỳnh Lý Thanh Nhàn";
            lblEmail.Text = "Email: hao_dth235644@student.agu.edu.vn";
            lblSoDienThoai.Text = "Số điện thoại: 0842884812";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
