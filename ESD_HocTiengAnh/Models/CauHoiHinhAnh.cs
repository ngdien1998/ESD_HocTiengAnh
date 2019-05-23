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
            //Chu de 7
            new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 7,
                NoiDung = "duck",
                Images = new List<string>
                {
                    "/images/con-vit.PNG",
                    "/images/con-buom.PNG",
                    "/images/ca-heo.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-rua.PNG",
                    "/images/con-tho.PNG",
                    "/images/con-ruoi.PNG",
                    "/images/con-meo.PNG",
                    "/images/ca-map.PNG",
                    "/images/con-ga.PNG"
                },
                CauTraLoiDung = 0
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 7,
                NoiDung = "rabbit",
                Images = new List<string>
                {
                    "/images/con-trau.PNG",
                    "/images/con-ga.PNG",
                    "/images/con-buom.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-vit.PNG",
                    "/images/con-chuot.PNG",
                    "/images/ca-map.PNG",
                    "/images/con-tho.PNG",
                    "/images/ca-heo.PNG",
                    "/images/con-ruoi.PNG"
                },
                CauTraLoiDung = 7
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 7,
                NoiDung = "tiger",
                Images = new List<string>
                {
                    "/images/con-ga.PNG",
                    "/images/con-te-giac.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-gau.PNG",
                    "/images/con-meo.PNG",
                    "/images/con-chuot.PNG",
                    "/images/con-ho.PNG",
                    "/images/con-tho.PNG",
                    "/images/con-vit.PNG",
                    "/images/con-buom.PNG",
                },
                CauTraLoiDung = 6
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 7,
                NoiDung = "butterfly",
                Images = new List<string>
                {
                    "/images/con-trau.PNG",
                    "/images/con-ga.PNG",
                    "/images/con-buom.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-vit.PNG",
                    "/images/con-chuot.PNG",
                    "/images/ca-map.PNG",
                    "/images/con-tho.PNG",
                    "/images/ca-heo.PNG",
                    "/images/con-ruoi.PNG"
                },
                CauTraLoiDung = 2
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 7,
                NoiDung = "shark",
                Images = new List<string>
                {
                    "/images/con-buom.PNG",
                    "/images/con-ga.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-ruoi.PNG",
                    "/images/ca-map.PNG",
                    "/images/ca-heo.PNG",
                    "/images/con-meo.PNG",
                    "/images/con-tho.PNG",
                    "/images/con-ho.PNG",
                    "/images/con-chuot.PNG",
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 7,
                NoiDung = "panda",
                Images = new List<string>
                {
                    "/images/ca-sau.PNG",
                    "/images/con-te-giac.PNG",
                    "/images/con-ech.PNG",
                    "/images/con-gau.PNG",
                    "/images/ca-map.PNG",
                    "/images/con-meo.PNG",
                    "/images/con-rua.PNG",
                    "/images/con-tho.PNG",
                    "/images/con-trau.PNG",
                    "/images/con-chon.PNG",
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 7,
                NoiDung = "crocodile",
                Images = new List<string>
                {
                    "/images/con-rua.PNG",
                    "/images/con-chon.PNG",
                    "/images/con-heo.PNG",
                    "/images/con-ho.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-trau.PNG",
                    "/images/con-meo.PNG",
                    "/images/con-ga.PNG",
                    "/images/con-ruoi.PNG",
                    "/images/con-gau.PNG",
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 7,
                NoiDung = "mouse",
                Images = new List<string>
                {
                     "/images/con-buom.PNG",
                    "/images/con-ga.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-ruoi.PNG",
                    "/images/ca-map.PNG",
                    "/images/ca-heo.PNG",
                    "/images/con-meo.PNG",
                    "/images/con-tho.PNG",
                    "/images/con-ho.PNG",
                    "/images/con-chuot.PNG",
                },
                CauTraLoiDung = 9
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 7,
                NoiDung = "cat",
                Images = new List<string>
                {
                     "/images/con-vit.PNG",
                    "/images/con-buom.PNG",
                    "/images/ca-heo.PNG",
                    "/images/ca-sau.PNG",
                    "/images/con-rua.PNG",
                    "/images/con-tho.PNG",
                    "/images/con-ruoi.PNG",
                    "/images/con-meo.PNG",
                    "/images/ca-map.PNG",
                    "/images/con-ga.PNG"
                },
                CauTraLoiDung = 7
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 7,
                NoiDung = "penguin",
                Images = new List<string>
                {
                    "/images/con-trau.PNG",
                    "/images/con-ga.PNG",
                    "/images/con-buom.PNG",
                    "/images/con-chim-canh-cut.PNG",
                    "/images/con-vit.PNG",
                    "/images/con-chuot.PNG",
                    "/images/ca-map.PNG",
                    "/images/con-tho.PNG",
                    "/images/ca-heo.PNG",
                    "/images/con-ruoi.PNG"
                },
                CauTraLoiDung = 3
            },
            //Chu de 3: rau qua
            new CauHoiHinhAnh
             {
                IdCauHoi = 1,
                IdChuDe = 3,
                NoiDung = "wine",
                Images = new List<string>
                {
                    "/images/d-ca-phe.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-ruou.PNG",
                    "/images/d-pizza.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-qua-cam.PNG",
                    "/images/d-qua-xoai.PNG",
                    "/images/d-keo.PNG",
                    "/images/d-qua-chuoi.PNG",
                    "/images/d-sua.PNG"
                },
                CauTraLoiDung = 2
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 2,
                IdChuDe = 3,
                NoiDung = "beef",
                Images = new List<string>
                {
                    "/images/d-dau-cove.PNG",
                    "/images/d-sua.PNG",
                    "/images/d-ca-phe.PNG",
                    "/images/d-qua-cam.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-cai-xanh.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-ruou.PNG",
                    "/images/con-ga.PNG",
                    "/images/d-keo.PNG"
                },
                CauTraLoiDung = 6
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 3,
                IdChuDe = 3,
                NoiDung = "mango",
                Images = new List<string>
                {
                    "/images/d-thit-heo.PNG",
                    "/images/d-qua-ot.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-qua-cam.PNG",
                    "/images/d-ruou.PNG",
                    "/images/d-keo.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-sua.PNG",
                    "/images/d-qua-xoai.PNG",
                    "/images/d-banh-mi.PNG"
                },
                CauTraLoiDung = 8
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 4,
                IdChuDe = 3,
                NoiDung = "sandwich",
                Images = new List<string>
                {
                    "/images/d-keo.PNG",
                    "/images/con-ga.PNG",
                    "/images/d-cai-xanh.PNG",
                    "/images/d-sua.PNG",
                    "/images/d-pizza.PNG",
                    "/images/d-banh-mi.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-dau-cove.PNG",
                    "/images/d-qua-ot.PNG",
                    "/images/d-qua-cam.PNG"
                },
                CauTraLoiDung = 4
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 5,
                IdChuDe = 3,
                NoiDung = "broccoli",
                Images = new List<string>
                {
                    "/images/d-keo.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-cai-xanh.PNG",
                    "/images/d-qua-cam.PNG",
                    "/images/d-sua.PNG",
                    "/images/d-ca-phe.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-dau-cove.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-ca-cao.PNG"
                },
                CauTraLoiDung = 2
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 6,
                IdChuDe = 3,
                NoiDung = "peas",
                Images = new List<string>
                {
                    "/images/d-qua-ot.PNG",
                    "/images/d-ruou.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-thit-heo.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-cai-xanh.PNG",
                    "/images/d-keo.PNG",
                    "/images/d-con-tom.PNG",
                    "/images/d-dau-cove.PNG",
                    "/images/d-pizza.PNG"
                },
                CauTraLoiDung = 8
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 7,
                IdChuDe = 3,
                NoiDung = "bananas",
                Images = new List<string>
                {
                    "/images/d-thit-bo.PNG",
                    "/images/d-qua-chuoi.PNG",
                    "/images/d-keo.PNG",
                    "/images/d-pizza.PNG",
                    "/images/d-banh-mi.PNG",
                    "/images/d-sua.PNG",
                    "/images/d-qua-chanh.PNG",
                    "/images/d-con-tom.PNG",
                    "/images/con-ga.PNG",
                    "/images/d-ca-phe.PNG"
                },
                CauTraLoiDung = 1
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 8,
                IdChuDe = 3,
                NoiDung = "pie",
                Images = new List<string>
                {
                    "/images/d-cai-xanh.PNG",
                    "/images/d-qua-cam.PNG",
                    "/images/d-ca-phe.PNG",
                    "/images/d-qua-xoai.PNG",
                    "/images/d-qua-sua.PNG",
                    "/images/d-con-tom.PNG",
                    "/images/d-thit-heo.PNG",
                    "/images/d-banh-mi.PNG",
                    "/images/con-ga.PNG",
                    "/images/d-qua-ot.PNG"
                },
                CauTraLoiDung = 7
             },
            new CauHoiHinhAnh
               {
                IdCauHoi = 9,
                IdChuDe = 3,
                NoiDung = "lemon",
                Images = new List<string>
                {
                    "/images/d-qua-xoai.PNG",
                    "/images/d-ca-cao.PNG",
                    "/images/d-banh-mi.PNG",
                    "/images/d-cai-xanh.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-ruou.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-con-tom.PNG",
                    "/images/d-qua-chanh.PNG",
                    "/images/d-ca-phe.PNG"
                },
                CauTraLoiDung = 8
             },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 3,
                NoiDung = "pork",
                Images = new List<string>
                {
                    "/images/d-ca-phe.PNG",
                    "/images/d-keo.PNG",
                    "/images/d-dau-cove.PNG",
                    "/images/d-thit-bo.PNG",
                    "/images/d-thit-heo.PNG",
                    "/images/d-cai-xanh.PNG",
                    "/images/d-con-tom.PNG",
                    "/images/d-ca-cao.PNG",
                    "/images/d-qua-tao.PNG",
                    "/images/d-banh-mi.PNG"
                },
                CauTraLoiDung = 4
            },
        };
    }
}
