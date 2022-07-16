using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    public class AdddestinationController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Adddestination
        public ActionResult index()
        {
            List<destination> all_data = db.destinations.ToList();
            return View(all_data);

        }

        public ActionResult items()
        {
            List<destination> all_data = db.destinations.ToList();
            return View(all_data);
        }


        public ActionResult create()
        {

            return View();
        }
        public ActionResult Savedata(destination destination, HttpPostedFileBase photo)
        {
            string path = Server.MapPath("~/Uploads");
            string filename = photo.FileName;
            string new_path = path + "/" + filename;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            photo.SaveAs(new_path);
            destination.photo = "~/Uploads";
            destination.photo_name = filename;
            db.destinations.Add(destination);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult edit(int id)
        {
            destination destination = db.destinations.Find(id);
            //employee data=db.employees.firstordefault(x=>x.id==id);
            return View(destination);
        }
        public ActionResult Updatedata(destination destination)
        {

            db.Entry(destination).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult deletedata(int id)
        {
            destination data = db.destinations.Find(id);
            db.destinations.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}