// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




void Numbers(int num)
{
    if (num >= 1)
    {
        Console.Write(num + " ");
        Numbers(num - 1);
    }
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Numbers(num);




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




int AmountOfElements(int M, int N)
{
    if (M < N)
    {
        return AmountOfElements(M + 1, N) + M;
    }
    else if (M > N)
    {
        return AmountOfElements(M, N + 1) + N;
    }
    else return 0;
}

Console.WriteLine("Введите число М:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int sum = AmountOfElements(m, n);

if (m < n)
{
    Console.WriteLine($"M = {m}; N = {n} -> {sum + n}");
}
else Console.WriteLine($"M = {m}; N = {n} -> {sum + m}");




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




int AckFuncion(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckFuncion(n - 1, 1);
    else
        return AckFuncion(n - 1, AckFuncion(n, m - 1));
}

Console.WriteLine("Введите число М:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
int res = AckFuncion(m, n);
Console.WriteLine(res);