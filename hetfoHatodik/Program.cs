using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hetfoHatodik
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Laura";
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"{name} do you like cats?");
            Console.WriteLine(">>>>>>>>>>>>>>");
            string resp = Console.ReadLine();
            if (resp.ToLower().StartsWith("yes")) 
            {
                Console.WriteLine("awwwwwwww :3 :3");
            }
            else Console.WriteLine(" :((((");
            
        }
    }
}
