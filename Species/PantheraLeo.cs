using System;

namespace Zoolandia.Species
{
    public class PantheraLeo : Animal
    {
        public PantheraLeo (string name) : base(name)
        {
            this.Sound = "Roar";
        }

        public override string SpecAbility()
        {
            return "Fire Blast";
        }

          public override string Evolution()
        {
            return "Mega King Leo";
        }

        public string Sound{get; set;}
        
        public int Smacks{get; set;}
        public string SmackDat (int smacks)
        {
            this.Smacks = smacks;
            return " smacks dat biotch " + this.Smacks + " times in the face.";
        } 
        

        public string SmackDat()
        {
            return " smacks dat biotch in the face.";
        }

    }
}