using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    public class RegistroTemperatura
    {
        public int Temperatura { get; set; }
        public Persona PersonaTurno { get; set; }

        public DateTime FechaRegistro { get; set; }

        public RegistroTemperatura(int temperatura, Persona personaTurno, DateTime fechaRegistro) 
        {
            this.Temperatura = temperatura;
            this.PersonaTurno = personaTurno;
            this.FechaRegistro = fechaRegistro;
        }



        public override string ToString()
        {
            return $"Temperatura: {this.Temperatura}, Persona de Turno: {this.PersonaTurno}, Fecha de Registro: {this.FechaRegistro}";
        }

    }
}
