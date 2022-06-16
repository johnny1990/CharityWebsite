using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using System.IO;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Rotativa.AspNetCore;

namespace Charity.Web.Controllers
{
    public class DonationController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Formular()
        {
            try
            {
                return new ViewAsPdf("Formular");
            }
            catch (Exception ex)
            {
                ex.ToString();
                return NotFound();
            }

        }


    }
}
