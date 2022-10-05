// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("введите число ");
int num = int.Parse(Console.ReadLine());
if (num == 1) 
    Console.WriteLine("Понедельник");
else if (num == 2) 
    Console.WriteLine("вторник");
else if (num == 3) 
    Console.WriteLine("среда");
else if (num == 4) 
    Console.WriteLine("четверг");
else if (num == 5) 
    Console.WriteLine("пятница");
else if (num == 6) 
    Console.WriteLine("суббота");
else if (num == 7) 
    Console.WriteLine("воскресенье");
else 
    Console.WriteLine("так сложилось, но в неделе всего 7 дней");