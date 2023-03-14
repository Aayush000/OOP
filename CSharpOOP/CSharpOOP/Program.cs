using Characters.Warriors;
using System;

public class Program
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "Good Guy"); // control + . + enter --> shows different suggestions.
        Warrior theBadGuy = new Warrior(170, 100, "Bad Guy");
        
        Console.WriteLine(theGoodGuy.Height);
        Console.WriteLine(theBadGuy.Height);

        // Gets error saying the value is inaccessible.
        // theBadGuy.Height = 10;

        theGoodGuy.Greetings(theBadGuy); 
    }
}