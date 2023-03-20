using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreKitaplık.Models;

namespace CoreKitaplık.ViewComponents
{
    public class YeniKitaplar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=6,
                    KitapAd="Korku",
                    Yazar="zweig"
                },
                new Kitaplar
                {
                    ID=7,
                    KitapAd="anna karanına",
                    Yazar="tolstoy"
                }
            };
            return View(kitaplistesi);
        }
    }
}
