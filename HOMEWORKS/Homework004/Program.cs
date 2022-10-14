//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*Console.Write("Input a number A: " );
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int B  = Convert.ToInt32(Console.ReadLine());

    int step = A;
    for(int i = 1; i < B; i++)
    {
    step = step * A;
    }
Console.WriteLine( "Degree Of The Second Number :" + step );*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11, 82 -> 10, 9012 -> 12

/*Console.WriteLine("Input a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0 )
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("The sum of all digits in the number is equal to: " + sum);
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//m = 5 -> [1, 2, 5, 7, 19]
//m = 3 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[]array = new int [size];
    for(int i = 0;i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
} 
int size = Convert.ToInt32(Console.ReadLine());
int[] createArray = CreateArray(size);
Console.WriteLine(createArray);


