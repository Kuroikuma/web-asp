using System;
using System.Collections.Generic;

namespace web_asp.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignatura{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }
    }
}