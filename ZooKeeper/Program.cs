using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> list = new List<IAnimal>();
            while (list.Count <= 2)
            {
                Console.Write("\nCage " + (list.Count + 1) +
                    "\nWhat is the animal’s species? ");
                string species = Console.ReadLine().ToLower();

                switch (species)
                {
                    case "lion":
                        Lion lion = new Lion();
                        lion.SetAge();
                        lion.RequestUniqueCharacteristic();
                        list.Add(lion);
                        break;

                    case "wolf":
                        Wolf wolf = new Wolf();
                        wolf.SetAge();
                        wolf.RequestUniqueCharacteristic();
                        list.Add(wolf);
                        break;

                    case "bear":
                        Bear bear = new Bear();
                        bear.SetAge();
                        bear.RequestUniqueCharacteristic();
                        list.Add(bear);
                        break;

                    default:
                        Console.WriteLine("We dont take-in that animal. " +
                            "Try lion, wolf bear.");
                        break;
                }
            }
            Console.WriteLine("=====");
            int cageNum = 1;
            foreach (var animal in list)
            {
                Console.Write($"Cage {cageNum++} ");
                animal.GetDescription();
            }
        }
    }
}
