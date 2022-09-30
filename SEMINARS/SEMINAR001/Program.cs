/*        Console.Write("Input a first number:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number;");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int quad2 = n1 * n2;

        if (n1 == quad2)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        */
// Задача 2
/*Console.Write("Input a namber: ");
int number = Convert.ToInt32(Console.ReadLine());

int current;

if(number > 0)
{
    current = -number;
}
else
{
    current = number;
    number *= -1;
}
while(current <= number)
{
        Console.Write(current + " ");
        current++;
    
}
*/
// Задача3

Console.Write("input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    Console.WriteLine($"Last digit of {n} is {n % 10}");
}
else
{
    Console.WriteLine("Uncorrent input"!);
}