using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreKitaplık.Models;

namespace CoreKitaplık.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){ID=1,KitapAd="SATRANÇ",Yazar="ZWEİG"},
                new Kitaplar(){ID=2,KitapAd="dr OXUN DENEYİ",Yazar="JULES VERNE"},
                new Kitaplar(){ID=3,KitapAd="delifişek",Yazar="vasconse"},
                new Kitaplar() { ID = 4, KitapAd = "kırmızı bısıklet ", Yazar = "muzaffer izgü" },
                new Kitaplar() { ID = 5, KitapAd = "toros canavarı", Yazar = "aziz nesin" }
        };
            return View(ktp);
        }
        public IActionResult Deneme()
        {
            return View();
        }
        public IActionResult StatikTema()
        {
            return View();
        }
    }
}