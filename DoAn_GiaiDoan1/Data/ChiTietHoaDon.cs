using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanKaraoke.Data
{
    public class ChiTietHoaDon
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }

        public string Loai { get; set; } // "Phong" hoặc "DichVu"
        public string Ten { get; set; }

        public double SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachChiTietHoaDon
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public string Loai { get; set; } 
        public string Ten { get; set; }
        public double SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
