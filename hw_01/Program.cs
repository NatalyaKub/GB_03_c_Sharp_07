// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Метод заполнения массива случайными вещественными числами от -10 до 10
double[,] FillMatrix(int m, int n)
{
    double [,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    // Method code.
       for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                // System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]); // заменить на свою строчку
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
}

Console.WriteLine("Задайте размер двухмерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = FillMatrix(m, n);
PrintArray(array);
