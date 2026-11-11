//1.2.2 Write a C# Sharp program to find the sum of first 10 natural numbers.


int sum = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    sum += i;
}

Console.WriteLine($"The sum is: {sum}");