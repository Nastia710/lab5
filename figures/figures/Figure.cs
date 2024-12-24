using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public abstract class Figure
    {
        protected float centerX;
        protected float centerY;
        public abstract void DrawBlack(Graphics g);
        public abstract void HideDrawingBackGround(Graphics g);

        public Figure(float centerX, float centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }

        public void MoveRight(Graphics g)
        {
            for (int i = 0; i < 350; i++)
            {
                DrawBlack(g);
                System.Threading.Thread.Sleep(25);
                HideDrawingBackGround(g);
                centerX += 1;
            }
        }
    }
}
