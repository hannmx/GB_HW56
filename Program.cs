using System;

namespace GB_HW56
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Введите количетсво строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];
            Console.WriteLine("--------------------------------------");
            void FillMatrix(int[,] matr)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        matr[i, j] = rand.Next(-100, 100);
                        Console.Write(matr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
          
            void NumberRow(int[,] matr)
            {
                int minRow = 0;
                int num_row = 0;
                int sumRow = 0;
                for (int i = 0; i < matr.GetLength(1); i++)
                {
                    minRow += matr[0, i];
                }
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        sumRow += matr[i, j];
                    }
                    if (sumRow < minRow)
                    {
                        minRow = sumRow;
                        num_row = i;
                    }
                    sumRow = 0;
                }
                Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {num_row + 1} строка");
            }

            FillMatrix(matrix);
            NumberRow(matrix);
        }
    }
}
