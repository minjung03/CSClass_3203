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
            /*
            List<int> list = new List<int>();
            
            list.Add(3);
            list.Add(2);
            list.Add(0);
            list.Add(3);
            */

            List<int> list = new List<int>() { 3,2,0,3 }; // 한번에 추가 가능
            list.Remove(0); // 0이라는 값을 지운다

            foreach (var item in list) // foreach문을 사용하도록 하자
            {
                Console.WriteLine("Count:"+list.Count + "\titem:"+item);
            }
            Console.WriteLine();


            // Math 클래스
            Console.WriteLine(Math.Abs(-52273));     // 절대값
            Console.WriteLine(Math.Ceiling(52.273)); // 올림
            Console.WriteLine(Math.Floor(52.273));   // 내림
            Console.WriteLine(Math.Max(52, 273)); 
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));   // 반올림
            Console.WriteLine(Math.PI);

        }
    }
}