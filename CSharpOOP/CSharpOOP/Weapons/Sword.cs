﻿
namespace Weapons
{
    public class Sword
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public Sword()
        {
            this.Damage = 10;
        }
    }
}
