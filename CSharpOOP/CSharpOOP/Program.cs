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

        theGoodGuy.Age = 25;
        theBadGuy.Age = 15;

        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(theGoodGuy.Age);
        Console.WriteLine(theBadGuy.Age);

        theGoodGuy.Greetings(theBadGuy); 
        theBadGuy.Greetings(theGoodGuy); 
    }
}