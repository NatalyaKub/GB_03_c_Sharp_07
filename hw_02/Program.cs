// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

//Метод поиска числа
int FindElement(int[,] array, int elem)
{
    int resultFind = 0;
    
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
           if(array[i,j] == elem){
             resultFind = 1;
            return resultFind;
           }else{
             resultFind = 0;
           }
        }
    }
    return resultFind;
}

Console.WriteLine("Задайте размер двухмерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = FillMatrix(m, n);
PrintArray(array);


Console.WriteLine("Поиск элемента:");
int elem = Convert.ToInt32(Console.ReadLine());
int findElems = FindElement(array, elem);
if(findElems == 1){
    Console.WriteLine($"Число {elem} - такое число есть в массиве");
}else{
    Console.WriteLine($"Число {elem} - такого числа в массиве нет");
}
