public class JuegoParcial2
{
    static void Main(string[] args)
    {
        Random numAzar = new Random();
        int numJugadores, numOculto;
        int numJugador1, numJugador2, numJugador3, numJugador4;

        Console.WriteLine("¡Bienvenido al juego: Adivina el número!\n");
        Console.WriteLine("¿Cuántos jugadores van a participar? (Min: 2; Max: 4)");
        numJugadores = int.Parse(Console.ReadLine());

        if (numJugadores == 2)
        {
            
            numOculto = numAzar.Next(0, 50);

            do
            {
                Console.WriteLine("¡Que comience el juego!");
                Console.WriteLine("Solo ingrese números del 0 al 50.\n");
                Console.WriteLine("Jugador 1, ingrese su número: ");
                numJugador1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Jugador 2, ingrese su número: ");
                numJugador2 = int.Parse(Console.ReadLine());

                if(numJugador1 == numOculto || numJugador2 == numOculto)
                {

                    if (numJugador1 == numOculto)
                    {
                        Console.WriteLine("¡Tenemos un ganador! ¡Felicidades Jugador 1!");
                        Console.WriteLine($"El número que ingresaste es: {numJugador1} y el número oculto es: {numOculto}.");
                    } else if(numJugador2 == numOculto)
                    {
                        Console.WriteLine("¡Tenemos un ganador! ¡Felicidades Jugador 2!");
                        Console.WriteLine($"El número que ingresaste es: {numJugador2} y el número oculto es: {numOculto}.");
                    }else if(numJugador1 == numOculto && numJugador2 == numOculto)
                    {
                        Console.WriteLine("¡Ambos adivinaron! ¡Felicidades!");
                        Console.WriteLine($"El número oculto es: {numOculto}.");
                    }
                    
                }
            } while (numJugador1 >= 0 && numJugador1 <= 50 && numJugador2 >= 0 && numJugador2 <=50);

        } else if(numJugadores == 3){
            numOculto = numAzar.Next(0, 100);
        }
        else
        {
            numOculto = numAzar.Next(0, 200);
        }
      
    }
}
