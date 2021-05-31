using FirstGame.Core.Data.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;

namespace FirstGame.Web.UI.Controllers
{
    public class AdventureController: Controller
    {
        private readonly DefaultContext _context;

        public AdventureController(DefaultContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.SecondTitle = "Adventure page";

            var adventures = _context.Adventures.ToList();

            return View(adventures);

            //ForEach
            // ViewBag.Coll = new List<int>() {1,2,3,4,5 };

            //List<Adventure> adventures = new List<Adventure>()
            //{
            //    new Adventure()
            //    {
            //        Id = 1,
            //        Title = "LOTR"
            //    },
            //    new Adventure()
            //    {
            //        Id = 2,
            //        Title = "World of Warcraft"
            //    },
            //};
        }
    }
}
