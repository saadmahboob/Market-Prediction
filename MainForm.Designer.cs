﻿namespace MarketPrediction
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChart = new System.Windows.Forms.Panel();
            this.checkBoxDpo = new System.Windows.Forms.CheckBox();
            this.checkBoxPpo = new System.Windows.Forms.CheckBox();
            this.checkBoxIndex = new System.Windows.Forms.CheckBox();
            this.checkBoxMacd = new System.Windows.Forms.CheckBox();
            this.checkBoxRsi = new System.Windows.Forms.CheckBox();
            this.checkBoxSma = new System.Windows.Forms.CheckBox();
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxEma = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.groupBoxPlot = new System.Windows.Forms.GroupBox();
            this.groupBoxProcessing = new System.Windows.Forms.GroupBox();
            this.groupBoxIndicators = new System.Windows.Forms.GroupBox();
            this.groupBoxCurrency = new System.Windows.Forms.GroupBox();
            this.tabPageNeuron = new System.Windows.Forms.TabPage();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.progressBarNeuronLearn = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelChart.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.groupBoxPlot.SuspendLayout();
            this.groupBoxProcessing.SuspendLayout();
            this.groupBoxIndicators.SuspendLayout();
            this.groupBoxCurrency.SuspendLayout();
            this.tabPageNeuron.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BorderColor = System.Drawing.Color.Silver;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart.Size = new System.Drawing.Size(806, 491);
            this.chart.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.Controls.Add(this.chart);
            this.panelChart.Location = new System.Drawing.Point(-30, 0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(806, 491);
            this.panelChart.TabIndex = 1;
            // 
            // checkBoxDpo
            // 
            this.checkBoxDpo.AutoSize = true;
            this.checkBoxDpo.Location = new System.Drawing.Point(178, 21);
            this.checkBoxDpo.Name = "checkBoxDpo";
            this.checkBoxDpo.Size = new System.Drawing.Size(49, 17);
            this.checkBoxDpo.TabIndex = 9;
            this.checkBoxDpo.Tag = "MarketPrediction.DetrendedPriceOscillation";
            this.checkBoxDpo.Text = "DPO";
            this.toolTip.SetToolTip(this.checkBoxDpo, "Detrended Price Oscillation");
            this.checkBoxDpo.UseVisualStyleBackColor = true;
            this.checkBoxDpo.CheckedChanged += new System.EventHandler(this.checkBoxIndicator_CheckedChanged);
            // 
            // checkBoxPpo
            // 
            this.checkBoxPpo.AutoSize = true;
            this.checkBoxPpo.Location = new System.Drawing.Point(124, 21);
            this.checkBoxPpo.Name = "checkBoxPpo";
            this.checkBoxPpo.Size = new System.Drawing.Size(48, 17);
            this.checkBoxPpo.TabIndex = 8;
            this.checkBoxPpo.Tag = "MarketPrediction.PercentagePriceOscillator";
            this.checkBoxPpo.Text = "PPO";
            this.toolTip.SetToolTip(this.checkBoxPpo, "Price Percentage Oscillation");
            this.checkBoxPpo.UseVisualStyleBackColor = true;
            this.checkBoxPpo.CheckedChanged += new System.EventHandler(this.checkBoxIndicator_CheckedChanged);
            // 
            // checkBoxIndex
            // 
            this.checkBoxIndex.AutoSize = true;
            this.checkBoxIndex.Location = new System.Drawing.Point(10, 21);
            this.checkBoxIndex.Name = "checkBoxIndex";
            this.checkBoxIndex.Size = new System.Drawing.Size(52, 17);
            this.checkBoxIndex.TabIndex = 7;
            this.checkBoxIndex.Text = "Index";
            this.toolTip.SetToolTip(this.checkBoxIndex, "Currency Index");
            this.checkBoxIndex.UseVisualStyleBackColor = true;
            this.checkBoxIndex.CheckedChanged += new System.EventHandler(this.checkBoxIndex_CheckedChanged);
            // 
            // checkBoxMacd
            // 
            this.checkBoxMacd.AutoSize = true;
            this.checkBoxMacd.Location = new System.Drawing.Point(61, 21);
            this.checkBoxMacd.Name = "checkBoxMacd";
            this.checkBoxMacd.Size = new System.Drawing.Size(57, 17);
            this.checkBoxMacd.TabIndex = 6;
            this.checkBoxMacd.Tag = "MarketPrediction.MovingAverageConvergenceDivergence";
            this.checkBoxMacd.Text = "MACD";
            this.toolTip.SetToolTip(this.checkBoxMacd, "Moving Average Convergence Divergence");
            this.checkBoxMacd.UseVisualStyleBackColor = true;
            this.checkBoxMacd.CheckedChanged += new System.EventHandler(this.checkBoxIndicator_CheckedChanged);
            // 
            // checkBoxRsi
            // 
            this.checkBoxRsi.AutoSize = true;
            this.checkBoxRsi.Location = new System.Drawing.Point(11, 21);
            this.checkBoxRsi.Name = "checkBoxRsi";
            this.checkBoxRsi.Size = new System.Drawing.Size(44, 17);
            this.checkBoxRsi.TabIndex = 5;
            this.checkBoxRsi.Tag = "MarketPrediction.RelativeStrengthIndex";
            this.checkBoxRsi.Text = "RSI";
            this.toolTip.SetToolTip(this.checkBoxRsi, "Relative Strength Index");
            this.checkBoxRsi.UseVisualStyleBackColor = true;
            this.checkBoxRsi.CheckedChanged += new System.EventHandler(this.checkBoxIndicator_CheckedChanged);
            // 
            // checkBoxSma
            // 
            this.checkBoxSma.AutoSize = true;
            this.checkBoxSma.Location = new System.Drawing.Point(11, 21);
            this.checkBoxSma.Name = "checkBoxSma";
            this.checkBoxSma.Size = new System.Drawing.Size(49, 17);
            this.checkBoxSma.TabIndex = 1;
            this.checkBoxSma.Tag = "MarketPrediction.SimpleMovingAverage";
            this.checkBoxSma.Text = "SMA";
            this.toolTip.SetToolTip(this.checkBoxSma, "Simple Moving Average");
            this.checkBoxSma.UseVisualStyleBackColor = true;
            this.checkBoxSma.CheckedChanged += new System.EventHandler(this.checkBoxIndicator_CheckedChanged);
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(10, 19);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(272, 21);
            this.comboBoxSeries.TabIndex = 4;
            this.comboBoxSeries.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeries_SelectedIndexChanged);
            // 
            // checkBoxEma
            // 
            this.checkBoxEma.AutoSize = true;
            this.checkBoxEma.Location = new System.Drawing.Point(66, 21);
            this.checkBoxEma.Name = "checkBoxEma";
            this.checkBoxEma.Size = new System.Drawing.Size(49, 17);
            this.checkBoxEma.TabIndex = 2;
            this.checkBoxEma.Tag = "MarketPrediction.ExponentialMovingAverage";
            this.checkBoxEma.Text = "EMA";
            this.toolTip.SetToolTip(this.checkBoxEma, "Exponential Moving Average");
            this.checkBoxEma.UseVisualStyleBackColor = true;
            this.checkBoxEma.CheckedChanged += new System.EventHandler(this.checkBoxIndicator_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageData);
            this.tabControl.Controls.Add(this.tabPageNeuron);
            this.tabControl.Location = new System.Drawing.Point(763, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(320, 467);
            this.tabControl.TabIndex = 4;
            // 
            // tabPageData
            // 
            this.tabPageData.AutoScroll = true;
            this.tabPageData.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.tabPageData.Controls.Add(this.groupBoxPlot);
            this.tabPageData.Controls.Add(this.groupBoxCurrency);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(312, 441);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlot
            // 
            this.groupBoxPlot.Controls.Add(this.groupBoxProcessing);
            this.groupBoxPlot.Controls.Add(this.groupBoxIndicators);
            this.groupBoxPlot.Controls.Add(this.checkBoxIndex);
            this.groupBoxPlot.Location = new System.Drawing.Point(10, 68);
            this.groupBoxPlot.Name = "groupBoxPlot";
            this.groupBoxPlot.Size = new System.Drawing.Size(292, 153);
            this.groupBoxPlot.TabIndex = 11;
            this.groupBoxPlot.TabStop = false;
            this.groupBoxPlot.Text = "Plot";
            // 
            // groupBoxProcessing
            // 
            this.groupBoxProcessing.Controls.Add(this.checkBoxEma);
            this.groupBoxProcessing.Controls.Add(this.checkBoxSma);
            this.groupBoxProcessing.Location = new System.Drawing.Point(10, 44);
            this.groupBoxProcessing.Name = "groupBoxProcessing";
            this.groupBoxProcessing.Size = new System.Drawing.Size(272, 46);
            this.groupBoxProcessing.TabIndex = 9;
            this.groupBoxProcessing.TabStop = false;
            this.groupBoxProcessing.Text = "Processing";
            // 
            // groupBoxIndicators
            // 
            this.groupBoxIndicators.Controls.Add(this.checkBoxRsi);
            this.groupBoxIndicators.Controls.Add(this.checkBoxPpo);
            this.groupBoxIndicators.Controls.Add(this.checkBoxMacd);
            this.groupBoxIndicators.Controls.Add(this.checkBoxDpo);
            this.groupBoxIndicators.Location = new System.Drawing.Point(10, 96);
            this.groupBoxIndicators.Name = "groupBoxIndicators";
            this.groupBoxIndicators.Size = new System.Drawing.Size(272, 46);
            this.groupBoxIndicators.TabIndex = 8;
            this.groupBoxIndicators.TabStop = false;
            this.groupBoxIndicators.Text = "Indicators";
            // 
            // groupBoxCurrency
            // 
            this.groupBoxCurrency.Controls.Add(this.comboBoxSeries);
            this.groupBoxCurrency.Location = new System.Drawing.Point(10, 10);
            this.groupBoxCurrency.Name = "groupBoxCurrency";
            this.groupBoxCurrency.Size = new System.Drawing.Size(292, 52);
            this.groupBoxCurrency.TabIndex = 10;
            this.groupBoxCurrency.TabStop = false;
            this.groupBoxCurrency.Text = "Currency";
            // 
            // tabPageNeuron
            // 
            this.tabPageNeuron.Controls.Add(this.progressBarNeuronLearn);
            this.tabPageNeuron.Controls.Add(this.buttonLearn);
            this.tabPageNeuron.Location = new System.Drawing.Point(4, 22);
            this.tabPageNeuron.Name = "tabPageNeuron";
            this.tabPageNeuron.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNeuron.Size = new System.Drawing.Size(312, 441);
            this.tabPageNeuron.TabIndex = 1;
            this.tabPageNeuron.Text = "Neural Network";
            this.tabPageNeuron.UseVisualStyleBackColor = true;
            // 
            // buttonLearn
            // 
            this.buttonLearn.Location = new System.Drawing.Point(123, 79);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(75, 23);
            this.buttonLearn.TabIndex = 0;
            this.buttonLearn.Text = "Learn";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // progressBarNeuronLearn
            // 
            this.progressBarNeuronLearn.Location = new System.Drawing.Point(10, 407);
            this.progressBarNeuronLearn.Name = "progressBarNeuronLearn";
            this.progressBarNeuronLearn.Size = new System.Drawing.Size(292, 23);
            this.progressBarNeuronLearn.Step = 1;
            this.progressBarNeuronLearn.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarNeuronLearn.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 491);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelChart);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Prediction";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelChart.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.groupBoxPlot.ResumeLayout(false);
            this.groupBoxPlot.PerformLayout();
            this.groupBoxProcessing.ResumeLayout(false);
            this.groupBoxProcessing.PerformLayout();
            this.groupBoxIndicators.ResumeLayout(false);
            this.groupBoxIndicators.PerformLayout();
            this.groupBoxCurrency.ResumeLayout(false);
            this.tabPageNeuron.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.CheckBox checkBoxMacd;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxRsi;
        private System.Windows.Forms.CheckBox checkBoxSma;
        private System.Windows.Forms.CheckBox checkBoxIndex;
        private System.Windows.Forms.CheckBox checkBoxPpo;
        private System.Windows.Forms.CheckBox checkBoxDpo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TabPage tabPageNeuron;
        private System.Windows.Forms.GroupBox groupBoxPlot;
        private System.Windows.Forms.GroupBox groupBoxProcessing;
        private System.Windows.Forms.GroupBox groupBoxIndicators;
        private System.Windows.Forms.GroupBox groupBoxCurrency;
        private System.Windows.Forms.CheckBox checkBoxEma;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.ProgressBar progressBarNeuronLearn;
    }
}

