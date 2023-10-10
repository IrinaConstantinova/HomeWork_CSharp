// Напишите программу, которая на входе принимает
// два числа и выдаёт, какое число больше, а какое маньше.
// a = 5; b = 7 -> Первое число 5 меньше чем второе число 7
// a = 2; b = 2 -> Введённые числа равны
// a = -3; b = -9 -> Первое число -3 больше чем второе число -9

System.Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine("Первое число " + a + " больше чем второе число " + b);
}
else if (a < b)
{
    System.Console.WriteLine("Первое число " + a + " менише чем второе число " + b);
}
else if (a == b)
{
    System.Console.WriteLine("Введённые числа равны " + a);
}
