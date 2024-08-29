using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int _edad;
        public int Edad
        {
            get => _edad;
            //Agregar validación en edad para que value sea siempre mayor a cero
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La edad debe ser mayor a cero");
                }
                _edad = value;
            }
        }
        public string Genero { get; set; }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad, string genero)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._edad = edad;
            this.Genero = genero;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Apellido: {this.Apellido}, Edad: {this._edad}, Genero: {this.Genero}";
        }


    }
}
