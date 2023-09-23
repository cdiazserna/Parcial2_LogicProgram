using System;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {// declaracion de mis variables

            Random random = new Random();

            int NumParticipantes = 0, numGanador;
            numGanador = random.Next(0, 100);

            Console.WriteLine("Participante 1 ingrese el número:  ");
            Console.WriteLine("Participante 2 ingrese el número:  ");
            Console.WriteLine("Participante 3 ingrese el número:  ");
            Console.WriteLine("Participante 4 ingrese el número:  ");






            if (NumParticipantes == 2)
            {
                numGanador = random.Next(0,50);
                
            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumParticipantes == 3)
            {
                numGanador = random.Next(0, 100);

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");

            if (NumParticipantes == 4)
            {
                numGanador = random.Next(0, 200);

            }


            else Console.WriteLine("Para este juego deben participar minimo 2 jugadores maximo 4");



            //c
           

        }
    }
}
