namespace Zoolandia.ZoolandiaPart4.BeastGenus.Species
{
    public class Ox: BeastGenus
        {
            public int NumberOfHorns()
                {
                    return 4;
                }

            public override bool Claws()
                {
                    return false;
                }  

            public override string SpecialAbility()
                {
                    return "Invulnerability";
                } 

            public override bool Evil()
                {
                    return false;
                }  

            public string Cousin()
                {
                    return "Minataour";
                }              
        }
}