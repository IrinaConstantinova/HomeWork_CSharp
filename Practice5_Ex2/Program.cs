// Задача 36: Задайте одномерный массив, заполненный
// случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях


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

int SumOfArrayElementsOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((i % 2) == 1) sum += array[i];
    }
    return sum;
}    

// Основной блок кода

int[] array = GenerateNumArray(8, 0, 5);
PrintArray(array);
int result = SumOfArrayElementsOddIndex(array);
System.Console.WriteLine($"Сумма элементов массива с нечётным индексом = {result}");
