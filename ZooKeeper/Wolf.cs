using System;
using System.Collections.Generic;
using System.Text;

namespace ZooKeeper
{
    class Wolf : Animal, IAnimal
    {
        public int speed { get; set; }
        public void GetDescription()
        {
            Console.WriteLine("contains a " + Age + "-year-old " + Species +
                " that runs " + speed + " km/h.");
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("How fast can it run (in km/h)? ");
            speed = Int32.Parse(Console.ReadLine());
        }
    }
}