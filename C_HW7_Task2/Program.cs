// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
// (int, int) Find(int[,] array, int number) // кортеж (tuple) -возврат из функции 2-ух значений
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (number == array[i, j])
//             {
//                 return (i, j);
//             }
//         }
//     }
//     return (-1, -1);
// }


int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество колонок");
int[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);
int numbX = ReadInt($"Введите номер строки для поиска ");
int numbY = ReadInt($"Введите номер столбца для поиска ");
if (numbX > 0 && numbX <= arr.GetLength(0))
    if (numbY > 0 && numbY <= arr.GetLength(1))

    {
        System.Console.WriteLine($"Значение числа по заданным координатам = {arr[numbX - 1, numbY - 1]}");
    }
    else
    {
        System.Console.WriteLine($"Такого элемента в массиве нет");
    }
else
{
    System.Console.WriteLine($"Такого элемента в массиве нет");
}
