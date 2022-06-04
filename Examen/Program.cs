using System;
using Examen;
namespace Examen
{
    public class Program
    {
        private static int length;

        public static int Length { get => length; set => length = value; }

        private static void Main(string[] args)
        {
            Primaria primaria = new Primaria("Antonella", "Duran", " Cinco de Junio", "1351212871", 500);
            Secundaria secundaria = new Secundaria("Antonella", "Duran", " Colegio Manta ", "1351212871", 6, 200);
            Universitarios U = new Universitarios("Antonella", "Duran", " Eloy Alfaro de Manabí", "1351212871", 300, 20);
            for (int i = Length + 1; i >= 0; i++)
            {
                primaria.ImprimirDatos();
                primaria.Calcular();
                Console.WriteLine("");
                secundaria.Calcular();
                Console.WriteLine("");
                U.ImprimirDatos();
                U.Calcular();
            }
        }
    }
}