using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figures
{
    public partial class Form1 : Form
    {
        Thread thread;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                Clear();
                thread.Abort();
            }
            thread = new Thread(StartCircle);
            thread.Start();
        }

        private void StartCircle()
        {
            Figure circle = new Circle(100, 120, 120);
            circle.MoveRight(g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                Clear();
                thread.Abort();
            }
            Figure square = new Square(100, 120, 120);
            thread = new Thread(StartSquare);
            thread.Start();
        }

        private void StartSquare()
        {
            Figure square = new Square(100, 120, 120);
            square.MoveRight(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                Clear();
                thread.Abort();
            }
            thread = new Thread(StartRomb);
            thread.Start();
        }

        private void StartRomb()
        {
            Figure romb = new Romb(130, 180, 200, 100);
            romb.MoveRight(g);
        }

        private void Clear()
        {
            g.Clear(BackColor);
        }

        
    }
}
