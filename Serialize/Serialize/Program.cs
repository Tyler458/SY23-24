using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serialize
{
    internal class Program
    {
        
        public class Cereal
        {
            public string name { get; set; }
            public string slogan { get; set; }
            public Boolean clarkeApproved { get; set; }
            public int calories { get; set; }
            public decimal price { get; set; }
            public string picture { get; set; }
        }
        static void Main(string[] args)
        {
            Cereal luckyCharms = new Cereal();
            luckyCharms.name = "Lucky Charms";
            luckyCharms.slogan = "They're magically delicious";
            luckyCharms.clarkeApproved = true;
            luckyCharms.price = 5.49m;
            luckyCharms.calories = 137;

            Cereal frootLoops = new Cereal();
            frootLoops.name = "Froot Loops";
            frootLoops.slogan = "Follow your nose";
            

            Cereal fruityPebbles = new Cereal();
            fruityPebbles.name = "Fruity Pebbles";
            fruityPebbles.slogan = "rocks your whole mouth";

            string jsonString = JsonSerializer.Serialize(luckyCharms);
            Console.WriteLine(jsonString);
            Console.ReadKey();
        }
    }
}
