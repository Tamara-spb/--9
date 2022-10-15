// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int m, int n)
{
    if (m == n)
        return n;
    return n + SumDigits(m, n - 1);
}

int m = ReadNumber("Введите первое число:");
int n = ReadNumber("Введите второе число:");
Console.WriteLine($"Сумма элементов = {SumDigits(m, n)}");
