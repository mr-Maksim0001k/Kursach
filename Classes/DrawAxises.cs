using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OP1___CSharp_WinForm___Labs.Classes
{
    class DrawAxises : DrawBaseOfTrigFunctions
    {
        public Pen AxisPen = new Pen(Color.Blue, 2f);
        public Graphics drawAxises = null;
        public void DrawingAxisesToGraphPanel(Panel graphPanel)
        {
            drawAxises = graphPanel.CreateGraphics();
        }

        public void DrawAxis()
        {
            for (int i = 0; i <= (rangeTop + rangeBottom); i++)
            {
                if (HL.Y == originPosition.Y)
                {
                    drawAxises.DrawLine(AxisPen, HL, HR);
                    drawAxises.DrawLine(AxisPen, HR.X, HR.Y, HR.X + 20f, HR.Y);
                    drawAxises.DrawLine(AxisPen, HR.X + 20f, HR.Y, HR.X + 5f, HR.Y - 8f);
                    drawAxises.DrawLine(AxisPen, HR.X + 20f, HR.Y, HR.X + 5f, HR.Y + 8f);
                }
                HL.Y += OneStep;
                HR.Y = HL.Y;
            }

            for (int i = 0; i <= (rangeLeftPI + rangeRightPI) * 2; i++)
            {
                if (VT.X == originPosition.X)
                {
                    drawAxises.DrawLine(AxisPen, VT, VB);
                    drawAxises.DrawLine(AxisPen, VT.X, VT.Y, VT.X, VT.Y - 20f);
                    drawAxises.DrawLine(AxisPen, VT.X, VT.Y - 20f, VT.X - 8f, VT.Y - 5f);
                    drawAxises.DrawLine(AxisPen, VT.X, VT.Y - 20f, VT.X + 8f, VT.Y - 5f);
                }
                VT.X += OneStep * (float)Math.PI / 2;
                VB.X = VT.X;
            }
        }
    }
}
