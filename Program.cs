using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            AilurusFulgens redPanda = new AilurusFulgens("Steve");
            redPanda.Name = "Steve";
            string response = "Hello";


            Console.WriteLine(redPanda.Name + " says " + response);

            // This is saying that Joe is a new AilurusFulgens  
            AilurusFulgens Joe = new AilurusFulgens("Joe");
            Console.WriteLine(Joe.Welcome());
            Console.WriteLine(Joe.Name);

            Console.ReadLine();
        }
    }
}
