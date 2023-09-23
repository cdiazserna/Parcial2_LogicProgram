using System;
using System.ComponentModel.Design;
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
            int numeroInte, numN;
            
            //Generar numero aleatorio

            Console.WriteLine("BIENVENIDO AL JUEGO");
            Console.WriteLine("\n");
            Console.Write("Por favor ingresar el numero de integrantes que desea participar: ");
            numeroInte = Convert.ToInt32(Console.ReadLine());
            Random Random = new Random();
            if (numeroInte < 2) 
            {
                Console.WriteLine("El numero de integrantes debe ser mayor a 2 y menor a 4");
                Console.WriteLine("\n");
                Console.WriteLine("Por favor ingresar el numero de integrantes que desea participar: ");
                numeroInte = Convert.ToInt32(Console.ReadLine());
            }
            else 
            {
                if (numeroInte > 4)
                {
                    Console.WriteLine("El numero de integrantes debe ser mayor o igual a 2 y menor o igual a 4");
                    Console.WriteLine("\n");
                    Console.WriteLine("Por favor ingresar el numero de integrantes que desea participar: ");
                    numeroInte = Convert.ToInt32(Console.ReadLine());

                                 
                }
            }

            if (numeroInte == 2)
            { 
                numN = Random.Next(0, 51); 
            }

            else
            {
                if (numeroInte == 3)
                { numN = Random.Next(0, 100); }

                    else
                    {
                    if (numeroInte == 4)
                        numN = Random.Next(0, 200);
                    }
                
        }   }









       
    }
}
