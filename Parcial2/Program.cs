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

            Console.WriteLine("Ingrese el numero de jugadores:  ");
            NumJugadores = Convert.ToInt32(Console.ReadLine());



            if (NumJugadores == 2)
            {
                Console.WriteLine("jugador 1 ingrese el número:  ");
                jugador1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("jugador 2 ingrese el número:  ");
                jugador2 = Convert.ToInt32(Console.ReadLine());

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumParticipantes == 3)
            {
                Console.WriteLine("jugador 1 ingrese el número:  ");
                jugador1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("jugador 2 ingrese el número:  ");
                jugador2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("jugador 3 ingrese el número:  ");
                jugador3 = Convert.ToInt32(Console.ReadLine());

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumParticipantes == 4)
            {
                Console.WriteLine("jugador 1 ingrese el número:  ");
                jugador1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("jugador 2 ingrese el número:  ");
                jugador2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("jugador 3 ingrese el número:  ");
                jugador3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("jugador 4 ingrese el número:  ");
                jugador4 = Convert.ToInt32(Console.ReadLine());
            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            //3 pedir los valores porconsola 

            


            





        }
    }
}
