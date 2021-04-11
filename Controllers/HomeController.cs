using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CiftciSatis.Data.Repositories;
using CiftciSatis.Data.Models;

namespace CiftciSatis.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CiftciRepository cft = new CiftciRepository();
            return View(cft.TList());
        }
        public IActionResult Urunler()
        {
            UrunlerRepository urn = new UrunlerRepository();
            return View(urn.TList());
        }
        public IActionResult YeniUrun()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniUrun(Urunler uruns)
        {
            UrunlerRepository urn = new UrunlerRepository();
            urn.TUpdate(uruns);
            return RedirectToAction("Urunler");
        }
        public IActionResult Sil(int id)
        {
            UrunlerRepository urn = new UrunlerRepository();
            var sil = urn.TList().Find(x => x.UrunId == id);
            urn.TDelete(sil);
            CiftciRepository cft = new CiftciRepository();
            return RedirectToAction("Index");
        }
        public IActionResult Siparisler()
        {
            return View();
        }
    }
}
