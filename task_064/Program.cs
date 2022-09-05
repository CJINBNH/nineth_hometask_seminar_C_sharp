// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите чило N: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    PrintNumbers(n-1);
}
PrintNumbers(number);