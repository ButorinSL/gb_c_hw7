// // Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Generate2DArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + 2 * j;
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



double[] GetColumnAverages(double[,] array)
{
    double[] averages = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        averages[j] = sum / array.GetLength(0);
    }
    return averages;
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество колонок");
double[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);
System.Console.WriteLine();
Console.WriteLine("Среднее арифметическое колонки");

double[] averages = GetColumnAverages(arr);

for (int j = 0; j < averages.Length; j++)
{
    Console.Write($"{j+1}: {averages[j]}\t");
}

System.Console.WriteLine();
