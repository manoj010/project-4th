using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class adminController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: admin
        public ActionResult Index()
        {
            //Session["Totalbook"] = db.booktours.Count();
            Session["Total"] = db.destinationns.Count();
            Session["TotalPhoto"] = db.gallerydatas.Count();
            Session["TotalContact"] = db.contactus.Count();
            Session["TotalBook"] = db.booktours.Count();
            return View();
        }
    }
}