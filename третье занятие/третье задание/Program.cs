// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void kub (int _N)
{
    if (_N == 0)
        Console.WriteLine("0");
    else if (_N < 0)
    {
        for (int i = 1; i >= _N; i--)
            Console.WriteLine(Math.Pow(i , 3));
    }
     else 
     {
        for (int i = 1; i <= _N; i++)
            Console.WriteLine(Math.Pow(i, 3));
     }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
kub(N);
