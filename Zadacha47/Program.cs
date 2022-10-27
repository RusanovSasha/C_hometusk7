// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] MakeArrayDouble(int x, int y)
{
    double[,] result = new double[x,y];
    Random rnd = new Random();
    for (int j = 0; j < x; j++)
    for (int i = 0; i < y; i++)
    {
        result[j,i] = (rnd.NextDouble()* 2 - 1) * Math.Pow(10, rnd.Next(1, 5));
        result[j,i] = Math.Round(result[j,i], 2);
    }
    return result;
}

void PrintArray(double[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    for (int j = 0; j < x; j++)
    {
        for (int i = 0; i < y; i++)
        {
            Console.Write($"{array[j, i]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Создаем двумерный массив mxn.");

Console.WriteLine();
Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());

double[,] arr = MakeArrayDouble(m, n);

PrintArray(arr);