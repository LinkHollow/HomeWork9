// Задача 68: Выполнить с помощью рекурсии.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введи число m: ");
int M  = int.Parse(Console.ReadLine()!);

Console.Write("Введи число n: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(Akkerman(M,N));

// ------------------Method------------------
int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if ((N == 0) && (M != 0)) return Akkerman(M -1, 1) ;
    return Akkerman(M - 1, Akkerman(M, N - 1));
}