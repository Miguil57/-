//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


int m = 0;
int n = 0;
 
// Запрашиваем у пользователя значения M и N с проверкой на правильность ввода
do
{
    Console.Write("Введите значение M: ");
} while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);

do
{
    Console.Write("Введите значение N (больше либо равно M): ");
} while (!int.TryParse(Console.ReadLine(), out n) || n < m);


Console.WriteLine($"Натуральные числа от {m} до {n}:");
PrintNaturalNumbers(m, n);

// Рекурсивная функция для вывода всех натуральных чисел в промежутке от m до n
static void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNaturalNumbers(m + 1, n); // Рекурсивный вызов для следующего числа
    }
}
