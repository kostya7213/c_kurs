// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void opr_day (int num)
{
  switch (num)
  {
    case 1:
        Console.WriteLine("Понедельник");
    break;
    case 2:
        Console.WriteLine("Вторник");
    break;
    case 3:
        Console.WriteLine("Среда");
    break;
    case 4:
        Console.WriteLine("Четверг");
    break;
    case 5:
        Console.WriteLine("Пятница");
    break;
    case 6:
        Console.WriteLine("Суббота");
    break;
    case 7:
        Console.WriteLine("Воскресенье");
    break;
    default: 
         Console.WriteLine("так сложилось, но в неделе всего 7 дней");
    break;
  }
    
}
Console.Write("введите число ");
int number = int.Parse(Console.ReadLine());
opr_day (number);