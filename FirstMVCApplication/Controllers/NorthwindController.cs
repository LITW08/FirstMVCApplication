using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.Controllers
{
    public class NorthwindController : Controller
    {
        private string _connectionString =
            @"Data Source=.\sqlexpress; Initial Catalog=Northwnd;Integrated Security=true;";
        
        public ActionResult Products()
        {
            NorthwindViewModel vm = new NorthwindViewModel();
            NorthwindDb db = new NorthwindDb(_connectionString);
            vm.Products = db.GetProducts();
            
            return View(vm);
        }
    }
}