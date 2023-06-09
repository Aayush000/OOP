﻿using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        /* Fields are mostly used for internal use while properties are used mostly for external use.   */

        // Fields - private access modifiers to make sure it can be accessible only within the class.
        private int height; // fields small letter.
        private int weight;
        private string name;
        private int age;
        private Sword swordWeapon;
        // select all the fields and hit ctrl + . + enter --> autogenerates the constructor for you.


        // properties start with capital letter.
        // get and set are accessors.
        public int Height 
        { 
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }  // type prop and enter to get autogenerated property.
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    this.age = value;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException(string.Empty, $"The selected age for {name} is not proper age of warrier. It should be between 18 and 45.");
                    Console.WriteLine("Error");

                }
            }
        }
        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        // Constructors are public
        // There can be multiple constructors.

        // Default constructor
        public Warrior()
            : this(170, 70) // default height and weight for second constructor. age, name, swordweapon are
                            // already in second constructor, so no need to repeat here so just remove it.
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, "Young Warrior") // height and weight will come from user and "young warrior"
                                                    // is passed to third constructor as it needs it and age and
                                                    // swordweapon is already in third constructor so no need to
                                                    // repeat.
        {
        }

        public Warrior(int height, int weight, string name)
        {
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = 18;
            this.SwordWeapon = new Sword(); // press f12 to go to that class.
        }

        public Warrior(int height, int weight, string name, int age, Sword swordWeapon)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.age = age;
            this.swordWeapon = swordWeapon;
        }

        public void Greetings(string name) // passed object as an argument
        {
            Console.WriteLine($"{this.name} Greetings, {name}");
        }
    }
}
