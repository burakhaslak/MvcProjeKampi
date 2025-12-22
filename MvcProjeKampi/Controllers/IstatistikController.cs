using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var totalCategories = c.Categories.Count();

            ViewBag.TotalCategories = totalCategories;

            var softwareHeadingCount=c.Headings.Count(x=>x.Category.CategoryName =="Yazılım");

            ViewBag.SoftwareHeadingCount = softwareHeadingCount;

            var authorWithA = c.Writers.Count(x => x.WriterName.Contains("a"));

            ViewBag.AuthorWithA = authorWithA;

            var maxHeadingCategory = c.Categories.Where(x => x.CategoryID == c.Headings.GroupBy(h => h.CategoryID).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault())
                .Select(x => x.CategoryName).FirstOrDefault();

            ViewBag.MaxHeadingCategory = maxHeadingCategory;

            var activeCategories = c.Categories.Count(x => x.CategoryStatus == true);
            var passiveCategories = c.Categories.Count(x => x.CategoryStatus == false);

            var difference = activeCategories-passiveCategories;

            ViewBag.Difference = difference;

            return View();
        }
    }
}