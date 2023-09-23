//Desarrollar el juego “Adivina el número” en un programa de C#.
//El juego es muy sencillo, consiste en adivinar  un  número N aleatorio  que  el  sistema  escoge  de  un  determinado  rango  y
//lo guarda  en memoria sin ser revelado.
using System.ComponentModel.Design;

public class JuegoParcial2
{
    static void Main(string[] args)
        
{
        //Declaracion de las variables
      int numeroJugadores, numeroGanador;
      bool proximoIntento = true;

        Console.WriteLine("----------ADIVINA EL NÚMERO----------\n");
        Console.WriteLine("Por favor Ingrese el número de jugadores que van a participar en el juego, teniendo en cuenta que solo podrán jugar entre 2 y 4 jugadores: ");
        numeroJugadores = Convert.ToInt32(Console.ReadLine());
        
        if (numeroJugadores < 2);
        {
            Console.WriteLine("El juego no puede comenzar si no hay al menos 2 jugadores");
        }
        if (numeroJugadores > 4);
        {
         Console.WriteLine("Porfavor, ingresar un número de jugadores en el rango indicado");
        }



    }


}