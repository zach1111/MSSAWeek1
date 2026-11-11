/*
1.2.3 Write a menu driven application to perform calculation functions like 
addition, subtraction, multiplication, and division. 
Call them appropriately when user selects the option. 
Give the user the option to continue or exit the program.
*/


bool continueProgram = true;
int num1, num2;

while (continueProgram){

    Console.WriteLine("\n\n\nSelect an operation:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1: //addition
            Console.WriteLine("Enter the first number to add:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to add:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
            break;

        case 2: //subtraction
            Console.WriteLine("Enter the first number to subtract from:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the number to subtract from {num1}:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result of {num1} - {num2} is: {num1 - num2}");
            break;

        case 3: //multiplication
            Console.WriteLine("Enter the first number to multiply:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to multiply:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The product of {num1} and {num2} is: {num1 * num2}");
            break;

        case 4: //division
            Console.WriteLine("Enter the dividend:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            num2 = int.Parse(Console.ReadLine());
            if (num2 != 0)
            {
                Console.WriteLine($"The result of {num1} / {num2} is: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            break;

        case 5: //exit
            Console.WriteLine("Exiting calculator...");
            continueProgram = false;
            break;

        default: //invalid choice
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
}