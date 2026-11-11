// 1.3.1 Write a program in C# to calculate area of triangle, 
// square and rectangle. 
// Write 3 different functions for each shape to take dimensions of figure and display the area. 
// You may create menus.




double TriArea(double baseLength, double height)
{
    return baseLength * height / 2;
}

double SquareArea(double sideLength)
{
    return sideLength * sideLength;
}

double RectArea(double baseLength, double height)
{
    return baseLength * height;
}

string choice;

do
{
    Console.WriteLine("Choose a shape to calculate the area:\n\"s\" for Square\n\"t\" for Triangle\n\"r\" for Rectangle\n\"exit\" to exit the program");
    choice = Console.ReadLine().ToLower();
    Console.WriteLine("you selected " + choice);
    
    switch (choice)
    {
        case "s": //square
            Console.WriteLine("Enter the side length of the square: ");
            double sideLength = double.Parse(Console.ReadLine());
            double squareArea = SquareArea(sideLength);
            Console.WriteLine($"The area of a square with side length {sideLength} is: {squareArea}\n\n");    
            break;

        case "t": //triangle
            Console.WriteLine("Enter the base length of the triangle: ");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle: ");
            double height = double.Parse(Console.ReadLine());
            double triangleArea = TriArea(baseLength, height);
            Console.WriteLine($"The area of a triangle with base {baseLength} and height {height} is: {triangleArea}\n\n");
            break;

        case "r": //rectangle
            Console.WriteLine("Enter the base length of the rectangle: ");
            double rectBaseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle: ");
            double rectHeight = double.Parse(Console.ReadLine());
            double rectangleArea = RectArea(rectBaseLength, rectHeight);
            Console.WriteLine($"The area of a rectangle with base {rectBaseLength} and height {rectHeight} is: {rectangleArea}\n\n");
            break;

        case "exit":
            Console.WriteLine("Exiting program...");
            break;

        default: //invalid input
            Console.WriteLine("Invalid choice\n\n");
            break;
    }

} while (choice != "exit");