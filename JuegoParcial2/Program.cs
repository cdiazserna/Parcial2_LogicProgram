
using System;

namespace juegoparcial2

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numjugadores, num1;
            const string MESSAGE = "El juego permite maximo 4 jugadores";

            Console.Write("Ingrese el numero de jugadores, maximo 4 ");
            numjugadores = Convert.ToInt32(Console.ReadLine());
            if (numjugadores == 2)
            {
                Random r = new Random();


                Console.WriteLine(r.Next(0, 51));

                Console.ReadLine();
            }
            if (numjugadores == 3)
            {
                Random r = new Random();


                Console.WriteLine(r.Next(0, 101));

                Console.ReadLine();
            }
            else
                (numjugadores == 4)
            {
                Random r = new Random();


                Console.WriteLine(r.Next(0, 201));

                Console.ReadLine();

            }



                Console.Write("Ingrese un numero entero del 1 al 100 ");
            if (!int.TryParse(Console.ReadLine(), out num1))
                
                {
                    Console.WriteLine(MESSAGE);
                    Console.Clear();
                    Console.Write("Ingrese un nùmero ");



                    Random r = new Random();


                    Console.WriteLine(r.Next(1, 101));

                    Console.ReadLine();



                }
            }
    }
}

