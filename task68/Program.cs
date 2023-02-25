// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void GetSeriesOfNumbers()
{
    Console.WriteLine("Задайте два неотрицательных числа M и N для вычисления функции Аккермана");
    int numberM = InputWithValidation("M: ");
    int numberN = InputWithValidation("N: ");
    int akkerman = GetSeries(numberM, numberN);
    Console.Write($"M = {numberM}; N = {numberN} -> ");;
    Console.Write($"A({numberM}, {numberN}) = {akkerman}");
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
            if (num < 0)
            {
                Console.WriteLine("Ошибка! Введите положительное натуральное число.");
                continue;
            }
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

int GetSeries(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM > 0 && numN == 0)
    {
        return GetSeries(numM - 1, 1);
    }
    int result = GetSeries(numM, numN - 1);
    return GetSeries(numM - 1, result);
}

GetSeriesOfNumbers();