using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        private Product[] products =
        {
            new Product {Name = "Каяк", Category = "Водные виды спорта", Price = 350M},
            new Product {Name = "Спасательный жилет", Category = "Водные виды спорта", Price = 200M},
            new Product {Name = "Мяч", Category = "Футбол", Price = 120M},
            new Product {Name = "Угловой флажок", Category = "Футбол", Price = 75M}
        };



        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            
            ShopingCart cart=new ShopingCart(calc)
            {
                Products = products
            };
           
            decimal totalValue = cart.CalculateProductsTotal();

            return View(totalValue);
        }
    }
}