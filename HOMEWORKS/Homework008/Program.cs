/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] array = new int[4 , 4];
CreateArray(array);
ShowArray(array);
Console.WriteLine();
SortArray(array);
ShowArray(array);
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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(1) - 1; b++)
            {
                if (array[i, b] < array[i, b + 1])
                {
                    int temp = array[i, b + 1];
                    array[i, b + 1] = array[i, b];
                    array[i, b] = temp;
                }
            }
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
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
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

void NumsMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($" {minSumRow + 1} строка   (Сумма чисел минимальной строки {minRow}) ");
}
int[,] array = new int[4 , 4];
CreateArray(array);
ShowArray(array);
Console.WriteLine();
NumMinSumElements(array);
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
/*
Console.Write("Input rows: ");
int rows =Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int columns =Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int [rows, columns];

CreateArray(array);
ShowArray(array);
Console.WriteLine();
CreateArray(secondArray);
ShowArray(secondArray);
Console.WriteLine();

void  CreateArray(int [,] array) 
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
        array[i,j] = new Random().Next(1, 10);  
        }
    }
}
if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Cannot be multiplied ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int a = 0; a < array.GetLength(1); a++)
        {
            resultArray[i, j] += array[i, a] * secondArray[a, j];
        } 
    }
}
ShowArray( resultArray);

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
*/
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.Write("Input x: ");
int x =Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y =Convert.ToInt32(Console.ReadLine());
Console.Write("Input z: ");
int z =Convert.ToInt32(Console.ReadLine());

void  CreateArray(int [, ,] array) 
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void ShowArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]}({i},{j},{k}); ");
      }
        Console.WriteLine();
    }
  
  }
}
int[, ,] array = new int[x, y, z];
CreateArray(array);
Console.WriteLine();
ShowArray(array);



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
/*
void CreateArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int val = 1;
    for (int z = 0; z < n * n; z++)
    {
        int m = 0;
        do { array[i, j++] = val++; } while (++m < n - 1);
        for (m = 0; m < n - 1; m++) array[i++, j] = val++;
        for (m = 0; m < n - 1; m++) array[i, j--] = val++;
        for (m = 0; m < n - 1; m++) array[i--, j] = val++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {    
            Console.Write("0" + array[i,j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
} 
int[,] array = new int[4, 4]; 
CreateArraySpiral(array, 4);
ShowArray(array);
*/