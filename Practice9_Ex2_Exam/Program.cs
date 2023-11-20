// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SumNumbers(int m, int n)
{
    if (m > n) return 0;
    return m + SumNumbers(m + 1, n);
}
//----------------

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");

int sumNum = SumNumbers(M, N);
System.Console.WriteLine($"Сумма натуральных чисел от {M} до {N} = {sumNum}");