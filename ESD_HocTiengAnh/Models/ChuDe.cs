using System.Collections.Generic;
using System.Linq;

namespace ESD_HocTiengAnh.Models
{
    public class ChuDe
    {
        public int IdChude { get; set; }
        public string TenChuDe { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }

        public virtual List<CauHoiTracNghiem> CacCauHoiTracNghiemThuong => 
            CauHoiTracNghiem.Data.Where(e => e.LoaiTracNghiem == LoaiTracNghiem.CoBan && e.IdChuDe == IdChude)
            .ToList();

        public virtual List<CauHoiTracNghiem> CacCauHoiTracNghiemNangCao =>
            CauHoiTracNghiem.Data.Where(e => e.LoaiTracNghiem == LoaiTracNghiem.NangCao && e.IdChuDe == IdChude)
            .ToList();

        public virtual List<CauHoiDichNghia> CacCauHoiDichNghia =>
            CauHoiDichNghia.Data.Where(e => e.IdChuDe == IdChude).ToList();

        public static List<ChuDe> Data = new List<ChuDe>
        {
            new ChuDe
            {
                IdChude = 1,
                TenChuDe = "Đồ dùng học tập",
                MoTa = "",
                HinhAnh = "~/images/1.jpg"
            },
            new ChuDe
            {
                IdChude = 2,
                TenChuDe = "Thời tiết",
                MoTa = "",
                HinhAnh = "~/images/4.jpg"
            },
            new ChuDe
            {
                IdChude = 3,
                TenChuDe = "Từ vựng về rau củ quả",
                MoTa = "",
                HinhAnh = "~/images/9.png"
            },
            new ChuDe
            {
                IdChude = 4,
                TenChuDe = "Số đếm",
                MoTa = "",
                HinhAnh = "~/images/2.jpg"
            },
            new ChuDe
            {
                IdChude = 5,
                TenChuDe = "Phương tiện giao thông",
                MoTa = "",
                HinhAnh = "~/images/5.jpg"
            },
            new ChuDe
            {
                IdChude = 6,
                TenChuDe = "Dụng cụ nhà bếp",
                MoTa = "",
                HinhAnh = "~/images/8.jpg"
            },
            new ChuDe
            {
                IdChude = 7,
                TenChuDe = "Động vật",
                MoTa = "",
                HinhAnh = "~/images/3.jpg"
            },
            new ChuDe
            {
                IdChude = 8,
                TenChuDe = "Trang phục",
                MoTa = "",
                HinhAnh = "~/images/6.jpg"
            },
            new ChuDe
            {
                IdChude = 9,
                TenChuDe = "Trường học",
                MoTa = "",
                HinhAnh = "~/images/7.jpg"
            },
        };
    }
}