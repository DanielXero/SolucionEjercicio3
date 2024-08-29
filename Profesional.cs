using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    public class Profesional : Persona
    {
        public int NumeroMatricula { get; set; }

        public Profesional(string nombre, string apellido, int edad, string genero, int numeroMatricula) : base(nombre, apellido, edad, genero)
        {
            this.NumeroMatricula = numeroMatricula;
        }

        public Profesional() { }


        public override string ToString()
        {
            return $"{base.ToString()}, Numero Matricula: {this.NumeroMatricula}";
        }

    }
}
