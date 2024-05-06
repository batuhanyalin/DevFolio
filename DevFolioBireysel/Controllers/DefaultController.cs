using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class DefaultController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkills()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSocialMedia()
        {
            var values = db.TblSocialMedia.Where(x => x.Status == true).ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact p)
        {
            if (!ModelState.IsValid)
            {
                return PartialView();
            }
            else
            {
                db.TblContact.Add(p);
                db.SaveChanges();
                return PartialView();
            }
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialPortfolio()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
    }
}