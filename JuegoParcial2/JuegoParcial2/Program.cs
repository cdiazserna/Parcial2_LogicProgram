public class juegoParcial2
{
    static void Main(string[] args)
    {
        //declaracion variables
        int cantidadJugadores, rango1, rango2, rango3, i ,numeroJugador;
        bool salir = true;
        string respuesta = "S";
        Random random = new Random();
        //cantidadJugadores = random.Next(2, 4);
        rango1 = random.Next(0, 50);
        rango2 = random.Next(0, 100);
        rango3 = random.Next(0, 200);

        //proceso
        while(salir)
        {
            Console.Clear();
            Console.WriteLine("Juego adivina el número");
            Console.WriteLine("Ingrese la cantidad de jugadores: ");
            cantidadJugadores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La cantidad de jugadores es: " + cantidadJugadores);
            for(i=1; i<=cantidadJugadores; i++)
            {
                if(cantidadJugadores == 2)
                {

                    Console.WriteLine("Jugador " + i + " adivine el número: " + rango1);
                    numeroJugador = Convert.ToInt32(Console.ReadLine());

                    if (numeroJugador == rango1)
                    {
                        Console.WriteLine("!Ganaste papu¡");
                        salir = true;
                    }
                    else if (numeroJugador < rango1)
                    {
                        Console.WriteLine("El número que escogiste es menor");

                    }

                    else Console.WriteLine("El número que escogiste es mayor");

                }
                else if (cantidadJugadores == 3)
                {
                    Console.WriteLine("Jugador " + i + " adivine el número: " + rango2);
                    numeroJugador = Convert.ToInt32(Console.ReadLine());

                    if (numeroJugador == rango2)
                    {
                        Console.WriteLine("!Ganaste papu¡");
                        salir = true; ;
                    }
                    else if (numeroJugador < rango2)
                    {
                        Console.WriteLine("El número que escogiste es menor");
                    }
                    else Console.WriteLine("El número que escogiste es mayor");
                }
                else
                {
                    Console.WriteLine("Jugador " + i + "adivine el número: " + rango3);
                    numeroJugador = Convert.ToInt32(Console.ReadLine());

                    if (numeroJugador == rango3)
                    {
                        Console.WriteLine("Ganaste papu");
                        salir = true;
                    }
                    else if (numeroJugador < rango2) Console.WriteLine("El número que escogiste es menor");
                    else Console.WriteLine("El número que escogiste es mayor");
                }
                
            }

            Console.WriteLine("Desea hacer otro tirito? S/N: ");
            respuesta = Convert.ToString(Console.ReadLine);
            if (respuesta == "N") salir = false;

        }



    }

}
