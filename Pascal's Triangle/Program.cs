using System;
using System.Collections.Generic;

namespace Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> miLista = PascalsTriangle(10);

            foreach (var item in miLista)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
        }
        public static List<int> PascalsTriangle(int fila)
        {
            int posiciones = (int)Math.Pow(fila + 1, 2);
            int[,] miTriangulo = new int[posiciones, posiciones];
            List<int> miLista = new List<int>();

            for (int n = 1; n <= fila; n++)
            {
                for (int m = 1; m <= n; m++)
                {
                    if (m == 1)
                    {
                        miTriangulo[n, m] = 1;
                    }
                    else if (m == n)
                    {
                        miTriangulo[n, m] = 1;
                        break;
                    }
                    else
                    {
                        miTriangulo[n, m] = miTriangulo[n - 1, m] + miTriangulo[n - 1, m - 1];
                    }
                }
            }

            for (int i = 0; i < miTriangulo.GetLength(0); i++)
            {
                for (int j = 0; j < miTriangulo.GetLength(1); j++)
                {
                    if (miTriangulo[i, j] != 0)
                    {
                        miLista.Add(miTriangulo[i, j]);
                    }
                }

            }

            return miLista;
        }

    }
}
