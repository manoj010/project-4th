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
        //GET: Adddestination
        public ActionResult index()
        {
            List<destinationn> all_data = db.destinationns.ToList();
            return View(all_data);

        }

        public ActionResult items()
        {
            List<destinationn> all_data = db.destinationns.ToList();
            return View(all_data);
        }


        public ActionResult create()
        {

            return View();
        }
        public ActionResult Savedata(destinationn destination, HttpPostedFileBase photo)
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
            db.destinationns.Add(destination);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult edit(int id, HttpPostedFileBase photo)
        {
            destinationn destination = db.destinationns.Find(id);
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
            db.destinationns.Add(destination);
            db.SaveChanges();
            //return RedirectToAction("index");
            //employee data=db.employees.firstordefault(x=>x.id==id);
            return View(destination);
        }
        public ActionResult Updatedata(destinationn destination)
        {

            db.Entry(destination).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult deletedata(int id)
        {
            destinationn data = db.destinationns.Find(id);
            db.destinationns.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}