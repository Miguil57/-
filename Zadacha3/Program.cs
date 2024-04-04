//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

// Создаем массив
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 101);
}

// Выводим элементы сгенерированного массива для наглядности конечного результата
Console.WriteLine("Полученный массив: ");
PrintArray(array, 0);
Console.WriteLine();
// Выводим элементы массива, начиная с конца
Console.WriteLine("Элементы массива, начиная с конца: ");
PrintArrayReversed(array, size - 1);

static void PrintArrayReversed(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write($"{array[i]} ");
        PrintArrayReversed(array, i - 1); // Рекурсивный вызов для предыдущего элемента
    }
}

static void PrintArray(int[] array, int i)
{
    if (i < array.Length)
    {
        Console.Write(array[i] + " ");
        PrintArray(array, i + 1); // Рекурсивный вызов для следующего элемента
    }


}





