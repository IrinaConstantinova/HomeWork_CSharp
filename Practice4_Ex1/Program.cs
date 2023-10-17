// Задача 25 : Напишите программу, которая принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

// 3,5 -> 243
// 2,4 -> 16

// System.Console.Write("Введите число A =");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число B =");
// int power = Convert.ToInt32(Console.ReadLine());

// if (power > 0)
// {
//     int result = 1;
//     for (int i = 1; i <= power; i++)
//     {
//         result *= number;
//     }
//     System.Console.WriteLine(result);
// }   
// else 
// System.Console.WriteLine("Введённое число < 0, введите положительное число");

int EnterNumbers(string msg)
{
    System.Console.Write(msg); // запрос на ввод числа
    string? inputA = Console.ReadLine(); // получение числа с консоли
    int numberA = Convert.ToInt32(inputA); // преобразование строки в int
    return numberA; // возврат числа для дальнейших операций с ним
}

int FindPower(int number, int powerNumber)
{
    int result = 1;
    for (int i = 1; i <= powerNumber; i++)
    {
        result *= number;
    }
    return result;
}

int number = EnterNumbers("Введите число: "); // обращение к матоду ввода чисел с консоли
int powerNumber = EnterNumbers("Введите степень числа: ");
// int pow = FindPower(number, powerNumber);
// System.Console.WriteLine(pow);
// Если число степени <0, то программа выдаст ответ 1, необходимо проверить положительный ли показатель степени

if (powerNumber < 0) // проверка
{
    System.Console.WriteLine("Число не может быть меньше 0. Введите положительное число"); // вывод если показатель степени <0
}
else
{
    System.Console.WriteLine($"Введённое число {number} в степени {powerNumber} = {FindPower(number, powerNumber)}"); // вывод если показатель степени >0
}