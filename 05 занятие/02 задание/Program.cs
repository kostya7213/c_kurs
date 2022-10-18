//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void fill (int[] a, int N)
{
    for (int i = 0; i < N; i++)
    {
        a[i] = new Random().Next(100,999);
        
    }
}
void show (int[] a, int N)
{
    for (int i = 0; i < N; i++)
        Console.Write($"{a[i]} ");
        Console.WriteLine();
}

int sum_array (int[] a, int N)
{
    int sum = 0; 
    for (int i = 0; i < N; i++)
    {
        if (i % 2 == 0)
        {
            sum += a[i];
        }
    }
    return sum;
}

int _N = 10;
int [] array = new int [_N];
fill (array, _N);
show(array, _N);
int s = sum_array(array, _N);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {s}");