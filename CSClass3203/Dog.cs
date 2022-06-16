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
        public override void Eat()
        {
            Console.WriteLine("사료 먹음");
        }
    }
}