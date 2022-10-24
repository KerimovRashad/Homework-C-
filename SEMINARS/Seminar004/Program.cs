//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
    {
        sum += current; 
    }
    return sum;
}

Console.Write( "input a number");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetSum(num);
Console.WriteLine($" sum of numbers from 1 to { num } is {s} ");
*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*int CountNumber( int num)
{
  int current ;
    for(current = 1; num > 9; current++)
            num = num /10;
     return current;
}   
Console.Write(" Input a num");
int num  = Convert.ToInt32(Console.ReadLine());
int countNumber = CountNumber(num);
Console.WriteLine( countNumber);

    */

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/* int GetSum(int a)
{
    int sum = 1;

    for(int current = 1; current <= a; current++)
    {
        sum *= current; 
    }
    return sum;
}

Console.Write( "input a number");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetSum(num);
Console.WriteLine($" sum of numbers from 1 to { num } is {s} ");
*/

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

/*int[] CreateRandomArray(int size, int minValue, int maxValue )
{
    int[] newArray = new int[size];

    for(int i = 0;i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
 void ShowArray(int[] array)
{
    for( i = 0; i < array.Length; i++)
    
    Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
Console.Write("input a number of elements:");
int size = Convert.ToInt32(Console.Readline());
int min = 0;
int max = 9;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);*/

//Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.
