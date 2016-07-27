using System;

namespace Zoolandia
{
    public abstract class Animal
    {
        // This is a contructor for the Animal class
        public Animal (string name)
        {
            this.Name = name;
        }
        public String Name {get; set;}

        public int Weight {get; set;}

        public virtual string SpecAbility()
        {
            return "Mach Speed";
        }

        public virtual string Evolution()
        {
            return "No Evolution";
        }

        public virtual string Eat(int numberOfFoodz)

        {
            return "Yum";
        }
    }
}