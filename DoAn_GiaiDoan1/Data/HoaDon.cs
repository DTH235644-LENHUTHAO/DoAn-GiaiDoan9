using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class HoaDon
    {
        public int ID {  get; set; }
        public int DatPhongID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime ThoiGianLap {  get; set; }
        public decimal TongTien {  get; set; }

        public virtual ObservableCollectionListSource<ChiTietHoaDon> ChiTietHoaDon { get; } = new();

        public virtual DatPhong DatPhong { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;

    }
}
