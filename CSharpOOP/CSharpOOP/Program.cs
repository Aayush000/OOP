using Characters.Warriors;
using System;

public class Program
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior();
        Warrior secondWarrior = new Warrior(150, 50);
        Warrior thirdWarrior = new Warrior(140, 78, "I am the third warrior!");

        //Warrior theGoodGuy = new Warrior(190, 80, "Good Guy"); // control + . + enter --> shows different suggestions.
        //Warrior theBadGuy = new Warrior(170, 100, "Bad Guy");
        
        //Console.WriteLine(theGoodGuy.Height);
        //Console.WriteLine(theBadGuy.Height);

        //theGoodGuy.Age = 25;
        //theBadGuy.Age = 15;

        //try
        //{
        //    theGoodGuy.Age = 25;
        //    theBadGuy.Age = 15;
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //Console.WriteLine(theGoodGuy.Age);
        //Console.WriteLine(theBadGuy.Age);

        //theGoodGuy.Greetings("Tod");
        //Console.WriteLine(theGoodGuy.SwordWeapon.Damage);
    }
}