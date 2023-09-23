using System;

namespace JuegoParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables

            double  intento, participantes;
            bool iniciar = true;
            bool empezar = true;
            
            Random numero = new Random();

            Console.WriteLine("______JUEGO ADIVINA EL NÚMERO_______");

            Console.WriteLine("Escribe la cantidad de participantes: ");
            participantes = Convert.ToInt32(Console.ReadLine());

            if (participantes < 1 ^ participantes > 4) ;
            {
                Console.WriteLine("Cantidad de participantes incorrecta, mín.1 y máx. 4");

                empezar = false;

            }
            if (participantes == 1) ;

            numero = numero.Next()
            {

            }


            while (!empezar) ;
            {
                Console.WriteLine("ULTIMA OPORTUNIDAD");
                Console.WriteLine("Escribe la cantidad de participantes: ");
                participantes = Convert.ToInt32(Console.ReadLine());

                if (participantes < 1 ^ participantes > 4) ;
                {
                    Console.WriteLine("Cantidad de participantes incorrecta, mín.1 y máx. 4");

  

                }
                
                
            }
            //while () ;
               {


            }


            
        }
    }
}
