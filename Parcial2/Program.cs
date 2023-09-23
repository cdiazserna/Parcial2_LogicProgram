using System;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {// declaracion de mis variables

            Random random = new Random();

            int NumParticipantes = 0, numGanador, jugador1, jugador2, jugador3, jugador4;
            numGanador = random.Next(0, 100);
            
            Console.WriteLine("jugador 1 ingrese el número:  ");
            Convert.ToInt32("Participante 1 ingrese el número:  ");

            Console.WriteLine("Participante 2 ingrese el número:  ");

            Console.WriteLine("Participante 3 ingrese el número:  ");

            Console.WriteLine("Participante 4 ingrese el número:  ");






            if (NumParticipantes == 2)
            {
                Console.WriteLine("jugador 1 ingrese el número:  ");

                Console.WriteLine("jugador 2 ingrese el número:  ");


            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumParticipantes == 3)
            {
                Console.WriteLine("jugador 3 ingrese el número:  ");

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumParticipantes == 4)
            {
                Console.WriteLine("jugador 4 ingrese el número:  ");

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");



            //c
           

        }
    }
}
