using System;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name) : base(name)
        {
            // don't need to do "This.name = name"
        }
        public override string SpecAbility()
        {
            // base will call the parent class
            return "Flamethrower";
        }

        public override string Evolution()
        {
            return "Mega Red Panda";
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