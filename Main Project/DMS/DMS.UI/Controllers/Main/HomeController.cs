using AutoMapper;
using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.Repositories.MainRepo;
using DMS.DAL.StaticHelper;
using DMS.Services.General.Interface;
using DMS.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;
        public HomeController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        SystemInfoForSession systemSession = SessionHelper.GetSession();

        public ActionResult AccessDeniedPage()
        {
            return View();
        }

        public ActionResult Index()
        {
            List<destinationn> data = db.destinationns.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult gallery()
        {
            ViewBag.Message = "Your gallery page.";
            List<gallerydata> data = db.gallerydatas.ToList();
            return View(data);
        }

        public ActionResult Search(string name1)
        {
            var data1 = db.gallerydatas.Where(x => x.destination_name == name1).ToList();
            return View("gallery", data1);
        }

        public ActionResult Search1(string name2)
        {
            var data2 = db.destinationns.Where(x => x.dname == name2).ToList();
            return View("beautifultours", data2);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Save(contactu contact)
        {
            db.contactus.Add(contact);
            db.SaveChanges();
            return RedirectToAction("contactsuccess","Home");
        }
        public ActionResult beautifultours()
        {
            ViewBag.Message = "Your tours page.";
            List<destinationn> data = db.destinationns.ToList();
            return View(data);
        }

        public ActionResult destination(string dname)
        {
            Session["dname"] = dname;
            return RedirectToAction("Booktour", "Home");
        }
        

        public ActionResult Sort(int name2)
        {
            var data1 = db.destinationns.Where(x => x.id == name2).ToList();
            return View("Readmorepage", data1);
        }

        public ActionResult Savedata(booktour book)
        {
            db.booktours.Add(book);
            db.SaveChanges();
            return RedirectToAction("Success", "Home");
        }

        public ActionResult Readmorepage()
        {
            List<destinationn> data = db.destinationns.ToList();
            return View(data);
        }
        public ActionResult Booktour()
        {
            return View();
        }

        public ActionResult contactsuccess()
        {
            return View();
        }

        public ActionResult Success()
        {
            List<destinationn> data = db.destinationns.ToList();
            return View(data);
        }
        public async Task<ActionResult> Dashboard()
        {
            return RedirectToAction("Index", "admin");
        }

    }
}