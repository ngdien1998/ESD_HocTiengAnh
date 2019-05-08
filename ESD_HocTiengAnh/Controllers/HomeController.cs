using ESD_HocTiengAnh.Models;
using Microsoft.AspNetCore.Mvc;
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

        [Route("kiem-tra/{id}/{level}")]
        public IActionResult DoTest([FromRoute(Name = "id")] int? idChuDe, string level)
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

            switch (level)
            {
                case "co-ban":
                    return View("TracNghiem", chuDe.CacCauHoiTracNghiemThuong);
                case "trung-binh":
                    return View("TracNghiem", chuDe.CacCauHoiTracNghiemNangCao);
                case "nang-cao":
                    return View("DichNghia", chuDe.CacCauHoiDichNghia);
                default:
                    return BadRequest();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}