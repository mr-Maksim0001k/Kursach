using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace OP1___CSharp_WinForm___Labs.Classes
{
    class DrawMesh : DrawBaseOfTrigFunctions
    {
        public Pen MeshPen = new Pen(Color.Black, 1.0f);
        public Graphics drawMesh = null;
        public void DrawingMeshToGraphPanel(Panel graphPanel)
        {
            MeshPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            drawMesh = graphPanel.CreateGraphics();
        }

        public void DrawMeshes()
        {
            for (int i = 0; i <= (rangeTop + rangeBottom); i++)
            {
                if (HL.Y != originPosition.Y)
                    drawMesh.DrawLine(MeshPen, HL, HR);
                HL.Y += OneStep;
                HR.Y = HL.Y;
            }

            for (int i = 0; i <= (rangeLeftPI + rangeRightPI) * 2; i++)
            {
                if (VT.X != originPosition.X)
                    drawMesh.DrawLine(MeshPen, VT, VB);
                VT.X += OneStep * (float)Math.PI / 2;
                VB.X = VT.X;
            }
        }
    }
}
