namespace JuegoParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en 
             adivinar  un  número N aleatorio  que  el  sistema  escoge  de  un  determinado  rango  y lo guarda  en
             memoria sin ser revelado.

            El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y 
            máximo 4 integrantes. Dependiendo de la cantidad de jugadores, el número ℕaleatorio se generará en los
            siguientes rangos.
            - Si participan 2 jugadores, el número N aleatorio se generará entre 0 y 50
            - Si participan 3 jugadores, el número N aleatorio se generará entre 0 y 100
            - Si participan 4 jugadores, el número N aleatorio se generará entre 0 y 200

            Cada jugador comenzará su turno intentando adivinar ese número N aleatorio.El programa deberá mostrarle
            al jugador la siguiente información:
            - Si  el  número  ingresado  es  mayor  al  número  aleatorio,  entonces  mostrar  por  pantalla  la
            palabra “MENOR” y darle la oportunidad al siguiente jugador.
            - Si  el  número  ingresado  es menor al  número  aleatorio,  entonces  mostrar  por  pantalla  la 
            palabra “MAYOR” y darle la oportunidad al siguiente jugador.
            - Si  el  número  ingresado  coincide  con  el  número  aleatorio, entonces  mostrar  por pantalla  la 
            palabra “¡HAS GANADO!”. Aquí ya finaliza el juego.

            El programa deberá estar en capacidad de pedir a los jugadores si desean un nuevo “tirito” para
            volver a jugar y borrar consola, de lo contrario, finalizar el programa. */

            bool jugarOtraVez = true;

            while (jugarOtraVez)
            {
                Console.WriteLine("Bienvenido a Adivina el número");

                // Paso 1: Solicitar al usuario la cantidad de jugadores
                Console.Write("Ingrese la cantidad de jugadores (entre 2 y 4): ");
                int numJugadores = int.Parse(Console.ReadLine());

                if (numJugadores < 2 || numJugadores > 4)
                {
                    Console.WriteLine("Número de jugadores no válido. Debe ser entre 2 y 4.");
                    continue;
                }

                int numeroSecreto;
                int rangoMaximo;

                // Paso 2: Determinar el rango según la cantidad de jugadores
                if (numJugadores == 2)
                {
                    rangoMaximo = 50;
                }






            } 

















        }
    }
}




























