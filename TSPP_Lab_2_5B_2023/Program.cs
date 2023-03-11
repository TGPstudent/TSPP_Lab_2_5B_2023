//TSPP_Lab_2_5B_2023 Добуток елементів max та min в рядах масиву, який згенеровано.
using System;

namespace TSPP_Lab_2_5B_2023
{
    class Program
    {
        public static void ArgGenerator(int[,] A, int n, int m)//Генератор елементів масиву
        {
            int min = -100, max = 100;
            Random ri = new Random();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    A[i, j] = ri.Next(min, max);
                }
            }
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("\n Введiть кiлькiсть рядкiв в двовимiрному масивi n=");
            string TN = Console.ReadLine();
            n = int.Parse(TN);
            Console.Write("\n Введiть кiлькiсть стовпцiв в двовимiрному масивi m=");
            string TM = Console.ReadLine();
            m = int.Parse(TM);
            int[,] A = new int[n, m];
            ArgGenerator(A, n, m);
            int[] B = new int[n];
            for (int i = 0; i < n; ++i)
            {
                int max = A[i, 0];
                int min = A[i, 0];
                for (int j = 0; j < m; ++j)
                {
                    if (A[i, j] > max) max = A[i, j];
                    else if (A[i, j] < min) min = A[i, j];
                }
                B[i] = max * min;
            }
            //Виведення результатiв
            Console.Clear();
            Console.WriteLine($"\n Згенеровано масив A[{n}, {m}]:\n");
            for (int i = 0; i < n; ++i)
            {
                Console.Write("\t|");
                for (int j = 0; j < m; ++j)
                {

                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine("\b\b\b\b\b\b |\n");
            }
            Console.Write("\n Отриманий вектор добуткiв max i min елементiв кожного рядка:\n\n\t B[" + $"{n}" + "]={");
            foreach (int elem in B)
                Console.Write($"{elem}" + ", ");
            Console.WriteLine("\b\b}");
            Console.ReadLine();
        }
    }
}