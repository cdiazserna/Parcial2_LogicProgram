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
            int numberPlayers, min = 0, max, numberAttempt = 0, randomNumber = 0;
            bool hasWinner = false, isPlayAgain;
            string resetGame = "";

            do
            {
                PaintMenu(out numberPlayers);
                randomNumber = GenerateRandomNumber(min, out max, randomNumber, numberPlayers);
                PlayGame(numberPlayers, randomNumber, numberAttempt, min, max, hasWinner);
                isPlayAgain = PlayAgain(resetGame);
            } while (isPlayAgain);
        }
        private static bool PlayAgain(string resetGame)
        {
            Console.WriteLine("Si quieren jugar de nuevo digita YES o NO para finalizar");
            resetGame = Console.ReadLine();
            Console.Clear();






