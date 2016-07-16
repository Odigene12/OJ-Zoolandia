using System;

namespace Zoolandia
{
    public class Animal
    {
        // This is a contructor for the Animal class
        public Animal (string name)
        {
            this.Name = name;
        }
        public String Name {get; set;}

        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!";
        }
    }
}