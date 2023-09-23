//Desarrollar el juego “Adivina el número” en un programa de C#.
//El juego es muy sencillo, consiste en adivinar  un  número N aleatorio  que  el  sistema  escoge  de  un  determinado  rango  y
//lo guarda  en memoria sin ser revelado.
using System.ComponentModel.Design;

public class JuegoParcial2
{
    static void Main(string[] args)
        
{
        Random numeroGenerado = new Random();
        //Declaracion de las variables
      int numeroJugadores, numeroGanador;
      bool proximoIntento = true;

        Console.WriteLine("----------ADIVINA EL NÚMERO----------\n");
        Console.WriteLine("Por favor Ingrese el número de jugadores que van a participar en el juego. Tenga en cuenta que solo podrán jugar entre 2 y 4 jugadores: ");
        numeroJugadores = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= 200; i++)

        if (numeroJugadores < 2 && numeroJugadores > 4 );
        {
            Console.WriteLine("Porfavor, ingresar un número de jugadores en el rango indicado");
        }
        if (numeroJugadores == 2)
        {
            numeroGenerado.Next(0, 50);
            Console.WriteLine("Jugador 1: Ingrese su número:");
            Console.WriteLine("Jugador 2: Ingrese su número: ");
        }
        else if (numeroJugadores == 3)
        {
            numeroGenerado.Next(0, 100);
            Console.WriteLine("Jugador 1: Ingrese su número:");
            Console.WriteLine("Jugador 2: Ingrese su número: ");
            Console.WriteLine("Jugador 3: Ingrese su número: ");
        }
        else if (numeroJugadores == 4)
        {
           numeroGenerado.Next(0, 200);
            Console.WriteLine("Jugador 1: Ingrese su número:");
            Console.WriteLine("Jugador 2: Ingrese su número: ");
            Console.WriteLine("Jugador 3: Ingrese su número: ");
            Console.WriteLine("Jugador 4: Ingrese su número: ");
        }







    }


}