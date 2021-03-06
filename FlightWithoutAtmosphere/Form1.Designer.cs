
namespace FlightWithoutAtmosphere
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonStop = new System.Windows.Forms.Button();
            this.titleActions = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericAngle = new System.Windows.Forms.NumericUpDown();
            this.labelAngle = new System.Windows.Forms.Label();
            this.titleData = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Thistle;
            this.splitContainer1.Panel1.BackgroundImage = global::FlightWithoutAtmosphere.Properties.Resources.bg;
            this.splitContainer1.Panel1.Controls.Add(this.buttonContinue);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStop);
            this.splitContainer1.Panel1.Controls.Add(this.titleActions);
            this.splitContainer1.Panel1.Controls.Add(this.labelTimer);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1.Controls.Add(this.numericHeight);
            this.splitContainer1.Panel1.Controls.Add(this.numericSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.labelHeight);
            this.splitContainer1.Panel1.Controls.Add(this.labelSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.numericAngle);
            this.splitContainer1.Panel1.Controls.Add(this.labelAngle);
            this.splitContainer1.Panel1.Controls.Add(this.titleData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::FlightWithoutAtmosphere.Properties.Resources.bg;
            this.splitContainer1.Panel2.Controls.Add(this.chart);
            this.splitContainer1.Size = new System.Drawing.Size(1414, 691);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonStop.Location = new System.Drawing.Point(26, 388);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(203, 44);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // titleActions
            // 
            this.titleActions.AutoSize = true;
            this.titleActions.BackColor = System.Drawing.Color.Transparent;
            this.titleActions.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleActions.ForeColor = System.Drawing.Color.Indigo;
            this.titleActions.Location = new System.Drawing.Point(75, 277);
            this.titleActions.Name = "titleActions";
            this.titleActions.Size = new System.Drawing.Size(103, 34);
            this.titleActions.TabIndex = 9;
            this.titleActions.Text = "Actions:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.Indigo;
            this.labelTimer.Location = new System.Drawing.Point(22, 200);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 21);
            this.labelTimer.TabIndex = 8;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonStart.Location = new System.Drawing.Point(26, 329);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(203, 44);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericHeight
            // 
            this.numericHeight.BackColor = System.Drawing.Color.GhostWhite;
            this.numericHeight.ForeColor = System.Drawing.Color.Indigo;
            this.numericHeight.Location = new System.Drawing.Point(109, 166);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 20);
            this.numericHeight.TabIndex = 6;
            // 
            // numericSpeed
            // 
            this.numericSpeed.BackColor = System.Drawing.Color.GhostWhite;
            this.numericSpeed.ForeColor = System.Drawing.Color.Indigo;
            this.numericSpeed.Location = new System.Drawing.Point(109, 129);
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericSpeed.TabIndex = 5;
            this.numericSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.BackColor = System.Drawing.Color.Transparent;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.Color.Indigo;
            this.labelHeight.Location = new System.Drawing.Point(22, 164);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(69, 21);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.Indigo;
            this.labelSpeed.Location = new System.Drawing.Point(22, 127);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(62, 21);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Speed:";
            // 
            // numericAngle
            // 
            this.numericAngle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericAngle.ForeColor = System.Drawing.Color.Indigo;
            this.numericAngle.Location = new System.Drawing.Point(109, 93);
            this.numericAngle.Name = "numericAngle";
            this.numericAngle.Size = new System.Drawing.Size(120, 20);
            this.numericAngle.TabIndex = 2;
            this.numericAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.BackColor = System.Drawing.Color.Transparent;
            this.labelAngle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngle.ForeColor = System.Drawing.Color.Indigo;
            this.labelAngle.Location = new System.Drawing.Point(22, 91);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(61, 21);
            this.labelAngle.TabIndex = 1;
            this.labelAngle.Text = "Angle:";
            // 
            // titleData
            // 
            this.titleData.AutoSize = true;
            this.titleData.BackColor = System.Drawing.Color.Transparent;
            this.titleData.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleData.ForeColor = System.Drawing.Color.Indigo;
            this.titleData.Location = new System.Drawing.Point(82, 32);
            this.titleData.Name = "titleData";
            this.titleData.Size = new System.Drawing.Size(71, 34);
            this.titleData.TabIndex = 0;
            this.titleData.Text = "Data:";
            // 
            // chart
            // 
            this.chart.BackImage = "C:\\Users\\Alyona\\Desktop\\bg.jpg";
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1160, 691);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
           
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonContinue.FlatAppearance.BorderSize = 0;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContinue.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonContinue.Location = new System.Drawing.Point(26, 446);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(203, 44);
            this.buttonContinue.TabIndex = 11;
            this.buttonContinue.Text = "CONTINUE";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FlightWithoutAtmosphere.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1414, 691);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "FightWithoutAtmosphere";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numericAngle;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label titleData;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.Label titleActions;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonContinue;
    }
}

