﻿
using System.ComponentModel.Design;

public class JuegoParcial2
{
    static void Main(string[] args)
    {
        int numJugadores,num; // declarar variables

        Random rand1 = new Random(); // Asignar números aleatorios
        Random rand2 = new Random();
        Random rand3 = new Random();

        Console.WriteLine("Ingrese el número de jugadores de 2 a 4: ");
        numJugadores = Convert.ToInt32(Console.ReadLine());

        if (numJugadores == 2)
        {
            rand1.Next(0, 51);

            Console.WriteLine("Ingrese un número");
            num = Convert.ToInt32(Console.ReadLine());
           
            if (num > rand1)
            {
                Console.WriteLine("El número es menor");
            } 
            else if (num < rand1)
            {
                Console.WriteLine("El número es mayor");
            }
            else
            {
                Console.WriteLine("HAS GANADO");
            }
        }
        else if (numJugadores == 3)
        {
            rand2.Next(0, 100);

            Console.WriteLine("Ingrese un número");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > rand2)
            {
                Console.WriteLine("El número es menor");
            }
            else if (num < rand2)
            {
                Console.WriteLine("El número es mayor");
            }
            else
            {
                Console.WriteLine("HAS GANADO");
            }
        }
        else if (numJugadores == 4)
        {
            rand3.Next(0, 200);

            Console.WriteLine("Ingrese un número");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > rand3)
            {
                Console.WriteLine("El número es menor");
            }
            else if (num < rand3)
            {
                Console.WriteLine("El número es mayor");
            }
            else
            {
                Console.WriteLine("HAS GANADO");
            }
        }
    }
       
            

        