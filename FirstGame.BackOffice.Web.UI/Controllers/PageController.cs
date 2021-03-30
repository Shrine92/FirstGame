using FirstGame.Core.Data.Models;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstGame.BackOffice.Web.UI.Controllers
{
    public class PageController: Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Page page)
        {
            return View();
        }
    }
}
