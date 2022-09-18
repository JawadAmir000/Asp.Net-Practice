using System;
using System.Threading;

namespace Characters
{
    public class Character
    {
        private int weight;
        private int healthPoints;
        private string name;

        protected int age;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public virtual int Age
        {

            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Please use age between 18 and 45.");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Character()
        {

        }

        public Character(int healthPoints, int weight, int age)
        {
            this.HealthPoints = healthPoints;
            this.Weight = weight;
            this.Age = age;
        }

        protected void Greetings(string name)
        {
            Console.WriteLine($@"{this.name} greets {name}");
        }
        
        public virtual void Move(int pauseBetweenMovements)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving!");
                Thread.Sleep(pauseBetweenMovements);
            }
        }
    }
}
