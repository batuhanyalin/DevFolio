using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Project()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Project", "Project");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.TblProject.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var values = db.TblProject.Find(p.ProjectID);
            values.Title = p.Title;
            values.CoverImageUrl = p.CoverImageUrl;
            values.ProjectCategory = p.ProjectCategory;
            values.GithubLink = p.GithubLink;
            db.SaveChanges();
            return RedirectToAction("Project");
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.TblProject.Find(id);
            db.TblProject.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Project");
        }
    }
}


