using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    public class EstacionMeteorologica
    {
        public RegistroTemperatura[,] temperaturasDiariasMes { get; }
        private List<Persona> personasTurno;

        public EstacionMeteorologica(List<Persona> personasTurno)
        {
            
            this.temperaturasDiariasMes = new RegistroTemperatura[5, 7];
            this.personasTurno = personasTurno;

        }

        
        public void RegistrarTemperatura(RegistroTemperatura registro, int semana, int dia)
        {
            int auxSemana = semana - 1;
            int auxDia = dia - 1;
            Random random = new Random();


            if ((auxSemana < 0 || auxSemana >= 5) || (auxDia < 0 || auxDia >= 7))
            {
                auxSemana = random.Next(0, 6);
                auxDia = random.Next(0, 7);
                Console.WriteLine("Se almaceno en un día aleatorio");
            }

            this.temperaturasDiariasMes[auxSemana, auxDia] = registro;
        }


        public void CargarTemperaturasAutomaticamente()
        {
            Random random = new Random();
            int temperatura = 0;
            int contAux = 1;
            DateTime fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            for (int i = 0; i < this.temperaturasDiariasMes.GetLength(0); i++)
            {
                for (int j = 0; j < this.temperaturasDiariasMes.GetLength(1); j++)
                {
                    if (contAux <= 31)
                    {
                        temperatura = random.Next(-20, 40);
                        DateTime fechaRegistro = fechaInicio.AddDays(contAux);
                        Persona personaDeTurno = personasTurno[contAux % personasTurno.Count];


                        this.temperaturasDiariasMes[i, j] = new RegistroTemperatura(temperatura, personaDeTurno, fechaRegistro);

                    }
                    contAux++;

                    
                }
            }
        }

        // Método para visualizar las temperaturas de la matriz
        public void VerTemperaturas()
        {
            Console.WriteLine("\n\n\t***** Calendario de temperatura del mes *****\n\n");
            Console.WriteLine("DO\tLU\tMA\tMI\tJU\tVI\tSA");
            RegistroTemperatura registro = this.temperaturasDiariasMes[0,0];
            int contDias = 1;
            for (int i = 0; i < this.temperaturasDiariasMes.GetLength(0); i++)
            {
                for (int j = 0; j < this.temperaturasDiariasMes.GetLength(1); j++)
                {
                    
                    if (contDias <= 31)
                    {
                        registro = this.temperaturasDiariasMes[i, j];
                        Console.Write($"{registro.Temperatura}°C\t");
                    }
                    contDias++;
                }
                Console.WriteLine();
            }
        }

        // Método para obtener la temperatura de un día específico
        public RegistroTemperatura VerTemperaturaEspecifica(int dia)
        {
            int contDias = 0;
            for (int i = 0; i < this.temperaturasDiariasMes.GetLength(0); i++)
            {
                for (int j = 0; j < this.temperaturasDiariasMes.GetLength(1); j++)
                {
                    if (contDias == dia - 1)
                    {
                        return this.temperaturasDiariasMes[i, j];
                    }
                    contDias++;
                }
            }
            return null;
        }
    }
}





