using System;
using System.Threading.Tasks;

//Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo,
//consiste en adivinar  un  número ℕaleatorio  que  el  sistema  escoge  de  un  determinado
//rango  y lo guarda  en memoriasin ser revelado.

namespace Parcial2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numeroInte;
            double numN;

            //Generar numero aleatorio

            Console.WriteLine("BIENVENIDO AL JUEGO");
            Console.WriteLine("\n");
            Console.Write("Por favor ingresar el numero de integrantes que desea participar: ");
            numeroInte = Convert.ToInt32(Console.ReadLine());
            Random Random = new Random();
            if (numeroInte < 1) 
            {
                Console.Write("El numero de integrantes debe ser mayor a 2 y menor a 4");
                Console.Write("Por favor ingresar el numero de integrantes que desea participar: ");
                numeroInte = Convert.ToInt32(Console.ReadLine());
            }
            else 
            {
            if (numeroInte  == 2) { tasa = Random.Next(1, 51);
                }
            }
            Random Random = new Random();



        }
    }
}
