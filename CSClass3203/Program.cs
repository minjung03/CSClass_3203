using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csclass_3203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            // 객체를 먼저 선언한 후, 오류나는 곳에 Alt+Enter -> 새 형식으로 class 만들기 클릭

            car.SetInTime();
            car.SetOutTime();
            // 메서드를 선언한 후, 오류나는 곳에 Alt+Enter -> 메서드 만들기 클릭 -> 함수 구현

            // 랜덤 
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

        }
    }
}