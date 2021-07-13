using System;
using System.Collections.Generic;
using System.Text;

namespace ZooKeeper
{
    class Bear : Animal, IAnimal
    {
        public string grizzly { get; set; }
        public void GetDescription()
        {
            Console.WriteLine("contains a " + Age + "-year-old " + 
                grizzly + Species + ".");
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("Is it a grizzly bear (true/false)? ");
            string answer = Console.ReadLine().ToLower();
            bool isGrizzly = true;

            if (answer == "no" ||
                !isGrizzly == Convert.ToBoolean(answer))
            {
                grizzly = "non-grizzly ";
            }
            else if (answer == "yes" ||
                isGrizzly == Convert.ToBoolean(answer))
            {
                grizzly = "grizzly ";
            }
            else
            {
                Console.Write("unspecified type of ");
                grizzly = Console.ReadLine();
            }
        }
    }
}
