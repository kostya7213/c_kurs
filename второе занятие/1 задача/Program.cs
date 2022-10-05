//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int num;
if ((number > 99) && (number < 1000))
{
    num = number / 10;
Console.WriteLine(num % 10);
}
else 
    Console.WriteLine("Число не трехзначное");