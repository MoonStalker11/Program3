using System;

namespace ClaseEntero
{
    public class Cadena
    {
        public string Cad;

        public Cadena()
        {
            Cad = "";
        }

        public Cadena(string myCadena)
        {
            Cad = myCadena ?? "";
        }

        // Método para contar el número de vocales en una palabra
        public int ContarVocales()
        {
            // Verificar si la cadena es nula o vacía
            if (string.IsNullOrEmpty(Cad))
            {
                Console.WriteLine("Error: La cadena está vacía o nula.");
                return 0;
            }

            int contadorVocales = 0;
            foreach (char letra in Cad.ToLower())
            {
                if ("aeiou".Contains(letra))
                {
                    contadorVocales++;
                }
            }
            return contadorVocales;
        }


        public int ContarPalabras()
        {
            string[] palabras = Cad.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}
