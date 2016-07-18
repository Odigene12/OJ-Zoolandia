using System;

namespace Zoolandia.Species
{
    public class PantheraLeo : Animal
    {
        public PantheraLeo (string name) : base(name)
        {

        }

        public override string SpecAbility()
        {
            return "Hyper Beam";
        }

          public override string Evolution()
        {
            return "Mega King Leo";
        }

        public string Sound()
        {
            return "Roar";
        }
    }
}