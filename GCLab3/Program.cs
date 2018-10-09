using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAgain;

            Console.WriteLine("The Information you already know game");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            do
            {
                Console.Clear();


                Console.WriteLine("Alright " + name + " Lets do this");

                Console.Write("Now pick a number from 1 to 100: ");
                int pickedNumber = Convert.ToInt32(Console.ReadLine());
                if (pickedNumber % 2 == 1 
                    && pickedNumber >= 1
                    && pickedNumber <= 100)
                {
                    Console.WriteLine(name + "you chose " +
                        pickedNumber + " and it is Odd");
                }
                else if (pickedNumber % 2 == 0 
                    && pickedNumber >= 1 
                    && pickedNumber <= 100)
                {
                    if (pickedNumber < 25)
                    {
                        Console.WriteLine(name + "That number is less than 25 " +
                            "and you picked " + pickedNumber);
                    }
                    else if (pickedNumber > 60)
                    {
                        Console.WriteLine(name + "you chose " + pickedNumber
                            + " And it is Even");
                    }
                    else Console.WriteLine(name + "That number is Even");

                }
                else Console.WriteLine("You didnt pick a supported number " + name);
                Console.Write("Do you want to pick another number "
                    + name + " y/n: ");
                doAgain = Console.ReadLine();
            } while (doAgain.ToLower() == "y" || doAgain.ToLower() == "yes");
            Console.WriteLine("Peace Out " + name);
            Console.ReadKey();
        }
    }
}
