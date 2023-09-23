using System;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir las varibles

            int numJugadores, player1, player2, player3, player4, i, n;
            bool repetir = true;
            Random numrandom = new Random();

            // pedir datos a los participantes.

            Console.WriteLine("------------Bienvenidos-----------\n");
            Console.WriteLine("Cuantos quieren jugar hoy: 2, 3 o 4 ");
            numJugadores = Convert.ToInt32(Console.ReadLine());

            if (numJugadores == 2)
            {
                n = numrandom.Next(0, 50);
                for (i = 0; i <= 50; i++)
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
                        Console.WriteLine("el numero del primer jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del primer jugador es  menor");
                    }
                    if (player2 == n)
                    {
                        Console.WriteLine("el segundo jugador a ganado");
                    }
                    else if (player2 < n)
                    {
                        Console.WriteLine("el numero del segundo jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del segundo jugador es  menor");
                    }
                }


            }
            else if (numJugadores == 3)
            {
                n = numrandom.Next(0, 100);
                for (i = 0; i <= 100; i++)
                {
                    Console.WriteLine("primer jugador ingresa tu numero entre 0 y 100:  ");
                    player1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("segundo jugador ingresa tu numero entre 0 y 100:  ");
                    player2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("tercer jugador ingresa tu numero entre 0 y 100:  ");
                    player3 = Convert.ToInt32(Console.ReadLine());

                    if (player1 == n)
                    {
                        Console.WriteLine("el primer jugador a ganado");

                    }
                    else if (player1 < n)
                    {
                        Console.WriteLine("el numero del primer jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del primer jugador es  menor");
                    }
                    if (player2 == n)
                    {
                        Console.WriteLine("el segundo jugador a ganado");
                    }
                    else if (player2 < n)
                    {
                        Console.WriteLine("el numero del segundo jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del segundo jugador es  menor");
                    }
                    if (player3 == n)
                    {
                        Console.WriteLine("el tercer jugador a ganado");
                    }
                    else if (player3 < n)
                    {
                        Console.WriteLine("el numero del tercer jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del tercer jugador es  menor");
                    }
                }


            }
            else if(numJugadores == 4)
            {
                n = numrandom.Next(0, 200);
                for (i = 0; i <= 200; i++)
                {
                    Console.WriteLine("primer jugador ingresa tu numero entre 0 y 200:  ");
                    player1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("segundo jugador ingresa tu numero entre 0 y 200:  ");
                    player2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("tercer jugador ingresa tu numero entre 0 y 200:  ");
                    player3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("cuarto jugador ingresa tu numero entre 0 y 200:  ");
                    player4 = Convert.ToInt32(Console.ReadLine());
                    if (player1 == n)
                    {
                        Console.WriteLine("el primer jugador a ganado");

                    }
                    else if (player1 < n)
                    {
                        Console.WriteLine("el numero del primer jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del primer jugador es  menor");
                    }
                    if (player2 == n)
                    {
                        Console.WriteLine("el segundo jugador a ganado");
                    }
                    else if (player2 < n)
                    {
                        Console.WriteLine("el numero del segundo jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del segundo jugador es  menor");
                    }
                    if (player3 == n)
                    {
                        Console.WriteLine("el tercer jugador a ganado");
                    }
                    else if (player3 < n)
                    {
                        Console.WriteLine("el numero del tercer jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del tercer jugador es  menor");
                    }
                    if (player4 == n)
                    {
                        Console.WriteLine("el cuarto jugador a ganado");
                    }
                    else if (player4 < n)
                    {
                        Console.WriteLine("el numero del cuarto jugador es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero del cuarto jugador es  menor");
                    }
                }
            }

        }
    }

}
