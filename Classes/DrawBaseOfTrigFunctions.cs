using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace OP1___CSharp_WinForm___Labs.Classes
{
    class DrawBaseOfTrigFunctions : iDraw
    {
        protected int rangeTop = 4;
        protected int rangeBottom = 4;
        protected int rangeLeftPI = 2;
        protected int rangeRightPI = 2;

        protected float OneStep = new float();
        protected PointF HL = new PointF();
        protected PointF HR = new PointF();
        protected PointF VT = new PointF();
        protected PointF VB = new PointF();
        protected PointF originPosition = new PointF();

        public void setInitialLines(Panel graphPanel)
        {
            HL.X = graphPanel.Width * 0.012f;
            HR.X = graphPanel.Width * 0.012f + graphPanel.Width - graphPanel.Width * 0.049f;
            OneStep = (HR.X - HL.X) / ((rangeLeftPI + rangeRightPI) * (float)Math.PI);
            originPosition.X = HL.X + OneStep * rangeLeftPI * (float)Math.PI;
            originPosition.Y = (graphPanel.Height - OneStep * (rangeTop + rangeBottom)) / 2 + OneStep * rangeTop;

            HL.Y = originPosition.Y - OneStep * rangeTop;
            HR.Y = HL.Y;

            VT.X = HL.X;
            VB.X = HL.X;
            VT.Y = HL.Y;
            VB.Y = VT.Y + OneStep * (rangeTop + rangeBottom);
        }
        public void setOriginPosition(Panel graphPanel)
        {
            HL.X = graphPanel.Width * 0.012f;
            HR.X = graphPanel.Width * 0.012f + graphPanel.Width - graphPanel.Width * 0.049f;
            OneStep = (HR.X - HL.X) / ((rangeLeftPI + rangeRightPI) * (float)Math.PI);
            originPosition.X = HL.X + OneStep * rangeLeftPI * (float)Math.PI;
            originPosition.Y = (graphPanel.Height - OneStep * (rangeTop + rangeBottom)) / 2 + OneStep * rangeTop;
        }

        public void ifRangeChanged(TextBox rangeRightPI_textBox, 
            TextBox rangeLeftPI_textBox, TextBox rangeTop_textBox, TextBox rangeBottom_textBox)
        {
            try // rangeRightPI
            {
                rangeRightPI = Int32.Parse(rangeRightPI_textBox.Text);
                if (rangeRightPI < 1)
                {
                    rangeRightPI = 1;
                    rangeRightPI_textBox.Text = rangeRightPI.ToString();
                }
                else if (rangeRightPI > 10)
                {
                    rangeRightPI = 10;
                    rangeRightPI_textBox.Text = rangeRightPI.ToString();
                }
            }
            catch (FormatException)
            {
                rangeRightPI = 2;
                rangeRightPI_textBox.Text = rangeRightPI.ToString();
            }
            catch (OverflowException)
            {
                rangeRightPI = 2;
                rangeRightPI_textBox.Text = rangeRightPI.ToString();
            }

            try // rangeLeftPI
            {
                rangeLeftPI = Int32.Parse(rangeLeftPI_textBox.Text);
                if (rangeLeftPI < 0)
                {
                    rangeLeftPI = 0;
                    rangeLeftPI_textBox.Text = rangeLeftPI.ToString();
                }
                else if (rangeLeftPI > 10)
                {
                    rangeLeftPI = 10;
                    rangeLeftPI_textBox.Text = rangeLeftPI.ToString();
                }
            }
            catch (FormatException)
            {
                rangeLeftPI = 2;
                rangeLeftPI_textBox.Text = rangeLeftPI.ToString();
            }
            catch (OverflowException)
            {
                rangeLeftPI = 2;
                rangeLeftPI_textBox.Text = rangeLeftPI.ToString();
            }

            try // rangeTop
            {
                rangeTop = Int32.Parse(rangeTop_textBox.Text);
                if (rangeTop < 1)
                {
                    rangeTop = 1;
                    rangeTop_textBox.Text = rangeTop.ToString();
                }
                else if (rangeTop > 15)
                {
                    rangeTop = 15;
                    rangeTop_textBox.Text = rangeTop.ToString();
                }
            }
            catch (FormatException)
            {
                rangeTop = 4;
                rangeTop_textBox.Text = rangeTop.ToString();
            }
            catch (OverflowException)
            {
                rangeTop = 4;
                rangeTop_textBox.Text = rangeTop.ToString();
            }

            try // rangeBottom
            {
                rangeBottom = Int32.Parse(rangeBottom_textBox.Text);
                if (rangeBottom < 0)
                {
                    rangeBottom = 0;
                    rangeBottom_textBox.Text = rangeBottom.ToString();
                }
                else if (rangeBottom > 15)
                {
                    rangeBottom = 15;
                    rangeBottom_textBox.Text = rangeBottom.ToString();
                }
            }
            catch (FormatException)
            {
                rangeBottom = 4;
                rangeBottom_textBox.Text = rangeBottom.ToString();
            }
            catch (OverflowException)
            {
                rangeBottom = 4;
                rangeBottom_textBox.Text = rangeBottom.ToString();
            }
        }

    }
}
