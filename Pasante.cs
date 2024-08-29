using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    public class Pasante : Persona
    {
        public int NumeroLegajo { get; set; }

        public Pasante(string nombre, string apellido, int edad, string genero, int numeroLegajo) : base(nombre, apellido, edad, genero)
        {
            this.NumeroLegajo = numeroLegajo;
        }

        public Pasante() { }    

        public override string ToString()
        {
            return $"{base.ToString()}, Numero Legajo: {this.NumeroLegajo}";
        }
    }
}
