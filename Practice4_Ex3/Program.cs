// Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран

// 1, 2, 5, 7, 19 -> [1,2,5,7,19]
// 6, 1, 33 -> [6,1,33]


// метод для вывода текста в консоль и запроса данных
int EnterNumbers(string msg)
{
    System.Console.Write(msg); // запрос на ввод числа
    string? inputA = Console.ReadLine(); // получение числа с консоли
    int numberA = Convert.ToInt32(inputA); // преобразование строки в int
    return numberA; // возврат числа для дальнейших операций с ним
}

// метод задания массива
//             длина       миним. значение   макс. значение 
int[] NumArray(int length, int minNumArray, int maxNumArray)
{    // массив             8 элем
    int[] array = new int[length]; // обьявили массив и его длину задаст пользователь
    Random rand = new Random(); // задали метод генерации случайных чисел
    
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minNumArray, maxNumArray + 1); // цикл заполнит массив случайными числами в диапазоне от минимального числа до максимального
    }
    return array; // вернёт массив
}

void PrintArray(int[] array) // метод вывода массива в консоль

{   System.Console.Write("["); 

    for (int i = 0; i < array.Length - 1; i++) // цикл пробегает по сгенерированному массиву и выводит все элементы кроме последнего
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]}"); // добавляется последний, это для того чтоб после него не было запятой
    System.Console.Write("]");
}

int Len = EnterNumbers("Введите значение длины массива: ");
int minNum = EnterNumbers("Введите значение минимального элемента массива: ");
int maxNum = EnterNumbers("Введите значение максимального элемента массива: ");
int[] array = NumArray(Len, minNum, maxNum);
PrintArray(array);