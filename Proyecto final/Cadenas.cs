using System;

namespace Practico
{
    public class Cadenas
    {
        public void ejercicio1(string cadena)
        {
            // Inicializamos el contador de palabras en 0
            int contador = 0;

            // Iteramos a través de la cadena
            // Incrementamos el contador cada vez que encontramos un espacio en blanco
            // ya que asumimos que las palabras están separadas por espacios
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    contador++;
                }
            }

            // Añadimos 1 al contador para incluir la última palabra si la cadena no termina con un espacio
            contador++;

            // Mostramos la cantidad de palabras encontradas en la consola
            Console.WriteLine("Número de palabras encontradas: " + contador);
        }

        public void ejercicio2(string cadena)
        {
            // Inicializamos una variable para almacenar la cadena sin vocales
            string cadenaSinVocales = "";

            // Iteramos a través de cada carácter en la cadena
            foreach (char caracter in cadena)
            {
                // Verificamos si el carácter actual no es una vocal
                if (!EsVocal(caracter))
                {
                    // Si no es una vocal, lo agregamos a la cadena sin vocales
                    cadenaSinVocales += caracter;
                }
            }

            // Mostramos la cadena sin vocales en la consola
            Console.WriteLine("Cadena sin vocales: " + cadenaSinVocales);
        }

        // Función para verificar si un carácter es una vocal
        private bool EsVocal(char caracter)
        {
            // Convertimos el carácter a minúscula para simplificar las comparaciones
            char c = char.ToLower(caracter);

            // Verificamos si el carácter es una vocal
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        public void ejercicio3(string cadena)
        {
            // Dividimos la cadena en palabras usando el espacio como delimitador
            string[] palabras = cadena.Split(' ');

            // Inicializamos la variable para almacenar la palabra más larga
            string palabraMasLarga = "";

            // Iteramos a través de todas las palabras en la cadena
            foreach (string palabra in palabras)
            {
                // Si la longitud de la palabra actual es mayor que la longitud de la palabra más larga registrada,
                // actualizamos la variable de la palabra más larga
                if (palabra.Length > palabraMasLarga.Length)
                {
                    palabraMasLarga = palabra;
                }
            }

            // Mostramos la palabra más larga en la consola
            Console.WriteLine("Palabra más larga: " + palabraMasLarga);
        }

        public void ejercicio4(string cadena)
        {
            // Dividimos la cadena en palabras usando el espacio como delimitador
            string[] palabras = cadena.Split(' ');

            // Inicializamos una variable para almacenar la cadena modificada
            string cadenaModificada = "";

            // Iteramos a través de cada palabra en la cadena
            foreach (string palabra in palabras)
            {
                // Si la longitud de la palabra es mayor que 1, eliminamos el primer carácter
                if (palabra.Length > 1)
                {
                    cadenaModificada += palabra.Substring(1) + " ";
                }
            }

            // Mostramos la cadena modificada en la consola
            Console.WriteLine("Cadena modificada: " + cadenaModificada.Trim());
        }

        public void ejercicio5(string cadena)
        {
            // Dividimos la cadena en palabras usando el espacio como delimitador
            string[] palabras = cadena.Split(' ');

            // Inicializamos una variable para almacenar la cadena invertida
            string cadenaInvertida = "";

            // Iteramos a través de cada palabra en la cadena
            foreach (string palabra in palabras)
            {
                // Invertimos la palabra actual y la agregamos a la cadena invertida
                cadenaInvertida += new string(palabra.Reverse().ToArray()) + " ";
            }

            // Mostramos la cadena invertida en la consola
            Console.WriteLine("Cadena invertida: " + cadenaInvertida);
        }






















    }
}