using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstGame.Web.UI.Controllers
{
    public class AdventureController: Controller
    {
        public IActionResult Index()
        {
            ViewBag.SecondTitle = "Adventure page";

            //ForEach
            ViewBag.Coll = new List<int>() {1,2,3,4,5 };

            return View();
        }
    }
}
