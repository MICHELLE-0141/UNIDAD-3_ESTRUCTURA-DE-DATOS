using PROYECTO_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_1_CLINICA
{
    public class Nodo
    {
        public Paciente Datos;
        public Nodo Siguente;

        public Nodo(Paciente paciente)
        {
            Datos = paciente;
            Siguente = null;
        }
    }
}
