using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace genetical
{
    internal class GameEngine
    {
        public GameEngine(decimal numericSells, decimal numericfoods, int Width, int Height)
        {
            startsells = (int)numericSells;
            startfoods = (int)numericfoods;
            this.Width = Width;
            this.Height = Height;
        }
        private List<Sell> sells;
        private List<Food> foods;
        private int startsells, startfoods;
        private int Width, Height;

        Random random = new Random();
        public void gamestart()
        {
            sells = new List<Sell>(startsells);
            foods = new List<Food>(startfoods);
            for (int i = 0; i < sells.Capacity; i++)
            {
                sells.Add(new Sell(Color.Aqua));
            }
            for (int i = 0; i < foods.Capacity; i++)
            {
                foods.Add(new Food(Color.FromArgb(random.Next())));
            }
            for (int i = 0; i < sells.Count; i++)
            {
                sells[i].rectangle.X = random.Next(Width);
                sells[i].rectangle.Y = random.Next(Height);
            }
            for (int i = 0; i < foods.Count; i++)
            {
                foods[i].rectangle.X = random.Next(Width);
                foods[i].rectangle.Y = random.Next(Height);
            }
        }
        public void age()
        {
            for (int i = 0; i < sells.Count; i++)
            {
                sells[i].energi -= 0.1f;
                if (sells[i].energi <= 0)
                    sells.Remove(sells[i]);
            }
        }
        private void deleni(int x, int y, int i)
        {
            bool mutation = !Convert.ToBoolean(random.Next(15));
            if (mutation)
                sells.Add(new Sell(Color.Red));
            else
                sells.Add(new Sell(Color.Aqua));
            sells[sells.Count - 1].rectangle.X = x + random.Next(-15, 15);
            sells[sells.Count - 1].rectangle.Y = y + random.Next(-15, 15);
        }
        private void collision()
        {
            for (int i = 0; i < sells.Count; i++)
            {
                for (int j = 0; j < foods.Count; j++)
                {
                    if (sells[i].rectangle.IntersectsWith(foods[j].rectangle))
                    {
                        sells[i].energi += 5;
                        foods.Remove(foods[j]);
                        if (sells[i].energi >= sells[i].energifordel)
                        {
                            deleni(sells[i].rectangle.X, sells[i].rectangle.Y, i);
                            sells[i].energi -= 12;
                            sells[i].stop = 20;
                        }
                    }
                }
            }
        }
        private double distant(int i)
        {
            double distanse = double.MaxValue;
            double dnow;
            for (int j = 0; j < foods.Count; j++)
            {
                dnow = Math.Sqrt((foods[j].rectangle.X - sells[i].rectangle.X) * (foods[j].rectangle.X - sells[i].rectangle.X) + (foods[j].rectangle.Y - sells[i].rectangle.Y) * (foods[j].rectangle.Y - sells[i].rectangle.Y));
                if (dnow < distanse)
                {
                    distanse = dnow;
                }
            }
            return distanse;
        }
        private int closestfood(int i)
        {
            double distanse = double.MaxValue;
            double dnow;
            int ret = 0;
            for (int j = 0; j < foods.Count; j++)
            {
                dnow = Math.Sqrt((foods[j].rectangle.X - sells[i].rectangle.X) * (foods[j].rectangle.X - sells[i].rectangle.X) + (foods[j].rectangle.Y - sells[i].rectangle.Y) * (foods[j].rectangle.Y - sells[i].rectangle.Y));
                if (dnow < distanse)
                {
                    distanse = dnow;
                    ret = j;
                }
            }
            return ret;
        }
        public void foodspawn()
        {
            foods.Add(new Food(random.Next(Width), random.Next(Height)));
        }
        public void runmove()
        {
            for (int i = 0; i < sells.Count; i++)
            {
                if (foods.Count > 0)
                {
                    move(i);
                }
                if (sells[i].stop > 0)
                    sells[i].stop--;
            }
            collision();
        }
        private void move(int i)
        {
            if (sells[i].stop == 0)
            {
                sells[i].rectangle.X += (int)(3f * (foods[closestfood(i)].rectangle.X - sells[i].rectangle.X) / distant(i));
                sells[i].rectangle.Y += (int)(3f * (foods[closestfood(i)].rectangle.Y - sells[i].rectangle.Y) / distant(i));
            }
        }
        public int getsellscount()
        {
            return sells.Count;
        }
        public int getfoodscount()
        {
            return foods.Count;
        }
        public Sell getsell(int i)
        {
            return sells[i];
        }
        public Food getfood(int i)
        {
            return foods[i];
        }
    }
}
