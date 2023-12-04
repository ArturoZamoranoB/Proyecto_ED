using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_ED.Models;
namespace Proyecto_ED.Clases
{
    public class Nodo
    {
        public Persona Jugador { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Persona jugador)
        {
            Jugador = jugador;
            Siguiente = null;
        }
    }

}
