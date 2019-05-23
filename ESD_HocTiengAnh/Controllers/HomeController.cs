using ESD_HocTiengAnh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ESD_HocTiengAnh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("dang-nhap")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("dang-nhap")]
        public IActionResult Login(string username, string password)
        {
            if (username == "ngdien1998" && password == "12345")
            {
                return RedirectToAction(nameof(MainPage));
            }
            return View();
        }

        public IActionResult MainPage()
        {
            return View(ChuDe.Data);
        }

        [Route("chu-de/{id}/{*name}")]
        public IActionResult Learn([FromRoute(Name = "id")] int? idChuDe)
        {
            if (idChuDe == null)
            {
                return BadRequest();
            }

            var chuDe = ChuDe.Data.Find(e => e.IdChude == idChuDe);
            if (chuDe == null)
            {
                return NotFound();
            }
            return View(chuDe);
        }

        [Route("trac-nghiem-chu-de/{id}")]
        public IActionResult TracNghiem([FromRoute(Name = "id")] int? idChuDe)
        {
            var data = CauHoiTracNghiem.Data.FindAll(e => e.IdChuDe == idChuDe).ShuffleTake(10);
            HttpContext.Session.Set("CauHoi", data);
            ViewBag.QuestionCount = data.Count;

            var ranDom = new Random();
            int index = ranDom.Next(data.Count);
            return View(data[index]);
        }

        public IActionResult CauTiepTheo()
        {
            var ranDom = new Random();
            var cauHoiTracNghiem = HttpContext.Session.Get<List<CauHoiTracNghiem>>("CauHoi");
            if (cauHoiTracNghiem.Count <= 0)
            {
                return Json(null);
            }

            int index = ranDom.Next(cauHoiTracNghiem.Count);
            return Json(cauHoiTracNghiem[index]);
        }

        public IActionResult KiemTra(int idCauHoi, int traLoi)
        {
            var cauHoiTracNghiem = HttpContext.Session.Get<List<CauHoiTracNghiem>>("CauHoi");

            var cauHoi = cauHoiTracNghiem.Find(e => e.IdCauHoi == idCauHoi);
            if (cauHoi != null)
            {
                cauHoiTracNghiem.Remove(cauHoi);
                HttpContext.Session.Set("CauHoi", cauHoiTracNghiem);

                if (cauHoi.CauTraLoiDung == (char)traLoi)
                {
                    return Json(new { ketQua = true });
                }
            }
            return Json(new { ketQua = false });
        }

        public IActionResult Game([FromRoute(Name = "id")] int idChuDe)
        {
            var cauHoi = CauHoiHinhAnh.Data.FindAll(e => e.IdChuDe == idChuDe).ShuffleTake(10);
            HttpContext.Session.Set("CauHoiHinhAnh", cauHoi);
            ViewBag.QuestionCount = cauHoi.Count;
            return View(cauHoi[0]);
        }

        public IActionResult TraLoiHinh(int idCauHoi, int traLoi)
        {
            var cauHoiHinhAnh = HttpContext.Session.Get<List<CauHoiHinhAnh>>("CauHoiHinhAnh");
            var cauHoi = cauHoiHinhAnh.Find(e => e.IdCauHoi == idCauHoi);
            bool right = cauHoi.CauTraLoiDung == traLoi;
            if (right)
            {
                cauHoiHinhAnh.Remove(cauHoi);
                HttpContext.Session.Set("CauHoiHinhAnh", cauHoiHinhAnh);
            }
            return Json(new { Right = right });
        }

        public IActionResult NextQuestion()
        {
            var cauHoiHinhAnh = HttpContext.Session.Get<List<CauHoiHinhAnh>>("CauHoiHinhAnh");
            if (cauHoiHinhAnh != null && cauHoiHinhAnh.Count > 0)
            {
                return Json(cauHoiHinhAnh[0]);
            }
            return Json(null);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}