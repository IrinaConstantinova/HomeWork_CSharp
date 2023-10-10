// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

System.Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max;

if (a > b)
{
    max = a;
}
else {
    max = b;
}
if (max > c)
{
    System.Console.WriteLine("Max = " + max);
}
else {
    max = c;
    System.Console.WriteLine("Max = " + c);
}