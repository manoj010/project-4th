using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    public class GalleryController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Gallery
        public ActionResult Index()
        {
            List<gallery> data = db.galleries.ToList();
            return View(data);
        }

        public ActionResult AddNew()
        {
            List<gallery> data = db.galleries.ToList();
            return View(data);
        }

        public ActionResult SaveImage(HttpPostedFileBase photo)
        {
            string path = Server.MapPath("~/Uploads");
            string filename = photo.FileName;
            string new_path = path + "/" + filename;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            photo.SaveAs(new_path);
            gallery gallery = new gallery();
            gallery.photo = "~/ Uploads";
            gallery.photo_name = filename;
            db.galleries.Add(gallery);
            db.SaveChanges();


            return RedirectToAction("Index");
        }

        public ActionResult Search(string name1)
        {
            var data1 = db.galleries.Where(x => x.destination_name == name1).ToList();
            return View("gallery", data1);
        }
    }
}