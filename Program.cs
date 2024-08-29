namespace SolucionEjercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pro1 = new Profesional("Valentina", "Ramírez", 20, "Femenino", 3241);
            var pas1 = new Pasante("Mateo", "García", 23, "Masculino", 1241);
            var pro2 = new Profesional("Luna", "Pérez", 30, "Femenino", 9241);
            var pas2 = new Pasante("Benjamín", "Martínez", 27, "Masculino", 7241);
            var pro3 = new Profesional("Ana", "Ramírez", 20, "Femenino", 8241);
            var pas3 = new Pasante("Laura", "Rodríguez", 33, "Femenino", 1241);

            List<Persona> personas = new List<Persona> { pro1, pas1, pro2, pas2, pro3, pas3};

            var estacion = new EstacionMeteorologica(personas);
            
            estacion.CargarTemperaturasAutomaticamente();

            estacion.VerTemperaturas();

            var temperatura = estacion.VerTemperaturaEspecifica(10);

            if (temperatura != null)
            {
                Console.WriteLine(temperatura.ToString());
            }

            var promedios = CalculoTemperaturas.CalcularPromedioSemanal(estacion.temperaturasDiariasMes);

            for (int i = 0; i < promedios.Count; i++)
            {
                Console.WriteLine($"Semana {i+1}: {promedios[i]}");
            }
        }
    }
}
