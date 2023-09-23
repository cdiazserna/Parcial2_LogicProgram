public class JuegoParcial2
{
    static void Main(string[] args)
    {
        Random numOculto = new Random();
        int numJugadores, num_Oculto;

        Console.WriteLine("¡Bienvenido al juego: Adivina el número!\n");
        Console.WriteLine("¿Cuántos jugadores van a participar? (Min: 2; Max: 4)");
        numJugadores = int.Parse(Console.ReadLine());

        if (numJugadores == 2)
        {
            num_Oculto = numOculto.Next(0, 50);
        } else if(numJugadores == 3){

        }
        else
        {

        }


    }
}
