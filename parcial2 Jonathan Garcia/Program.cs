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
            int numeroInte, numN=0, numIngresado;
            string nuevoTiro;
            bool newCod = false;



            //Generar numero aleatorio

            do
            {
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

                }
                //Iniciar el ciclo de adivinar el numero
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Ingrese el numero que cree que es el correcto:");
                    Console.WriteLine("\n");
                    numIngresado = Convert.ToInt32(Console.ReadLine());

                    if (numIngresado > numN)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("MENOR");
                        Console.WriteLine("\n");
                    }

                    else
                    {
                        if (numIngresado < numN)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("MAYOR");
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            if (numIngresado == numN)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("¡HAS GANADO!”. Aquí ya finaliza el juego.");
                                Console.WriteLine("\n");
                            }

                        }
                    }

                }

                while (numIngresado != numN);


                Console.WriteLine("\n");
                Console.WriteLine("¿¿¿ Desea  jugar un nuevo “tirito” ??? ");
                Console.WriteLine("¿¿¿ Ingrese SI o NO ??? ");
                Console.WriteLine("\n");
                nuevoTiro = Convert.ToString(Console.ReadLine());

                
                if (nuevoTiro == "SI")
                {
                    newCod = true;
                    Console.Clear();
                }
            }
            while (newCod == true);

    {

            }




        }


        

    








       
    }
}
