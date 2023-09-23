
using System;

namespace juegoparcial2

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numjugadores, num1;
            const string MESSAGE = "Por favor ingresar un número de jugadores";
            

            Console.Write("Ingrese un numero entero del 1 al 100 ");
            if (!int.TryParse(Console.ReadLine(), out num1)) 
            do
            {
                Console.WriteLine(MESSAGE);
                Console.Clear();
                Console.Write("Ingrese el primer número: ");
                Random r = new Random();

         
            Console.WriteLine(r.Next(1, 101));

            Console.ReadLine();
        }

    }
}