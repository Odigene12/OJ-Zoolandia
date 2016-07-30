namespace Zoolandia.ZoolandiaPart4.PlayerGenus
{
    public class PlayerGenus: PlainAnimal
        {
            public virtual string Armor()
                {
                    return "Knight Armor";
                }
           public virtual string Weapons()
                {
                    return "One-Handed Sword";
                }    

           public bool Shield()
                {
                    return true;
                }

            public override string SpecialAbility()
                {
                    return "Penetrate";
                }  
        }
}