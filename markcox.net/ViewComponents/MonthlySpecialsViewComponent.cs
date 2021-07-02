using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using markcox.net.Models;
using Microsoft.AspNetCore.Mvc;

namespace markcox.net.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly BlogDataContext db;

        public MonthlySpecialsViewComponent(BlogDataContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = db.MonthlySpecials.ToArray();
            return View(specials);
        }

    }
}
