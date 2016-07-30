namespace Zoolandia.ZoolandiaPart4.BeastGenus
{
    public class BeastGenus : PlainAnimal
    {
        public bool Roar()
            {
                return true;
            }

        public virtual int Teeth()
            {
                return 30;
            }

        public override string SpecialAbility()
            {
                return "Super Strength";
            }

        public override bool Evil()
            {
                return true;
            }

        public virtual bool Claws()
            {
                return true;
            }    
    }
}
