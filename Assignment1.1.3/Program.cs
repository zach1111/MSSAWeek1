Console.WriteLine("Please provide the numerator: ");
int num1 = int.Parse(Console.ReadLine());    

Console.WriteLine("Please provide the denominator: ");
int num2 = int.Parse(Console.ReadLine());

int result = num1 / num2;
int remainder = num1 % num2; 


Console.WriteLine($"The result of dividing {num1} by {num2} is {result} with a remainder of {remainder}");
