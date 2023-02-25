// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void GetSeriesOfNumbers()
{
    int num = InputWithValidation("Задайте число N для вывода натуральных чисел в промежутке от N до 1: ");
    Console.Write($"N = {num} -> ");
    Console.WriteLine(GetSeries(num));
}

int InputWithValidation(string message)
{
    int num;
    string? inputText;
    while (true)
    {
        Console.Write(message);
        inputText = Console.ReadLine();
        if (inputText == null || inputText.Trim() == "")
        {
            Console.WriteLine("Ошибка! Вы ничего не ввели.");
            continue;
        }
        try
        {
            num = int.Parse(inputText);
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка! Введите натуральное число.");
            continue;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка! Вы ввели слишком много символов.");
            continue;
        }
    }
    return num;
}

int GetSeries(int count)
{
    if (count == 1)
        return count;
    Console.Write(count + ", ");
    return GetSeries(--count);
}

GetSeriesOfNumbers();