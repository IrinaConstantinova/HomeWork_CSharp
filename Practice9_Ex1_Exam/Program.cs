// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void Numbers(int n)
{
    if (n == 0) return;
    System.Console.Write($"{n} ");
    Numbers(n - 1);
}

//----------------------------

int N = ReadInt("Введите число N: ");
System.Console.Write($"Натуральные числа в промежутке от {N} до 1: ");
Numbers(N);