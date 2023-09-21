using System;

public class GradeCheckr 
{
    public void Main()
    {
        Console.WriteLine("use this cool new program to see the grade of your exam!"); // intro message so you know what the program does
        Compare(100); // Insert grade here
    }

    public void Compare(int grade)
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