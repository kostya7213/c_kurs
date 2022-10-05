//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.WriteLine($"min = {a}");
    Console.WriteLine($"max = {b}");
} else if (a > b)
{
    Console.WriteLine($"min = {b}");
    Console.WriteLine($"max = {a}");
} else 
    Console.WriteLine("Числа равны");
