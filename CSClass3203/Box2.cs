using System;

namespace Csclass_3203
{
    class Box2
    {
        private int width;
        private int heigth;

        public void setWidth(int width)
        {
            if (width > 0)
                this.width = width;
            else 
                Console.WriteLine("양수를 입력해주세요");
        }

        public void setHeight(int heigth)
        {
            if (heigth > 0)
                this.heigth = heigth;
            else
                Console.WriteLine("양수를 입력해주세요");
        }

        public int getWidth() {  return width; }
        public int getHeight() { return heigth; }

        public Box2(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public int Area()
        {
            return this.width * this.heigth;
        }
    }
}