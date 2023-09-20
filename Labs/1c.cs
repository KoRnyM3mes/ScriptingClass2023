using System;

public class pyramid
{
public void Main(string[] args)
{
    for (int i = 1; i < 6; i++) // Insert number of height where 6 is
    {
         Console.WriteLine(i);
         for(int n = 1; n <= i; n++)
         {
            Console.Write(i);
         }
    }
 }
} //should output 5 tall pyramid