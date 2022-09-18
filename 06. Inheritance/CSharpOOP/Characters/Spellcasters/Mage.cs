using System;

namespace Characters.Spellcasters
{
    public class Mage : Character
    {
        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 30 && value <= 60)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Please use age between 18 and 45.");
                }
            }
        }

        public Mage()
        {

        }

        public Mage(int healthPoints, int weight, int age)
            : base(healthPoints, weight, age)
        {

        }

        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Mage");
        }
    }
}
