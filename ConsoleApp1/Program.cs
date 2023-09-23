
using System.ComponentModel.Design;

public class JuegoParcial2
{
    static void Main(string[] args)
    {
        int numJugadores; // declarar variables

        Random rand1 = new Random(); // Asignar números aleatorios
        Random rand2 = new Random();
        Random rand3 = new Random();

        rand1.Next(0, 51);

        Console.WriteLine("Ingrese el número de jugadores de 2 a 4: ");

        if (numJugadores == 2)
        {

        }
        else if (numJugadores == 3)
        {
            rand2.Next(0, 100);
        }
        else if (numJugadores == 4)
        {
            rand3.Next(0, 200);
        }
    }
       
            

        