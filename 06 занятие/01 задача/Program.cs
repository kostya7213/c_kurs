// : Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void show (List<int> a)
{
    for (int i = 0; i < a.Count; i++)
        Console.Write($"{a[i]} ");
        Console.WriteLine();
}
void fill (List<int> a, int N)
{
    Console.Write("Введите количество элементов: ");
    N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
        a.Add(int.Parse(Console.ReadLine()));
}
int plus (List<int> a)
{
    int pl = 0;
    for (int i = 0; i < a.Count; i++)
        if (a[i] > 0)
            pl++;
    return pl;
}
int _N = 0; 
int _pl;
List<int> array = new List<int>(_N);
fill(array, _N);
show(array);
_pl = plus(array);
Console.Write($"Количество элемнтов больше нуля: {_pl}");