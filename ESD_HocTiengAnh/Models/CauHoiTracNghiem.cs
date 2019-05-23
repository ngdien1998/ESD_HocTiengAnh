using System;
using System.Collections.Generic;

namespace ESD_HocTiengAnh.Models
{
    public class CauHoiTracNghiem : CauHoi
    {
        public Dictionary<char, string> CacCauTraLoi { get; set; }
        public char CauTraLoiDung { get; set; }
        public LoaiTracNghiem LoaiTracNghiem { get; set; }
        public string Image { get; set; }

        public static List<CauHoiTracNghiem> Data = new List<CauHoiTracNghiem>
        {
            new CauHoiTracNghiem
            {
                IdCauHoi = 1,
                NoiDung = "Duck",
                IdChuDe = 7,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Con chí" },
                    { 'B', "Con bò" },
                    { 'C', "Con gà" },
                    { 'D', "Con vịt" }
                },
                CauTraLoiDung = 'D',
                LoaiTracNghiem = LoaiTracNghiem.CoBan
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 2,
                NoiDung = "Rhinoceros",
                IdChuDe = 7,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Con tê giác" },
                    { 'B', "Con bò mộng" },
                    { 'C', "Con gà lôi" },
                    { 'D', "Con hưu cao cổ" }
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 3,
                NoiDung = "School",
                IdChuDe = 9,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Ngôi nhà" },
                    { 'B', "Nhà hàng" },
                    { 'C', "Trường học" },
                    { 'D', "Viện bảo tàn" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 4,
                NoiDung = "Book shelf",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cây kéo" },
                    { 'B', "Bút chì màu" },
                    { 'C', "Kệ sách" },
                    { 'D', "Hộp viết" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 5,
                NoiDung = "Drum",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cái trống" },
                    { 'B', "Cái dùi" },
                    { 'C', "Cái Giá" },
                    { 'D', "Cái ghế" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 6,
                NoiDung = "Eraser",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cái tẩy" },
                    { 'B', "Cái bút xóa" },
                    { 'C', "Cái compa" },
                    { 'D', "Cái thước kẻ" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan
            },
        };
    }
}
