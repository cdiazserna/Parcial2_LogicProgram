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
                Console.WriteLine("Bienvenido a ¡Adivina el número!");

                // Paso 1: Solicitar al usuario la cantidad de jugadores
                Console.Write("Ingrese la cantidad de jugadores, minimo 2 y maximo 4): ");
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
                else if (numJugadores == 3)
                {
                    rangoMaximo = 100;
                }
                else
                {
                    rangoMaximo = 200;
                }
                // Paso 3: Generar un número aleatorio dentro del rango
                Random random = new Random();
                numeroSecreto = random.Next(0, rangoMaximo + 1);

                bool haGanado = false;
                int intentos = 0;

                Console.WriteLine($"Se ha generado un número entre 0 y {rangoMaximo}. ¡Adivina el número!");

                // Paso 4: Iniciar el juego
                while (!haGanado)
                {
                    for (int jugador = 1; jugador <= numJugadores; jugador++)
                    {
                        // Paso 5: Solicitar al jugador su intento
                        Console.Write($"Jugador {jugador}, ingrese su número: ");
                        int intento = int.Parse(Console.ReadLine());
                        intentos++;

                        // Paso 6: Comparar el intento con el número secreto
                        if (intento == numeroSecreto)
                        {
                            Console.WriteLine($"¡Felicitaciones, Jugador {jugador}! ¡HA GANADO en {intentos} intentos!");
                            haGanado = true;
                            break;
                        }

                        else if (intento < numeroSecreto)
                        {
                            Console.WriteLine("MAYOR");
                        }
                        else
                        {
                            Console.WriteLine("MENOR");
                        }
                    }

                    // Paso 7: Verificar si ningún jugador ha adivinado y continuar el juego
                    if (!haGanado)
                    {
                        Console.WriteLine("Ningún jugador ha adivinado el número. Continúa el juego.");
                    }
                }

                // Paso 8: Preguntar a los jugadores si desean jugar otra vez
                Console.Write("¿Desean jugar otra vez? (S/N): ");
                string respuesta = Console.ReadLine();
                jugarOtraVez = respuesta.ToUpper() == "S";

                // Paso 9: Borrar la consola para un nuevo juego
                Console.Clear();
            }
            // Paso 10: Finalizar el programa
            Console.WriteLine("¡Gracias por jugar espero que lo haya disfrutado!");

        }
    }
}




























