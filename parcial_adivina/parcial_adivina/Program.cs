class Program
{
   static void Main()
    {
        int cantJugadores = 0,numeroGanador,numeroEscoger;
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
                        else if (jugadores == 1) {
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
                else if (cantJugadores == 3)
                {
                    int jugadores = 3;
                    numeroGanador = aleatorio.Next(0, 100);
                    while (partidaIniciada)
                    {

                        Console.WriteLine("Numero ganador" + numeroGanador);

                        if (jugadores == 3)
                        {
                            jugadores = 1;
                        }
                        else if (jugadores == 1)
                        {
                            jugadores = 2;
                        }
                        else if (jugadores == 2)
                        {
                            jugadores = 3;
                        }


                        Console.WriteLine($"Por favor dijite un numero jugador {jugadores}");
                        numeroEscoger = Convert.ToInt32(Console.ReadLine());
                        if (numeroEscoger == numeroGanador)
                        {
                            Console.WriteLine($"¡HAS GANADO! jugador {jugadores}");
                            partidaIniciada = false;
                        }
                        else if (numeroEscoger > numeroGanador)
                        {
                            Console.WriteLine("Menor");
                        }
                        else if (numeroEscoger < numeroGanador)
                        {
                            Console.WriteLine("Mayor");
                        }
                    }
                }
                else if (cantJugadores == 4)
                {
                    int jugadores = 4;
                    numeroGanador = aleatorio.Next(0, 200);
                    while (partidaIniciada)
                    {

                        Console.WriteLine("Numero ganador" + numeroGanador);

                        if (jugadores == 4)
                        {
                            jugadores = 1;
                        }
                        else if (jugadores == 1)
                        {
                            jugadores = 2;
                        }
                        else if (jugadores == 2)
                        {
                            jugadores = 3;
                        }
                        else if (jugadores == 3)
                        {
                            jugadores = 4;
                        }


                        Console.WriteLine($"Por favor dijite un numero jugador {jugadores}");
                        numeroEscoger = Convert.ToInt32(Console.ReadLine());
                        if (numeroEscoger == numeroGanador)
                        {
                            Console.WriteLine($"¡HAS GANADO! jugador {jugadores}");
                            partidaIniciada = false;
                        }
                        else if (numeroEscoger > numeroGanador)
                        {
                            Console.WriteLine("Menor");
                        }
                        else if (numeroEscoger < numeroGanador)
                        {
                            Console.WriteLine("Mayor");
                        }
                    }
                }
            }
            else {
                Console.WriteLine("El número de participantes que jugarán debe ser de :" +
                    " mínimo 2 y máximo 4 integrantes.");
                jugarVariable = true;
            }


            Console.WriteLine("Desea seguir Jugando s/n");
            continuarJugando = Console.ReadLine().ToLower();

            if (continuarJugando == "n")
            {
                jugarVariable = false;
            }


        } while (jugarVariable);
    }
}