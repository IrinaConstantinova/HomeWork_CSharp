// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// 1    4   7   2
// 5    9   2   3
// 8    4   2   4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftRange, int rigthRange)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rigthRange + 1);
        }
    }

    return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    double sum = 0;
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        array[j] = sum / matrix.GetLength(0);
    }
    return array;
}

void PrintListAvr(double[] newArray)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    foreach (double num in newArray)
    {
        Console.Write($"{num:f2}" + "\t");

    }
    Console.WriteLine();
}

int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");
int[,] matrix = GenerateMatrix(m, n, 0, 10);
PrintMatrix(matrix);
PrintListAvr(FindAverageInColumns(matrix));
