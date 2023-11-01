// Задача 50: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// 1   4   7   2
// 5   9   2   3
// 8   4   2   4
// 17 -> такого элемента нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftRange, int rigthRange)
{
    int [,] tempMatrix = new int[rows, cols];
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

int [] FindIndexPosition(int [,] matrix, int x, int y)
{
    int [] arrayNum = {0, -1};
    if (x >= 0 && x < matrix.GetLength(0) && y >=0 && y < matrix.GetLength(1))
    {
        arrayNum [1] = 0;
        arrayNum [0] = matrix[x, y];
    }
    return arrayNum;
}

void IfIndexPositionError(int [] array, int X, int Y)
{
    if (array [1] == -1) System.Console.WriteLine("Такого индекса нет");
    else System.Console.WriteLine($"Число на позиции:({X}, {Y}) это - {array[0]}");
    
}

int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");
int x = ReadInt("Введите номер позиции числа на строке, x = ");
int y = ReadInt("Введите номер позиции числа в столбце, y = ");
int[,] matrix = GenerateMatrix(m, n, 0, 10);
PrintMatrix(matrix);
IfIndexPositionError(FindIndexPosition(matrix, x, y), x, y);
