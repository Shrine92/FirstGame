using FirstGame.Core.Data.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;

namespace FirstGame.BackOffice.Web.UI.Controllers
{
    public class PageController: Controller
    {
        private List<Page> _pages = new()
        {
            new Page() {Id = 1, Nummer = 1, Title = "Titre 1", Text = "Text 1"},
            new Page() {Id = 2, Nummer = 2, Title = "Titre 2", Text = "Text 2"},
            new Page() {Id = 3, Nummer = 3, Title = "Titre 3", Text = "Text 3"},
        };

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(_pages.First(p => p.Id == id));
        }

        [HttpPost]
        public IActionResult Create(Page page)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Page page)
        {
            return View();
        }
    }
}
