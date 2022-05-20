using System;

namespace Csclass_3203
{
    /// <summary>
    /// 자동차 주차장 입차, 출차 시간을 저장하는 클래스 입니다.
    /// </summary>
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;
        
        /// <summary>
        /// 자동차 입차 시간을 지정합니다.
        /// </summary>
        public void SetInTime() // 메서드 첫글자는 대문자 (C# 스타일 (Java는 소문자))
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차 출차 시간을 지정합니다.
        /// </summary>
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

}