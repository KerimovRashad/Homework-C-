/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int SecondDigitNumber(int num)
{
    int Number = num % 100 % 10;
    int result = Number;
    return result;
}
int num = new Random().Next(100, 1000);
int secondDigitNumber = SecondDigitNumber(num);
int result = secondDigitNumber;
Console.WriteLine("Fisth Thrid Number is " + result);
*/
/*Задача 13: Напишите программу, которая выводит туретью цифр заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*int ThirDigitdNumber(int num)

{   if( num < 100 )
    {
       Console.WriteLine("there is no third digit");
    }
    else
    {

     if(num >1000)
   { 
    do
    {
        num = num / 10;
    }
    while(num >1000);
    
    }
    num = num % 10;
    }
    return num;
        
}
Console.WriteLine("Input a number");
int num = Convert.ToInt32(Console.ReadLine());
int thirDigitdNumber = ThirDigitdNumber(num);
Console.WriteLine( thirDigitdNumber);
*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*string FindWeekends(int num)
 {
   string result;
   if ((num > 0) && (num < 8))
   {

    if ((num == 6) || (num == 7)) result = "Yes";
    else result = "no";
    }
    else result = "there is no such day of the week";
    return result;
 }
Console.WriteLine("Input a number");
int num = Convert.ToInt32(Console.ReadLine());
string  findWeekendsr = FindWeekends(num);
Console.WriteLine( findWeekendsr);
*/