
using System.ComponentModel.Design;

public class JuegoParcial2
{
    static void Main(string[] args)
    {
        int numJugadores,num; // declarar variables
        bool continuar = true;
        string respuesta;

        Random rand1 = new Random(); // Asignar números aleatorios
        Random rand2 = new Random();
        Random rand3 = new Random();

        Console.WriteLine("Ingrese el número de jugadores de 2 a 4: ");
        numJugadores = Convert.ToInt32(Console.ReadLine());

        while (continuar)
        {
            while (numJugadores == 2)
            {
                int numAleatorio1 = rand1.Next(0, 51);

                Console.WriteLine("Ingrese un número");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > numAleatorio1)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (num < numAleatorio1)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    Console.WriteLine("HAS GANADO");
                }
            }
            while (numJugadores == 3)
            {
                int numAleatorio2 = rand2.Next(0, 100);

                Console.WriteLine("Ingrese un número");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > numAleatorio2)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (num < numAleatorio2)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    Console.WriteLine("HAS GANADO");
                }
            }
            while (numJugadores == 4)
            {
                int numAleatorio3 = rand3.Next(0, 200);

                Console.WriteLine("Ingrese un número");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > numAleatorio3)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (num < numAleatorio3)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    Console.WriteLine("HAS GANADO");
                }
            }
            Console.WriteLine(String.Format("Desea jugar de nuevo? (s/n)");
            respuesta = Console.ReadLine();

            if (!respuesta = "s") ;

            continuar = false;
        }
    }
       
            

        