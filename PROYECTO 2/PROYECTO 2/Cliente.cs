using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_2
{
    public class Cliente
    {
        public string Nombre {  get; set;}
        public int Personas { get; set;}

        public CLIENTE(string nombre, int personas)
        {
            Nombre = nombre;
            Personas = personas;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Personas}personas";
        }
    }
}
