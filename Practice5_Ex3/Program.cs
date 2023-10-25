// Задача 38: Задайте массив вещественных чисел,
// Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

double[] GenerateNumArray(int length, double maxRan, double minRan)
{   
    double[] array = new double[length]; 
    Random rand = new Random(); 
    for (int i = 0; i < length; i++)
    {
        double randomValue = rand.NextDouble() * (maxRan - minRan + 1) + minRan; 
        array[i] = Math.Round(randomValue, 2);
    }
    return array; 
}

void PrintArray(double[] arrayForPrint)  
{
    
    Console.WriteLine("[" + string.Join("\t", arrayForPrint) + "]");
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}   

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}   

double DifferenceMaxMin(double[] array)
{
    double difference = Math.Round(FindMax(array) - FindMin(array), 2);
    return difference;
}


// Основной блок кода

double[] array = GenerateNumArray(4, 0, 5);
PrintArray(array);
double result1 = FindMax(array);
System.Console.WriteLine($"Максимальный элемент массива = {result1}");
double result2 = FindMin(array);
System.Console.WriteLine($"Минимальный элемент массива= {result2}");
double result3 = DifferenceMaxMin(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result3}");


