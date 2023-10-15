// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine($"Третья цифра числа: {number % 10}");
}
else
    System.Console.WriteLine("Третьей цифры нет");

