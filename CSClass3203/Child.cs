using System;
namespace Csclass_3203
{
    public class Child : Parent
    {
        public string variable = "hiding";

        public void Method()
        {
            Console.WriteLine("자식의 메서드");
        }

        public override void Method2()
        {
            Console.WriteLine("자식의 메서드");
        }


        public Child() : base()
        {
            Console.WriteLine("자식 생성자");
        }

        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(String input) : base(input)");
        }

        public void CountChild()
        {
            Child.counter++;
        }
    }
}