// 
double dist (double _x1,double _y1, double _z1,double _x2,double _y2,double _z2)
{
return Math.Sqrt(Math.Pow((_x2 - _x1),2)+Math.Pow((_y2- _y1),2)+Math.Pow((_z2 - _z1),2));
}
double x1,y1,z1,x2,y2,z2;
Console.WriteLine("Введите координаты первой точки А (x, y, z)");
x1 = double.Parse(Console.ReadLine());
y1 = double.Parse(Console.ReadLine());
z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки B (x, y, z)");
x2 = double.Parse(Console.ReadLine());
y2 = double.Parse(Console.ReadLine());
z2 = double.Parse(Console.ReadLine());

Console.Write("Растояние между точками ");
Console.WriteLine(Math.Round(dist(x1,y1,z1,x2,y2,z2), 3));