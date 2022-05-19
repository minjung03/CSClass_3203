using System;

namespace Csclass_3203
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime() // 메서드 첫글자는 대문자 (C# 스타일 (Java는 소문자))
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

}