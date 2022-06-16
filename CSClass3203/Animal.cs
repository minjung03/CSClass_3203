using System;

namespace Csclass_3203
{
    public class Animal
    {
        public int Age { get; set; }

        public Animal()
        {
            this.Age = 0;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
}