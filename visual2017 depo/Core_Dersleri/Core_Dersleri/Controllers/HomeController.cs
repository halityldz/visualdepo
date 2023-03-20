using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_Dersleri.Models;

namespace Core_Dersleri.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 24;
        }
        public string Index4()
        {
            return "merhaba bugun hava cok güzel";
        }
        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap() { ID = 1, KitapAd = "80 Günde Devri Alem", Yazar = "jules verne" },
                new Kitap() { ID = 2, KitapAd = "Bilinmeyen bir kadının mektubu", Yazar = "zweig" },
                new Kitap() { ID = 3, KitapAd = "bir noel hikayesi", Yazar = "charles dıckes" }
            };
            return View(ktp);
        }
        public IActionResult Index6()
        {
            ViewBag.deger1 = "merhaba core dersleri devam ediyor";
            ViewBag.deger2 = "sizden bir ricam var";
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public IActionResult Index9()
        {
            return View();
        }
    }
}