using System;

public class ThermoSafe 
{
    public void Main()
    {
        Console.WriteLine("How is the weather today?"); // intro message so you know what the program does
        Compare(29); // Insert Temperature here
    }

    public void Compare(int temp)
    {
        if (temp < 31)
        {
            Console.WriteLine("The weather looks great, Have a good day!"); //encourages a good day
        } else {
            Console.WriteLine("It is rather hot today, make sure to stay hydrated and avoid direct sunlight.");
            //warns users of the current state of the weather
        }
    }

}