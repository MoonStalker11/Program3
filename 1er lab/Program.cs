using System;

namespace ClaseEntero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ejercicio 1: Rotar un dígito del número ingresado por teclado
            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine("Ingrese un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Entero entero = new Entero(numero);
            int nuevoNumero = entero.RotarUltimoDigito();
            Console.WriteLine("Número rotado: " + nuevoNumero);

            // Ejercicio 2: Verificar si todos los dígitos de un número ingresado por teclado están ordenados ascendentemente
            Console.WriteLine("\nEjercicio 2:");
            Console.WriteLine("Ingrese un número entero:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de dígitos a comparar:");
            int nd = Convert.ToInt32(Console.ReadLine());
            bool ascendente = entero.DigitsAscendentes(nd);
            Console.WriteLine("Los dígitos están ordenados ascendentemente: " + ascendente);

            // Ejercicio 3: Verificar cuántas vocales tiene una palabra ingresada por teclado
            Console.WriteLine("\nEjercicio 3:");
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            Cadena cadena = new Cadena(palabra);
            int contadorVocales = cadena.ContarVocales();
            Console.WriteLine("La palabra tiene " + contadorVocales + " vocales.");

            // Ejercicio 4: Contar cuántas palabras tiene una oración ingresada por teclado
            Console.WriteLine("\nEjercicio 4:");
            Console.WriteLine("Ingrese una oración:");
            string oracion = Console.ReadLine();
            cadena = new Cadena(oracion);
            int contadorPalabras = cadena.ContarPalabras();
            Console.WriteLine("La oración tiene " + contadorPalabras + " palabras.");
        }
    }
}

