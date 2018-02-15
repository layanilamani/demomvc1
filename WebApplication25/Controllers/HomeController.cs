using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication25.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            //var batches = new string[] { "ipro-201510C", "ipro-201802G" };
            li.Add(new SelectListItem() { Text = "ipro-201010C", Value = "1" });
            li.Add(new SelectListItem() { Text = "ipro-201510G", Value = "2" });

            ViewBag.BatchId = li;
            return View();
        }
    }
}