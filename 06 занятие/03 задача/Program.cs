// возведение в степень числа с помощью рекурсии
int power (int a, int n)
{
    if (n == 0)
        return 1;
    else if (n == 1)
        return a;
    else
        return (a * power (a, n - 1));
}


int a, n; 
Console.Write("Введите число: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите желаемую степень: ");
n = int.Parse(Console.ReadLine());
int st = power (a, n);
Console.Write(st);