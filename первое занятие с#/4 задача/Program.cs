﻿Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i <=N; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}
