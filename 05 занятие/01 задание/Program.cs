// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
int chetnost (int[] a, int N)
{
    int sum = 0; 
    for (int i = 0; i < N; i++)
    {
        if (a[i] % 2 == 0)
            sum++;
    }
    return sum;
}   

int _N = 10;
int [] array = new int [_N];
fill (array, _N);
show(array, _N);
int s = 0; 
s = chetnost(array, _N);
Console.WriteLine($"Количество четных элементов: {s}");