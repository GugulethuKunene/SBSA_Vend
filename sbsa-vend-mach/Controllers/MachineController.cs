using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sbsa_vend_mach.Models;

namespace sbsa_vend_mach.Controllers
{
    public class MachineController : Controller
    {
        public IActionResult Index()
        {
           /* MVCEntity db = new MVCEntity();
            List<Product> prod = db.Product.ToList();
            ViewBag.ProductList = new SelectList(prod,productID,name,quantity,price);
            */
            List<Product> prod = new List<Product>();
            prod.Add(new Product{productID = 1, name = "Coke", quantity = 8 , price = 16.00});
            prod.Add(new Product{productID = 2, name = "Chocolate", quantity = 10 , price = 10.00});
            prod.Add(new Product{productID = 3, name = "Chips", quantity = 12 , price = 8.00});
            
            //return View(prod); 
            return View(prod);
        }

        [HttpPost]
        public IActionResult Index(Product model)
        {
           /* MVCEntity db = new MVCEntity();
            Product p = db.Product.FirstOrDefault(x => x.productID = model.productID);
            int sum = p.quantity - 1;
            p.quantity = sum;
            db.SaveChanges();
            */
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Hello(){
            return "me";
        }
    }
}
