﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoWeb1.Controllers
{
    public class ConsultationController : Controller
    {
        // GET: Consultation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agenda()
        {
            return View();
        }
    }
}