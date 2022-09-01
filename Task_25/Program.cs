// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void PowNumber(int number1, int number2)
{
    if (number2 > 0)
    {
        Console.WriteLine($"Число А в степени В : {Math.Pow(number1, number2)}");
    }
}

Console.WriteLine("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());
PowNumber(num1, num2);