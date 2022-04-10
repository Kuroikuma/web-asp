using System;

namespace web_asp.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}