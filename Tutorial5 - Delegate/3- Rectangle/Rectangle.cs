using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleSpace
{

    class Rectangle
    {
        public delegate void RectangleCalc();

        public decimal Width { get; set; }
        public decimal Length { get; set; }
        private void Area()
        {
            decimal area = this.Width * this.Length;
            Console.WriteLine($"Area of the rectangle = {area}");
        }
        private void Perimeter()
        {
            decimal Perimeter = (this.Width + this.Length)*2;
            Console.WriteLine($"Perimeter of the rectangle = {Perimeter}");
        }
        public void Calculate()
        {
            RectangleCalc rect = Area;
            rect += Perimeter;
            rect();
        }
        

    }
}
