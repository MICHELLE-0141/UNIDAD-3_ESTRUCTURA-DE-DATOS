using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_3
{
    public class Llamada
    {
        public string NumeroTelefono { get; set; }
        public string NombrePersona {  get; set;}
        public string Motivo { get; set; }

        public Llamada(string numero, string nombre, string motivo)
        {
            NumeroTelefono = numero;
            NombrePersona = nombre;
            Motivo = motivo;

        }

        public override string ToString()
        {
            return $"Tel: {NumeroTelefono} | Nombre: {NombrePersona} | Motivo: {Motivo} ";
        }
    }
}
