using Enumerations;
using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior : Character
    {
        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 70;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Warrior";

        private readonly int id;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        private static int idCounter;

        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            set
            {
                idCounter = value;
            }
        }
        
        private int height;
        private Sword swordWeapon;
        private Faction faction;

        public int ID
        {
            get
            {
                return this.id;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
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
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = Faction;
            }
        }


        public Warrior()
            : this(170, 70)
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, "Young Warrior", Faction.Default)
        {
        }

        public Warrior(int height, int weight, string name, Faction faction)
        {
            IdCounter++;

            this.id = IdCounter;
            this.Height = height;
            base.Weight = weight;
            this.Name = name;
            base.Age = 18;
            this.SwordWeapon = new Sword();
            this.Faction = faction;

            if (this.faction == Faction.GoodGuy)
            {
                base.HealthPoints = 120;
            }
            else if (this.faction == Faction.BadGuy)
            {
                base.HealthPoints = 100;
            }
        }

        public Warrior(int healthPoints, int weight, int age)
            : base(healthPoints, weight, age)
        {

        }

        public void SpecialWarriorGreeting()
        {
            base.Greetings(base.Name);
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"\nDefault Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefault Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");
        }

        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Warrior");
        }
    }
}