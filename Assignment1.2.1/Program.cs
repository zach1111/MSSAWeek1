//1.2.1 Write a C# Sharp program to accept two integers and check whether they are equal or not.

Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());


if (num1 == num2)
{
    Console.WriteLine($"{num1} is equal to {num2}");
}
else
{
    Console.WriteLine($"{num1} is not equal to {num2}");
}

