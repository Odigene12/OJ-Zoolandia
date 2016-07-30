namespace Zoolandia.ZoolandiaPart4.PlayerGenus.Species
{
    public class Sorcerer: PlayerGenus
        {
            public string Garments()
                {
                    return "Sorcer Robes";
                }
           public override string Weapons()
                {
                    return "Mystic Powers";
                }

          public bool EyeOfAgamotto()
                {
                    return true;
                }

            public override string SpecialAbility()
                {
                    return "Immortality";
                }

            public override bool Evil()
                {
                    return true;
                }    
        
        }
}