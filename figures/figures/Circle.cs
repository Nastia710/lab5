using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Circle : Figure
    {
        private float radius;

        public Circle(float centerX, float centerY, float radius) : base(centerX, centerY)
        {
            this.radius = radius;
        }
        public override void DrawBlack(Graphics g)
        {
            g.DrawEllipse(Pens.Black, centerX, centerY, radius, radius);
        }

        public override void HideDrawingBackGround(Graphics g)
        {
            g.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), centerX, centerY, radius, radius);
        }
    }
}
