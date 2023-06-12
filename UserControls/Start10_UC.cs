using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OP1___CSharp_WinForm___Labs.Classes;

namespace OP1___CSharp_WinForm___Labs.UserControls
{
    public partial class Start10_UC : UserControl
    {
        public Start10_UC()
        {
            InitializeComponent();
        }

        DrawAxises newAxis = new DrawAxises();
        DrawMesh newMesh = new DrawMesh();
        DrawTrigWaves newOne = new DrawTrigWaves();

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            newAxis.DrawingAxisesToGraphPanel(graphPanel);
            newMesh.DrawingMeshToGraphPanel(graphPanel);
            newOne.graphPanel_Drawing(graphPanel);
        }

        private void GO_Button_Click(object sender, EventArgs e)
        {
            graphPanel.Refresh();

            newAxis.ifRangeChanged(rangeRightPI_textBox, rangeLeftPI_textBox, rangeTop_textBox, rangeBottom_textBox);
            newAxis.setInitialLines(graphPanel);
            newAxis.DrawAxis();
            newMesh.ifRangeChanged(rangeRightPI_textBox, rangeLeftPI_textBox, rangeTop_textBox, rangeBottom_textBox);
            newMesh.setInitialLines(graphPanel);
            newMesh.DrawMeshes();

            newOne.ifRangeChanged(rangeRightPI_textBox, rangeLeftPI_textBox, rangeTop_textBox, rangeBottom_textBox);
            newOne.setOriginPosition(graphPanel);
            newOne.DrawTrigFunction();
        }

        private void solidLine_button_Click(object sender, EventArgs e)
        {
            newOne.solidLine_button_Pressed(solidLine_button, dotLine_button);
        }

        private void dotLine_button_Click(object sender, EventArgs e)
        {
            newOne.dotLine_button_Pressed(solidLine_button, dotLine_button);
        }

        private void t1_button_Click(object sender, EventArgs e)
        {
            newOne.t1_button_Pressed(t1_button, t2_button, t3_button);
        }

        private void t2_button_Click(object sender, EventArgs e)
        {
            newOne.t2_button_Pressed(t1_button, t2_button, t3_button);
        }

        private void t3_button_Click(object sender, EventArgs e)
        {
            newOne.t3_button_Pressed(t1_button, t2_button, t3_button);
        }

        private void redColor_button_Click(object sender, EventArgs e)
        {
            newOne.redColor_button_Pressed(redColor_button, greenColor_button,
                blueColor_button, cyanColor_button, yellowColor_button, blackColor_button);
        }

        private void greenColor_button_Click(object sender, EventArgs e)
        {
            newOne.greenColor_button_Pressed(redColor_button, greenColor_button,
                blueColor_button, cyanColor_button, yellowColor_button, blackColor_button);
        }

        private void blueColor_button_Click(object sender, EventArgs e)
        {
            newOne.blueColor_button_Pressed(redColor_button, greenColor_button,
                blueColor_button, cyanColor_button, yellowColor_button, blackColor_button);
        }
        private void cyanColor_button_Click(object sender, EventArgs e)
        {
            newOne.cyanColor_button_Pressed(redColor_button, greenColor_button,
                blueColor_button, cyanColor_button, yellowColor_button, blackColor_button);
        }

        private void yellowColor_button_Click(object sender, EventArgs e)
        {
            newOne.yellowColor_button_Pressed(redColor_button, greenColor_button,
                blueColor_button, cyanColor_button, yellowColor_button, blackColor_button);
        }

        private void blackColor_button_Click(object sender, EventArgs e)
        {
            newOne.blackColor_button_Pressed(redColor_button, greenColor_button,
                blueColor_button, cyanColor_button, yellowColor_button, blackColor_button);
        }

        private void Sine_button_Click(object sender, EventArgs e)
        {
            newOne.Sine_button_Pressed(Sine_button, Cosine_button, Tangent_button, Cotangent_button);
        }

        private void Cosine_button_Click(object sender, EventArgs e)
        {
            newOne.Cosine_button_Pressed(Sine_button, Cosine_button, Tangent_button, Cotangent_button);
        }

        private void Tangent_button_Click(object sender, EventArgs e)
        {
            newOne.Tangent_button_Pressed(Sine_button, Cosine_button, Tangent_button, Cotangent_button);
        }

        private void Cotangent_button_Click(object sender, EventArgs e)
        {
            newOne.Cotangent_button_Pressed(Sine_button, Cosine_button, Tangent_button, Cotangent_button);
        }
    }
}
