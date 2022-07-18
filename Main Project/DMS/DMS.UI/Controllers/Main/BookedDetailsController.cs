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
        public ActionResult index()
        {
            List<booktour> all_data = db.booktours.ToList();
            return View(all_data);
        }

        public ActionResult delete1(string number)
        {
            booktour data = db.booktours.Find(number);
            db.booktours.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index","Bookeddetails");
        }
    }
}