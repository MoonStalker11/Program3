using System;

namespace Practico
{
    public class Vectores
    {
        public void ejercicio1(params int[] numeros)
        {
            // Inicializamos un contador para los números pares
            int contadorPares = 0;

            // Iteramos a través de cada número dado
            foreach (int numero in numeros)
            {
                // Verificamos si el número es par
                if (EsPar(numero))
                {
                    // Si es par, incrementamos el contador
                    contadorPares++;
                }
            }

            // Mostramos la cantidad de números pares en la consola
            Console.WriteLine("Cantidad de numeros pares => " + contadorPares);
        }

        // Función para verificar si un número es par
        private bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

//-----------------------------------------------------------------------------------

        public void ejercicio2(params int[] arr)
        {
            int[] sortedArray = MergeSort(arr);
            Console.WriteLine("Vector ordenado MergeSort:");
            MostrarVector1(sortedArray);
        }

        private int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int[] left = new int[arr.Length / 2];
            int[] right = new int[arr.Length - left.Length];

            Array.Copy(arr, 0, left, 0, left.Length);
            Array.Copy(arr, left.Length, right, 0, right.Length);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result[resultIndex++] = left[leftIndex++];
                }
                else
                {
                    result[resultIndex++] = right[rightIndex++];
                }
            }

            while (leftIndex < left.Length)
            {
                result[resultIndex++] = left[leftIndex++];
            }

            while (rightIndex < right.Length)
            {
                result[resultIndex++] = right[rightIndex++];
            }

            return result;
        }

        private void MostrarVector1(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

//-----------------------------------------------------------------------------------
        public void ejercicio3(params int[] arr)
        {
            int[] sortedArray = InsertionSort(arr);
            Console.WriteLine("Vector ordenado InsertionSort:");
            MostrarVector2(sortedArray);
        }

        private int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        private void MostrarVector2(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

//-----------------------------------------------------------------------------------

        public void ejercicio4(params int[] arr)
        {
            Console.WriteLine("Vector original:");
            MostrarVector3(arr);

            Console.Write("Posición a eliminar (de derecha a izquierda): ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            int[] resultado = EliminarElemento(arr, posicion);

            Console.WriteLine("Vector sin el elemento en la posición " + posicion + ":");
            MostrarVector3(resultado);
        }

        private int[] EliminarElemento(int[] arr, int posicion)
        {
            int[] resultado = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - posicion) // excluimos el elemento en la posición indicada
                {
                    resultado[j++] = arr[i];
                }
            }
            return resultado;
        }

        private void MostrarVector3(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

//-----------------------------------------------------------------------------------

        public void ejercicio5(params int[] arr)
        {
            Console.WriteLine("Vector original:");
            MostrarVector4(arr);

            Console.Write("Invertir v: ");
            string[] valores = Console.ReadLine().Split(',');
            int x = int.Parse(valores[0].Trim());
            int y = int.Parse(valores[1].Trim());

            int[] resultado = InvertirParte(arr, x, y);

            Console.WriteLine("Vector con parte invertida desde la posición " + x + " hasta la posición " + y + ":");
            MostrarVector4(resultado);
        }

        private int[] InvertirParte(int[] arr, int x, int y)
        {
            if (x < 0 || x >= arr.Length || y < 0 || y >= arr.Length || x >= y)
            {
                Console.WriteLine("Posiciones no válidas.");
                return arr;
            }

            int[] resultado = new int[arr.Length];
            Array.Copy(arr, resultado, arr.Length);

            while (x < y)
            {
                int temp = resultado[x];
                resultado[x] = resultado[y];
                resultado[y] = temp;
                x++;
                y--;
            }

            return resultado;
        }

        private void MostrarVector4(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }























    }
}