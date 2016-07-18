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

        public string Weight {get; set;}

        public virtual string SpecAbility()
        {
            return "Mach Speed";
        }

        public virtual string Evolution()
        {
            return "No Evolution";
        }
    }
}