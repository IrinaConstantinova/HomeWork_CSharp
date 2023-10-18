// Задача 27: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int result = 0;
// while (number != 0)
// {
//     result = number % 10;
//     sum = sum + result;
//     number = number / 10;
// }
// System.Console.WriteLine(sum);


int EnterNumber(string msg)
{
    System.Console.Write(msg); // запрос на ввод числа
    return Math.Abs(Convert.ToInt32(Console.ReadLine())); 
}

int SumNumbers(int number)
{
    int sum = 0;
    int result = 0;
    while (number != 0)
    {
        result = number % 10;
        sum += result;
        number /= 10;
    }
    return sum;
}

int num = EnterNumber("Введите число: "); // обращение к методу ввода чисел с консоли
System.Console.WriteLine($"Введённое число {num}, сумма цифр числа = {SumNumbers(num)}"); // вывод 
