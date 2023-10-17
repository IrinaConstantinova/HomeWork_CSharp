// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли оно полиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


System.Console.Write("Введите пятизначное число: ");
string? strNumber = Console.ReadLine();


if (strNumber.Length == 5)
{
    if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
    {
        bool num = true;
        System.Console.WriteLine(num);
    }
    else
    {
        bool num = false;
        System.Console.WriteLine(num);
    }
}
else
{
    bool num = false;
    System.Console.WriteLine($"Число не пятизначное {num}");
}