// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20.

void show (List<int> a)
{
    for (int i = 0; i < a.Count; i++)
        Console.Write($"{a[i]} ");
        Console.WriteLine();
}

void exchange (List <int> a)
{
     for (int i = 0; i < a.Count; i++)
     {
        if (a[i] == 20)
        {
            a[i] = 200;
            break;
        }
     }
}


int _N = 5;
List<int> array = new List<int>(_N) {21, 53,20, 56, 45,20};
//fill(array);
Console.Write("Изначальный список: ");
show(array);
exchange(array);
Console.Write("Изменненый список: ");
show(array);