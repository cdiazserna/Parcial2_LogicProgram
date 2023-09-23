using System;

namespace JuegoParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables

            int intento, participantes, aleatorio;
            bool iniciar = true;
            bool empezar = true;

            Random numero = new Random();

            Console.WriteLine("______JUEGO ADIVINA EL NÚMERO_______");

            while (empezar == false)
            {

                Console.WriteLine("Escribe la cantidad de participantes: ");
                participantes = Convert.ToInt32(Console.ReadLine());

                if (participantes > 5) 
                { 

               Console.WriteLine("Cantidad de participantes incorrecta, mín.2 y máx. 4");

                    empezar = false;
                }
                if (participantes == 2)
                {
                    aleatorio = numero.Next(0, 50);
                }
                if (participantes == 3)
                {
                    aleatorio = numero.Next(0, 100);
                }
                if (participantes == 4)
                {
                    aleatorio = numero.Next(0, 200);
                }
                
                
                Console.WriteLine("Escribe el número correcto");
                intento = Convert.ToInt32(Console.ReadLine());

                if ( aleatorio == intento)
                {
                    Console.WriteLine("Ganaste");
                }
            }

            
          

            

            




            {


            }


            
        }
    }
}
