using System;
using Zoolandia.Species;
namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            
            
            // AilurusFulgens redPanda = new AilurusFulgens("Steve");
            // redPanda.Name = "Steve";
            // string response = "Hello";


            // Console.WriteLine(redPanda.Name + " says " + response);

            // // This is saying that Joe is a new AilurusFulgens  
            // AilurusFulgens Joe = new AilurusFulgens("Joe");
            // Console.WriteLine(Joe.Welcome());
            // Console.WriteLine(Joe.Name);


            // PantheraLeo firePokemon = new PantheraLeo("Arcanine");
            // firePokemon.Name = "Arcanine";
            // Console.WriteLine(firePokemon.Name + " used " + firePokemon.SpecAbility());

            // CanisLupus wolfPokemon = new CanisLupus("Garurumon");
            // wolfPokemon.Name = "Garurumon";
            // wolfPokemon.Weight = 300;
            // Console.WriteLine("A " + wolfPokemon.Weight + " pound " +  wolfPokemon.Name + " used " + wolfPokemon.SpecAbility());
            // Console.WriteLine(firePokemon.Name + firePokemon.SmackDat(7) + firePokemon.SmackDat());

            //Habitat Exercise//

            ZoolandiaPart7.Forest newforest = new ZoolandiaPart7.Forest();
            newforest.public_name = "Oz Forest"; 
            newforest.theAnimals.Add("Lion");
            newforest.theAnimals.Add("Tigers");
            newforest.theAnimals.Add("Bears");

            ZoolandiaPart7.Mountain newmountain = new ZoolandiaPart7.Mountain();
            newmountain.public_name = "Stone Mountain";
            newmountain.theAnimals.Add("Eagle");
            newmountain.theAnimals.Add("Dragon");
            newmountain.theAnimals.Add("Fairy");

            Console.WriteLine("Habitat : " + newforest.public_name);
            foreach (string animal in newforest.theAnimals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("");

            Console.WriteLine("Habitat : " + newmountain.public_name);
            foreach (string animal in newmountain.theAnimals)
            {
                Console.WriteLine(animal);
            }
                     

        }
    }
}
