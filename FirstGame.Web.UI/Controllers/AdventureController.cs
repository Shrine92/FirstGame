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
            return View();
        }
    }
}
