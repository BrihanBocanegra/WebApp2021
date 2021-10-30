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

        // GET: TipoMedicamentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoMedicamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMedicamentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoMedicamentoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoMedicamentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoMedicamentoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoMedicamentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
