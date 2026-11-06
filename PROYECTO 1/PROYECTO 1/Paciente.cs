/* sistema de pacientes
 lista enlasada pacientes
cola pacientes normales
cola prioridades emergentes*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace PROYECTO_1
{
    public class Paciente
    {
        public int Expediente {  get; set;}
        public string Nombre { get; set;}
        public int Edad {  get; set;}
        public int Priodidad { get; set;}

        public Paciente(int expediente, string nombre, int edad, int priodidad)

        {
            Expediente = expediente;
            Nombre = nombre;
            Edad = edad;
            Prioridad = prioridad;
        }

        public override string ToString()
        {
            return $"Expediente: {Expediente}|" +
                $"Nombre:{Nombre}|" +
                $"Edad:{Edad}|" +
                $"Prioridad:{Prioridad}";
        }
    }
}
