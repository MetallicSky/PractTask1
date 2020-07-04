using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractTask1
{
    public partial class Form1 : Form
    {
        private Pen ObjOutline = new Pen(Color.Black, 1);
        private Brush ObjInside = new SolidBrush(Color.White);
        private Pen TrjClr = new Pen(Color.Black);
        private int steps = 0;
        private int degs = 0;
        private List<PointF> Trj = new List<PointF>();
        private int bigRadius = 50;
        private int smallRadius = 25;
        private PointF[] Obj = new PointF[4];
        private PointF[] minObj = new PointF[4];
        private PointF[] pulsingObj = new PointF[4];
        private PointF[] rotatingObj = new PointF[4];
        private PointF lastPosition;
        private bool increasing = true;
        private int stepsRemaining;
        private int lastDeg = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBoxTrj.Controls.Add(pictureBoxObj);
            pictureBoxObj.Location = new Point(0, 0);
            pictureBoxObj.BackColor = Color.Transparent;
        }

        private void restart()
        {
            steps = 0;
            degs = 0;
            Trj.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxObjKind.SelectedIndex = 0;
            comboBoxTrjKind.SelectedIndex = 0;
            colorDialogObjInside.Color = Color.White;
            timerFPS.Interval = 1000 / (int)numericUpDownStepsPerSec.Value;
            timerFPS.Enabled = true;
            timerFPS.Start();
        }

        private void checkBoxPulse_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Obj.Count(); ++i)
                pulsingObj[i] = Obj[i];
            if (checkBoxPulse.Checked)
            {
                stepsRemaining = (int)numericUpDownStepsPerPulse.Value;
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
                lastDeg = 0;
                labelRotationDeg.Enabled = false;
                numericUpDownRotationDeg.Enabled = false;
            }
        }

        private void buttonObjOutline_Click(object sender, EventArgs e)
        {
            colorDialogObjOutline.ShowDialog();
            ObjOutline.Color = colorDialogObjOutline.Color;
            pictureBoxPreview.Refresh();
        }

        private void buttonObjInside_Click(object sender, EventArgs e)
        {
            colorDialogObjInside.ShowDialog();
            ObjInside = new SolidBrush(colorDialogObjInside.Color);
            pictureBoxPreview.Refresh();
        }

        private void buttonTrjClr_Click(object sender, EventArgs e)
        {
            colorDialogTrjClr.ShowDialog();
            TrjClr = new Pen(colorDialogTrjClr.Color, trackBarTrjThk.Value);
        }

        private void pictureBoxPreview_Paint(object sender, PaintEventArgs e)
        {
            double temp = (double)numericUpDownHeight.Value / Math.Sin(Math.PI * (double)numericUpDownDeg.Value / 180);
            double BigDeg = 180 - (double)numericUpDownDeg.Value;
            double side = temp * Math.Sin(Math.PI * (BigDeg - 90) / 180);
            e.Graphics.TranslateTransform(pictureBoxPreview.Width / 2 - (float)((double)numericUpDownWidth.Value + side) / 2, pictureBoxPreview.Height / 2 + (float)numericUpDownHeight.Value / 2);
            e.Graphics.ScaleTransform(1, -1);
            Obj[0] = new PointF(0, 0);
            Obj[1] = new PointF((float)side, (float)numericUpDownHeight.Value);
            Obj[2] = new PointF((float)side + (float)numericUpDownWidth.Value, (float)numericUpDownHeight.Value);
            Obj[3] = new PointF((float)numericUpDownWidth.Value, 0);

            double ratio = Math.Sqrt((double)(numericUpDownMin.Value / 100));
            for (int i = 0; i < Obj.Count(); ++i)
            {
                minObj[i].X = Obj[i].X * (float)ratio;
                minObj[i].Y = Obj[i].Y * (float)ratio;
            }
            e.Graphics.FillPolygon(ObjInside, Obj);
            e.Graphics.DrawPolygon(ObjOutline, Obj);
        }

        private void trackBarObjThk_Scroll(object sender, EventArgs e)
        {
            ObjOutline.Width = trackBarObjThk.Value;
            pictureBoxPreview.Refresh();
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
        }

        private void numericUpDownDeg_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
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
        }

        private void numericUpDownStepsPerSec_ValueChanged(object sender, EventArgs e)
        {
            timerFPS.Stop();
            timerFPS.Interval = 1000 / (int)numericUpDownStepsPerSec.Value;
            timerFPS.Start();
        }

        private void timerFPS_Tick(object sender, EventArgs e)
        {
            pictureBoxTrj.Refresh();
            pictureBoxObj.Refresh();
        }

        private void pictureBoxTrj_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBoxTrj.Width / 2, pictureBoxTrj.Height / 2);
            e.Graphics.ScaleTransform(1, -1);
            for (int i = 0; i < Trj.Count() - 1; i++)
            {
                e.Graphics.DrawLine(TrjClr, Trj[i], Trj[i + 1]);
                steps++;
            }
            float x;
            float y;
            if (checkBoxClock.Checked)
            {
                x = (float)((smallRadius + bigRadius) * Math.Cos(Math.PI * (degs + (float)numericUpDownStepLength.Value) / 180)
                - smallRadius * Math.Cos(Math.PI * (degs + (float)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius));
                y = (float)((smallRadius + bigRadius) * Math.Sin(Math.PI * (degs + (float)numericUpDownStepLength.Value) / 180)
                    - smallRadius * Math.Sin(Math.PI * (degs + (float)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius));
                degs += (int)numericUpDownStepLength.Value;
            }
            else
            {
                x = (float)((smallRadius + bigRadius) * Math.Cos(Math.PI * (degs - (float)numericUpDownStepLength.Value) / 180)
                - smallRadius * Math.Cos(Math.PI * (degs - (float)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius));
                y = (float)((smallRadius + bigRadius) * Math.Sin(Math.PI * (degs - (float)numericUpDownStepLength.Value) / 180)
                    - smallRadius * Math.Sin(Math.PI * (degs - (float)numericUpDownStepLength.Value) / 180 * (bigRadius + smallRadius) / smallRadius));
                degs -= (int)numericUpDownStepLength.Value;
            }

            lastPosition.X = x;
            lastPosition.Y = y;
            Trj.Insert(0, new PointF(x, y));
            if (Trj.Count > 1)
                e.Graphics.DrawLine(TrjClr, Trj[0], Trj[1]);
            steps++;
            if (Math.Abs(degs) >= 360 * numericUpDownRepeats.Value && checkBoxRepeatsInf.Checked == false)
            {
                restart();
            }
        }

        private void comboBoxTrjKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTrjKind.SelectedIndex)
            {
                case 0:
                    TrjClr = new Pen(colorDialogTrjClr.Color, trackBarTrjThk.Value);
                    pictureBoxTrj.Refresh();
                    break;

                case 1:
                    float[] dash = { 1, 1 };
                    TrjClr.DashPattern = dash;
                    pictureBoxTrj.Refresh();
                    break;

                case 2:
                    float[] bigDash = { 2, 1 };
                    TrjClr.DashPattern = bigDash;
                    pictureBoxTrj.Refresh();
                    break;
            }
        }

        private void pictureBoxObj_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBoxObj.Width / 2 + lastPosition.X, pictureBoxObj.Height / 2 - lastPosition.Y);
            e.Graphics.ScaleTransform(1, -1);
            if (checkBoxPulse.Checked == true)
            {
                double ratio = Math.Sqrt((double)(numericUpDownMax.Value / numericUpDownMin.Value));
                if (increasing)
                {
                    if (stepsRemaining > 1)
                    {
                        for (int i = 1; i < pulsingObj.Length; ++i)
                        {
                            pulsingObj[i].X += (float)(minObj[i].X * (ratio - 1) / (double)numericUpDownStepsPerPulse.Value);
                            pulsingObj[i].Y += (float)(minObj[i].Y * (ratio - 1) / (double)numericUpDownStepsPerPulse.Value);
                        }
                        --stepsRemaining;
                    }
                    else
                    {
                        for (int i = 1; i < pulsingObj.Length; ++i)
                        {
                            pulsingObj[i].X = (float)(minObj[i].X * ratio);
                            pulsingObj[i].Y = (float)(minObj[i].Y * ratio);
                        }
                        stepsRemaining = (int)numericUpDownStepsPerPulse.Value;
                        increasing = false;
                    }
                }
                else
                {
                    if (stepsRemaining > 1)
                    {
                        for (int i = 1; i < pulsingObj.Length; ++i)
                        {
                            pulsingObj[i].X -= (float)(minObj[i].X * (ratio - 1) / (double)numericUpDownStepsPerPulse.Value);
                            pulsingObj[i].Y -= (float)(minObj[i].Y * (ratio - 1) / (double)numericUpDownStepsPerPulse.Value);
                        }
                        --stepsRemaining;
                    }
                    else
                    {
                        for (int i = 1; i < pulsingObj.Length; ++i)
                        {
                            pulsingObj[i].X = minObj[i].X;
                            pulsingObj[i].Y = minObj[i].Y;
                        }
                        stepsRemaining = (int)numericUpDownStepsPerPulse.Value;
                        increasing = true;
                    }
                }

                if (checkBoxRotation.Checked)
                {
                    for (int i = 1; i < pulsingObj.Length; ++i)
                    {
                        rotatingObj[i].X = pulsingObj[i].X * (float)Math.Cos(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180)
                            - pulsingObj[i].Y * (float)Math.Sin(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180);
                        rotatingObj[i].Y = pulsingObj[i].X * (float)Math.Sin(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180)
                            + pulsingObj[i].Y * (float)Math.Cos(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180);
                    }
                    lastDeg += (int)numericUpDownRotationDeg.Value;
                    e.Graphics.FillPolygon(ObjInside, rotatingObj);
                    e.Graphics.DrawPolygon(ObjOutline, rotatingObj);
                }
                else
                {
                    e.Graphics.FillPolygon(ObjInside, pulsingObj);
                    e.Graphics.DrawPolygon(ObjOutline, pulsingObj);
                }
            }
            else
            {
                if (checkBoxRotation.Checked)
                {
                    for (int i = 1; i < Obj.Length; ++i)
                    {
                        rotatingObj[i].X = Obj[i].X * (float)Math.Cos(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180)
                            - Obj[i].Y * (float)Math.Sin(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180);
                        rotatingObj[i].Y = Obj[i].X * (float)Math.Sin(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180)
                            + Obj[i].Y * (float)Math.Cos(Math.PI * (lastDeg + (double)numericUpDownRotationDeg.Value) / 180);
                    }
                    lastDeg += (int)numericUpDownRotationDeg.Value;
                    e.Graphics.FillPolygon(ObjInside, rotatingObj);
                    e.Graphics.DrawPolygon(ObjOutline, rotatingObj);
                }
                else
                {
                    e.Graphics.FillPolygon(ObjInside, Obj);
                    e.Graphics.DrawPolygon(ObjOutline, Obj);
                }
            }
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}