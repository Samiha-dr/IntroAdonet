using MedicoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoWeb1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HoraireModel h = new HoraireModel();
            List<HoraireModel> Lm = h.GetAll();
            return View(Lm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Medecins()
        {
            return View();
        }

        public ActionResult Patients()
        {
            return View();
        }

        
    }
}