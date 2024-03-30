using System;

namespace Practico
{
    public class Series
    {
        public void Fibonacci(int posicion)
        {
            if (posicion <= 0)
            {
                Console.WriteLine("La posición debe ser un número entero positivo mayor que cero.");
                return;
            }

            int a = 0;
            int b = 1;
            int resultado = 0;

            if (posicion == 1)
                resultado = a;
            else if (posicion == 2)
                resultado = b;
            else
            {
                for (int i = 3; i <= posicion; i++)
                {
                    resultado = a + b;
                    a = b;
                    b = resultado;
                }
            }
            Console.WriteLine("Posicion " + posicion + " => " + resultado + " de la serie Fibonacci");
        }

//-----------------------------------------------------------------------------------------------------------------------------
        public void GenerarSerie1(int cantidadTerminos, int enesimoTermino)
        {
            if (cantidadTerminos <= 0)
            {
                Console.WriteLine("La cantidad de términos debe ser un número entero positivo mayor que cero.");
                return;
            }

            Console.Write("Serie generada: ");
            int numero = 1;
            int enesimo = 0;
            for (int i = 1; i <= cantidadTerminos; i++)
            {
                Console.Write(numero + " ");

                if (i == enesimoTermino)
                    enesimo = numero;

                if (i % 2 == 0)
                    numero++;
                else
                    numero *= 2;
            }
            Console.WriteLine();

            Console.WriteLine($"El enésimo término solicitado (en la posición {enesimoTermino}) es: {enesimo}");
        }

//-----------------------------------------------------------------------------------------------------------------------------
        public void GenerarSumar(int cantidadTerminos, int cantidadSumar)
        {
            if (cantidadTerminos <= 0 || cantidadSumar <= 0)
            {
                Console.WriteLine("La cantidad de términos y la cantidad a sumar deben ser números enteros positivos mayores que cero.");
                return;
            }

            Console.Write("Serie generada: ");
            int numero = 0;
            int suma = 0;
            for (int i = 1; i <= cantidadTerminos; i++)
            {
                Console.Write(numero + " ");
                if (i <= cantidadSumar)
                    suma += numero;
                numero += 2; // Sumamos 2 para obtener el siguiente número par
            }
            Console.WriteLine();

            Console.WriteLine($"La suma de los primeros {cantidadSumar} términos de la serie es: {suma}");
        }



        
        





    }
}