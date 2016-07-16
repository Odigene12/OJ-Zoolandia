using System;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name) : base(name)
        {
            // don't need to do "This.name = name"
        }
        public override string Eat(int numberOfFoodz)
        {
            // base will call the parent class
            string animalEat = base.Eat(3);
            return "Nom nom nom";
        }

        public string Eat(){
            return "I don't know what I just ate, but it was good";
        }

        public string Welcome (string name)
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, " + this.Name;
        }
    }
}