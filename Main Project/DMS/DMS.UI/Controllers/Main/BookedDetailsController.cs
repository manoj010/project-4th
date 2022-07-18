using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    public class BookedDetailsController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: BookedDetails
        public ActionResult Index()
        {
            List<booktour> all_data = db.booktours.ToList();
            return View(all_data);
        }

        public ActionResult Delete1(int name)
        {
            booktour data = db.booktours.Find(name);
            db.booktours.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index","BookedDetails");
        }
    }
}