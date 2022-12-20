Console.Clear();
restart:
Console.WriteLine("1: Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("2: Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.Write("Введите номер задачи: ");
int Task = int.Parse(Console.ReadLine());
switch (Task)
{
    case 1: /*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
        int SumElem(int a, int b)
        {
            if (a == b + 1) return 0;
            else return a + SumElem(a + 1, b);
        }
    start:
        Console.Write("Введите значения M и N через пробел: ");
        int[] elem = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
        int M = elem[0], N = elem[1];
        if (M < N)
            Console.Write($"M = {M}; N = {N} -> {SumElem(M, N)}");
        else
        {
            Console.WriteLine("Введены некоректные значения M и N");
            goto start;
        }
        break;
    case 2: /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/
        int AkkermanFunction(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return AkkermanFunction(n - 1, 1);
            else
                return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
        }
        Console.Write("Введите значения m и n через пробел: ");
        int[] mn = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
        int m = mn[0], n = mn[1];
        Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AkkermanFunction(m, n)}");
        break;
    default:
        goto restart;
}