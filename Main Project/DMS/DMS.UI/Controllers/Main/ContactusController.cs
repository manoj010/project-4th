using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    public class ContactusController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Contactus
        public ActionResult Index()
        {
            List<contactu> all_data = db.contactus.ToList();
            return View(all_data);
        }

        public ActionResult Delete(string name)
        {
            contactu data = db.contactus.Find(name);
            db.contactus.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index", "Contactus");
        }
    }
}