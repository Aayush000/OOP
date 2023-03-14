public class Warrior
{
    // Fields
    public int height;
    public int width;
}

public class Program
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior();
        theGoodGuy.height = 190;
        theGoodGuy.width = 80;

        Warrior theBadGuy = new Warrior();
        theBadGuy.height = 170;
        theBadGuy.width = 100;

        Console.WriteLine(theGoodGuy.height);
    }
}