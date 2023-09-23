using System;

namespace JuegoParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creación de un juego
            // declaración de variables
            int numeroJugadores, numeroEscogido, numeroAleatorio, jugador = 1;
            String jugarDeNuevo;
            bool volverJugar = true;

            Random numeroRandom = new Random();
            
            
            do {

                Console.Clear();

                //Proceso del juego

                //Pedimos el número de jugadores

                Console.WriteLine("Bienvenidos al juego de adivinar el número");
                Console.WriteLine("Ingrese el número de jugadores que desean jugar\n" +
                    "mínimo deben de ser 2 jugadores y máximo 4");

                numeroJugadores = Convert.ToInt32(Console.ReadLine());

                numeroAleatorio = numeroRandom.Next(0, 200);

                if (numeroJugadores == 2)
                {

                    numeroAleatorio = numeroRandom.Next(0, 50);

                } else if (numeroJugadores == 3) {

                    numeroAleatorio = numeroRandom.Next(0, 100);

                } else if (numeroJugadores == 4) {

                    numeroAleatorio = numeroRandom.Next(0, 200);

                } else {

                    Console.WriteLine("Ingreso un número de jugadores no aceptado");

                }


                Console.WriteLine("La maquina ha escogido el número");

                for (int i = 1; i <= numeroJugadores; i++)
                {

                    Console.WriteLine($"Jugador numero {jugador} ingrese su número");
                    jugador++;
                    numeroEscogido = Convert.ToInt32(Console.ReadLine());

                    if (numeroEscogido < numeroAleatorio)
                    {

                        Console.WriteLine("ES MAYOR");

                    } else if (numeroEscogido > numeroAleatorio) {

                        Console.WriteLine("ES MENOR");

                    }
                    else
                    {
                        Console.WriteLine("¡HAS GANADO!");

                    }



                }

                Console.WriteLine("¿Desea seguir jugando? (S/N)");
                jugarDeNuevo = Convert.ToString(Console.ReadLine());

                if (jugarDeNuevo != "S")
                {
                    volverJugar = false;
                }

                

            } while (volverJugar =  true);


        }
    }
}
