using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame150519
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" GUSSING GAME");
            Random pickAword = new Random();
            int numOfGusses = 0;
            string[] words = new string[5];
            words[0] = "same";
            words[1] = "notsafe";
            words[2] = "world";
            words[3] = "map";
            words[4] = "computer";
            List<char> charit = new List<char>();
            string theWordIs = words[pickAword.Next(5)];
            foreach (char x in theWordIs)
            {
                Console.Write(" _ ");
                
                charit.Add(x);
            }
            Console.WriteLine();
            Console.WriteLine($"guess number: {numOfGusses}");
            Console.WriteLine("what is your guss?");
            char letter = Convert.ToChar( Console.ReadLine());
            Console.ReadLine();
        








        }
    }
}
