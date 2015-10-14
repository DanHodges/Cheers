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
            System.Console.Write("Hey , " + name + " what's your birthday? (MM/DD) \n");
            string birthday = System.Console.ReadLine();
            DateTime objMyBirthday = DateTime.Parse(birthday);
            DateTime now = DateTime.Now;
            int numDays = (objMyBirthday - now).Days;
            string happyB;
            if (numDays == 0)
            {
                happyB = "It's Your Birthday!!!";
                System.Console.Write("if has come");
            }
            else
            {
                happyB = null;
                if (numDays < 0)
                {
                    numDays += 366;
                }
                else
                {
                    numDays += 1;
                }
            }
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
            if (happyB == null)
            {
                System.Console.WriteLine("Your birthday is " + numDays + "days away \n");
            }
            else
            {
                System.Console.WriteLine(happyB);
            }
            System.Console.WriteLine("Press return to exit . . .");
            System.Console.ReadKey();
        }
    }
}
