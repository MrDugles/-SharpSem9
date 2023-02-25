// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void GetSeriesOfNumbers()
{
    Console.WriteLine("Задайте значения M и N чтобы найти сумму натуральных элементов в промежутке от M до N");
    int numberM = InputWithValidation("M: ");
    int numberN = InputWithValidation("N: ");
    if (numberM > numberN)
    {
        Console.WriteLine("M больше N - противоречит условию.");
        Environment.Exit(0);
    }
    Console.Write($"M = {numberM}; N = {numberN} -> ");
    Console.WriteLine(GetSeries(numberM, numberN));
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

int GetSeries(int numM, int numN)
{
    int summ = 0;
    if (numN == numM)
        return summ + numM;
    summ += numN + GetSeries(numM, --numN);
    return summ;
}

GetSeriesOfNumbers();