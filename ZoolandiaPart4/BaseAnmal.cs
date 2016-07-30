namespace Zoolandia.ZoolandiaPart4
{
    public class PlainAnimal
        {
            public string Name {get; set;}

            public int WeightInPounds {get; set;}

            public int HeightInFeet {get; set;}

            public virtual int NumberOfLegs()
            {
                return 4;
            }

            public virtual string SpecialAbility()
                {
                    return "Regeneration";
                }

            public virtual bool Evil()
                {
                    return false;
                }    
        }
}