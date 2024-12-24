using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Square : Figure
    {
        private float sizeLength;
        public Square(float centerX, float centerY, float size) : base(centerX, centerY)
        {
            this.sizeLength = size;
        }
        public override void DrawBlack(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, centerX, centerY, sizeLength, sizeLength);
        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Form1.ActiveForm.BackColor), centerX, centerY, sizeLength, sizeLength);
        }
    }
}
