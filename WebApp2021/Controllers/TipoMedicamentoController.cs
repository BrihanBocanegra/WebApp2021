using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidad;

namespace WebApp2021.Controllers
{
    public class TipoMedicamentoController : Controller
    {

        public List<TipoMedicamentoCLS> ListarTipoMedicamento()
        {
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.ListarMedicamentos();
        }

        // GET: TipoMedicamentoController
        public ActionResult Index()
        {
            return View();
        }


    }
}
