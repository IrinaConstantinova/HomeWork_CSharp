//Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1 || dayNumber == 2 || dayNumber == 3 || dayNumber == 4 || dayNumber == 5)
{
    System.Console.WriteLine("Нет, не выходной день");
}
else if (dayNumber == 6 || dayNumber == 7)
{
    System.Console.WriteLine("Да, выходной!");
}