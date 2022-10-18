// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int sum (int num)
{
    int s = 0;
    if (num < 0)
        num = -num;

    while (num != 0)
    {
        s = s + (num % 10);
        num /= 10;
    }
    return s;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int s_itog;
s_itog = sum(a);
Console.WriteLine($"Сумма цифр в числе: {s_itog}");
