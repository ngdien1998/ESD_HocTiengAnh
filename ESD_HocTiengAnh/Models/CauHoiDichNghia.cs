using System.Collections.Generic;

namespace ESD_HocTiengAnh.Models
{
    public class CauHoiDichNghia : CauHoi
    {
        public List<string> CacCauTraLoiDung { get; set; }

        public static List<CauHoiDichNghia> Data = new List<CauHoiDichNghia>
        {

        };
    }
}
