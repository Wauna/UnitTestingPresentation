using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestMVCApp.Controllers
{
    public class SubscribeController : Controller
    {
        // GET: Subscribe
        public ActionResult Index()
        {
            return View();
        }

        // GET: Subscribe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subscribe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subscribe/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

   
    }
}
