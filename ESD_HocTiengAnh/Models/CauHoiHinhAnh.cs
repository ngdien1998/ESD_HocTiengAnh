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
            //Chu de 1: Do dung hoc tap
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 1,
                NoiDung = "paper",
                Images = new List<string>
                {
                    "/images/1-bangkeo.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-giay.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-keo.PNG",
                    "/images/1-kepgiay.PNG",
                    "/images/1-maytinh.PNG",
                    "/images/1-thumuc.PNG",
                    "/images/1-thuoc.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 1,
                NoiDung = "folder",
                Images = new List<string>
                {
                    "/images/1-thumuc.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-giay.PNG",
                    "/images/1-butchi.PNG",
                    "/images/1-giaynote.PNG",
                    "/images/1-thuoc.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-keo.PNG",
                    "/images/1-bangkeo.PNG"
                },
                CauTraLoiDung = 0
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 1,
                NoiDung = "crayons",
                Images = new List<string>
                {
                    "/images/1-bangkeo.PNG",
                    "/images/1-butmay.PNG",
                    "/images/1-butchi.PNG",
                    "/images/1-butbi.PNG",
                    "/images/1-maytinh.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-thuoc.PNG",
                    "/images/1-giay.PNG",
                    "/images/1-kepgiay.PNG"
                },
                CauTraLoiDung = 6
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 1,
                NoiDung = "scissors",
                Images = new List<string>
                {
                    "/images/1-thumuc.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-kepgiay.PNG",
                    "/images/1-maytinh.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-giaynote.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-keo.PNG",
                    "/images/1-giay.PNG",
                    "/images/1-butmay.PNG"
                },
                CauTraLoiDung = 7
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 1,
                NoiDung = "calculator",
                Images = new List<string>
                {
                    "/images/1-thumuc.PNG",
                    "/images/1-butchi.PNG",
                    "/images/1-butbi.PNG",
                    "/images/1-maytinh.PNG",
                    "/images/1-bam.PNG",
                    "/images/1-giay.PNG",
                    "/images/1-thuoc.PNG",
                    "/images/1-bang.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-ghim.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 1,
                NoiDung = "fountain pen",
                Images = new List<string>
                {
                    "/images/1-cove.PNG",
                    "/images/1-butmay.PNG",
                    "/images/1-ghim.PNG",
                    "/images/1-keo.PNG",
                    "/images/1-giaynote.PNG",
                    "/images/1-butxoa.PNG",
                    "/images/1-butbi.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-giay.PNG",
                    "/images/1-bam.PNG"
                },
                CauTraLoiDung = 1
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 1,
                NoiDung = "pins",
                Images = new List<string>
                {
                    "/images/1-keo.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-bam.PNG",
                    "/images/1-bang.PNG",
                    "/images/1-butxoa.PNG",
                    "/images/1-ghim.PNG",
                    "/images/1-butbi.PNG",
                    "/images/1-thuoc.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-thumuc.PNG"
                },
                CauTraLoiDung = 5
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 1,
                NoiDung = "tape",
                Images = new List<string>
                {
                    "/images/1-maytinh.PNG",
                    "/images/1-butchi.PNG",
                    "/images/1-keo.PNG",
                    "/images/1-butbi.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-bangkeo.PNG",
                    "/images/1-butmay.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-thumuc.PNG",
                    "/images/1-ghim.PNG"
                },
                CauTraLoiDung = 5
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 1,
                NoiDung = "blackboard",
                Images = new List<string>
                {
                    "/images/1-butgot.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-butbi.PNG",
                    "/images/1-thuoc.PNG",
                    "/images/1-ghim.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-thumuc.PNG",
                    "/images/1-bang.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-butxoa.PNG"
                },
                CauTraLoiDung = 7
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 1,
                NoiDung = "notepad",
                Images = new List<string>
                {
                    "/images/1-keo.PNG",
                    "/images/1-butmau.PNG",
                    "/images/1-maytinh.PNG",
                    "/images/1-cuctay.PNG",
                    "/images/1-butxoa.PNG",
                    "/images/1-cove.PNG",
                    "/images/1-giaynote.PNG",
                    "/images/1-hopbut.PNG",
                    "/images/1-bam.PNG",
                    "/images/1-butbi.PNG"
                },
                CauTraLoiDung = 6
            },
            //Chu de 2: Thien nhien
             new CauHoiHinhAnh
             {
                IdCauHoi = 1,
                IdChuDe = 2,
                NoiDung = "rainbow",
                Images = new List<string>
                {
                    "/images/2-cauvong.PNG",
                    "/images/2-ho.PNG",
                    "/images/2-mayxanh.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-nang.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-samac.PNG",
                    "/images/2-song.PNG",
                    "/images/2-sam.PNG",
                    "/images/2-rung.PNG"
                },
                CauTraLoiDung = 0
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 2,
                IdChuDe = 2,
                NoiDung = "forest",
                Images = new List<string>
                {
                    "/images/2-ho.PNG",
                    "/images/2-song.PNG",
                    "/images/2-nang.PNG",
                    "/images/2-may.PNG",
                    "/images/2-nui.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-mayxanh.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-cauvong.PNG",
                    "/images/2-rung.PNG"
                },
                CauTraLoiDung = 9
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 3,
                IdChuDe = 2,
                NoiDung = "bush",
                Images = new List<string>
                {
                    "/images/2-may.PNG",
                    "/images/2-rung.PNG",
                    "/images/2-ho.PNG",
                    "/images/2-la.PNG",
                    "/images/2-mayxanh.PNG",
                    "/images/2-rung.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-cay.PNG",
                    "/images/2-nuilua.PNG",
                    "/images/2-cauvong.PNG"
                },
                CauTraLoiDung = 4
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 4,
                IdChuDe = 2,
                NoiDung = "river",
                Images = new List<string>
                {
                    "/images/2-mayxanh.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-may.PNG",
                    "/images/2-rung.PNG",
                    "/images/2-cay.PNG",
                    "/images/2-nuilua.PNG",
                    "/images/2-song.PNG",
                    "/images/2-la.PNG",
                    "/images/2-nui.PNG"
                },
                CauTraLoiDung = 7
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 5,
                IdChuDe = 2,
                NoiDung = "leaf",
                Images = new List<string>
                {
                    "/images/2-nang.PNG",
                    "/images/2-ho.PNG",
                    "/images/2-nui.PNG",
                    "/images/2-song.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-nuilua.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-la.PNG",
                    "/images/2-sam.PNG",
                    "/images/2-samac.PNG"
                },
                CauTraLoiDung = 7
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 6,
                IdChuDe = 2,
                NoiDung = "desert",
                Images = new List<string>
                {
                    "/images/2-gio.PNG",
                    "/images/2-samac.PNG",
                    "/images/2-nang.PNG",
                    "/images/2-cay.PNG",
                    "/images/2-song.PNG",
                    "/images/2-cauvong.PNG",
                    "/images/2-la.PNG",
                    "/images/2-rung.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-mayxanh.PNG"
                },
                CauTraLoiDung = 1
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 7,
                IdChuDe = 2,
                NoiDung = "lake",
                Images = new List<string>
                {
                    "/images/2-nang.PNG",
                    "/images/2-mayxanh.PNG",
                    "/images/2-cay.PNG",
                    "/images/2-ho.PNG",
                    "/images/2-may.PNG",
                    "/images/2-cauvong.PNG",
                    "/images/2-samac.PNG",
                    "/images/2-nuilua.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-gio.PNG"
                },
                CauTraLoiDung = 3
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 8,
                IdChuDe = 2,
                NoiDung = "snow",
                Images = new List<string>
                {
                    "/images/2-samac.PNG",
                    "/images/2-mayxanh.PNG",
                    "/images/2-ho.PNG",
                    "/images/2-sam.PNG",
                    "/images/2-cauvong.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-song.PNG",
                    "/images/2-la.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-nui.PNG"
                },
                CauTraLoiDung = 5
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 9,
                IdChuDe = 2,
                NoiDung = "mountain",
                Images = new List<string>
                {
                    "/images/2-mayxanh.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-may.PNG",
                    "/images/2-cauvong.PNG",
                    "/images/2-cay.PNG",
                    "/images/2-nui.PNG",
                    "/images/2-ho.PNG",
                    "/images/2-gio.PNG",
                    "/images/2-mua.PNG",
                    "/images/2-samac.PNG"
                },
                CauTraLoiDung = 5
            },
             new CauHoiHinhAnh
             {
                IdCauHoi = 10,
                IdChuDe = 2,
                NoiDung = "tornado",
                Images = new List<string>
                {
                    "/images/2-sam.PNG",
                    "/images/2-nuilua.PNG",
                    "/images/2-song.PNG",
                    "/images/2-la.PNG",
                    "/images/2-cauvong.PNG",
                    "/images/2-nang.PNG",
                    "/images/2-voirong.PNG",
                    "/images/2-samac.PNG",
                    "/images/2-tuyet.PNG",
                    "/images/2-mua.PNG"
                },
                CauTraLoiDung = 6
            },
              //Chu de 3: Rau qua
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
            // Chu de 4: So dem
            new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 4,
                NoiDung = "eight",
                Images = new List<string>
                {
                    "/images/4-tam.PNG",
                    "/images/4-muoisau.PNG",
                    "/images/4-muoilam.PNG",
                    "/images/4-muoi.PNG",
                    "/images/4-mot.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-nam.PNG",
                    "/images/4-muoimot.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-bay.PNG"
                },
                CauTraLoiDung = 0
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 4,
                NoiDung = "fourteen",
                Images = new List<string>
                {
                    "/images/4-chin.PNG",
                    "/images/4-bay.PNG",
                    "/images/4-mot.PNG",
                    "/images/4-muoibon.PNG",
                    "/images/4-sau.PNG",
                    "/images/4-muoitam.PNG",
                    "/images/4-muoilam.PNG",
                    "/images/4-muoimot.PNG",
                    "/images/4-hai.PNG",
                    "/images/4-muoibay.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 4,
                NoiDung = "fifteen",
                Images = new List<string>
                {
                    "/images/4-muoi.PNG",
                    "/images/4-muoimot.PNG",
                    "/images/4-muoisau.PNG",
                    "/images/4-sau.PNG",
                    "/images/4-bon.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-muoilam.PNG",
                    "/images/4-tam.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-bay.PNG"
                },
                CauTraLoiDung = 6
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 4,
                NoiDung = "eighteen",
                Images = new List<string>
                {
                    "/images/4-muoilam.PNG",
                    "/images/4-sau.PNG",
                    "/images/4-hai.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-muoitam.PNG",
                    "/images/4-saumuoi.PNG",
                    "/images/4-mot.PNG",
                    "/images/4-muoibon.PNG",
                    "/images/4-muoi.PNG",
                    "/images/4-muoisau.PNG"
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 4,
                NoiDung = "sixteen",
                Images = new List<string>
                {
                    "/images/4-muoi.PNG",
                    "/images/4-muoibon.PNG",
                    "/images/4-saumuoi.PNG",
                    "/images/4-muoitam.PNG",
                    "/images/4-hai.PNG",
                    "/images/4-muoisau.PNG",
                    "/images/4-nam.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-baymuoi.PNG"
                },
                CauTraLoiDung = 5
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 4,
                NoiDung = "four",
                Images = new List<string>
                {
                    "/images/4-mot.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-sau.PNG",
                    "/images/4-muoimot.PNG",
                    "/images/4-bay.PNG",
                    "/images/4-nam.PNG",
                    "/images/4-muoiba.PNG",
                    "/images/4-muoitam.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-bon.PNG"
                },
                CauTraLoiDung = 9
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 4,
                NoiDung = "ten",
                Images = new List<string>
                {
                    "/images/4-muoilam.PNG",
                    "/images/4-nam.PNG",
                    "/images/4-hai.PNG",
                    "/images/4-muoi.PNG",
                    "/images/4-saumuoi.PNG",
                    "/images/4-bonmuoi.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-mot.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-baymuoi.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 4,
                NoiDung = "sixty",
                Images = new List<string>
                {
                    "/images/4-sau.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-muoiba.PNG",
                    "/images/4-bon.PNG",
                    "/images/4-tam.PNG",
                    "/images/4-baymuoi.PNG",
                    "/images/4-nam.PNG",
                    "/images/4-muoimot.PNG",
                    "/images/4-saumuoi.PNG",
                    "/images/4-hai.PNG"
                },
                CauTraLoiDung = 8
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 4,
                NoiDung = "forty",
                Images = new List<string>
                {
                    "/images/4-baymuoi.PNG",
                    "/images/4-saumuoi.PNG",
                    "/images/4-bonmuoi.PNG",
                    "/images/4-bay.PNG",
                    "/images/4-muoibay.PNG",
                    "/images/4-sau.PNG",
                    "/images/4-hai.PNG",
                    "/images/4-muoimot.PNG",
                    "/images/4-mot.PNG",
                    "/images/4-tam.PNG"
                },
                CauTraLoiDung = 2
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 4,
                NoiDung = "thirteen",
                Images = new List<string>
                {
                    "/images/4-muoimot.PNG",
                    "/images/4-nam.PNG",
                    "/images/4-muoisau.PNG",
                    "/images/4-muoiba.PNG",
                    "/images/4-mot.PNG",
                    "/images/4-muoilam.PNG",
                    "/images/4-hai.PNG",
                    "/images/4-chin.PNG",
                    "/images/4-muoi.PNG",
                    "/images/4-saumuoi.PNG"
                },
                CauTraLoiDung = 3
            },
            //Chu de 5: Phuong tien giao thong
            new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 5,
                NoiDung = "elevator",
                Images = new List<string>
                {
                    "/images/5-xedap.PNG",
                    "/images/5-xemay.PNG",
                    "/images/5-thangmay.PNG",
                    "/images/5-xetruot.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-thangcuon.PNG",
                    "/images/5-cuuhoa.PNG",
                    "/images/5-xekhach.PNG",
                    "/images/5-xeoto.PNG",
                    "/images/5-maybay.PNG"
                },
                CauTraLoiDung = 2
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 5,
                NoiDung = "fire engine",
                Images = new List<string>
                {
                    "/images/5-thangmay.PNG",
                    "/images/5-xekhach.PNG",
                    "/images/5-cuuhoa.PNG",
                    "/images/5-capcuu.PNG",
                    "/images/5-xetai.PNG",
                    "/images/5-thangcuon.PNG",
                    "/images/5-xedap.PNG",
                    "/images/5-xemay.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-maybay.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 5,
                NoiDung = "boat",
                Images = new List<string>
                {
                    "/images/5-xetai.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-thangmay.PNG",
                    "/images/5-tructhang.PNG",
                    "/images/5-xedap.PNG",
                    "/images/5-xekhach.PNG",
                    "/images/5-maybay.PNG",
                    "/images/5-thangcuon.PNG",
                    "/images/5-vantruot.PNG",
                    "/images/5-xetruot.PNG"
                },
                CauTraLoiDung = 1
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 5,
                NoiDung = "escalator",
                Images = new List<string>
                {
                    "/images/5-xetai.PNG",
                    "/images/5-xemay.PNG",
                    "/images/5-maybay.PNG",
                    "/images/5-xeoto.PNG",
                    "/images/5-thangcuon.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-cuuhoa.PNG",
                    "/images/5-xetruot.PNG",
                    "/images/5-xekhach.PNG",
                    "/images/5-xedap.PNG"
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 5,
                NoiDung = "rocket",
                Images = new List<string>
                {
                    "/images/5-maybay.PNG",
                    "/images/5-xetai.PNG",
                    "/images/5-thangmay.PNG",
                    "/images/5-xemay.PNG",
                    "/images/5-xedap.PNG",
                    "/images/5-capcuu.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-xebus.PNG",
                    "/images/5-tenlua.PNG",
                    "/images/5-xetruot.PNG"
                },
                CauTraLoiDung = 8
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 5,
                NoiDung = "skateboard",
                Images = new List<string>
                {
                    "/images/5-xelu.PNG",
                    "/images/5-thangmay.PNG",
                    "/images/5-xemay.PNG",
                    "/images/5-xeoto.PNG",
                    "/images/5-xetai.PNG",
                    "/images/5-thangcuon.PNG",
                    "/images/5-xetruot.PNG",
                    "/images/5-xebus.PNG",
                    "/images/5-vantruot.PNG",
                    "/images/5-tenlua.PNG"
                },
                CauTraLoiDung = 8

            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 5,
                NoiDung = "motorbike",
                Images = new List<string>
                {
                    "/images/5-xemay.PNG",
                    "/images/5-cuuhoa.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-xetruot.PNG",
                    "/images/5-maybay.PNG",
                    "/images/5-capcuu.PNG",
                    "/images/5-xetai.PNG",
                    "/images/5-xeoto.PNG",
                    "/images/5-xelu.PNG",
                    "/images/5-tenlua.PNG"
                },
                CauTraLoiDung = 0
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 5,
                NoiDung = "bus",
                Images = new List<string>
                {
                    "/images/5-tructhang.PNG",
                    "/images/5-xelu.PNG",
                    "/images/5-cuuhoa.PNG",
                    "/images/5-xedap.PNG",
                    "/images/5-xemay.PNG",
                    "/images/5-xebus.PNG",
                    "/images/5-xeoto.PNG",
                    "/images/5-taudien.PNG",
                    "/images/5-xetai.PNG",
                    "/images/5-xekhach.PNG"
                },
                CauTraLoiDung = 5
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 5,
                NoiDung = "helicopter",
                Images = new List<string>
                {
                    "/images/5-xemay.PNG",
                    "/images/5-xedap.PNG",
                    "/images/5-xebus.PNG",
                    "/images/5-xekhach.PNG",
                    "/images/5-vantruot.PNG",
                    "/images/5-tenlua.PNG",
                    "/images/5-maybay.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-taudien.PNG",
                    "/images/5-tructhang.PNG"
                },
                CauTraLoiDung = 9
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 5,
                NoiDung = "truck",
                Images = new List<string>
                {
                    "/images/5-xetruot.PNG",
                    "/images/5-cano.PNG",
                    "/images/5-xekhach.PNG",
                    "/images/5-cuuhoa.PNG",
                    "/images/5-vantruot.PNG",
                    "/images/5-xedap.PNG",
                    "/images/5-thangcuon.PNG",
                    "/images/5-xetai.PNG",
                    "/images/5-tructhang.PNG",
                    "/images/5-xemay.PNG"
                },
                CauTraLoiDung = 7
            },
            //Chu de 6: Dung cu nha bep
             new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 6,
                NoiDung = "wine glass",
                Images = new List<string>
                {
                    "/images/6-amnuoc.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-dia.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-lynuoc.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-mayxay.PNG",
                    "/images/6-muong.PNG",
                    "/images/6-dia.PNG"
                },
                CauTraLoiDung = 6
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 6,
                NoiDung = "bottle",
                Images = new List<string>
                {
                    "/images/6-lynuoc.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-dorua.PNG",
                    "/images/6-khan.PNG",
                    "/images/6-amnuoc.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-muong.PNG",
                    "/images/6-dia.PNG",
                    "/images/6-lyruou.PNG"
                },
                CauTraLoiDung = 2
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 6,
                NoiDung = "glass",
                Images = new List<string>
                {
                    "/images/6-chao.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-nia.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-muong.PNG",
                    "/images/6-mayxay.PNG",
                    "/images/6-giay.PNG",
                    "/images/6-dorua.PNG"
                },
                CauTraLoiDung = 2
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 6,
                NoiDung = "frying pan",
                Images = new List<string>
                {
                    "/images/6-amtra.PNG",
                    "/images/6-chaoran.PNG",
                    "/images/6-lynuoc.PNG",
                    "/images/6-dia.PNG",
                    "/images/6-amnuoc.PNG",
                    "/images/6-giay.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-khan.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-dokhui.PNG"
                },
                CauTraLoiDung = 1
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 6,
                NoiDung = "plate",
                Images = new List<string>
                {
                    "/images/6-thot.PNG",
                    "/images/6-amnuoc.PNG",
                    "/images/6-chaoran.PNG",
                    "/images/6-dorua.PNG",
                    "/images/6-dia.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-khan.PNG",
                    "/images/6-amtra.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-chao.PNG"
                },
                CauTraLoiDung = 4
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 6,
                NoiDung = "kettle",
                Images = new List<string>
                {
                    "/images/6-chaoran.PNG",
                    "/images/6-chao.PNG",
                    "/images/6-dorua.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-amnuoc.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-muong.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-thot.PNG"
                },
                CauTraLoiDung = 5
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 6,
                NoiDung = "dishcloth",
                Images = new List<string>
                {
                    "/images/6-dorua.PNG",
                    "/images/6-mayxay.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-khan.PNG",
                    "/images/6-chao.PNG",
                    "/images/6-amtra.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-muong.PNG"
                },
                CauTraLoiDung = 0
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 6,
                NoiDung = "chopping board",
                Images = new List<string>
                {
                    "/images/6-mayxay.PNG",
                    "/images/6-thot.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-maybao.PNG",
                    "/images/6-khan.PNG",
                    "/images/6-nia.PNG",
                    "/images/6-amtra.PNG",
                    "/images/6-amnuoc.PNG",
                    "/images/6-muong.PNG",
                    "/images/6-giay.PNG"
                },
                CauTraLoiDung = 1
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 6,
                NoiDung = "paper towels",
                Images = new List<string>
                {
                    "/images/6-dao.PNG",
                    "/images/6-thot.PNG",
                    "/images/6-amtra.PNG",
                    "/images/6-giay.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-lynhua.PNG",
                    "/images/6-dokhui.PNG",
                    "/images/6-amnuoc.PNG",
                    "/images/6-dorua.PNG",
                    "/images/6-lynuoc.PNG"
                },
                CauTraLoiDung = 3
            },
             new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 6,
                NoiDung = "spoon",
                Images = new List<string>
                {
                    "/images/6-lynuoc.PNG",
                    "/images/6-dia.PNG",
                    "/images/6-nia.PNG",
                    "/images/6-mayxay.PNG",
                    "/images/6-chairuou.PNG",
                    "/images/6-chao.PNG",
                    "/images/6-maybao.PNG",
                    "/images/6-lyruou.PNG",
                    "/images/6-muong.PNG",
                    "/images/6-giay.PNG"
                },
                CauTraLoiDung = 2
            },
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
           // Chu de 8: Trang phuc
            new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 8,
                NoiDung = "raincoat",
                Images = new List<string>
                {
                    "/images/8-aochoang.PNG",
                    "/images/8-aococo.PNG",
                    "/images/8-aocomu.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-dephong.PNG",
                    "/images/8-deplao.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-mu.PNG"
                },
                CauTraLoiDung = 2
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 8,
                NoiDung = "flip flops",
                Images = new List<string>
                {
                    "/images/8-aosomi.PNG",
                    "/images/8-deplao.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-giay.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-aococo.PNG",
                    "/images/8-mu.PNG",
                    "/images/8-dephong.PNG",
                    "/images/8-aochum.PNG"
                },
                CauTraLoiDung = 1
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 8,
                NoiDung = "blouse",
                Images = new List<string>
                {
                    "/images/8-ung.PNG",
                    "/images/8-dephong.PNG",
                    "/images/8-giay.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aococo.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-deplao.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-aochoang.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 8,
                NoiDung = "hat",
                Images = new List<string>
                {
                    "/images/8-aochoang.PNG",
                    "/images/8-aococo.PNG",
                    "/images/8-aocomu.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-dephong.PNG",
                    "/images/8-deplao.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-mu.PNG"
                },
                CauTraLoiDung =9
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 8,
                NoiDung = "sandals",
                Images = new List<string>
                {
                    "/images/8-mu.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aochum.PNG",
                    "/images/8-quan.PNG",
                    "/images/8-aocomu.PNG",
                    "/images/8-dephong.PNG",
                    "/images/8-aococo.PNG",
                    "/images/8-ung.PNG"
                },
                CauTraLoiDung = 1
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 8,
                NoiDung = "boots",
                Images = new List<string>
                {
                    "/images/8-aocomu.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-ung.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-dephong.PNG",
                    "/images/8-kinh.PNG",
                    "/images/8-aochum.PNG",
                    "/images/8-aochoang.PNG",
                    "/images/8-deplao.PNG"
                },
                CauTraLoiDung = 2
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 8,
                NoiDung = "hoodie",
                Images = new List<string>
                {
                    "/images/8-deplao.PNG",
                    "/images/8-quanboi.PNG",
                    "/images/8-quan.PNG",
                    "/images/8-kinh.PNG",
                    "/images/8-giay.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-ung.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-aochum.PNG",
                    "/images/8-aochoang.PNG"
                },
                CauTraLoiDung = 8
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 8,
                NoiDung = "jean",
                Images = new List<string>
                {
                    "/images/8-dephong.PNG",
                    "/images/8-balo.PNG",
                    "/images/8-deplao.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-quan.PNG",
                    "/images/8-docap.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-mu.PNG",
                    "/images/8-quanboi.PNG",
                    "/images/8-giay.PNG"
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 8,
                NoiDung = "swimming trunks",
                Images = new List<string>
                {
                    "/images/8-mu.PNG",
                    "/images/8-ung.PNG",
                    "/images/8-deplao.PNG",
                    "/images/8-aochum.PNG",
                    "/images/8-aocomu.PNG",
                    "/images/8-giay.PNG",
                    "/images/8-quan.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-quanboi.PNG"
                },
                CauTraLoiDung = 9
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 8,
                NoiDung = "sunglasses",
                Images = new List<string>
                {
                    "/images/8-dephong.PNG",
                    "/images/8-aocomu.PNG",
                    "/images/8-aokhoac.PNG",
                    "/images/8-aosomi.PNG",
                    "/images/8-kinh.PNG",
                    "/images/8-baotay.PNG",
                    "/images/8-depnau.PNG",
                    "/images/8-quan.PNG",
                    "/images/8-ung.PNG",
                    "/images/8-mu.PNG"
                },
                CauTraLoiDung = 4
            },

           // CHu de 9: Truong hoc
            new CauHoiHinhAnh
            {
                IdCauHoi = 1,
                IdChuDe = 9,
                NoiDung = "spanish",
                Images = new List<string>
                {
                    "/images/9-lichsu.PNG",
                    "/images/9-bancung.PNG",
                    "/images/9-vatly.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-datnuoc.PNG",
                    "/images/9-sinhhoc.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-hoahoc.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-toan.PNG"
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 2,
                IdChuDe = 9,
                NoiDung = "maths",
                Images = new List<string>
                {
                    "/images/9-bancung.PNG",
                    "/images/9-datnuoc.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-hoahoc.PNG",
                    "/images/9-lichsu.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-sinhhoc.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-vatly.PNG"
                },
                CauTraLoiDung = 8
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 3,
                IdChuDe = 9,
                NoiDung = "english",
                Images = new List<string>
                {
                    "/images/9-sinhhoc.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-vatly.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-bancung.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-amnhac.PNG"
                },
                CauTraLoiDung = 5
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 4,
                IdChuDe = 9,
                NoiDung = "computing",
                Images = new List<string>
                {
                    "/images/9-lichsu.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-vatly.PNG",
                    "/images/9-amnhac.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-datnuoc.PNG",
                    "/images/9-sinhhoc.PNG"
                },
                CauTraLoiDung = 6
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 5,
                IdChuDe = 9,
                NoiDung = "geography",
                Images = new List<string>
                {
                    "/images/9-hoahoc.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-bancung.PNG",
                    "/images/9-sinhhoc.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-datnuoc.PNG",
                    "/images/9-amnhac.PNG"
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 6,
                IdChuDe = 9,
                NoiDung = "physics",
                Images = new List<string>
                {
                    "/images/9-tienganh.PNG",
                    "/images/9-vatly.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-bancung.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-sinhhoc.PNG",
                    "/images/9-hoahoc.PNG",
                    "/images/9-lichsu.PNG",
                    "/images/9-amnhac.PNG"
                },
                CauTraLoiDung = 1
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 7,
                IdChuDe = 9,
                NoiDung = "chemistry",
                Images = new List<string>
                {
                    "/images/9-toan.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-lichsu.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-sinhhoc.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-hoahoc.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-bancung.PNG"
                },
                CauTraLoiDung = 7
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 8,
                IdChuDe = 9,
                NoiDung = "physical education",
                Images = new List<string>
                {
                    "/images/9-bancung.PNG",
                    "/images/9-datnuoc.PNG",
                    "/images/9-lichsu.PNG",
                    "/images/9-amnhac.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-vatly.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-mythuat.PNG"
                },
                CauTraLoiDung = 4
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 9,
                IdChuDe = 9,
                NoiDung = "art",
                Images = new List<string>
                {
                    "/images/9-bancung.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-theduc.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-datnuoc.PNG",
                    "/images/9-hoahoc.PNG",
                    "/images/9-sinhhoc.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-toan.PNG",
                    "/images/9-vatly.PNG"
                },
                CauTraLoiDung = 3
            },
            new CauHoiHinhAnh
            {
                IdCauHoi = 10,
                IdChuDe = 9,
                NoiDung = "music",
                Images = new List<string>
                {
                    "/images/9-hoahoc.PNG",
                    "/images/9-vatly.PNG",
                    "/images/9-dialy.PNG",
                    "/images/9-tinhoc.PNG",
                    "/images/9-bancung.PNG",
                    "/images/9-tienganh.PNG",
                    "/images/9-lichsu.PNG",
                    "/images/9-amnhac.PNG",
                    "/images/9-mythuat.PNG",
                    "/images/9-theduc.PNG"
                },
                CauTraLoiDung = 7
            },
        };
    }
}
