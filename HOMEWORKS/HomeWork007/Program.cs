//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];

void  CreateDoubleArray(double [,] array) 
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
        array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;  
        }
    }
}
void ShowArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}   
CreateDoubleArray(array);
ShowArray(array);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет
/*
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int[4, 4];
void  CreateDoubleArray(int [,] array) 
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
        array[i,j] = new Random().Next(0, 10) ;  
        }
    }
} 
if (rows > num.GetLength(0) || columns > num.GetLength(1))
{
    Console.WriteLine("There is no such element: ");
}
else
{
    Console.WriteLine($"The value of the {rows} element of the row and {columns} of the column is equal to {num[rows-1,columns-1]} ");
}
 
void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}   
CreateDoubleArray(num);
ShowArray(num);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 Console.Write("Input a number of rows: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int[a , b];
    
void  CreateArray(int [,] array) 
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
        array[i,j] = new Random().Next(0, 10);  
        }
    }
}
void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}  
CreateArray(num);
ShowArray(num);
 Console.WriteLine();
void ArithmeticMeanNumber(int[,] num)
{
  
for (int j = 0; j < b; j++)

{
    double res = 0;
    for (int i = 0; i < a; i++)
    {
        res = res + num[i, j]; 
       
    }
   
  Console.Write($"{Math.Round(res / b, 1)} ; ");
} 
 Console.WriteLine();
} 
ArithmeticMeanNumber(num);

