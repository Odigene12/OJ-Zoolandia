using System;

namespace Zoolandia.Species
{
    public class CanisLupus : Animal
    {
        public CanisLupus(string name) : base(name)
        {

        }

        public override string SpecAbility()
        {
            return "Ice Beam";
        }

        public override string Evolution()
        {
            return "Mega Werewolf";
        }

        public string Moon()
        {
            return "Howl";
        }
    }
}