using System;

namespace HW3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Написать программу, выводящую элементы двумерного массива по диагонали.");

            Console.WriteLine("Введите размер матрицы(от двух до девяти)");

            var n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            string diagonal1 = "";
            string currentNumb = "";
            string currentNumbReverse = "";
            string diagonal3 = "";

            for (int i = 0; i < matrix.GetLength(0); i++)

            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    int small = rnd.Next(1, 10);
                    matrix[i, j] = (small);
                    System.Console.Write($"{matrix[i, j]} ");
                    if (i == j)//ПЕРВАЯ ДИАГОНАЛЬ
                    {
                        currentNumb = matrix[i, j].ToString();
                        diagonal1 += currentNumb;
                        //continue;
                    }
                    if (j == (matrix.GetLength(1) - (i + 1)))
                    {
                        currentNumbReverse = matrix[i, j].ToString();
                        diagonal3 += currentNumbReverse;

                    }



                }

                System.Console.WriteLine();

            }
            long diagonal2 = 0;
            long diagonal4 = 0;
            Console.WriteLine();
            Console.WriteLine($"Первая диагональ:{diagonal1}");
            int toReverse = Convert.ToInt32(diagonal1);
            while (toReverse != 0)
            {
                int temp = toReverse % 10;
                diagonal2 = diagonal2 * 10 + temp;
                toReverse /= 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Вторая диагональ:{diagonal2}");
            Console.WriteLine();
            Console.WriteLine($"Третья диагональ:{diagonal3}");
            Console.WriteLine();
            toReverse = Convert.ToInt32(diagonal3);
            while (toReverse != 0)
            {
                int temp = toReverse % 10;
                diagonal4 = diagonal4 * 10 + temp;
                toReverse /= 10;
            }

            Console.WriteLine($"Четвертая диагональ:{diagonal4}");


        }



    }
}


