using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2021.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public string Saludo()
        {
            return "Hola Mundo";
        }

        public string SaludoNombreApellido(string nombre, string apellido)
        {
            return "¡Hola " + nombre + " " + apellido + "!";
        }


    }
}
