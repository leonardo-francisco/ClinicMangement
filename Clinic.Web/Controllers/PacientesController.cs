using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Web.Controllers
{
    public class PacientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdicionaPacientes()
        {
            return View();
        }

        public IActionResult EditaPacientes()
        {
            return View();
        }
    }
}