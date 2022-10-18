/*Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19.*/

Console.Write ("введите размер массива N ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
    array[i] = int.Parse(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;

Console.Write ($"введите число k(0 - {N - 1}) ");
int k = int.Parse(Console.ReadLine());

if ((0 < k) && (k < N)) 
{
    for (int i = 0; i < N; i++)
    {
        if (i <= k)
            sum1 += array[i];
        else
            sum2 += array[i];
    }
    if (sum1 > sum2)
        Console.WriteLine($"Первая часть ({sum1} | {sum2})");
    else  if (sum1 < sum2)
        Console.WriteLine($"вторая часть ({sum2} | {sum1})");
    else 
        Console.WriteLine($"части равны ({sum1} | {sum2})");
}else
    Console.WriteLine("число К вне размера массива");