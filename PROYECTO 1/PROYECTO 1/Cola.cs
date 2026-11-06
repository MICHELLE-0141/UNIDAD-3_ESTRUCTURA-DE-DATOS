using PROYECTO_1;
using PROYECTO_1_CLINICA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    public class Cola1
    {
        private Nodo1 frente;
        private Nodo1 final;
        public Cola1()
        {
            frente = null;
            fibal = null;
        }
        public void Encolar(Paciente paciente)
        {
            Nodo1 nuevo = new Nodo1(paciente);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
        }
        public Paciente Desencolar()
        {
            if (frente == null)
                return null;
            Paciente paciente = frente.Datos;
            frente = frente.siguiente;
            if (frente == null)
                final = null;
            return paciente;
        }
        public void Mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }
            Nodo1 aux = frente;
            while (aux != null)
            {
                Console.WriteLine(aux,.Datos);
                aux = aux.siguiente;
            }
        }
    }
}
