using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

using WinRH;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RH.Controllers
{
    public class FormController : Controller
    {
        // GET: /<controller>/
        public IActionResult New()
        {
            return View();
        }

        public IActionResult Edit(long id)
        {
            return View();
        }

        public IActionResult AskToDelete(long id)
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

    }
}