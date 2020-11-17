using System;

namespace AppMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3] { { 5, -3, 10 }, { 15, 8, 2 }, { 7, 9, -4 } };

            int negativo = 0;
            string diagonalPrincipal = "";

            Console.WriteLine("Diagonal:");
            for (int x = 0; x < 3; x++)
            {
                Console.Write(mat[x, x] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j)
                        diagonalPrincipal += mat[i, j] + " ";
                    
                    if (mat[i, j] < 0)
                        negativo++;
                }
            }

            Console.WriteLine("Diagonal: " + diagonalPrincipal);
            Console.WriteLine("Negativos: " + negativo);
            Console.ReadKey();
        }
    }
}
