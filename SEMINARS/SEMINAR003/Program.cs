﻿/*int FindQuart(doubie x, double y)
{   int quart = 0;
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return quart;
}
Cosole.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.Read());
Console.Write("Input y-coordinate:");
double y = Convert.ToDouble(Console.Read());

Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)}quart");
*/
//Задание 1: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
/*void FindDipozon(int quart)
{   
    if (quart == 1) Console.WriteLine("x > 0 && y > 0");
    if (quart == 2) Console.WriteLine("x < 0 && y > 0");
    if (quart == 3) Console.WriteLine("x < 0 && y < 0");
    if (quart == 4) Console.WriteLine("x > 0 && y < 0");
    
}
Cosole.Write("Input quart: ");
double quart = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(FindDipozon(quart));
*/



//Задание 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*double FindDistance(double x1, double y1, double x2, double y2)
{
 double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
 return distance;
}
Console.WriteLine("Введите x1: ");
double x1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Растояние между точками = {FindDistance(x1,y1,x2,y2)}");
*/
//Задача №4. Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 
// 1 до N.

/*void WriteQ(int N)
{
    int count = 1;
    if(N<1)
    {
        Console.WriteLine("Input a number more 1");
    }
    else
    {
        while(count <=N)
        {
            Console.WriteLine(Math.Pow(count,2));
            count++;
        }
    }
}
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
WriteQ(N);
*/
