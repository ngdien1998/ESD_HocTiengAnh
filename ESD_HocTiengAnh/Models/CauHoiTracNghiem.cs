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
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/vit.jpg"
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
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/tegiac.jpg"
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
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/truonghoc.jpg"
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 4,
                NoiDung = "Book shelf",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cây kéo" },
                    { 'B', "Bút chì màu" },
                    { 'C', "Kệ sách" },
                    { 'D', "Hộp viết" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/kesach.jpg"
            },
            new CauHoiTracNghiem
            {
                IdCauHoi = 5,
                NoiDung = "Drum",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cái trống" },
                    { 'B', "Cái dùi" },
                    { 'C', "Cái Giá" },
                    { 'D', "Cái ghế" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/caitrong.jpg"
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
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/earser.jpg"
            },
             new CauHoiTracNghiem
            {
                IdCauHoi = 7,
                NoiDung = "Book",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Quyển vỡ" },
                    { 'B', "Cái bàn" },
                    { 'C', "cái quạt" },
                    { 'D', "Bút chì" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/sach.jpg"
            },
              new CauHoiTracNghiem
            {
                IdCauHoi = 8,
                NoiDung = "Ruler",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Quyển vỡ" },
                    { 'B', "Cái bàn" },
                    { 'C', "Cái thước" },
                    { 'D', "Bút chì" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/ruler.jpg"
            },
               new CauHoiTracNghiem
            {
                IdCauHoi = 9,
                NoiDung = "scissors",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cái kéo" },
                    { 'B', "Cái bàn" },
                    { 'C', "Bàn học" },
                    { 'D', "Bức hình" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/keo.jpg"
            },
                new CauHoiTracNghiem
            {
                IdCauHoi = 9,
                NoiDung = "Calculator",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Ba lô" },
                    { 'B', "Quyển vỡ" },
                    { 'C', "Máy tính" },
                    { 'D', "Bức hình" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/maytinh.jpg"
            },
                 new CauHoiTracNghiem
            {
                IdCauHoi = 9,
                NoiDung = "Pack",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Ba lô" },
                    { 'B', "Cái bàn" },
                    { 'C', "cái ly" },
                    { 'D', "Bức hình" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/balo.jpg"
            },
                  new CauHoiTracNghiem
            {
                IdCauHoi = 10,
                NoiDung = "Board",
                IdChuDe = 1,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cái kéo" },
                    { 'B', "Cái bảng" },
                    { 'C', "Bàn học" },
                    { 'D', "Bức hình" },
                },
                CauTraLoiDung = 'B',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/bang.jpg"
            },
                   new CauHoiTracNghiem
            {
                IdCauHoi = 11,
                NoiDung = "Cloudy",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Trời mưa" },
                    { 'B', "Có gió" },
                    { 'C', "Nhiều mây" },
                    { 'D', "Có tuyết" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/bang.jpg"
            },
                   new CauHoiTracNghiem
            {
                IdCauHoi = 12,
                NoiDung = "Thunder",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Sấm sét" },
                    { 'B', "Có gió" },
                    { 'C', "Có nắng" },
                    { 'D', "Có tuyết" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/samset.jpg"
            },
                    new CauHoiTracNghiem
            {
                IdCauHoi = 13,
                NoiDung = "Sunny",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Có mưa" },
                    { 'B', "Trời lạnh" },
                    { 'C', "Có nắng" },
                    { 'D', "Có tuyết" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/nang.jpg"
            },
                     new CauHoiTracNghiem
            {
                IdCauHoi = 14,
                NoiDung = "Rain",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Sấm sét" },
                    { 'B', "Có gió" },
                    { 'C', "Có nắng" },
                    { 'D', "Có mưa" },
                },
                CauTraLoiDung = 'D',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/mua.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 15,
                NoiDung = "Snow",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Trời nóng" },
                    { 'B', "Bão" },
                    { 'C', "Ngập lụt" },
                    { 'D', "Có tuyết" },
                },
                CauTraLoiDung = 'D',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/tuyet.jpg"
            },
                       new CauHoiTracNghiem
            {
                IdCauHoi = 16,
                NoiDung = "Rainbow",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Cầu vòng" },
                    { 'B', "Có gió" },
                    { 'C', "Trời lạnh" },
                    { 'D', "Có tuyết" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/cauvong.jpg"
            },
                        new CauHoiTracNghiem
            {
                IdCauHoi = 17,
                NoiDung = "icy",
                IdChuDe = 2,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Gió nhẹ" },
                    { 'B', "Có gió" },
                    { 'C', "Sóng thần" },
                    { 'D', "Đóng băng" },
                },
                CauTraLoiDung = 'D',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/dongbang.jpg"
            },
                         new CauHoiTracNghiem
            {
                IdCauHoi = 18,
                NoiDung = "Carrot",
                IdChuDe = 3,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "cà rốt" },
                    { 'B', "Khoai tây" },
                    { 'C', "Khoai lang" },
                    { 'D', "Dưa chuột" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/carot.jpg"
            },
                          new CauHoiTracNghiem
            {
                IdCauHoi = 18,
                NoiDung = "Potato",
                IdChuDe = 3,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Bắp ngô" },
                    { 'B', "Khoai tây" },
                    { 'C', "Khoai lang" },
                    { 'D', "Đậu" },
                },
                CauTraLoiDung = 'B',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/khoaitay.jpg"
            },
                           new CauHoiTracNghiem
            {
                IdCauHoi = 19,
                NoiDung = "Taro",
                IdChuDe = 3,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Khoai sọ" },
                    { 'B', "Khoai tây" },
                    { 'C', "Cà chua" },
                    { 'D', "Đậu" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/khoaiso.jpg"
            },
                            new CauHoiTracNghiem
            {
                IdCauHoi = 20,
                NoiDung = "Cucumber",
                IdChuDe = 3,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Dưa Chuột" },
                    { 'B', "Khoai tây" },
                    { 'C', "Khoai lang" },
                    { 'D', "Đậu" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/duachuot.jpg"
            },
                             new CauHoiTracNghiem
            {
                IdCauHoi = 21,
                NoiDung = "Tomato",
                IdChuDe = 3,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Bắp ngô" },
                    { 'B', "Khoai tây" },
                    { 'C', "Cà chua" },
                    { 'D', "Đậu" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/cachua.jpg"
            },
                              new CauHoiTracNghiem
            {
                IdCauHoi = 22,
                NoiDung = "Garlic",
                IdChuDe = 3,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Tỏi" },
                    { 'B', "Hành tây" },
                    { 'C', "Khoai lang" },
                    { 'D', "Bí ngô" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/toi.jpg"
            },
                                 new CauHoiTracNghiem
            {
                IdCauHoi = 23,
                NoiDung = "One",
                IdChuDe = 4,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Số một" },
                    { 'B', "Số Ba" },
                    { 'C', "Số năm" },
                    { 'D', "Số tám" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/sommot.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 23,
                NoiDung = "Four",
                IdChuDe = 4,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Số tám" },
                    { 'B', "Số chính" },
                    { 'C', "Số hai" },
                    { 'D', "Số bốn" },
                },
                CauTraLoiDung = 'D',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/sobon.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 24,
                NoiDung = "Two",
                IdChuDe = 4,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Số tám" },
                    { 'B', "Số chính" },
                    { 'C', "Số hai" },
                    { 'D', "Số bốn" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/sohai.jpg"
            },
                        new CauHoiTracNghiem
            {
                IdCauHoi = 25,
                NoiDung = "Three",
                IdChuDe = 4,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Số Ba" },
                    { 'B', "Số chính" },
                    { 'C', "Số hai" },
                    { 'D', "Số Năm" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/soba.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 26,
                NoiDung = "Eight",
                IdChuDe = 4,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Số tám" },
                    { 'B', "Số chính" },
                    { 'C', "Số hai" },
                    { 'D', "Số bốn" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/sobon.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 27,
                NoiDung = "Fish",
                IdChuDe = 7,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Con heo" },
                    { 'B', "Con gà" },
                    { 'C', "Bạch tuột" },
                    { 'D', "Con Cá" },
                },
                CauTraLoiDung = 'D',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/conca.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 28,
                NoiDung = "Frog",
                IdChuDe = 7,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Con heo" },
                    { 'B', "Con ếch" },
                    { 'C', "Bạch tuột" },
                    { 'D', "Con Cá" },
                },
                CauTraLoiDung = 'B',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/conech.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 29,
                NoiDung = "Pig",
                IdChuDe = 7,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Con heo" },
                    { 'B', "Con gà" },
                    { 'C', "Bạch tuột" },
                    { 'D', "Con Cá" },
                },
                CauTraLoiDung = 'A',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/conheo.jpg"
            },
                      new CauHoiTracNghiem
            {
                IdCauHoi = 30,
                NoiDung = "Octopus",
                IdChuDe = 7,
                CacCauTraLoi = new Dictionary<char, string>
                {
                    { 'A', "Con heo" },
                    { 'B', "Con gà" },
                    { 'C', "Bạch tuột" },
                    { 'D', "Con Cá" },
                },
                CauTraLoiDung = 'C',
                LoaiTracNghiem = LoaiTracNghiem.CoBan,
                Image = "/images/bachtuot.jpg"
            },





        };
    }
}
