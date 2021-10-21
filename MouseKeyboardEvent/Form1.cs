using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseKeyboardEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics g1 = CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            g1.DrawEllipse(p, 150, 20, 50, 50);
            g1.DrawEllipse(p, 160, 35, 10, 10);
            g1.DrawEllipse(p, 180, 35, 10, 10);
            g1.DrawArc(p, 150, 35, 50, 30, 45, 90);
            g1.DrawRectangle(p, 150, 75, 50, 100);
            g1.DrawLine(p, 175, 175, 150, 250);
            g1.DrawLine(p, 175, 175, 200, 250);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Graphics g2 = CreateGraphics();
            SolidBrush sbr = new SolidBrush(Color.Chocolate);
            g2.FillEllipse(sbr, 150, 25, 50, 50);
            sbr.Color = Color.Gray;
            g2.FillEllipse(sbr, 160, 35, 10, 10);
            g2.FillEllipse(sbr, 180, 35, 10, 10);
            sbr.Color = Color.Black;
            g2.FillPie(sbr, 150, 35, 50, 30, 45, 90);
            sbr.Color = Color.Bisque;
            g2.FillRectangle(sbr, 150, 75, 50, 100);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Text += e.KeyCode.ToString();
            
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox2.Text += "Hover";
        }
    }
}