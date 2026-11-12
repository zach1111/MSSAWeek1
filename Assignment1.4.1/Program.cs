/*
1.4.1
Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. 
Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. 
( if p1.x is more than p2.x , it is to the right )
*/

Point P1 = new Point (10, 9.5);
Console.WriteLine($"P1: {P1.ToString()}");

//prompt user for P2 coordinates, create P2
Console.Write("Give me an x! ");
double userX = double.Parse(Console.ReadLine());

Console.Write("Give me a y! ");
double userY = double.Parse(Console.ReadLine());

Point P2 = new Point (userX, userY);

Console.WriteLine($"Your P2 is {P2.ToString()}");

double xDiff = P2.xCoord - P1.xCoord; //positive == P2 is right of P1   0 == P2 P1 equal      negative == P2 left of P1


switch (xDiff)
{
    case > 0:
        Console.WriteLine("P2 is right of P1");
        break;
    case < 0:
        Console.WriteLine("P2 is left of P1");
        break;
    case 0:
        Console.WriteLine("P2 and P1 are on same x coordinate");
        break;
    default:
        Console.WriteLine("Unexpected error");
        break;
}
    


public struct Point
{
    public Point(double XCoord, double YCoord)
    {
        xCoord = XCoord;
        yCoord = YCoord;
    }

    public double xCoord { get; }
    public double yCoord { get; }

    public override string ToString() => $"({xCoord}, {yCoord})";

}

