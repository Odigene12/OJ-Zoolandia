namespace Zoolandia.ZoolandiaPart4.BeastGenus.Species
{
    public class WhiteTiger: BeastGenus
        {
            public bool Feathers() 
                {
                    return false;
                }

            public string SkinType()
                {
                    return "White Skin";
                }

           public int NumOfCubs()
                {
                    return 5;
                }

            public override string SpecialAbility()
                {
                    return "Invisibility";
                }          
        }
}