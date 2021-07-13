using System;
using System.Collections.Generic;
using System.Text;

namespace ZooKeeper
{
    class Lion : Animal, IAnimal
    {
        public string maneColour { get; set; }
        public void GetDescription()
        {
            Console.WriteLine("contains a " + Age + "-year-old " + Species +
                " with a " + maneColour + " mane.");
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("What colour is its mane? ");
            maneColour = Console.ReadLine().ToLower();
        }
    }
}
