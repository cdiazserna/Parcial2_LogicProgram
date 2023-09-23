//Desarrollar el juego "adivina el numero" en un programa en c#, consiste en adivinar un numero N aleatorio//
//que el sistema escoge de un determinado rango y lo guarda en memoria sin ser revelado//
using System;
using System.Runtime.CompilerServices;

namespace ResolucionParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variables del programa//
            //se declara variable boolena de ganador //


            int Numerojuego, min = 0, max, Numerointento  = 0, randomNumber = 0;
            bool Ganador = false, isPlayAgain;
            string resetGame = "";

            do
            {
                PaintMenu(out Numerojuego);
                randomNumber = GenerateRandomNumber(min, out max, randomNumber, Numerojuego);
                PlayGame(Numerojuego, randomNumber, Numerointento, min, max, Ganador);
                isPlayAgain = PlayAgain(resetGame);
            } while (isPlayAgain);
        }
        private static bool PlayAgain(string resetGame)
        {
            Console.WriteLine("Si quieren jugar de nuevo digita YES o NO para finalizar");
            resetGame = Console.ReadLine();
            Console.Clear();
            if (resetGame.ToLower() == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void PlayGame(int Numerojuego, int randomNumber, int Numerointento, int min, int max, bool hasWinner)
        {
            do
            {
                for (int i = 1; i <= Numerojuego; i++)
                {
                    Console.WriteLine(String.Format("Jugardor #{0}, lanza un número que esté entre {1} y {2}", i, min, max));
                    Numerointento = Convert.ToInt32(Console.ReadLine());

                    if (Numerointento > randomNumber)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else if (Numerointento < randomNumber)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else
                    {
                        Console.WriteLine("¡Has Ganado!");
                        hasWinner = true;
                        break;
                    }
                }
            } while (!hasWinner);
        }

        private static int GenerateRandomNumber(int min, out int max, int randomNumber, int Numerojuego)
        {
            Random random = new Random();
            max = 50;

            //se hace sw con cliclo case para evaluar y quede mas accequible en los ingresos//

            switch (Numerojuego)
            {
                //si participan 2 jugdores el numero N aleatorio se genera entre 0 y 50//
                case 1:
                    randomNumber = random.Next(min, max);
                    break;

                //si participan 3 jugdores el numero N aleatorio se genera entre 0 y 100//

                case 2:
                    max = 100;
                    randomNumber = random.Next(min, max);
                    break;

                //si participan 4 jugdores el numero N aleatorio se genera entre 0 y 200//

                case 3:
                    max = 200;
                    randomNumber = random.Next(min, max);
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida.");
                    break;
            }

            return randomNumber;
        }

        private static void PaintMenu(out int numberPlayers)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*JUEGO ADIVINA EL NÚMERO*");
            Console.WriteLine("*************************");
            Console.WriteLine("¿Cuántos participantes jugarán?");
            Console.WriteLine("Dos jugadores");
            Console.WriteLine("Tres jugadores");
            Console.WriteLine("Cuatro jugadores");
            Console.WriteLine("Digite el número de jugadores\n");
            numberPlayers = Convert.ToInt32(Console.ReadLine());
        }
    }
}







