using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace genetical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics graphics;
        GameEngine engine;
        private void Draw()
        {
            graphics.Clear(Color.White);
            for (int i = 0; i < engine.getsellscount(); i++)
            {
                graphics.FillEllipse(engine.getsell(i).color, engine.getsell(i).rectangle);
            }
            for (int i = 0; i < engine.getfoodscount(); i++)
            {
                graphics.FillEllipse(engine.getfood(i).color, engine.getfood(i).rectangle);
            }
            pictureBox1.Refresh();
        }
   
        private void timer2_Tick(object sender, EventArgs e)
        {
            engine.age();
            engine.foodspawn();
            engine.runmove();
            Draw();
            label1.Text = Convert.ToString(engine.getsellscount());
        }
        private void start_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            engine = new GameEngine(numericSells.Value, numericfood.Value, pictureBox1.Width, pictureBox1.Height);
            engine.gamestart();

            timer2.Interval = (int)timercount.Value;
            timer2.Start();
        }

    }

}
