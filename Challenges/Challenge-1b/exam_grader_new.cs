using System;

public class GradeChecker 
{
    public SubjectChecker checksubject;
    public void Main()
    {
        checksubject = new SubjectChecker();
        Console.WriteLine("use this cool new program to see the grade of your exam!"); // intro message so you know what the program does
        Grade(100); // Insert grade here
        Console.WriteLine("By the way, what is your favorite subject?");
        checksubject.SubCheck();
    }

    public void Grade(int grade)
    {
        if (grade >= 90)
        {
            Console.WriteLine("You got an A! Amazing job!"); //result for A
        } else if (grade >= 80) {
            Console.WriteLine("You got a B, good job!");//Result for B
        } else if (grade >= 70) {
            Console.WriteLine("You got a C, you passed.");//Result for C
        } else if (grade >= 60){
            Console.WriteLine("You got a D, at least you passed.");//Result for D
        } else {
            Console.WriteLine("You got an F, you've failed!");//Result for F
        }

    }
}
public class SubjectChecker
{
    public enum Subject //List of available subjects is here
    {
        Math,
        Science,
        History,
        Music
    }
    public Subject FaveSubject = Subject.Music;//insert a subject here
    public void SubCheck()
    {
        switch (FaveSubject)
        {
            case Subject.Math:
            Console.WriteLine("Algebra, Triginometry, Calculus, I'm sure you'll get the hang of all of them!");
            break;
            case Subject.Science:
            Console.WriteLine("Theres a whole lot of different sciences, good choice! Don't forget to study.");
            break;
            case Subject.History:
            Console.WriteLine("History is very interesting, studying all of the different time periods is thrilling!");
            break;
            case Subject.Music:
            Console.WriteLine("What an amazing art form, I wonder what theory goes into it?");
            break;
            default:
            Console.WriteLine("I'm sure thats an excellent choice to study, have fun learning about it!");//generic answer
            break;
        }
    }
} // should output a score of A message and subject Music