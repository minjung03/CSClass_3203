using System;

namespace Csclass_3203
{
    internal class Box
    {
        private int width;
        public int Width 
        {
            get { return width; }
            set {
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요");
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set {
                if (value > 0) height = value;
                else Console.WriteLine("양수를 입력해주세요");
            }
        }

        public Box(int width, int height)
        {
            this.Width = width; // Width의 set 함수 부분이 호출된다
            this.Height = height;
        }

        public int Area
        {
            get { return this.Width * this.Height; } // 각각의 get 함수 부분이 호출된다
        }
    }
}