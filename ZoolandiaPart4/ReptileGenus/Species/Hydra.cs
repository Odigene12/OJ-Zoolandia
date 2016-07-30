namespace Zoolandia.ZoolandiaPart4.Reptile.Species
{
    public class Hydra: ReptileGenus
        {
            public int NumberOfHeads {get; set;}
            public override string SkinType()
                {
                    return "Slimy";
                }
            public override int Teeth()
                {
                    return 70;
                }

            public string Breath()
                {
                    return "Stank";
                }

            public struct Personalities
                {
                    public string Mad()
                        {
                            return "GRRRRR";
                        }

                    public string Happy()
                        {
                            return "YAY!!!";
                        }

                    public int NumberOfTears()
                        {
                            return 1000;
                        }         
                }

            public override string SpecialAbility()
                {
                    return "Head Multiplication";
                }

            public override bool Evil()
                {
                    return true;
                }
        
        }
}