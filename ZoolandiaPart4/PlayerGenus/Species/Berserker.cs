namespace Zoolandia.ZoolandiaPart4.PlayerGenus.Species
{
    public class Berserker: PlayerGenus
        {
            public override string Armor()
                {
                    return "Gold Plated Wares";
                }
           public override string Weapons()
                {
                    return "Twin Axes";
                }

           public int VoicesInHead()
                {
                    return 10;
                }

            public override string SpecialAbility()
                {
                    return "Infinite Stamina";
                }

            public override bool Evil()
                {
                    return true;
                }         
        }
}