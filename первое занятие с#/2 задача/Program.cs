//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисе
Console.WriteLine("Введите числа");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;
if (number_2 > max)
    max = number_2;
if (number_3 > max)
    max = number_3;
Console.WriteLine($"max = {max}");
