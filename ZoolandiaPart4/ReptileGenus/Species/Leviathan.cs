namespace Zoolandia.ZoolandiaPart4.Reptile.Species
{
    public class Leviathan: ReptileGenus
        {
            public interface ISummon
            {                    
                 void MPUsage();      
            }
        
        public string Element()
            {
                return "Water";
            }
            public override int Teeth()
                {
                    return 25;
                }

            public struct SummoningConditions
                {
                    public string PartyLeaderStatus()
                        {
                            return "Party Leader Petrified";
                        }
                    
                    public int MinNumberInParty()
                        {
                            return 3;
                        }
                }

            public struct Attacks
                {
                    public string TailWhip()
                        {
                            return "Whip";
                        }

                    public string Raor()
                        {
                            return "Screeeech!!!";
                        }

                    public string Tsunami()
                        {
                            return "Gather Ocean and Drown";
                        }         
                }

            public override string SpecialAbility()
                {
                    return "Intangibility";
                }

        
        }
}