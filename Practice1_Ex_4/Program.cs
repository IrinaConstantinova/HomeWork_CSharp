// Напишите программу, которая на вход 
// принимает число (N), а на выходе 
// показывает все чётные число от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Чётные числа от 1 до " + N + ":");

for ( int i = 2; i <= N; i+=2)
{
    System.Console.WriteLine(i);
}


