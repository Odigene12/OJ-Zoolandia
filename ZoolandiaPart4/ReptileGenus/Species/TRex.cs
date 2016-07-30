namespace Zoolandia.ZoolandiaPart4.Reptile.Species
{
    public class TRex: ReptileGenus
        {
           public bool Intelligent()
                {
                    return false;
                }
        
           public string Eat()
                {
                    return "Carnivore";
                }
            public override int Teeth()
                {
                    return 40;
                }        

            public override string SpecialAbility()
                {
                    return "Head Crusher";
                }
            
            public override bool Evil()
                {
                    return true;
                }
        
        }
}