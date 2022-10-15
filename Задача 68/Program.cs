// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Function(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Function(m - 1, 1);
    else
        return Function(m - 1, Function(m, n - 1));
}
int m = ReadNumber("Введите неотрицательное число M: ");
int n = ReadNumber("Введите неотрицательное число N: ");
Console.WriteLine(Function(m, n));