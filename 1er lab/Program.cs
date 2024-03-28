using System;

namespace ClaseEntero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño de la matriz (filas columnas):");
            string[] tamanoInput = Console.ReadLine().Split(' ');

            int filas = int.Parse(tamanoInput[0]);
            int columnas = int.Parse(tamanoInput[1]);

            int[,] matrizGenerada = GenerarMatrizPatron(filas, columnas);

            MostrarMatriz(matrizGenerada);
        }

        static int[,] GenerarMatrizPatron(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = (i + 1) * (j + 1);
                }
            }

            return matriz;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

