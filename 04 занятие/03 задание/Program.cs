//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно 
//(диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. 
//Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
void show (int[] a, int N)
{
    for (int i = 0; i < N; i++)
        Console.Write($"{a[i]} ");
        Console.WriteLine();
}
void fill (int[] a, int N)
{
    for (int i = 0; i < N; i++)
    {
        a[i] = new Random().Next(1, 100);
        
    }
}
void sum_element_array(int[] a, int N)
{
    for (int i = 0 ; i < N; i++)
    {
        int num = a[i];
        int sum = 0;
        while (num != 0)
        {
            sum = sum + (num % 10);
            num /= 10;
        }
        a[i] = sum;
    }
}
int _N = 8;
int [] array = new int [_N];

fill( array, _N );
Console.Write("Изначальный массив: ");
show(array, _N );
sum_element_array(array, _N);
Console.Write("Измененный массив: ");
show(array, _N );



