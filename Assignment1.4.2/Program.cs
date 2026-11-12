/*
1.4.2
Write a class: “Student” with private data members: StudentId ( int), StudentFirstName (string), StudentLastName (string ), 
StudentGrade ( char ) and public properties for each data member. Instantiate the class and assign data to properties. 
Display the data back on console.
*/




//Student student1 = new Student(23, "Bob", "Mackie", 'C');

using System.Collections;

Student student1 = new Student();
student1.StudentId = 23;
student1.StudentFirstName = "Bob";
student1.StudentLastName = "Mackie";
student1.StudentGrade = 'C';
Console.WriteLine(student1); //uses overriden ToString() method


public class Student
{

    private int _studentId;
    private string _studentFirstName;
    private string _studentLastName;
    private char _studentGrade;


    public int StudentId
    {
        get { return _studentId; }
        set { _studentId = value; }
    }

    public string StudentFirstName
    {
        get { return _studentFirstName; }
        set { _studentFirstName = value; }
    }

    public string StudentLastName
    {
        get { return _studentLastName; }
        set { _studentLastName = value; }
    }

    public char StudentGrade
    {
        get { return _studentGrade; }
        set 
        {
            switch (value)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'F':
                    _studentGrade = value;
                    break;
                default:
                    throw new ArgumentException("Invalid value for grade");

            } 
        }
    }    
/*
    public Student(int studentId, string studentFirstName, string studentLastName, char studentGrade)
    {
        StudentId = studentId;
        StudentFirstName = studentFirstName;
        StudentLastName = studentLastName;
        StudentGrade = studentGrade;
    }
    public int StudentId { get; set; }
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public char StudentGrade { get; set; }
*/
    public override string ToString() => $"ID: {StudentId}\nName: {StudentFirstName} {StudentLastName}\nGrade: {StudentGrade}";


}


