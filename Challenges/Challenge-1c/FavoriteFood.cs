using System;

public class FoodFave
{
    public void Main()
    {
        Console.WriteLine("What is your top 3 favorite foods?"); 
        string[] foods = {"Hamburger", "Pizza", "Olives"}; // input foods here
        foreach (string i in foods)
        {
            Console.WriteLine("I love " + i + "!"); //Writes the same message for each item in the array
        }
    }
}