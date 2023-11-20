// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int AkkernamFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (n==0) return AkkernamFunction(m-1, 1);
        else return AkkernamFunction(m-1, AkkernamFunction(m, n-1));
    }
    
}
//-----------------------
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");

int result = AkkernamFunction(m,n);
System.Console.WriteLine($"Результат вычисления функции Аккермана({m},{n}) = {result}");