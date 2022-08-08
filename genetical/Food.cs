using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace genetical
{
    internal class Food
    {
        public Food(Color color)
        {
            this.color = new SolidBrush(color);
        }
        public Food(int x, int y)
        {
            rectangle.X = x;
            rectangle.Y = y;
        }
        public SolidBrush color = new SolidBrush(Color.Red);
        public Rectangle rectangle = new Rectangle(0, 0, 5, 5);
    }
}
