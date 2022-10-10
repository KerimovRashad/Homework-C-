/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


/*string PalindromeNumber( int num)
{  
    string result  ="error";
    if(((num / 10000) > 0) && ((num / 10000) < 10))
    {

    
    if((((num / 10) % 10) == ((num / 1000 ) % 10)) && (num % 10 == num / 10000))
    
     result = "Yes";
    else result =  "No";
    }
    return  result;
        
} 

Console.Write("Input a number " );
int num = Convert.ToInt32(Console.ReadLine());
string palindromeNumber = PalindromeNumber(num);
Console.WriteLine(palindromeNumber);
*/


//Задача 21 .Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.8 A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double FindDistance(double x1, double y1, double x2, double y2, double z1, double z2)
{
 double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)) ;
    return distance ;
}
Console.WriteLine("input x1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"distance between points = {FindDistance(x1, y1, x2, y2, z1, z2 )}");
*/
/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void WriteQ(int N)
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
            Console.WriteLine(Math.Pow(count,3));
            count++;
        }
    }
}
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
WriteQ(N);
*/