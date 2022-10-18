// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.

double sqr (double a, double b)
{
    double c = a;
    int i = 1;
    if (b == 0)
    {
        return 1;
    }
    else if (b > 0)
    {
        while ( i < b)
        {
            c *= a;
            i++;
        }
        return c;
    }
    else if (b < 0)
    {
        i = -1;
        while ( i > b)
        {
            c *= a;
            i--;
        }
        return 1/c;
    }

return c;

}

Console.Write("Введите число А: ");
Double _a = double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
Double _b = double.Parse(Console.ReadLine());
double _c; 
_c = sqr(_a, _b);
Console.Write($"{_a} в степени {_b} равно {_c}");


