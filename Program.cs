// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// void SortRow(int[,] array, int row)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int max = array[row, j];
//         for (int j2 = j + 1; j2 < array.GetLength(1); j2++)
//         {
//             if (array[row, j] < array[row, j2])
//             {
//                 int temp = array[row, j];
//                 array[row, j] = array[row, j2];
//                 array[row, j2] = temp;
//             }
//         }
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     SortRow(myArray, i);
// }

// Print2DArray(myArray);


// ***********************************************************************************
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int MinimalRowNumber(int[,] array)
// {
//     int minRow = 0;
//     int sumRow = 0;
//     for (int j = 0; j < array.GetLength(1); j++) // Задаем референс - 0-ю строку
//     {
//         sumRow = sumRow + array[0, j];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sumCurrentRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumCurrentRow = sumCurrentRow + array[i, j];
//         }
//         if (sumCurrentRow < sumRow)
//         {
//             minRow = i;
//             sumRow = sumCurrentRow;
//         }
//     }
//     return minRow;
// }



// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// Console.WriteLine($"Строка с минимальной суммой элементов: {MinimalRowNumber(myArray)}");


// ***********************************************************************************
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int InputNum(string message)
// {
// Console.WriteLine(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
// return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// }

// void MultArray (int[,] arrayR, int[,] array1, int [,] array2)
// {
//     for (int j = 0; j < arrayR.GetLength(1); j++)
//     {
//         for (int i = 0; i < arrayR.GetLength(0); i++)
//         {
//             int mult = 0;
//             for (int ir = 0; ir < arrayR.GetLength(0); ir++)
//             {
//                 mult = mult + array1[j,ir] * array2[ir,i];
//             }
//             arrayR[j,i] = mult;
//         }
//     }
// }



// int rows1 = InputNum("Введите количество строк первой матрицы: ");
// int cols1 = InputNum("Введите количество столбцов первой матрицы: ");
// int rows2 = cols1;
// int cols2 = InputNum("Введите количество столбцов второй матрицы: ");

// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray1 = Create2DArray(rows1, cols1);
// int[,] myArray2 = Create2DArray(rows2, cols2);


// Fill2DArray(myArray1, minValue, maxValue);
// Fill2DArray(myArray2, minValue, maxValue);

// Print2DArray(myArray1);
// Console.WriteLine();
// Print2DArray(myArray2);
// Console.WriteLine();

// int[,] resArray = Create2DArray(rows1, cols2);
// Print2DArray(resArray);
// MultArray (resArray, myArray1, myArray2);
// Print2DArray(resArray);





// ***********************************************************************************
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,,] Create3DArray(int rows, int columns, int levels)
// {
//     return new int[rows, columns, levels];
// }

// void Fill3DArray(int[,,] array, int start) // Заполняю подряд начиная с выбранного двухзначного элемента
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = start++;
//             }

// }

// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"[{i},{j},{k}] {array[i, j, k]}\t");

//             }
//         }

//     }
// }

// int rows = InputNum("Введите количество строк матрицы: ");
// int cols = InputNum("Введите количество столбцов матрицы: ");
// int levels = InputNum("Введите количество уровней матрицы: ");

// int start = InputNum("Введите начальный двузначный элемент: ");


// int[,,] myArray = Create3DArray(rows, cols, levels);

// Fill3DArray(myArray, start);

// Print3DArray(myArray);

// ***********************************************************************************
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillSpiral2DArray(int[,] array)
{
    int input = 1;
    int maxI = array.GetLength(0) - 1;
    int maxJ = array.GetLength(1) - 1;

    for (int j = 0; j == maxJ; j++)
    {
        array[0, j] = input++;
    }

    for (int i = 1; i == maxI; i++)
    {
        array[i, maxJ] = input++;
    }

    for (int j = maxJ - 1; j == 0; j--)
    {
        array[maxI, j] = input++;
    }

    for (int i = maxI - 1; i == 1; i--)
    {
        array[i, 0] = input++;
    }

    for (int j = 1; j == maxJ - 1; j++)
    {
        array[1, j] = input++;
    }

    for (int j = 2; j == 1; j--)
    {
        array[2, j] = input++;
    }


}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = 4;
int columns = 4;

int[,] myArray = Create2DArray(rows, columns);

FillSpiral2DArray(myArray);

Print2DArray(myArray);

