// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введи число M: ");
int M  = int.Parse(Console.ReadLine()!);

Console.Write("Введи число N: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumElements(M,N));

// ------------------Method------------------
int SumElements(int M, int N)
{
    if (M == N) return N;
    return (M + SumElements(M + 1, N));
}