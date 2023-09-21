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
        if (temp > 30)
        {
            Console.WriteLine("It is rather hot today, make sure to stay hydrated and avoid direct sunlight."); //warns user of hot day
        } else if (temp < 9) {
            Console.WriteLine("It is rather cold today, be sure to wear multiple layers. Maybe enjoy some hot cocoa!");
            //warns users if it is cold today
        } else {
            Console.WriteLine("The weather looks great, Have a good day!");
            //tells user to have a good day
        }
    }

}//outputs a good day message with current settings