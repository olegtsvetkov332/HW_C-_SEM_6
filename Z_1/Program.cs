//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

System.Console.Write("Введите длинну массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] GenerateArray(int Lenght)
{
    int[] Array = new int[Lenght];
    for (int i = 0; i != Lenght; i++)
    {
        System.Console.Write($"Введите {i} элемент массива: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array;
}

void PrintArray(int[] array)
{
    System.Console.Write("Исходный массив [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("] чисел больше нуля: ");
}

int PositiveDigits(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

int[] Array = GenerateArray(len);
PrintArray(Array);
Console.WriteLine(PositiveDigits(Array));