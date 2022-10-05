// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("введите число ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
if (number < 100)
    Console.WriteLine("третьей цифры нет");
else if (number < 1000)
    Console.WriteLine (number % 10);
else 
{
    while (number >= 1000)
        number /= 10;
    Console.WriteLine (number % 10);
}