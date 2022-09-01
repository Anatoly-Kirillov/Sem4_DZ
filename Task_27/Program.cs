// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumNumbers(int num)
{
    int num1 = num % 10;
    int num2 = num / 10 % 10;
    int num3 = num / 100 % 10;
    int num4 = num / 1000;
    if (num < 10000 && num > 0)
    {
        int number = num4 + num3 + num2 + num1;
        Console.WriteLine($"Сумма цифр числа {num} равна: {number}");
    }
}
Console.WriteLine("Введите число X: ");
int number = int.Parse(Console.ReadLine());
SumNumbers(number);