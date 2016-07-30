namespace Zoolandia.ZoolandiaPart4.BeastGenus.Species
{
    public class Griffin: BeastGenus
        {
            public bool Feathers() 
                {
                    return true;
                }

            public string Backside()
                {
                    return "Lion";
                }

            public string MouthType()
                {
                    return "Beak";
                }  

            public override string SpecialAbility()
                {
                    return "Mach Speed";
                }   

            public override bool Evil()
                {
                    return false;
                }          
        }
}