using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFolioBireysel.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public FilePathResult Index()
        {
            string dosyayolu = Server.MapPath("~/Files/batuhanyalinCV.pdf");
            string dosyaTuru = "application/pdf";
            return File(dosyayolu, dosyaTuru, "batuhanyalinCV.pdf");
        }
    }
}