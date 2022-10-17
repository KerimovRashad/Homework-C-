//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*Console.Write("Input a Array:");
int size = Convert.ToInt32(Console.ReadLine());
int createArray = CreateArray(size);
Console.WriteLine(createArray);
int EvenElements = 0;
int count = EvenElements;

int CreateArray(int size)
{   
    int[]array = new int [size];
    for(int i = 0;i < size; i++)
    {   Console.Write("[");
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
        Console.Write("]");
        Console.WriteLine();
    }
    int count = 0;
    Console.WriteLine($"number of even elements"  + "" );
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
          count++;
        }
    }
    return count;
}
*/
 //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19  ,[-4, -6, 89, 6] -> 0

/*int SumElement = 0;

    int CreateArray(int size)
{
    int[]array = new int [size];
    for(int i = 0;i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
         {
          SumElement +=  array[i];
         }
    }
    return SumElement;
} 
Console.Write("Input a array;");
int size = Convert.ToInt32(Console.ReadLine());
int createArray = CreateArray(size);
Console.WriteLine(createArray);
Console.WriteLine($"Sum of elements of odd positions" = {SumElement}");
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76

    double[] arrayNum = new double [5];
    for(int i = 0;i < arrayNum.Length; i++)
    {   Console.Write("[");
        arrayNum[i] = new Random().Next(1, 100);
        Console.Write(arrayNum[i] + " ");
        Console.Write("]");
        Console.WriteLine();
    }
    double maxDiffNum = arrayNum.Length;
    double minDiffNum = arrayNum.Length;
    
    for(int i = 1;i < arrayNum.Length; i++)
    {
        if(maxDiffNum < arrayNum[i])
        {
        maxDiffNum = arrayNum[i];
        }
        if(minDiffNum > arrayNum[i])
        {
        minDiffNum = arrayNum[i];
        }
    }
        double decision = maxDiffNum  - minDiffNum;
    
    
     Console.WriteLine($"the difference between the maximum ({maxDiffNum }) and minimum ({minDiffNum}) elements: {decision}");


   

