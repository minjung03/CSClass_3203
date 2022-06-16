using System;

namespace Csclass_3203
{
    public class Cat : Animal
    { 
        public void Meow()
        {
            Console.WriteLine("냐옹");
        }

        public override void Eat()
        {
            Console.WriteLine("참치 먹음");
        }
    }


}