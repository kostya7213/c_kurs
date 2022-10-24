int[,] array_diag(int [,] a, int N)
{
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
        {
            if (j <= i)
                a[i,j] = j + 1;
            else 
            a[i,j] = i + 1;
        }
    return a;
}
void show (int[,] a, int N)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
            Console.Write($"{a[i, j]} ");
        Console.WriteLine();
    }
}

int _N;
Console.WriteLine("Введите число N");
_N = int.Parse(Console.ReadLine());
int [,] array = new int [_N ,_N]; 

array = array_diag(array, _N);
show(array, _N);


