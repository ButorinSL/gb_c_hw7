// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Generate2DArray(int cntRows, int cntColumns)
{
    double[,] array = new double[cntRows, cntColumns];
    Random rnd = new Random();


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);

        }
    }
    return array;
}

void Print2DArray(double[,] array)
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

int rows = ReadInt("Введите количество строк = M");
int columns = ReadInt("Введите количество колонок = N");
double[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);