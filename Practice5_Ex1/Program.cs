// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


// метод задания массива
//             длина       миним. значение   макс. значение 
int[] GenerateNumArray(int length, int minNumArray, int maxNumArray)
{   
    int[] array = new int[length]; // обьявили массив и его длину задаст пользователь
    Random rand = new Random(); // задали метод генерации случайных чисел
    
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minNumArray, maxNumArray + 1); // цикл заполнит массив случайными числами в диапазоне от минимального числа до максимального
    }
    return array; // вернёт массив
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