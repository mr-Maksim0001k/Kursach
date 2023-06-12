using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using OP1___CSharp_WinForm___Labs.Classes;

namespace OP1___CSharp_WinForm___Labs.Classes
{
    class DrawTrigWaves : DrawBaseOfTrigFunctions
    {
        private int steps = 25;
        private int flag = 0;
        private PointF First = new PointF(0, 0);
        private PointF Second = new PointF(0, 0);
        private PointF Next = new PointF(0, 0);
        private PointF BaseForTan = new PointF(0, 0);

        public void DrawTrigFunction()
        {
            List<PointF> points;
            if (flag == 0) // Sine
            {
                points = new List<PointF>();
                for (int i = 0; i <= rangeRightPI * steps; i++)
                {
                    Next.X = originPosition.X + OneStep * (float)Math.PI / steps * i;
                    Next.Y = originPosition.Y - OneStep * (float)Math.Sin(Math.PI / steps * i);
                    points.Add(Next);
                }
                drawLines.DrawCurve(myPen, points.ToArray());

                points = new List<PointF>();
                for (int i = 0; i >= rangeLeftPI * steps * (-1); i--)
                {
                    points.Add(new PointF(
                        originPosition.X + OneStep * (float)Math.PI / steps * i,
                        originPosition.Y - OneStep * (float)Math.Sin(Math.PI / steps * i) ) );
                }
                drawLines.DrawCurve(myPen, points.ToArray());
            }

            else if (flag == 1) // Cosine
            {
                First = originPosition;
                First.Y = originPosition.Y - OneStep * (float)Math.Cos(Math.PI / steps * 0);
                for (int i = 0; i <= rangeRightPI * steps; i++)
                {
                    Second.X = originPosition.X + OneStep * (float)Math.PI / steps * i;
                    Second.Y = originPosition.Y - OneStep * (float)Math.Cos(Math.PI / steps * i);
                    drawLines.DrawLine(myPen, First, Second);
                    First = Second;
                }

                First = originPosition;
                First.Y = originPosition.Y - OneStep * (float)Math.Cos(Math.PI / steps * 0);
                for (int i = 0; i >= rangeLeftPI * steps * (-1); i--)
                {
                    Second.X = originPosition.X + OneStep * (float)Math.PI / steps * i;
                    Second.Y = originPosition.Y - OneStep * (float)Math.Cos(Math.PI / steps * i);
                    drawLines.DrawLine(myPen, First, Second);
                    First = Second;
                }
            }

            else if (flag == 2) // Tangent
            {
                BaseForTan = originPosition;
                for (int j = 1; j <= rangeRightPI * 2; j++)
                {
                    points = new List<PointF>();
                    for (int i = 0; i <= steps; i++)
                    {
                        try
                        {
                            Next.X = BaseForTan.X + OneStep * (float)Math.PI / (2 * steps) * i;
                            Next.Y = BaseForTan.Y -
                                OneStep * (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i);
                        }
                        catch (OverflowException)
                        {
                            continue;
                        }

                        if (Math.Sign(OneStep * (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) >= 0 &&
                            Math.Abs(OneStep * (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeTop))
                        {
                            points.Add(Next);
                        }
                        else if (Math.Sign(OneStep * (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) < 0 &&
                            Math.Abs(OneStep * (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeBottom))
                        {
                            points.Add(Next);
                        }
                    }
                    drawLines.DrawCurve(myPen, points.ToArray());
                    BaseForTan.X += OneStep / 2 * (float)Math.PI;
                }

                BaseForTan = originPosition;
                for (int j = -1; j >= rangeLeftPI * 2 * (-1); j--)
                {
                    points = new List<PointF>();
                    for (int i = 0; i >= steps * (-1); i--)
                    {
                        try
                        {
                            Next.X = BaseForTan.X + OneStep * (float)Math.PI / (2 * steps) * i;
                            Next.Y = BaseForTan.Y -
                                OneStep * (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i);
                        }
                        catch (OverflowException)
                        {
                            continue;
                        }

                        if (Math.Sign(OneStep * (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) >= 0 &&
                            Math.Abs(OneStep * (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeTop))
                        {
                            points.Add(Next);
                        }
                        else if (Math.Sign(OneStep * (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) < 0 &&
                            Math.Abs(OneStep * (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeBottom))
                        {
                            points.Add(Next);
                        }
                    }
                    drawLines.DrawCurve(myPen, points.ToArray());
                    BaseForTan.X -= OneStep / 2 * (float)Math.PI;
                }
            }

            else if (flag == 3) // Cotangent
            {
                BaseForTan = originPosition;
                for (int j = 1; j <= rangeRightPI * 2; j++)
                {
                    points = new List<PointF>();
                    for (int i = 0; i <= steps; i++)
                    {
                        try
                        {
                            Next.X = BaseForTan.X + OneStep * (float)Math.PI / (2 * steps) * i;
                            Next.Y = BaseForTan.Y -
                                OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i);
                        }
                        catch (OverflowException)
                        {
                            continue;
                        }

                        if (Math.Sign(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) >= 0 &&
                            Math.Abs(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeTop))
                        {
                            points.Add(Next);
                        }
                        else if (Math.Sign(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) < 0 &&
                            Math.Abs(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j - 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeBottom))
                        {
                            points.Add(Next);
                        }
                    }
                    drawLines.DrawCurve(myPen, points.ToArray());
                    BaseForTan.X += OneStep / 2 * (float)Math.PI;
                }

                BaseForTan = originPosition;
                for (int j = -1; j >= rangeLeftPI * 2 * (-1); j--)
                {
                    points = new List<PointF>();
                    for (int i = 0; i >= steps * (-1); i--)
                    {
                        try
                        {
                            Next.X = BaseForTan.X + OneStep * (float)Math.PI / (2 * steps) * i;
                            Next.Y = BaseForTan.Y -
                                OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i);
                        }
                        catch (OverflowException)
                        {
                            continue;
                        }

                        if (Math.Sign(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) >= 0 &&
                            Math.Abs(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeTop))
                        {
                            points.Add(Next);
                        }
                        else if (Math.Sign(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) < 0 &&
                            Math.Abs(OneStep * 1 / (float)Math.Tan(Math.PI / 2 * (j + 1) + Math.PI / (2 * steps) * i)) <= Math.Abs(OneStep * rangeBottom))
                        {
                            points.Add(Next);
                        }
                    }
                    drawLines.DrawCurve(myPen, points.ToArray());
                    BaseForTan.X -= OneStep / 2 * (float)Math.PI;
                }
            }
        }

        public void Sine_button_Pressed
            (Button Sine_button, Button Cosine_button, Button Tangent_button, Button Cotangent_button)
        {
            flag = 0;

            Sine_button.FlatAppearance.BorderColor = Color.Red;
            Sine_button.FlatAppearance.BorderSize = 3;
            Cosine_button.FlatAppearance.BorderColor = Color.Cyan;
            Cosine_button.FlatAppearance.BorderSize = 1;
            Tangent_button.FlatAppearance.BorderColor = Color.Cyan;
            Tangent_button.FlatAppearance.BorderSize = 1;
            Cotangent_button.FlatAppearance.BorderColor = Color.Cyan;
            Cotangent_button.FlatAppearance.BorderSize = 1;
        }
        public void Cosine_button_Pressed
            (Button Sine_button, Button Cosine_button, Button Tangent_button, Button Cotangent_button)
        {
            flag = 1;

            Sine_button.FlatAppearance.BorderColor = Color.Cyan;
            Sine_button.FlatAppearance.BorderSize = 1;
            Cosine_button.FlatAppearance.BorderColor = Color.Red;
            Cosine_button.FlatAppearance.BorderSize = 3;
            Tangent_button.FlatAppearance.BorderColor = Color.Cyan;
            Tangent_button.FlatAppearance.BorderSize = 1;
            Cotangent_button.FlatAppearance.BorderColor = Color.Cyan;
            Cotangent_button.FlatAppearance.BorderSize = 1;
        }
        public void Tangent_button_Pressed
            (Button Sine_button, Button Cosine_button, Button Tangent_button, Button Cotangent_button)
        {
            flag = 2;

            Sine_button.FlatAppearance.BorderColor = Color.Cyan;
            Sine_button.FlatAppearance.BorderSize = 1;
            Cosine_button.FlatAppearance.BorderColor = Color.Cyan;
            Cosine_button.FlatAppearance.BorderSize = 1;
            Tangent_button.FlatAppearance.BorderColor = Color.Red;
            Tangent_button.FlatAppearance.BorderSize = 3;
            Cotangent_button.FlatAppearance.BorderColor = Color.Cyan;
            Cotangent_button.FlatAppearance.BorderSize = 1;
        }
        public void Cotangent_button_Pressed
            (Button Sine_button, Button Cosine_button, Button Tangent_button, Button Cotangent_button)
        {
            flag = 3;

            Sine_button.FlatAppearance.BorderColor = Color.Cyan;
            Sine_button.FlatAppearance.BorderSize = 1;
            Cosine_button.FlatAppearance.BorderColor = Color.Cyan;
            Cosine_button.FlatAppearance.BorderSize = 1;
            Tangent_button.FlatAppearance.BorderColor = Color.Cyan;
            Tangent_button.FlatAppearance.BorderSize = 1;
            Cotangent_button.FlatAppearance.BorderColor = Color.Red;
            Cotangent_button.FlatAppearance.BorderSize = 3;
        }
    }
}
