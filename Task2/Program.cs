// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
int sum = 0;

void SomeRec(int m, int n)
{
    for (int i = n; i <= m; i++)
    {
        sum += i;
    }
    return;
    SomeRec(n, m);
}
SomeRec(N, M);
Console.WriteLine($"Сумма чисел от M до N равна {sum}");