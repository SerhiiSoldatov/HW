// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());

void SomeRec(int n, int m)
{
    if (n < m)
    SomeRec(n + 1, m);
    if (n > m)
    SomeRec(n - 1, m);
    Console.Write(n + " ");

}
SomeRec(N, M);