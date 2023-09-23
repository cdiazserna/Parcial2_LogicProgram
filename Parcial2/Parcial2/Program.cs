namespace Parcial2;

public class Punto1Parcial2

{
    static void Main(string[] args)


    {
        Random random = new Random();


        //Declaro variables
        int cantidadParticipantes, numeroAleatorio = 0, numero, contador = 1;
        string respuesta;
        bool repetir = true;
        do
        {
            Console.Clear();
            Console.WriteLine("ADIVINA EL NÚMERO\n*Juego entre 2 a 4 participantes*\n");
            do
            {
                Console.WriteLine("¿Cuántas personas participarán en el juego actual?\n*Participantes permitidos entre 2 y 4 personas*");
                cantidadParticipantes = Convert.ToInt32(Console.ReadLine());

                if (cantidadParticipantes == 2)
                {
                    numeroAleatorio = random.Next(0, 50);
                }
                else if (cantidadParticipantes == 3)
                {
                    numeroAleatorio = random.Next(0, 100);
                }
                else if (cantidadParticipantes == 4)
                {
                    numeroAleatorio = random.Next(0, 200);
                }
                else
                {
                    Console.WriteLine("\nRecuerda que el mínimo de jugadores es 2 y el máximo son 4");
                }
            } while (cantidadParticipantes >= 5 || cantidadParticipantes <= 1);
            

            do
            {
                if (contador > 4)
                {
                    contador = 1;
                }
                    Console.WriteLine($"\nJugador {contador}, ¿Cuál crees es el número?");
                    numero = Convert.ToInt32(Console.ReadLine());


                    if (numero > numeroAleatorio)
                    {
                        Console.WriteLine("MENOR\n");
                    }
                    else if (numero < numeroAleatorio)
                    {
                        Console.WriteLine("MAYOR\n");
                    }
                    else
                    {
                        Console.WriteLine("¡HAS GANADO!\n");
                    }
                    contador++;
                                                                              
               
            }
            while (numero != numeroAleatorio);

            Console.WriteLine("Fin del juego, ¿Desea continuar?\nSi/No");
            respuesta = Console.ReadLine();
            if (respuesta == "No")
            {
                repetir = false;
            }
            else if (respuesta == "Si")
            {
                repetir = true;
            }
            else
            {
                repetir = false;
            }
        }
        while (repetir == true);

       
    }
}
        