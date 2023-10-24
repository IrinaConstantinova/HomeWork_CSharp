// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateNumArray(int length, int minNumArray, int maxNumArray)
{   
    int[] array = new int[length]; 
    Random rand = new Random(); 
    
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minNumArray, maxNumArray + 1); 
    }
    return array; 
}

void PrintArray(int[] arrayForPrint)  
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int CountEvenElementsArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] % 2) == 0) count++;
    }
    return count;
}    

// Основной блок кода

int[] array = GenerateNumArray(10, 100, 1000);
PrintArray(array);
int res = CountEvenElementsArray(array);
System.Console.WriteLine($"Количество чётных чисел в массиве = {res}");