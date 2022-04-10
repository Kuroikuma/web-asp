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
    public class AsignaturaController : Controller
    {

        public AsignaturaController()
        {
            
        }

        public IActionResult Index()
        {
          Asignatura Asignatura = new Asignatura();
          Asignatura.Nombre = "Matematicas";
          Asignatura.UniqueId = Guid.NewGuid().ToString();
          return View(Asignatura);
        }

        public IActionResult ListAsignatura()
        {
          var listaAsignaturas = new List<Asignatura> () {
            new Asignatura {
            Nombre = "Matemáticas",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Educación Física",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Castellano",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Ciencias Naturales",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Programacion",
            UniqueId = Guid.NewGuid ().ToString ()
            }
          
        };
          return View(listaAsignaturas);
        }
    }
}
