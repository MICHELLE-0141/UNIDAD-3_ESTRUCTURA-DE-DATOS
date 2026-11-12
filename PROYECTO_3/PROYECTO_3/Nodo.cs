using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_3
{
    public class Nodo
    {
        public Llamada LlamadaDatos { get; set;}
        public Nodo Siguiente { get; set;}

        public Nodo(Llamada llamada)
        {
            LlamadaDatos = llamada;
            Siguiente = null;
        }
    }
}
