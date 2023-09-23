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

        int rangoMaximo = CalcularRangoMaximo(cantidadJugadores);
        int numeroAdivinar = GenerarNumeroAleatorio(rangoMaximo);

        int turno = 1;
        int jugadorActual = 1;
        bool Ganaste = false;

        while (!Ganaste)
        
    }
}