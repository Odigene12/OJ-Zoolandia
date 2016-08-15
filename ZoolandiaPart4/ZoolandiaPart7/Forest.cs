using System.Collections.Generic;
using Zoolandia.ZoolandiaPart7.HabitatInterfaces;
namespace Zoolandia.ZoolandiaPart7
{
    public class Forest: Habitats, IForest
        {
            public string weather()
                {
                    return "Cool";
                }

            public int numberoftrees()
                {
                    return 75;
                }

            public bool pond()
                {
                    return true;
                }

            public List<string> plants()
                {
                    return new List<string>() {"poison ivy", "poison oak", "cannibus"};
                }

        }
}