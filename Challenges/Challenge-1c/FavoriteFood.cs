using System;

public class FoodFave
{
    public void Main()
    {
        Console.WriteLine("What is your top 3 favorite foods?"); 

        string[] foods = new string[3]; //array for foods

        foods[0] = Console.ReadLine();
        foods[1] = Console.ReadLine();
        foods[2] = Console.ReadLine();

        foreach (string i in foods)
        {
            Console.WriteLine("I love " + i + "!"); //Writes the same message for each item in the array
        }
        Console.ReadKey();
    }
}