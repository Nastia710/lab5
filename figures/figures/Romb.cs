using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Romb : Figure
    {
        private float horDiagLen;
        private float vertDiagLen;
        public Romb(float centerX, float centerY, float horDiagLen, float vertDiagLen) : base(centerX, centerY)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }
        public override void DrawBlack(Graphics graphics)
        {
            graphics.DrawPolygon(Pens.Black, RombPoints());
        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), RombPoints());
        }

        private PointF[] RombPoints()
        {
            return new PointF[] {
                new PointF(centerX - (horDiagLen / 2),  centerY),
                new PointF(centerX,  centerY + (vertDiagLen / 2)),
                new PointF(centerX + (horDiagLen / 2),  centerY),
                new PointF(centerX,  centerY - (vertDiagLen / 2)),
            };
        }

    }
}
