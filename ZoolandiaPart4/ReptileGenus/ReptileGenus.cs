namespace Zoolandia.ZoolandiaPart4.Reptile
{
    public class ReptileGenus: PlainAnimal
        {
            public string Color {get; set;}
            public virtual string SkinType()
                {
                    return "Scales";
                }
            public virtual int Teeth()
                {
                    return 50;
                }

            public bool EyeOfAgamotto()
                {
                    return false;
                }

            public override string SpecialAbility()
                {
                    return "Immortality";
                }

        
        
        }
}