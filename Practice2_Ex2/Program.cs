// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n;
if (number > 99 && number < 1000)
{
    n = number % 10;
    System.Console.WriteLine($"Третья цифра числа: {n}");
}
else if (number < 99)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (number > 999)
{
    int N;
    int i = 0;
    while (i < 3)
    {
        number = number / 10;
        i++;
    }
    N = number % 10;
    System.Console.WriteLine(N);
}