// Задача 54:
// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftRange, int rightRange)
{
    var tempMatrix = new int[rows, cols];

    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
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

void SortRowsDescending(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols - 1; j++)
        {
            for (int k = 0; k < numCols - 1 - j; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}
// ------------------------------------
int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");

int[,] matrix = GenerateMatrix(m, n, 0, 10);
System.Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
System.Console.WriteLine("Массив с отсортированными по убыванию строками: ");

SortRowsDescending(matrix);
PrintMatrix(matrix);
