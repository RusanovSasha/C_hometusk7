//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

int[,] MakeArray(int x, int y)
{
    int[,] result = new int[x,y];
    Random rnd = new Random();
    for (int j = 0; j < x; j++)
    for (int i = 0; i < y; i++)
    {
        result[j,i] = rnd.Next(10000)-5000;
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

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
// даем возможность оперативно менять количество элементов в массиве, для чего задаем переменные m и n в программе. В предыдущей программе мы давали их ввести пользовталю, здесь в задании нет такого условия, поэтому просто поставим их равными четырем.
int m = 4;
int n = 4;
Console.WriteLine($"Создаем двумерный массив {m} на {n}");

int[,] arr = MakeArray(m, n);

PrintArray(arr);

Console.WriteLine();

int x = ReadInt("Введите индекс строки: ");
int y = ReadInt("Введите индекс столбца: ");

if (x < arr.GetLength(0) && y < arr.GetLength(1))
    Console.WriteLine(arr[x, y]);
else Console.WriteLine($"[{x}, {y}] -> такого числа в массиве нет");
