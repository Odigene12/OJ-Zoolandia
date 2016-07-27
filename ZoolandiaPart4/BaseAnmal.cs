namespace Zoolandia.ZoolandiaPart4
{
    public class PlainAnimal
        {
            public string Name {get; set;}

            public int WeightInPounds {get; set;}

            public int HeightInFeet {get; set;}

            public int NumberOfLegs {get; set;}

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