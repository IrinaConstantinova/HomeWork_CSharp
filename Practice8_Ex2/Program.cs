// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindRowWithMinSum(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    int minSumRowIndex = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < numRows; i++)
    {
        int currentRowSum = 0;
        for (int j = 0; j < numCols; j++)
        {
            currentRowSum += matrix[i, j];
        }

        if (currentRowSum < minSum)
        {
            minSum = currentRowSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
}

// ------------------------------------
int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");

int[,] matrix = GenerateMatrix(m, n, 0, 10);
System.Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);

int minSumRowIndex = FindRowWithMinSum(matrix);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");