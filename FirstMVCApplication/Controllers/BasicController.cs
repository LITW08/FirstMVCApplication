using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.Controllers
{
    public class BasicController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyOtherPage()
        {
            return View();
        }
    }
    
    //create a simple MVC application with the following pages:
    
    // /Home/PageOne - this page should link to /home/pagetwo 
    // /Home/PageTwo - this page should link to /home/pageone
    
    // /Other/First - this page should link to goolge
}