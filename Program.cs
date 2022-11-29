// Урок 8. Двумерные массивы. Продолжение

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] FillArray(int m, int n)
// {
//     int[,] array = new int [m,n];
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1);j++)
//             array [i,j]=new Random().Next(1,10);
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for(int i=0; i < arr.GetLength(0); i++)
//     {
//         for(int j=0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write($"{arr[i,j]} \t");
//             }
//             Console.WriteLine();
//     }
// }

// int[,] NewArray(int[,] arr2)
// {
//     for(int i=0; i < arr2.GetLength(0); i++)
//     {
//         for(int j=0; j < arr2.GetLength(1)-1; j++)
//             {
//                 int maxPosition=j;
//                 for (int k = j+1; k < arr2.GetLength(1); k++)
//                 {
//                     if(arr2[i,k] > arr2[i, maxPosition]) maxPosition = k; 
//                 }
//                 int x = arr2[i,j];
//                 arr2[i,j] = arr2[i,maxPosition];
//                 arr2[i,maxPosition] = x;
//             }
//     }
//     return arr2;
// }

// int[,] mas=FillArray(m,n);
// PrintArray(mas);
// Console.WriteLine();
// NewArray(mas);
// PrintArray(NewArray(mas));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] FillArray(int m, int n)
// {
//     int[,] arr = new int [m,n];
//     for (int i=0; i<arr.GetLength(0);i++)
//     {
//         for (int j=0; j<arr.GetLength(1);j++)
//             arr [i,j]=new Random().Next(1,10);
//     }
//     return arr;
// }

// void PrintArray(int[,] arr)
// {
//     for(int i=0; i < arr.GetLength(0); i++)
//     {
//         for(int j=0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write($"{arr[i,j]} \t");
//             }
//             Console.WriteLine();
//     }
// }

// int[,] arr =FillArray(m,n);
// PrintArray(arr);

// int SumMin = 0;
// int StSum = SumStr(arr, 0);
// for (int i = 1; i < arr.GetLength(0); i++)
// {
//   int x = SumStr(arr, i);
//   if (StSum > x)
//   {
//     StSum = x;
//     SumMin = i;
//   }
// }

// int SumStr(int[,] arr, int i)
// {
//   int StSum = arr[i,0];
//   for (int j = 1; j < arr.GetLength(1); j++)
//   {
//     StSum += arr[i,j];
//   }
//   return StSum;
// }
// Console.WriteLine($" Номер строки {SumMin+1} с наименьшей суммой равной: {StSum}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк первой матрицы");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов первой матрицы и строк второй матрицы");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов второй матрицы");
// int h = Convert.ToInt32(Console.ReadLine());

// int [,] FillArray(int [,] arr)
// {
//     for (int i=0; i<arr.GetLength(0);i++)
//     {
//         for (int j=0; j<arr.GetLength(1);j++)
//             arr [i,j]=new Random().Next(1,10);
//     }
//     return arr;
// }

// void PrintArray(int[,] arr)
// {
//     for(int i=0; i < arr.GetLength(0); i++)
//     {
//         for(int j=0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write($"{arr[i,j]} \t");
//             }
//             Console.WriteLine();
//     }
// }

// void FinArray(int[,] FirstArray, int[,] SecondArray, int[,] ResultArray)
// {
//   for (int i = 0; i < ResultArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < ResultArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < FirstArray.GetLength(1); k++)
//       {
//         sum += FirstArray[i,k] * SecondArray[k,j];
//       }
//       ResultArray[i,j] = sum;
//     }
//   }
// }
// Console.WriteLine();

// int[,] FirstArray = new int[m, n];
// FillArray(FirstArray);
// Console.WriteLine($" Матрица 1:");
// PrintArray(FirstArray);
// Console.WriteLine();

// int[,] SecondArray = new int[n, h];
// FillArray(SecondArray);
// Console.WriteLine($" Матрица 2:");
// PrintArray(SecondArray);

// int[,] ResultArray = new int[m,h];

// FinArray(FirstArray, SecondArray, ResultArray);
// Console.WriteLine($"Результирующая матрица будет:");
// PrintArray(ResultArray);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)









// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] Matrix = new int[4, 4];

int x = 1; int i = 0; int j = 0;

while (x <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = x;
  x++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

Console.WriteLine($"Для массива 4 на 4 спиральное заполнение:");
Array(Matrix);

void Array (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    Console.Write($" {array[i,j]} \t");
    Console.WriteLine();
  }
}
