//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*int FindeBiggesDigit(int num)
{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec)
    max = ed;
    else
    max = dec;
    return max;
}
int number = new Random().Next(10, 100);
int biggestDigit = FindeBiggesDigit(number);
Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*int TwoDigitNumber(int num)
{
    int firstNumber = num % 10;
    int thirdNumber = num /100;
    int result = thirdNumber * 10 + firstNumber;
    return result;
}
int num = new Random().Next(100, 1000);
int twoDigitNumber = TwoDigitNumber(num);
int res = TwoDigitNumber(num);
Console.WriteLine("two Digit Number is " + res);
*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b. a и b - инфо от пользователя(тоже int)

/*bool MultipleNumber(int number, int a, int b)
{
    bool result;

    if (number % a == 0 && number % b == 0) 
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.Write("Input a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first divisor");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second divisor");
int b = Convert.ToInt32(Console.ReadLine());
 
bool res = MultipleNumber( number, a, b); 
Console.WriteLine(res);
*/
