public class juegoParcial2
{
    static void Main(string[] args)
    {
        //declaracion variables
        int cantidadJugadores, rango1, rango2, rango3, i ;
        bool salir = true;
        Random random = new Random();
        cantidadJugadores = random.Next(2, 4);
        rango1 = random.Next(0, 50);
        rango2 = random.Next(0, 100);
        rango3 = random.Next(0, 200);

        //proceso
        while(salir)
        {
            for(i=1; i<=cantidadJugadores; i++)
            {
                if(cantidadJugadores == 2)
                {


                }
                else if (cantidadJugadores == 3)
                {

                }
                else
                {

                }
                    
            }

        }



    }

}
