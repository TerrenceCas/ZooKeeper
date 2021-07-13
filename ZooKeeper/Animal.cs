using System;
using System.Collections.Generic;
using System.Text;

namespace ZooKeeper
{
    class Animal
    {
        public int Age { get; set; }

        public string Species => GetType().Name.ToLower();

        public void SetAge()
        {
            Console.Write("How old is it? ");
            Age = Int32.Parse(Console.ReadLine());
        }
    }
}
