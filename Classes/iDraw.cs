using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OP1___CSharp_WinForm___Labs
{
    public class iDraw
    {
        public Pen myPen = new Pen(Color.Cyan, 3.0f);
        public bool paintFlag = true;

        public Graphics drawLines = null;
        public void graphPanel_Drawing(Panel graphPanel)
        {
            drawLines = graphPanel.CreateGraphics();

            if (paintFlag)
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        public void solidLine_button_Pressed
            (Button solidLine_button, Button dotLine_button)
        {
            paintFlag = true;

            solidLine_button.FlatAppearance.BorderColor = Color.Red;
            solidLine_button.FlatAppearance.BorderSize = 3;
            dotLine_button.FlatAppearance.BorderColor = Color.Cyan;
            dotLine_button.FlatAppearance.BorderSize = 1;
        }
        public void dotLine_button_Pressed
            (Button solidLine_button, Button dotLine_button)
        {
            paintFlag = false;

            solidLine_button.FlatAppearance.BorderColor = Color.Cyan;
            solidLine_button.FlatAppearance.BorderSize = 1;
            dotLine_button.FlatAppearance.BorderColor = Color.Red;
            dotLine_button.FlatAppearance.BorderSize = 3;
        }

        public void t1_button_Pressed
            (Button t1_button, Button t2_button, Button t3_button)
        {
            myPen.Width = 1f;

            t1_button.FlatAppearance.BorderColor = Color.Red;
            t1_button.FlatAppearance.BorderSize = 3;
            t2_button.FlatAppearance.BorderColor = Color.Cyan;
            t2_button.FlatAppearance.BorderSize = 1;
            t3_button.FlatAppearance.BorderColor = Color.Cyan;
            t3_button.FlatAppearance.BorderSize = 1;
        }
        public void t2_button_Pressed
            (Button t1_button, Button t2_button, Button t3_button)
        {
            myPen.Width = 2f;

            t2_button.FlatAppearance.BorderColor = Color.Red;
            t2_button.FlatAppearance.BorderSize = 3;
            t1_button.FlatAppearance.BorderColor = Color.Cyan;
            t1_button.FlatAppearance.BorderSize = 1;
            t3_button.FlatAppearance.BorderColor = Color.Cyan;
            t3_button.FlatAppearance.BorderSize = 1;
        }
        public void t3_button_Pressed
            (Button t1_button, Button t2_button, Button t3_button)
        {
            myPen.Width = 3f;

            t3_button.FlatAppearance.BorderColor = Color.Red;
            t3_button.FlatAppearance.BorderSize = 3;
            t2_button.FlatAppearance.BorderColor = Color.Cyan;
            t2_button.FlatAppearance.BorderSize = 1;
            t1_button.FlatAppearance.BorderColor = Color.Cyan;
            t1_button.FlatAppearance.BorderSize = 1;
        }

        public void redColor_button_Pressed
            (Button redColor_button, Button greenColor_button,
             Button blueColor_button, Button cyanColor_button,
             Button yellowColor_button, Button blackColor_button)
        {
            myPen.Color = Color.Red;

            redColor_button.FlatAppearance.BorderColor = Color.Red;
            redColor_button.FlatAppearance.BorderSize = 3;
            greenColor_button.FlatAppearance.BorderColor = Color.Cyan;
            greenColor_button.FlatAppearance.BorderSize = 1;
            blueColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blueColor_button.FlatAppearance.BorderSize = 1;
            cyanColor_button.FlatAppearance.BorderColor = Color.Cyan;
            cyanColor_button.FlatAppearance.BorderSize = 1;
            yellowColor_button.FlatAppearance.BorderColor = Color.Cyan;
            yellowColor_button.FlatAppearance.BorderSize = 1;
            blackColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blackColor_button.FlatAppearance.BorderSize = 1;
        }

        public void greenColor_button_Pressed
            (Button redColor_button, Button greenColor_button,
             Button blueColor_button, Button cyanColor_button,
             Button yellowColor_button, Button blackColor_button)
        {
            myPen.Color = Color.Green;

            redColor_button.FlatAppearance.BorderColor = Color.Cyan;
            redColor_button.FlatAppearance.BorderSize = 1;
            greenColor_button.FlatAppearance.BorderColor = Color.Red;
            greenColor_button.FlatAppearance.BorderSize = 3;
            blueColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blueColor_button.FlatAppearance.BorderSize = 1;
            cyanColor_button.FlatAppearance.BorderColor = Color.Cyan;
            cyanColor_button.FlatAppearance.BorderSize = 1;
            yellowColor_button.FlatAppearance.BorderColor = Color.Cyan;
            yellowColor_button.FlatAppearance.BorderSize = 1;
            blackColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blackColor_button.FlatAppearance.BorderSize = 1;
        }

        public void blueColor_button_Pressed
            (Button redColor_button, Button greenColor_button,
             Button blueColor_button, Button cyanColor_button,
             Button yellowColor_button, Button blackColor_button)
        {
            myPen.Color = Color.Blue;

            redColor_button.FlatAppearance.BorderColor = Color.Cyan;
            redColor_button.FlatAppearance.BorderSize = 1;
            greenColor_button.FlatAppearance.BorderColor = Color.Cyan;
            greenColor_button.FlatAppearance.BorderSize = 1;
            blueColor_button.FlatAppearance.BorderColor = Color.Red;
            blueColor_button.FlatAppearance.BorderSize = 3;
            cyanColor_button.FlatAppearance.BorderColor = Color.Cyan;
            cyanColor_button.FlatAppearance.BorderSize = 1;
            yellowColor_button.FlatAppearance.BorderColor = Color.Cyan;
            yellowColor_button.FlatAppearance.BorderSize = 1;
            blackColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blackColor_button.FlatAppearance.BorderSize = 1;
        }

        public void cyanColor_button_Pressed
            (Button redColor_button, Button greenColor_button,
             Button blueColor_button, Button cyanColor_button,
             Button yellowColor_button, Button blackColor_button)
        {
            myPen.Color = Color.Cyan;

            redColor_button.FlatAppearance.BorderColor = Color.Cyan;
            redColor_button.FlatAppearance.BorderSize = 1;
            greenColor_button.FlatAppearance.BorderColor = Color.Cyan;
            greenColor_button.FlatAppearance.BorderSize = 1;
            blueColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blueColor_button.FlatAppearance.BorderSize = 1;
            cyanColor_button.FlatAppearance.BorderColor = Color.Red;
            cyanColor_button.FlatAppearance.BorderSize = 3;
            yellowColor_button.FlatAppearance.BorderColor = Color.Cyan;
            yellowColor_button.FlatAppearance.BorderSize = 1;
            blackColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blackColor_button.FlatAppearance.BorderSize = 1;
        }

        public void yellowColor_button_Pressed
            (Button redColor_button, Button greenColor_button,
             Button blueColor_button, Button cyanColor_button,
             Button yellowColor_button, Button blackColor_button)
        {
            myPen.Color = Color.Yellow;

            redColor_button.FlatAppearance.BorderColor = Color.Cyan;
            redColor_button.FlatAppearance.BorderSize = 1;
            greenColor_button.FlatAppearance.BorderColor = Color.Cyan;
            greenColor_button.FlatAppearance.BorderSize = 1;
            blueColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blueColor_button.FlatAppearance.BorderSize = 1;
            cyanColor_button.FlatAppearance.BorderColor = Color.Cyan;
            cyanColor_button.FlatAppearance.BorderSize = 1;
            yellowColor_button.FlatAppearance.BorderColor = Color.Red;
            yellowColor_button.FlatAppearance.BorderSize = 3;
            blackColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blackColor_button.FlatAppearance.BorderSize = 1;
        }

        public void blackColor_button_Pressed
            (Button redColor_button, Button greenColor_button,
             Button blueColor_button, Button cyanColor_button,
             Button yellowColor_button, Button blackColor_button)
        {
            myPen.Color = Color.Black;

            redColor_button.FlatAppearance.BorderColor = Color.Cyan;
            redColor_button.FlatAppearance.BorderSize = 1;
            greenColor_button.FlatAppearance.BorderColor = Color.Cyan;
            greenColor_button.FlatAppearance.BorderSize = 1;
            blueColor_button.FlatAppearance.BorderColor = Color.Cyan;
            blueColor_button.FlatAppearance.BorderSize = 1;
            cyanColor_button.FlatAppearance.BorderColor = Color.Cyan;
            cyanColor_button.FlatAppearance.BorderSize = 1;
            yellowColor_button.FlatAppearance.BorderColor = Color.Cyan;
            yellowColor_button.FlatAppearance.BorderSize = 1;
            blackColor_button.FlatAppearance.BorderColor = Color.Red;
            blackColor_button.FlatAppearance.BorderSize = 3;
        }



    }
}
