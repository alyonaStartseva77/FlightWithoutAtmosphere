using System;
using FlightWithoutAtmosphere.Classes;

namespace FlightWithoutAtmosphere
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void InitComponents()
        {
            FightModel.a = (double)numericAngle.Value;
            FightModel.v0 = (double)numericSpeed.Value;
            FightModel.y0 = (double)numericHeight.Value;
            labelTimer.Text = "Timer:       0";
        }

        private void SetAxles()
        {
            chart.ChartAreas[0].AxisX.Maximum = FightModel.maxX;
            chart.ChartAreas[0].AxisY.Maximum = FightModel.maxY;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitComponents();
            FightModel.InitComponents();

            SetAxles();
            chart.Series[0].Points.Clear();
            chart.Series[0].Points.AddXY(FightModel.x, FightModel.y);

            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (FightModel.y < 0)
            {
                timer.Stop();
                return;
            }
            chart.Series[0].Points.AddXY(FightModel.x, FightModel.y);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            FightModel.MakeStep();

            labelTimer.Text = $"Timer:      {FightModel.t}";
            chart.Series[0].Points.AddXY(FightModel.x, FightModel.y);

            if (FightModel.y < 0) timer.Stop();
        }
    }
}
