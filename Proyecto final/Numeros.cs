using System;

namespace Practico
{
    public class Numeros
    {
        public void ejercicio1(int numero)
        {
            int mayor = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito > mayor)
                {
                    mayor = digito;
                }
                numero /= 10;
            }
            Console.WriteLine("El mayor dígito es: " + mayor);
        }

        public void ejercicio2(int numero)
        {
            int suma = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito % 2 == 0)
                {
                    suma += digito;
                }
                numero /= 10;
            }
            Console.WriteLine("La suma de los dígitos pares de " + suma);
        }

        public void ejercicio3(int numero)
        {
            int max = 0;
            int temp = numero;
            int pos = 0;
            int newNumber = 0;

            // Encontrar el mayor dígito
            while (temp > 0)
            {
                int digito = temp % 10;
                if (digito > max)
                {
                    max = digito;
                }
                temp /= 10;
            }

            // Recorrer el número para llevar el mayor dígito al final
            temp = numero;
            while (temp > 0)
            {
                int digito = temp % 10;
                if (digito != max)
                {
                    newNumber += digito * (int)Math.Pow(10, pos);
                    pos++;
                }
                temp /= 10;
            }

            newNumber = newNumber * 10 + max;
            Console.WriteLine("Número modificado: " + newNumber);
        }

        public void ejercicio4(int numero)
        {
            int previo = 10; // Inicializar previo con un valor mayor que cualquier dígito
            bool ordenado = true;
            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito > previo)
                {
                    ordenado = false;
                    break;
                }
                previo = digito;
                numero /= 10;
            }
            if (ordenado)
            {
                Console.WriteLine("El número está ordenado TRUE.");
            }
            else
            {
                Console.WriteLine("El número no está ordenado FALSE.");
            }
        }

        public void ejercicio5(int numero)
        {
            int imparesAntesDePar = 0;
            bool encontradoPar = false;
            
            while (numero > 0)
            {
                int digito = numero % 10;
                
                if (digito % 2 != 0 && !encontradoPar)
                {
                    imparesAntesDePar++;
                }
                else if (digito % 2 == 0)
                {
                    encontradoPar = true;
                }
                
                numero /= 10;
            }
            
            Console.WriteLine("Cantidad de dígitos impares antes de uno par: " + imparesAntesDePar);
        }
        
    }

}