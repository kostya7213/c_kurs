// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void fill (double[] a, int N)
{
    for (int i = 0; i < N; i++)
    {
        a[i] = new Random().Next(10,100);
        
    }
}
void show (double[] a, int N)
{
    for (int i = 0; i < N; i++)
        Console.Write($"{a[i]} ");
        Console.WriteLine();
}
double diff_min_and_max (double[] a, int N)
{
    double diff = 0;
    double max = a[0];
    double min = a[0];
    for (int i = 0; i < N; i++)
    {
        if (a[i] > max)
            max = a[i];
        else if (a[i] < min)
            min = a[i];
    }
    diff = max - min;
    return diff;
}


int _N = 10;
double [] array = new double [_N];
double diff;
fill (array, _N);
show(array, _N);
diff = diff_min_and_max(array, _N);
Console.WriteLine($"Разность между максимальным и минимальным элементом: {diff}");