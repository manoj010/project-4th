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
            List<gallerydata> data = db.gallerydatas.ToList();
            return View(data);
        }

        public ActionResult AddNew()
        {
            List<gallerydata> data = db.gallerydatas.ToList();
            return View(data);
        }

        public ActionResult Savedata(gallerydata gallerydata, HttpPostedFileBase photo)
        {
            string path = Server.MapPath("~/Galleryphoto");
            string filename = photo.FileName;
            string new_path = path + "/" + filename;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            photo.SaveAs(new_path);
            gallerydata.photo = "~/Galleryphoto";
            gallerydata.photo_name = filename;
            db.gallerydatas.Add(gallerydata);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult deletedata(int id)
        {
            gallerydata data = db.gallerydatas.Find(id);
            db.gallerydatas.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search(string name1)
        {
            var data1 = db.gallerydatas.Where(x => x.destination_name == name1).ToList();
            return View("gallery", data1);
        }
    }
}