//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void NumberCounter (int N)
{
    if (N == 0) return;
    Console.Write("  " + N);
    NumberCounter (N - 1);
}
Console.WriteLine();
NumberCounter(30);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
void NumberSum (int M , int N ,int  sum)
{  
    if (M > N)
    {
    Console.Write($" sum of numbers { sum } " );
    Console.WriteLine();
     return ;
    }
    sum += M++;
    NumberSum(M, N, sum);
}
NumberSum(3, 9 ,0);
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Input a number M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number N:");
int N = Convert.ToInt32(Console.ReadLine());
int AckermanFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermanFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
return AckermanFunction(M, N);
}
Console.WriteLine($"Ackerman function for numbers ({M},{N}) = {AckermanFunction(M, N)}");
