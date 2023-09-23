class Program
{
   static void Main()
    {
        int cantJugadores,numeroGanador,numeroEscoger;
        String continuarJugando;
        bool jugarVariable = true, partidaIniciada = true;
        Random aleatorio = new Random();
        do
        {

            Console.WriteLine("Cantidad de integrantes para jugar es de minimo 2 maximo 4");
            cantJugadores = Convert.ToInt32(Console.ReadLine());

            if (cantJugadores >= 2 && cantJugadores <= 4)
            {

                if (cantJugadores == 2) {
                    int jugadores = 2;
                    numeroGanador = aleatorio.Next(0, 50);
                    while (partidaIniciada) {
                      
                        Console.WriteLine("Numero ganador" + numeroGanador);

                        if (jugadores == 2)
                        {
                            jugadores = 1;
                        }
                        else if(jugadores == 1){
                            jugadores = 2;
                        }

                       
                        Console.WriteLine($"Por favor dijite un numero jugador {jugadores}");
                        numeroEscoger = Convert.ToInt32(Console.ReadLine());
                        if (numeroEscoger == numeroGanador) {
                            Console.WriteLine($"¡HAS GANADO! jugador {jugadores}");
                            partidaIniciada = false;
                        } else if (numeroEscoger > numeroGanador) {
                            Console.WriteLine("Menor");
                        }
                        else if (numeroEscoger < numeroGanador)
                        {
                            Console.WriteLine("Mayor");
                        }
                    }
                }
                Console.WriteLine("Desea seguir Jugando s/n");
                continuarJugando = Console.ReadLine().ToLower();

                if (continuarJugando == "s")
                {
                 
                }
                else
                {
                    jugarVariable = false;
                }
            }
            else {
                Console.WriteLine("El número de participantes que jugarán debe ser de :" +
                    " mínimo 2 y máximo 4 integrantes.");
                jugarVariable = true;
            }

            } while (jugarVariable);
    }
}