// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void search (int number)
{
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
}

Console.WriteLine("введите число ");
int num = int.Parse(Console.ReadLine());
num = Math.Abs(num);
search(num);
