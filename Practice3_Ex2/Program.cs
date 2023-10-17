// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит растояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53


int[] pointA = new int[3];
System.Console.Write("Введите координату x точки А: ");
pointA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки А: ");
pointA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки А: ");
pointA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int[] pointB = new int[3];
System.Console.Write("Введите координату x точки B: ");
pointB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки B: ");
pointB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки B: ");
pointB[2] = Convert.ToInt32(Console.ReadLine());

int resultX = (int) Math.Pow(pointA[0] - pointB[0], 2); 
int resultY = (int) Math.Pow(pointA[1] - pointB[1], 2);
int resultZ = (int) Math.Pow(pointA[2] - pointB[2], 2);

double distance = Math.Sqrt(resultX + resultY + resultZ);

System.Console.WriteLine();

System.Console.WriteLine(Math.Round(distance, 2));
