using M2NCore_HelloMVC.Areas.Marketing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace M2NCore_HelloMVC.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsViewModel()
        {
            var products = GetProducts();
            return View(products);
        }

        public IActionResult ProductsViewBag()
        {
            var products = GetProducts();
            ViewBag.ProductList = products;
            ViewBag.MyName = "Luis Perez";
            return View();
        }

        public IActionResult ProductsViewData()
        {
            var products = GetProducts();
            ViewData["ProductList"] = products;
            ViewData["Address"] = "Av.Paseo Colón 333"; 
            return View();
        }


        public List<Product> GetProducts() 
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(),
                "Areas\\Marketing\\Data\\products.json");

            var json = System.IO.File.ReadAllText(folder);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);

            return products;
        }


    }
}
