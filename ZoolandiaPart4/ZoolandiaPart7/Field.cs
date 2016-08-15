using Zoolandia.ZoolandiaPart7.HabitatInterfaces;
namespace Zoolandia.ZoolandiaPart7
{
    public class Field: Habitats, IField
        {
            public string weather()
                {
                    return "Humid";
                }

            public bool grass()
                {
                    return true;
                }

            public bool lake()
                {
                    return false;
                }       
        }
}