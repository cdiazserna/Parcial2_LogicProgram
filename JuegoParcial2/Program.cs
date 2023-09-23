public class JuegoParcial2
{
    static void Main(string[] args)
    {
        Random numAzar = new Random();
        int numJugadores, numOculto;

        Console.WriteLine("¡Bienvenido al juego: Adivina el número!\n");
        Console.WriteLine("¿Cuántos jugadores van a participar? (Min: 2; Max: 4)");
        numJugadores = int.Parse(Console.ReadLine());

        if (numJugadores == 2)
        {
            numOculto = numAzar.Next(0, 50);
        } else if(numJugadores == 3){
            numOculto = numAzar.Next(0, 100);
        }
        else
        {
            numOculto = numAzar.Next(0, 200);
        }

        do
        {

        }
    }
}
