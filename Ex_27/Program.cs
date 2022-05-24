// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Ведите натуральное число");
int num = Convert.ToInt32(Console.ReadLine()); //Чем отличаются разные конверторы в int?

int res = 0;

Console.Write($"Сумма цифр в числе {num} = ");
while (num > 0) 
{
    res = res + (num % 10);
    num = num / 10;
}
Console.WriteLine(res);