using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2021.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Medicamento()
        {
            return View();
        }

    }
}
