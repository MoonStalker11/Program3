using System;

namespace ClaseEntero
{
    public class Entero
    {
        public int N;

        public Entero()
        {
            N = 0;
        }

        public Entero(int num)
        {
            N = num;
        }

        public int RotarUltimoDigito()
        {
            int ultimoDigito = N % 10;
            int longitudNumero = (int)Math.Floor(Math.Log10(N) + 1);
            int nuevoNumero = (int)(ultimoDigito * Math.Pow(10, longitudNumero - 1) + N / 10);
            return nuevoNumero;
        }

        public bool DigitsAscendentes(int nd)
        {
            // Convertir el número a cadena para facilitar su manipulación
            string numeroString = N.ToString();

            // Si la cantidad de dígitos a comparar es mayor que la longitud del número, no están ordenados
            if (nd > numeroString.Length)
                return false;

            // Iterar sobre los dígitos del número para verificar su orden
            for (int i = 0; i < numeroString.Length - nd; i++)
            {
                // Convertir el conjunto de dígitos a verificar a un número entero
                int subNumero = int.Parse(numeroString.Substring(i, nd));

                // Verificar si los dígitos no están en orden ascendente
                if (!DigitosEnOrdenAscendente(subNumero))
                    return false;
            }

            // Si todos los conjuntos de dígitos están ordenados ascendentemente, retorna verdadero
            return true;
        }

        // Método auxiliar para verificar si los dígitos de un número están ordenados ascendentemente
        private bool DigitosEnOrdenAscendente(int num)
        {
            // Convertir el número a cadena para facilitar su manipulación
            string numString = num.ToString();

            // Iterar sobre los dígitos del número para verificar su orden
            for (int i = 0; i < numString.Length - 1; i++)
            {
                // Verificar si el dígito actual es mayor que el siguiente
                if (numString[i] > numString[i + 1])
                    return false;
            }

            // Si todos los dígitos están en orden ascendente, retorna verdadero
            return true;
        }
    }
}
