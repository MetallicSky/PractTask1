using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractTask1
{
    public partial class Form1 : Form
    {
        private Pen ObjOutline = new Pen(Color.Black, 2);
        private Brush ObjInside = new SolidBrush(Color.White);
        private Pen TrjClr = new Pen(Color.Black);
        private int repeats = 0;
        private int steps = 0;
        private int degs = 0;
        private List<PointF> Trj = new List<PointF>();
        private int bigRadius = 50;
        private int smallRadius = 25;

        public Form1()
        {
            InitializeComponent();
            pictureBoxTrj.Controls.Add(pictureBoxObj);
            pictureBoxObj.Location = new Point(0, 0);
            pictureBoxObj.BackColor = Color.Transparent;
        }

        private void restart()
        {
            repeats = 0;
            steps = 0;
            degs = 0;
            Trj.Clear();
            pictureBoxObj.Refresh();
            pictureBoxTrj.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxObjKind.SelectedIndex = 0;
            comboBoxTrjKind.SelectedIndex = 0;
            comboBoxClock.SelectedIndex = 0;
            colorDialogObjInside.Color = Color.White;
        }

        private void checkBoxPulse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPulse.Checked)
            {
                labelMin.Enabled = true;
                labelMax.Enabled = true;
                labelStepsPerPulse.Enabled = true;
                numericUpDownMin.Enabled = true;
                numericUpDownMax.Enabled = true;
                numericUpDownStepsPerPulse.Enabled = true;
            }
            else
            {
                labelMin.Enabled = false;
                labelMax.Enabled = false;
                labelStepsPerPulse.Enabled = false;
                numericUpDownMin.Enabled = false;
                numericUpDownMax.Enabled = false;
                numericUpDownStepsPerPulse.Enabled = false;
            }
        }

        private void checkBoxRepeatsInf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRepeatsInf.Checked)
                numericUpDownRepeats.Enabled = false;
            else
                numericUpDownRepeats.Enabled = true;
        }

        private void checkBoxRotation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotation.Checked)
            {
                labelRotationDeg.Enabled = true;
                numericUpDownRotationDeg.Enabled = true;
            }
            else
            {
                labelRotationDeg.Enabled = false;
                numericUpDownRotationDeg.Enabled = false;
            }
        }

        private void buttonObjOutline_Click(object sender, EventArgs e)
        {
            colorDialogObjOutline.ShowDialog();
            ObjOutline.Color = colorDialogObjOutline.Color;
            pictureBoxPreview.Refresh();
            pictureBoxObj.Refresh();
        }

        private void buttonObjInside_Click(object sender, EventArgs e)
        {
            colorDialogObjInside.ShowDialog();
            ObjInside = new SolidBrush(colorDialogObjInside.Color);
            pictureBoxPreview.Refresh();
            pictureBoxObj.Refresh();
        }

        private void buttonTrjClr_Click(object sender, EventArgs e)
        {
            colorDialogTrjClr.ShowDialog();
            TrjClr = new Pen(colorDialogTrjClr.Color);
            pictureBoxTrj.Refresh();
            pictureBoxObj.Refresh();
        }

        private void pictureBoxPreview_Paint(object sender, PaintEventArgs e)
        {
            double temp = (double)numericUpDownHeight.Value / Math.Sin(Math.PI * (double)numericUpDownDeg.Value / 180);
            double BigDeg = 180 - (double)numericUpDownDeg.Value;
            double side = temp * Math.Sin(Math.PI * (BigDeg - 90) / 180);
            e.Graphics.TranslateTransform(pictureBoxPreview.Width / 2 - (float)((double)numericUpDownWidth.Value + side) / 2, pictureBoxPreview.Height / 2 + (float)numericUpDownHeight.Value / 2);
            e.Graphics.ScaleTransform(1, -1);
            PointF[] dots = {
                new PointF(0, 0),
                new PointF((float)side, (float)numericUpDownHeight.Value),
                new PointF((float)side + (float)numericUpDownWidth.Value, (float)numericUpDownHeight.Value),
                new PointF((float)numericUpDownWidth.Value, 0) };
            e.Graphics.FillPolygon(ObjInside, dots);
            e.Graphics.DrawPolygon(ObjOutline, dots);
        }

        private void trackBarObjThk_Scroll(object sender, EventArgs e)
        {
            ObjOutline.Width = trackBarObjThk.Value;
            pictureBoxPreview.Refresh();
            pictureBoxObj.Refresh();
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
            pictureBoxObj.Refresh();
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
            pictureBoxObj.Refresh();
        }

        private void numericUpDownDeg_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
            pictureBoxObj.Refresh();
        }

        private void comboBoxObjKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxObjKind.SelectedIndex)
            {
                case 0:
                    ObjOutline = new Pen(colorDialogObjOutline.Color, trackBarObjThk.Value);
                    pictureBoxPreview.Refresh();
                    break;

                case 1:
                    float[] dash = { 1, 1 };
                    ObjOutline.DashPattern = dash;
                    pictureBoxPreview.Refresh();
                    break;

                case 2:
                    float[] bigDash = { 2, 1 };
                    ObjOutline.DashPattern = bigDash;
                    pictureBoxPreview.Refresh();
                    break;
            }
        }

        private void pictureBoxTrj_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBoxTrj.Width / 2, pictureBoxTrj.Height / 2);
            e.Graphics.ScaleTransform(1, -1);
            for (int i = 0; i < Trj.Count() - 1; i++)
            {
                e.Graphics.DrawLine(TrjClr, Trj[i], Trj[i + 1]);
                degs += (int)numericUpDownStepLength.Value;
                steps++;
            }
            while (repeats < numericUpDownRepeats.Value)
            {
                double temp1 = Math.Cos(Math.PI * (double)(degs + (int)numericUpDownStepLength.Value) / 180);
                double temp2 = Math.Cos(Math.PI * (double)(degs + (int)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius);
                int x = (int)((smallRadius + bigRadius) * Math.Cos(Math.PI * (double)(degs + (int)numericUpDownStepLength.Value) / 180)
                    - smallRadius * Math.Cos(Math.PI * (double)(degs + (int)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius));
                int y = (int)((smallRadius + bigRadius) * Math.Sin(Math.PI * (double)(degs + (int)numericUpDownStepLength.Value) / 180)
                    - smallRadius * Math.Sin(Math.PI * (double)(degs + (int)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius));
                Trj.Insert(0, new PointF(x, y));
                if (Trj.Count > 1)
                    e.Graphics.DrawLine(TrjClr, Trj[0], Trj[1]);

                degs += (int)numericUpDownStepLength.Value;
                steps++;
                if (degs >= 360)
                    repeats++;
                Thread.Sleep(1000 / (int)numericUpDownStepsPerSec.Value);
                //if ((checkBoxRepeatsInf.Checked == false) && (repeats >= numericUpDownRepeats.Value))
                //    restart();
            }
        }

        private void numericUpDownBigRadius_ValueChanged(object sender, EventArgs e)
        {
            bigRadius = (int)numericUpDownBigRadius.Value;
            restart();
        }

        private void numericUpDownSmallRadius_ValueChanged(object sender, EventArgs e)
        {
            smallRadius = (int)numericUpDownSmallRadius.Value;
            restart();
        }

        private void trackBarTrjThk_Scroll(object sender, EventArgs e)
        {
            TrjClr.Width = trackBarTrjThk.Value;
            pictureBoxTrj.Refresh();
            pictureBoxObj.Refresh();
        }
    }
}