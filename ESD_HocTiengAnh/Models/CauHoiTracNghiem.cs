using System.Collections.Generic;

namespace ESD_HocTiengAnh.Models
{
    public class CauHoiTracNghiem : CauHoi
    {
        public Dictionary<char, string> CacCauTraLoi { get; set; }
        public char CauTraLoiDung { get; set; }
        public LoaiTracNghiem LoaiTracNghiem { get; set; }

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
        };
    }
}
