/*
1.3.3
Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2
*/


Console.WriteLine("Input the number of elements to store in the array: ");
int arrSize = int.Parse(Console.ReadLine());
int[] myArr = new int[arrSize];

for (int i = 0; i < arrSize; i++)
{
    Console.Write($"element {i} : ");
    myArr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The values stored in the array are:");
foreach (int i in myArr)
{
    Console.Write(i + " ");
}
/*
Console.WriteLine("\nThe values stored in the array in reverse are:");
Array.Reverse(myArr);
foreach(int i in myArr)
{
    Console.Write(i + " ");
}

*/


//reverse array 
int holdNum1;
for (int i = 0; i < myArr.Length/2; i++)
{
    holdNum1 = myArr[i];
    myArr[i] = myArr[myArr.Length-i-1];
    myArr[myArr.Length-i-1] = holdNum1;
}

Console.WriteLine("\nReversed array: ");
foreach (int i in myArr)
{
    Console.Write(i + " ");
}