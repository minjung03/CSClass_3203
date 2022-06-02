using System;

namespace Csclass_3203
{
    public class Sample
    {
        public static int value = 42;

        static Sample()
        {
            value = 3203;
            Console.WriteLine("Sample() 정적 생성자 호출");
        }

        public Sample()
        {
            Console.WriteLine("Sample() 일반 생성자 호출");
        }
    }
}