using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class ProfileController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();

        [HttpGet]
        // GET: Profile
        public ActionResult Index(int id)
        {
            var value = db.TblProfile.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Index(TblProfile p)
        {
            var value = db.TblProfile.Find(p.ProfileID);
            value.NameSurname = p.NameSurname;
            value.Title = p.Title;
            value.Email = p.Email;
            value.Phone = p.Phone;
            db.SaveChanges();
            return RedirectToAction("Index","Dashboard");
        }
    }
}