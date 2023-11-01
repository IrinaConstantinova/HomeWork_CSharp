// Задача 47: Задайте двумерный массив размером m x n,
// заполненный случайными вещественными числами.
// m = 3, n = 4
// 0.5  7    -2   -0.2
// 1   -3.3   8   -9.9 
// 8    7.8  -7.1  9   

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] GenerateMatrix(int row, int cols, int leftRange, int rigthRange)
{
    double [,] matrix = new double [row, cols];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() + rand.Next(leftRange, rigthRange + 1), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

int n = ReadInt("Введите количество строк матрицы: ");
int m = ReadInt("Введите количество столбцов матрицы: ");
double [,] newMatrix = GenerateMatrix(n, m, -10, 10);
PrintMatrix(newMatrix);