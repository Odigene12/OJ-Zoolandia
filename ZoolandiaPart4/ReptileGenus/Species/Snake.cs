namespace Zoolandia.ZoolandiaPart4.Reptile.Species
{
    public class Snake: ReptileGenus
        {
            public bool Legs()
                {
                    return false;
                }
        
            public string MovementType()
                {
                    return "Slither";
                }
            public override int Teeth()
                {
                    return 2;
                }        

            public override string SpecialAbility()
                {
                    return "Mind Control";
                }
            
            public override bool Evil()
                {
                    return true;
                }
        
        }
}