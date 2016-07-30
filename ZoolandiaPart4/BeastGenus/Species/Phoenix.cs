namespace Zoolandia.ZoolandiaPart4.BeastGenus.Species
{
    public class Phoenix: BeastGenus
        {
            public bool Feathers() 
                {
                    return true;
                }

           public string Element()
                {
                    return "Fire";
                } 

            public int SpeedInMiles()
                {
                    return 200;
                }    

            public override string SpecialAbility()
                {
                    return "Rebirth";
                }         
        }
}