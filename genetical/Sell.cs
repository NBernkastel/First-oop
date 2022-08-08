using System.Drawing;
namespace genetical
{
    internal class Sell
    {

        public Sell(Color color)
        {
            this.color = new SolidBrush(color);
        }
        public Rectangle rectangle = new Rectangle(0, 0, 12, 12); 
        public float energi = 10;
        public int energifordel = 20;
        public SolidBrush color;
        public int stop = 0;
    }
}
