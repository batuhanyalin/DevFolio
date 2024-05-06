using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class StatisticController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();

        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.averageSkillPoint = db.TblSkill.Average(x => x.SkillValue);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.coreCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.htmlCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 6).Count();
            ViewBag.csharpCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 4).Count();
            ViewBag.getServicesCount = db.TblService.Count();
            ViewBag.pythonCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 3).Count();
            ViewBag.getLastTestimonial2 = db.getLastTestimonial2().FirstOrDefault();
            ViewBag.getLastTestimonialContect = db.getLastTestimonialContect().FirstOrDefault();
            return View();
        }
    }
}