namespace Week7Lecture1;
class Program
{
    static void Main(string[] args)
    {
        // create a new professor object
    Professor p1 = new Professor();
    p1.profname = "Alice";
    p1.classteach = "Java";
    p1.salary = 9000;

    Professor p2 = new Professor();
    p2.profname = "Bob";
    p2.classteach = "Math";
    p2.salary = 8000;

    Student s1 = new Student();
    s1.studentName = "Lisa";
    s1.classEnroll = "Java";
    s1.studentGrade = 90;

    Student s2 = new Student();
    s2.studentName = "Tom";
    s2.classEnroll = "Math";
    s2.studentGrade = 80;

    
    
    p1.PrintProfessorInfo();
    p2.PrintProfessorInfo();
    s1.PrintStudentInfo();
    s2.PrintStudentInfo();

    Console.WriteLine($"The salary difference between {p1.profname} and {p2.profname} is: {p1.salary - p2.salary}");
    Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {s1.studentGrade + s2.studentGrade}");
    

    }
}

class Professor
{
    public string profname;
    public string classteach;
    public double salary {get;set;}

    public void PrintProfessorInfo(){
    
    System.Console.WriteLine($"Professor {profname} teaches {classteach},and the salary is: {salary} ");

    }


}


class Student{
    //attributes
    public string studentName;
    public string classEnroll;

    public double studentGrade{get;set;}
    

    

    //behaviors
    public void PrintStudentInfo(){
        System.Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
 
    }
    }
    
    


