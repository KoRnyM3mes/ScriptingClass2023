using System;

public class ThermoSafe 
{
    public Weathercheck checkweather;
    public void Main()
    {
        checkweather = new Weathercheck();
        Console.WriteLine("How is the weather today?"); // intro message so you know what the program does
        Compare(9); // Insert Temperature here
        checkweather.WeatherSwitch();
    }

    public void Compare(int temp)
    {
        if (temp > 30)
        {
            Console.WriteLine("It is rather hot today, make sure to stay hydrated and avoid direct sunlight."); //warns user of hot day
        } else if (temp < 10) {
            Console.WriteLine("It is rather cold today, be sure to wear multiple layers. Maybe enjoy some hot cocoa!");
            //warns users if it is cold today
        } else {
            Console.WriteLine("The weather looks great, Have a good day!");
            //tells user to have a good day
        }
    }

}//outputs a cold day message with current settings
public class Weathercheck
{
    public enum Weather //List of available weather conditions is here
    {
        Rain,
        Cloud,
        Clear,
        Fog
    }
    public Weather condition = Weather.Fog;//insert a weather here
    public void WeatherSwitch()
    {
        switch (condition)
        {
            case Weather.Rain:
            Console.WriteLine("There is also a chance of rain today, so be weary.");
            break;
            case Weather.Cloud:
            Console.WriteLine("It also looks like it will be cloudy today");
            break;
            case Weather.Clear:
            Console.WriteLine("Today will also have a clear sky!");
            break;
            case Weather.Fog:
            Console.WriteLine("Be cautious while driving, there seems to be fog today.");
            break;
        }
    }
} // should output a fog warning. Kind of silly to manually put in the condition lol.