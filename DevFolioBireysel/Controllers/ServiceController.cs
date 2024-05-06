using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Service()
        {
            var value = db.TblService.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(TblService p)
        {
            var value = db.TblService.Add(p);
            db.SaveChanges();
            return RedirectToAction("Service");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.TblService.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(TblService p)
        {
            var value = db.TblService.Find(p.ServiceID);
            value.ServiceTitle = p.ServiceTitle;
            value.ServiceDescription = p.ServiceDescription;
            value.ServiceImageUrl = p.ServiceImageUrl;
            db.SaveChanges();
            return RedirectToAction("Service");
        }
        public ActionResult DeleteService(int id)
        {
            var value = db.TblService.Find(id);
            db.TblService.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Service");
        }

    }
}