using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public bool HireDoctor()
        {
            return true;
        }

        [HttpGet]
        public bool PatientRegister()
        {
            return true;
        }

        [HttpGet]

        public bool PatientAppoinment()
        {
            return true;
        }

        [HttpGet]

        public bool PanelPatient()
        {
            return true;
        }

        [HttpGet]

        public int Billing()
        {
            return 0;

        }
    }
}
