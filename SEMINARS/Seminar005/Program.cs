/*void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write (array [i] + " ");

    Console.WriteLine();
}

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] =  new Random.Next(10, 100))
    }
    return newArray;
}
*/
/*Напишите программу замены элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.*/

/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/

/*Задайте одномерный массив из 12 случайных чисел. Найдите 
количество элементов массива, значения которых лежат 
в отрезке [10,99].*/
/*
int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; 
    }
    return array;
}
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size, minValue, maxValue);
ShowArray(myArray);
int[] myArray2 = ChangeArray(myArray);
ShowArray(myArray2);
*/
/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/
/*
bool Digit(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == number)
            return true;
    return false;
}
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myNewArray = CreateArray( size,  minValue,  maxValue);
ShowArray(myNewArray);
bool digit = Digit(myNewArray, number);
Console.WriteLine(digit);
*/
/*Задайте одномерный массив из 12 случайных чисел. Найдите 
количество элементов массива, значения которых лежат 
в отрезке [10,99].

int Summ(int[] array, int n, int m){
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= n && array[i] <= m)
        sum++;
    return sum;
}


Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myNewArray = CreateArray( size,  minValue,  maxValue);
ShowArray(myNewArray);

int sum = Summ(myNewArray, n, m);

Console.WriteLine(sum);
*/