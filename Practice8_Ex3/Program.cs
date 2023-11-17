// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int numRowsA = matrixA.GetLength(0);
    int numColsA = matrixA.GetLength(1);
    int numColsB = matrixB.GetLength(1);

    int[,] resultMatrix = new int[numRowsA, numColsB];

    for (int i = 0; i < numRowsA; i++)
    {
        for (int j = 0; j < numColsB; j++)
        {
            int sum = 0;

            for (int k = 0; k < numColsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }

            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    int numColsA = matrixA.GetLength(1);
    int numRowsB = matrixB.GetLength(0);

    if (numColsA != numRowsB)
    {
        System.Console.WriteLine("Невозможно умножить матрицу A на матрицу B!");
    }
    else
    {
        System.Console.WriteLine("Результат умнажения матриц A и B: ");
        int[,] resultMatrix = MatrixMultiplication(matrixA, matrixB);
        PrintMatrix(resultMatrix);
    }
}
//---------------------------------------------------------------------------
int m = ReadInt("Введите количество строк двумерной матрицы A: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы A: ");

int k = ReadInt("Введите количество строк двумерной матрицы B: ");
int l = ReadInt("Введите количество столбцов двумерной матрицы B: ");


int[,] matrixA = GenerateMatrix(m, n, 0, 10);
int[,] matrixB = GenerateMatrix(k, l, 0, 10);
System.Console.WriteLine("Матрица A: ");
PrintMatrix(matrixA);
System.Console.WriteLine("Матрица B: ");
PrintMatrix(matrixB);
MultiplyIfPossible(matrixA, matrixB);