using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Hello, What's your name? \n");
            string name = System.Console.ReadLine();
            System.Console.Write("Nice to see you, " + name + "\n \n");
            char[] ans = { 'a', 'e', 'f','h','l','m','n','o','r','s','x'};
            int counter = 0;
            foreach (char letter in name)
            {
                if (ans.Contains(char.ToLower(letter)))
                {
                    System.Console.WriteLine("Give me an " + letter + "\n");
                }
                else
                {
                    System.Console.WriteLine("Give me a " + letter + "\n");
                }
                counter += 1;
                if (counter == name.Length)
                {
                    System.Console.WriteLine(name.ToUpper() + " is GRAND!!!! \n");
                }
            }
            System.Console.WriteLine("Press return to exit . . .");
            System.Console.ReadKey();
        }
    }
}
