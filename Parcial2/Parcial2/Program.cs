//Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar  un  número ℕaleatorio  que  el  sistema  escoge  de  un  determinado  rango  y lo guarda  en memoriasin ser revelado
public class parial2
{
    static void Main(string[] args)
    {
        int numeroAleatorio;
        int numeroIngresado;
        int numeroJugadores;
        int turno;
        bool ganador;
        string respuesta;

        
        {

            Console.WriteLine("cuantos jugadores van a jugar  (Mínimo 2 y máximo 4)\");\n");

            numeroJugadores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese un numero: ");

                while (numeroJugadores < 2 || numeroJugadores > 4)
                {
                    Console.WriteLine("El número de jugadores debe ser entre 2 y 4. Inténtalo de nuevo.");
                    numeroJugadores = Convert.ToInt32 (Console.ReadLine());

                    
                }












        }
    }
}