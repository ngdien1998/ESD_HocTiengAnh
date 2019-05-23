using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESD_HocTiengAnh.Models
{
    public class CauHoiHinhAnh : CauHoi
    {
        public List<string> Images { get; set; }
        public int CauTraLoiDung { get; set; }

        public static List<CauHoiHinhAnh> Data = new List<CauHoiHinhAnh>
        {
            new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 1,
                NoiDung = "alarm clock",
                Images = new List<string>
                {
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG",
                    "/images/cano.PNG"
                },
                CauTraLoiDung = 5
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 1,
                NoiDung = "lift",
                Images = new List<string>
                {
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG",
                    "/images/cau-thang.PNG"
                },
                CauTraLoiDung = 1
            }
        };
    }
}
