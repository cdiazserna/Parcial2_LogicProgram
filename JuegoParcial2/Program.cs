/*Juego:Desarrollar el juego “Adivina el número” en un programa de C#. 
  El juego es muy sencillo, consiste en adivinar
  un  número ℕaleatorio  que  el  sistema  escoge  de  un  determinado  
  rango  y lo guarda  en memoriasin ser revelado.*/



public class JuegoParcial2
{

    static void Main(string[] args)

        {
        Console.WriteLine("Adivina el número");
        Console.WriteLine("Ingrese la cantidad de jugadores entre 2 y 4:");

        int cantidadJugadores = ObtenerCantidadJugadores();

        /*int rangoMaximo = CalcularRangoMaximo(cantidadJugadores);*/
        int numeroAdivinar = GenerarNumeroAleatorio(rangoMaximo);

        int turno = 1;
        int jugadorActual = 1;
        bool Ganaste = false;

        while (!Ganaste)
        {
            Console.WriteLine($"\nJugador {jugadorActual}, es tu turno.");
            Console.Write("Elige un numero entre 0 y 50: ");
            int suposicion = Convert.ToInt32(Console.ReadLine());

            if (suposicion == numeroAdivinar)
            {
                Console.WriteLine($"Jugador {jugadorActual}, ganaste");
                Ganaste = true;
            }
            else if (suposicion <= numeroAdivinar)
            {
                Console.WriteLine("Ingresa un numero mayor");
            }
            else
            {
                Console.WriteLine("Ingresa un numero menor");
            }

            jugadorActual = (jugadorActual % cantidadJugadores) + 1;
            turno++;

            if (!Ganaste && turno % cantidadJugadores == 0)
            {
                Console.WriteLine("El numero correcto es"  + numeroAdivinar);
                Console.Write("siguiente ronda, comenzar? (S/N): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToUpper() != "S")
                {
                    break;
                }
                else
                {
                    numeroAdivinar = GenerarNumeroAleatorio(rangoMaximo);
                    turno = 0;
                }
            }
        }

        Console.WriteLine("Se acabo el juego");
    }

    static int ObtenerCantidadJugadores()
    {
        int cantidadJugadores;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out cantidadJugadores) && cantidadJugadores >= 2 && cantidadJugadores <= 4)
            {
                return cantidadJugadores;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido de jugadores entre 2 y 4.");
            }

            if (cantidadJugadores == 2)
            {
                Console.WriteLine(" Elige un numero entre 0 y 50");
            }
            else if (cantidadJugadores == 3)
            {
                Console.WriteLine(" Elige un numero entre 0 y 100");
            }

            else if (cantidadJugadores == 3)
            {
                Console.WriteLine(" Elige un numero entre 0 y 50");
            }
        }
    }

   /* static int CalcularRangoMaximo(int cantidadJugadores)
    {
        if (cantidadJugadores == 2)
        {
            return 50;
        }
        else if (cantidadJugadores == 3)
        {
            return 100;
        }
        else
        {
            return 200;
        }
    }
    */
    static int GenerarNumeroAleatorio(int rangoMaximo)
    {
        Random random = new Random();
        return random.Next(1, rangoMaximo);
    }
}