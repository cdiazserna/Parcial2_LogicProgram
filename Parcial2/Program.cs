using System;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir las varibles

            int numJugadores, player1, player2, player3, player4, i, n;
            Random numrandom = new Random();

            // pedir datos a los participantes.

            Console.WriteLine("------------Bienvenidos-----------\n");
            Console.WriteLine("Cuantos quieren jugar hoy: 2, 3 o 4 ");
            numJugadores = Convert.ToInt32(Console.ReadLine());
            
            if (numJugadores ==2)
            {
                n = numrandom.Next(0, 50);
                for (i = 0, i = 50; i++)
                {
                    Console.WriteLine("primer jugador ingresa tu numero entre 0 y 50:  ");
                    player1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("segundo jugador ingresa tu numero entre 0 y 50:  ");
                    player2 = Convert.ToInt32(Console.ReadLine());
                    if (player1 == n)
                    {
                        Console.WriteLine("el primer jugador a ganado");

                    }
                    else if (player1 < n)
                    {
                        Console.WriteLine("el numero es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero es menor");
                    }
                    }
                }
                
                
            }

        }
    }
}
