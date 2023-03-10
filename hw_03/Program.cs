// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int m, int n)
{
    int [,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
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

//среднее арифметическое элементов в каждом столбце
double [] ArrayAverage(int[,] array, int m, int n){
    double[] arr = new double[n];
    
    for (int j = 0; j < array.GetLength(1); j++){
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++){
            average = array[i,j] + average;
        }
        arr[j] = Math.Round(average/m, 1);
    }
    return arr;
}

//Вывод на печать одномерного массива
void PrintArr(double[] arr){
    // Method code.
       for (int i = 0; i < arr.GetLength(0); i++){
           Console.Write($"{arr[i]} ");  
        }
}

Console.WriteLine("Задайте размер двухмерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = FillMatrix(m, n);
PrintArray(array);
Console.WriteLine();

double [] arr = ArrayAverage(array, m, n);
PrintArr(arr);


