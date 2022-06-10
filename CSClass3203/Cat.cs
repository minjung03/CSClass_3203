using System;

namespace Csclass_3203
{
    public class Cat
    {
        public int Age { get; set; }

        public Cat()
        {
            this.Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine("Cat Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Cat Sleep");
        }

        public void Meow()
        {
            Console.WriteLine("Cat Meow");
        }
    }
}