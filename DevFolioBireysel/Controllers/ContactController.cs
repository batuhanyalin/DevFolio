using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Index()
        {
            var value = db.TblContact.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateMessage(TblContact p)
        {
            var value = db.TblContact.Find(p.ContactID);
            value.Email = p.Email;
            value.IsRead = p.IsRead;
            value.Message = p.Message;
            value.NameSurname = p.NameSurname;
            value.SendMessageDate = p.SendMessageDate;
            return RedirectToAction("Index", "Contact");
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            return RedirectToAction("Index", "Contact");
        }
    }
}