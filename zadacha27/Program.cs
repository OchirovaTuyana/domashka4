// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int sumNumber(int numA)
{
    int sum = 0;
    while (numA > 0)
    {
       int mod = numA % 10;
       sum = sum + mod;
       int div = numA / 10;
       numA = div;
    }
    return sum;
}

int summa = sumNumber(numA);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Сумма цифр в числе {numA} = {summa}");
Console.ResetColor();


