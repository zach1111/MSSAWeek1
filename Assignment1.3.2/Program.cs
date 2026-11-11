//Write a console application in C# to explore different ways in which array is declared and initialized 
//and explore different properties and methods of Array class.



//declare and initialize arrays 4 ways
string[] cars = new string[4];
cars[0] = "Volvo";
cars[1] = "BMW";
cars[2] = "Ford";
cars[3] = "Mazda";

string[] vehicles = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

string[] trucks = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

string[] makes = {"Volvo", "BMW", "Ford", "Mazda"};


string[][] arrayOfArrays = {cars, vehicles, trucks, makes};

foreach(string[] i in arrayOfArrays)
{
    Console.WriteLine($"Array:");
    foreach(string j in i)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}