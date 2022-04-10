using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_asp.Models;

namespace web_asp.Controllers
{
    public class EscuelaController : Controller
    {

        public EscuelaController()
        {
            
        }

        public IActionResult Index()
        {
          Escuela escuela = new Escuela();
          escuela.Nombre = "Platzi School";
          escuela.Pais = "Colombia";
          escuela.Ciudad = "Bogota";
          escuela.AñoDeCreación = 2019;
          escuela.TipoEscuela = TiposEscuela.Secundaria;
          escuela.UniqueId = Guid.NewGuid().ToString();
          return View(escuela);
        }
    }
}
