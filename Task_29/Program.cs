// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b)
// и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

void RandArray(int[] myArray, int start, int end)
{
    Random rand = new Random();
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rand.Next(start, end);
    }

    Console.Write($"[{String.Join(", ", myArray)}]");
}
Console.Write("Введите количество элементов массива N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число массива B: ");
int b = int.Parse(Console.ReadLine());
int[] array = new int[n];
RandArray(array,a,b);