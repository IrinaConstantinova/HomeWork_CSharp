// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n;
if (number > 99 && number < 1000)
{
    n = (number / 10) % 10;
    System.Console.WriteLine($"Вторая цифра числа: {n}");
}
else 
{
    System.Console.WriteLine("Нет, это не трёхзначное число, попробуйте снова");
}