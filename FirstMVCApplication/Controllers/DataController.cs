using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.Controllers
{
    public class DataController : Controller
    {
        public ActionResult RandomNumberDemo()
        {
            Random rnd = new Random();
            RandomNumberViewModel vm = new RandomNumberViewModel();
            vm.Number = rnd.Next(100, 1000);
            vm.RandomString = RandomString(15);
            return View(vm);
        }

        public static string RandomString(int length)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}