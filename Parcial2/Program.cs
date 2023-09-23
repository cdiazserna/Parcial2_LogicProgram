using System;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {// declaracion de mis variables

            Random random = new Random();

            int NumJugadores = 0, numGanador, jugador1, jugador2, jugador3, jugador4;
            numGanador = random.Next(0, 100);

            Console.Write("Ingrese el numero de jugadores:  ");
            NumJugadores = Convert.ToInt32(Console.ReadLine());



            if (NumJugadores == 2)
            {
                Console.Write("jugador 1 ingrese el número:  ");
                jugador1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("jugador 2 ingrese el número:  ");
                jugador2 = Convert.ToInt32(Console.ReadLine());

            }


            else Console.Write("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumJugadores == 3)
            {
                Console.Write("jugador 1 ingrese el número:  ");
                jugador1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("jugador 2 ingrese el número:  ");
                jugador2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("jugador 3 ingrese el número:  ");
                jugador3 = Convert.ToInt32(Console.ReadLine());

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumJugadores == 4)
            {
                Console.Write("jugador 1 ingrese el número:  ");
                jugador1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("jugador 2 ingrese el número:  ");
                jugador2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("jugador 3 ingrese el número:  ");
                jugador3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("jugador 4 ingrese el número:  ");
                jugador4 = Convert.ToInt32(Console.ReadLine());
            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            // calculos

           







            


            





        }
    }
}
