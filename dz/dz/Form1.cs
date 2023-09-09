using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graf_function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Show();
        }

        public void Print_Graf()
        {
            Graphics graph = this.CreateGraphics();


            Point StartPoint_X = new Point(100, 240);
            Point EndPoint_X = new Point(700, 240);

            Point StatPoint_Y = new Point(400, 40);
            Point EndPoint_Y = new Point(350, 6800);

            Pen blackPen = new Pen(Color.Black, 4);

            graph.DrawLine(blackPen, StartPoint_X, EndPoint_X);
            graph.DrawLine(blackPen, StatPoint_Y, EndPoint_Y);

            SolidBrush brush = new SolidBrush(Color.Blue);

            Rectangle[] mass = new Rectangle[] 
            {
                new Rectangle(105,225,5,30),
                new Rectangle(140, 225,5,30),
                new Rectangle(175,225,5,30),
                new Rectangle(210, 225,5,30),
                new Rectangle(245,225,5,30),
                new Rectangle(280, 225,5,30),
                new Rectangle(315,225,5,30),
                new Rectangle(350, 225,5,30),
                new Rectangle(385,225,5,30),
                new Rectangle(408, 225,5,30),
                new Rectangle(443,225,5,30),
                new Rectangle(478, 225,5,30),
                new Rectangle(513,225,5,30),
                new Rectangle(548, 225,5,30),
                new Rectangle(583,225,5,30),
                new Rectangle(618, 225,5,30),
                new Rectangle(653,225,5,30),
                new Rectangle(688, 225,5,30)
            };

            foreach (var i in mass)
            {
                graph.FillRectangle(brush, i);
            }

            Rectangle[] mass_r = new Rectangle[]
            {
                new Rectangle(385,45,30,5),
                new Rectangle(385,80,30,5),
                new Rectangle(385,115,30,5),
                new Rectangle(385,150,30,5),
                new Rectangle(385,185,30,5),
                new Rectangle(385,210,30,5),
                new Rectangle(385,260,30,5),
                new Rectangle(385,295,30,5),
                new Rectangle(385,330,30,5),
                new Rectangle(385,365,30,5),
                new Rectangle(385,400,30,5),
                new Rectangle(385,435,30,5)
            };

            foreach (var i in mass_r)
            {
                graph.FillRectangle(brush, i);
            }

            blackPen.Dispose();
            brush.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Print_Graf();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            Pen p = new Pen(Color.Red, 3);

            Matrix matrix = new Matrix(1, 0, 0, -1, 0, 0);
            graphics.Transform = matrix;
            graphics.TranslateTransform(391, 245, MatrixOrder.Append);

            if (comboBox1.SelectedIndex == 0)
            {
                graphics.DrawLine(p, 9, 0, 138, 240); 
                graphics.DrawLine(p, 9, 0, -138, 240);

            }
            if (comboBox1.SelectedIndex == 1)
            {
                Rectangle rectangle = new Rectangle(-145, -123, 306, 250);
                graphics.DrawEllipse(p, rectangle);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                graphics.DrawArc(p, -300, 10, 300, 200, 220, 200);
                graphics.DrawArc(p, 10, -200, 300, 200, 400, 200);

            }
            p.Dispose();
        }


    }
}
