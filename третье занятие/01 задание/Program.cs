//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void palindrom (string num)
{
    bool check = true;
    if (num.Length != 5)
    Console.WriteLine("число не пятизначное");
else
{
    for (int i = 0; i < num.Length / 2; i++)
    if (num [i] != num [num.Length - i - 1 ])
            {
            check = false;
            break;
            }    
    if (check == false)
        Console.WriteLine("no");
    else 
        Console.WriteLine("yes");
}
}
Console.WriteLine("введите число");
string number = Console.ReadLine();
palindrom(number);


