//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] MakeArray(int x, int y)
{
    int[,] result = new int[x,y];
    Random rnd = new Random();
    for (int j = 0; j < x; j++)
    for (int i = 0; i < y; i++)
    {
        result[j,i] = rnd.Next(10);
    }
    return result;
}

void PrintArray(int[,] array)
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

void PrintMiddle(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    double middle = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < x; j++)
    {
        for (int i = 0; i < y; i++)
        {
            middle += array[i,j];
        }
        middle = Math.Round(middle/y,2);
        Console.Write(middle);
        if (j < x-1) Console.Write("; ");
        middle = 0;
    }
}

Console.Clear();
// даем возможность оперативно менять количество элементов в массиве, для чего задаем переменные m и n в программе. В предыдущей программе мы давали их ввести пользовталю, здесь в задании нет такого условия, поэтому просто поставим их равными четырем.
int m = 4;
int n = 4;
Console.WriteLine($"Создаем двумерный массив {m} на {n}");

int[,] arr = MakeArray(m, n);

PrintArray(arr);

Console.WriteLine();

PrintMiddle(arr);

