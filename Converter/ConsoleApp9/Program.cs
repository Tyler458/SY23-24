using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers of liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);
           
            Console.WriteLine("Type 1 for Fluid ounce \nType 2 for Gill \nType 3 for Pint \nType 4 for Quart \nType 5 for Gallon \nType 6 for Tablespoon \nType 7 for Teaspoon \nType 8 for Cup ");
            int num = 0;
            int.TryParse(Console.ReadLine(),out num);

            switch (num)
            {
                case 1:
                    Console.WriteLine(liters * 33.814 + " Fluid ounce");
                    break;
                case 2:
                    Console.WriteLine(liters * 8.45351 + " Gill");
                    break;
                case 3:
                    Console.WriteLine(liters * 2.11338 + " Pint");
                    break;
                case 4:
                    Console.WriteLine(liters * 1.05669 + " Quart");
                    break;
                case 5:
                    Console.WriteLine(liters * 0.264172 + " Gallon");
                    break;
                case 6:
                    Console.WriteLine(liters * 67.628 + " Tablespoon");
                    break;
                case 7:
                    Console.WriteLine(liters * 202.884 + " Teaspoon");
                    break;
                case 8:
                    Console.WriteLine(liters * 4.22675 + " Cup");
                    break;

                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }
            Console.ReadLine();
            /*for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadKey(); */

            /* if (num == 1)
                 Console.WriteLine(meters * 3.28084 + "feet");

             if (num == 2)
                 Console.WriteLine(meters * 1.09361 + "yards");
             Console.ReadLine(); */

        }
    }
}
