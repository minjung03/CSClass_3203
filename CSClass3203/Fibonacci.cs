using System;
using System.Collections.Generic;

namespace Csclass_3203
{
    public class Fibonacci
    {

        private static Dictionary<int, long> memo =  new Dictionary<int, long>();
        // 한번 계산했던 값을 저장해두고 꺼내 쓰기위해 메모화 사용!

        public static long Get(int i)
        {
            Console.WriteLine("Get(" + i + ") 호출");
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }

            Console.WriteLine();
            if (memo.ContainsKey(i)) { return memo[i]; }
            else
            {
                return memo[i] = Get(i - 2) + Get(i - 1);

            }
        }
    }
}