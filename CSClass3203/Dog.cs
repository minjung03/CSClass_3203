using System;

namespace Csclass_3203
{
    public class Dog
    {

        public int Age { get; set; }
        public string color { get; set; }

        public Dog()
        {
            this.Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine("Dog Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog Sleep");
        }

        public void Bark()
        {
            Console.WriteLine("Dog Bark"); ;
        }
    }
}