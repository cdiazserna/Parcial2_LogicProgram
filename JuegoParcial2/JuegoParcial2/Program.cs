using System;

namespace JuegoParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creación de un juego
            // declaración de variables

            Random numeroRandom = new Random();

            int numeroJugadores, numeroEscogido;

            //Proceso del juego

            //Pedimos el número de jugadores

            Console.WriteLine("Bienvenidos al juego de adivinar el número");
            Console.WriteLine("Ingrese el número de jugadores que desean jugar\n" +
                "mínimo deben de ser 2 jugadores y máximo 4");

            numeroJugadores = Convert.ToInt32(Console.ReadLine());


            for (int i = 2;i <= numeroJugadores; i++)
            {

                

            }
            


        }
    }
}
