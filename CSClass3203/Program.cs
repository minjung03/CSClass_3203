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

            
            // 랜덤 클래스
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10+"\n");

          
            // 리스트 클래스
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            list.Add(0);
            list.Add(3);

            foreach(int i in list) // foreach문을 사용하도록 하자
            {
                Console.Write(i);
            }
            Console.WriteLine();

        }
    }
}