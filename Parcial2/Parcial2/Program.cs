//Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar  un  número ℕaleatorio  que  el  sistema  escoge  de  un  determinado  rango  y lo guarda  en memoriasin ser revelado
using System;

public class parial2
{
    static void Main(string[] args)
    {
        int numeroAleatorio;
        int numeroIngresado;
        int numeroJugadores;
        int rangoMaximo;
        int turno;
        bool ganador;
        string respuesta;

            Random random = new Random();


        {
            Console.WriteLine("BIENVENIDO AL JUEGO: ");

            Console.WriteLine("cuantos jugadores van a jugar  (Mínimo 2 y máximo 4)\");\n");

            numeroJugadores = Convert.ToInt32(Console.ReadLine());

            while (numeroJugadores < 2 || numeroJugadores > 4)
            {

                Console.WriteLine("El número de jugadores debe ser entre 2 y 4. Inténtalo de nuevo.");
                numeroJugadores = Convert.ToInt32(Console.ReadLine());
            }

            switch (numeroJugadores)
            {
                case 2:
                    rangoMaximo = 50;
                    break;
                case 3:
                    rangoMaximo = 100;
                    break;
                case 4:
                    rangoMaximo = 200;
                    break;
                default:
                    rangoMaximo = 0;
                    break;

            }
            
            {
                numeroAleatorio = random.Next(0, rangoMaximo + 1);

                turno = 1;
                ganador = false;

                Console.WriteLine($"el sistema a escogido entre 0 y {rangoMaximo}. intenta adivinarlo:");
                while(!ganador && turno <= numeroJugadores)
                {
                    Console.WriteLine($"Jugador {turno}, ingresa un número:");
                    numeroIngresado = int.Parse(Console.ReadLine());
                    if (numeroIngresado == numeroAleatorio)
                    {

                        Console.WriteLine("¡HAS GANADO!");
                        ganador = true;

                    }



                }
            }




























        }
    }
}