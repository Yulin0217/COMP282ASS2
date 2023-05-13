using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 3000;
            t.Elapsed += T_Elapsed;
            t.Start();
        }

        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MessageBox.Show("Times up");
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Point first = new Point((int)(picLines.Size.Width * rnd.NextDouble()), (int)(picLines.Size.Height * rnd.NextDouble()));
            Point second = new Point((int)(picLines.Size.Width * rnd.NextDouble()), (int)(picLines.Size.Height * rnd.NextDouble()));
            Color c = Color.FromArgb((int)(255 * rnd.NextDouble()), (int)(255 * rnd.NextDouble()),(int)(255 * rnd.NextDouble()));
            Tuple<Point, Point, Color> l = new Tuple<Point, Point, Color>(first, second, c);
            lines.Add(l);
             picLines.Invalidate();
        }

        List<Tuple<Point, Point, Color>> lines = new List<Tuple<Point, Point, Color>>();
        private void PicLines_Paint(object sender, PaintEventArgs e)
        {
            foreach (var l in lines)
            {
                Pen p = new Pen(l.Item3);
                e.Graphics.DrawLine(p, l.Item1, l.Item2);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRandom_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
