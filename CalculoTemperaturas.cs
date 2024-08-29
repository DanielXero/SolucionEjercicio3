using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    public static class CalculoTemperaturas
    {
        // Método para calcular el promedio semanal
        public static List<double> CalcularPromedioSemanal(RegistroTemperatura[,] matriz)
        {
            List<double> promediosSemanales = new List<double>();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int suma = 0, contador = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] != null)
                    {
                        suma += matriz[i, j].Temperatura;
                        contador++;
                    }
                }
                if (contador > 0)
                {
                    promediosSemanales.Add(Math.Round((double)suma / contador, 2));
                }
            }
            return promediosSemanales;
        }

        // Método para obtener temperaturas por encima de un umbral
        public static List<int> ObtenerTemperaturasAltas(RegistroTemperatura[,] matriz, int umbral)
        {
            List<int> temperaturasAltas = new List<int>();
            foreach (var registro in matriz)
            {
                if (registro != null && registro.Temperatura > umbral)
                {
                    temperaturasAltas.Add(registro.Temperatura);
                }
            }
            return temperaturasAltas;
        }

        // Método para calcular la temperatura promedio mensual
        public static double CalcularPromedioMensual(RegistroTemperatura[,] matriz)
        {
            int suma = 0, contador = 0;
            foreach (var registro in matriz)
            {
                if (registro != null)
                {
                    suma += registro.Temperatura;
                    contador++;
                }
            }
            return contador > 0 ? Math.Round((double)suma / contador, 2) : 0.0;
        }

    }
}
