using System;

namespace Csclass_3203
{
    public class Dog : Animal
    {
        public string color { get; set; }

        public void Bark()
        {
            base.Eat();
            Console.WriteLine("Dog Bark"); ;
        }
    }
}