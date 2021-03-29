using FirstGame.Core.Data.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace FirstGame.Web.UI.Controllers
{
    public class AdventureController: Controller
    {
        public IActionResult Index()
        {
            ViewBag.SecondTitle = "Adventure page";

            //ForEach
            // ViewBag.Coll = new List<int>() {1,2,3,4,5 };

            List<Adventure> adventures = new List<Adventure>()
            {
                new Adventure()
                {
                    Id = 1,
                    Title = "LOTR"
                },
                new Adventure()
                {
                    Id = 2,
                    Title = "World of Warcraft"
                },
            };

            return View(adventures);
        }
    }
}
