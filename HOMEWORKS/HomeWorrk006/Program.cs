//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3

/*int CreateArray(int size )
{
    int[] newArray = new int[size];
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        if (newArray[i] > 0)
    {
        sum++;
    }
    }
    Console.Write("[ ");
    for (int i = 0; i <  newArray.Length; i++)
    {
        Console.Write(newArray[i] + ", ");
    }
    Console.Write("]");
    return sum;   
}
Console.Write("Input a number element: ");
int size = Convert.ToInt32( Console.ReadLine());
int sum = CreateArray(size);
Console.WriteLine();
Console.WriteLine($"the number of values is greater 0 = {sum}");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Intersection at a point: ({x};{y})");