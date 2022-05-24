// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Задачу решить без использования Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число");
double num1 = Convert.ToDouble(Console.ReadLine()); // В степень можно возводить и дробное число
Console.WriteLine("Введите натуральное число");
int num2 = Convert.ToInt32(Console.ReadLine());
double res = 1;

for (int i=1; i<=num2; i++)
{
    res = res*num1;
}
Console.WriteLine ($"{num1} в степени {num2} = {res}");