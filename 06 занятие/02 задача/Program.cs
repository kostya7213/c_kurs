//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void line (double k1, double b1, double k2, double b2)
{   double k3 = k1 - k2;
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");
    else if (k3 == 0)
        Console.WriteLine("Прямые параллельны");    
    else
    {
        double b3 = b1 - b2;
        double x = -b3 / k3;
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения: {x:0.0} {y:0.0}");
    }
}



Console.Write("Введите k1: "); 
double _k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: "); 
double _b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: "); 
double _k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: "); 
double _b2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Первое уравнение: y = {_k1}x + {_b1}");
Console.WriteLine($"Второе уравнение: y = {_k2}x + {_b2}");
line (_k1, _b1, _k2,_b2);