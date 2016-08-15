using Zoolandia.ZoolandiaPart7.HabitatInterfaces;
namespace Zoolandia.ZoolandiaPart7
{
    public class Mountain: Habitats, IMountain
        {
            public string weather()
                {
                    return "Windy and Cold";
                }

            public string Cave()
                {
                    return "Cave of Wonders";
                }

             public bool ice()
                {
                    return true;
                }  
        }
}