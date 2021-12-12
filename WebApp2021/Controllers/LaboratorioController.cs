using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidad;

namespace WebApp2021.Controllers
{
    public class LaboratorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<LaboratorioCLS> ListarLaboratorio()
        {
            LaboratorioBL obj = new LaboratorioBL();
            return obj.ListarLaboratorio();
        }
    }
}
