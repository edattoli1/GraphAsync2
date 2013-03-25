namespace GraphAsync1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timeElapsedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.loadFlowsButton = new System.Windows.Forms.Button();
            this.viewFlowRecipe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mfc2Display = new System.Windows.Forms.Label();
            this.mfc1Display = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MFC4maxFlow = new System.Windows.Forms.Label();
            this.MFC3maxFlow = new System.Windows.Forms.Label();
            this.mfcPresFlowBox3 = new System.Windows.Forms.TextBox();
            this.mfcPlotCheck4 = new System.Windows.Forms.CheckBox();
            this.MFC3checkBox = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.mfcPlotCheck2 = new System.Windows.Forms.CheckBox();
            this.mfcPresFlowBox2 = new System.Windows.Forms.TextBox();
            this.mfc2TextBox = new System.Windows.Forms.NumericUpDown();
            this.mfcPresFlowBox1 = new System.Windows.Forms.TextBox();
            this.mfc1TextBox = new System.Windows.Forms.NumericUpDown();
            this.MFC1maxLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MFC2maxFlow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MFC2checkBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MFC1checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mfcPlotCheck1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.MFC4checkBox = new System.Windows.Forms.CheckBox();
            this.mfcPlotCheck3 = new System.Windows.Forms.CheckBox();
            this.mfcPresFlowBox4 = new System.Windows.Forms.TextBox();
            this.mfc3TextBox = new System.Windows.Forms.NumericUpDown();
            this.mfc4TextBox = new System.Windows.Forms.NumericUpDown();
            this.configMFCsButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nextRecipeTimeEventBox = new System.Windows.Forms.TextBox();
            this.lastRecipeTimeEventBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.recipePauseCheckbox = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.exitRecipeButton = new System.Windows.Forms.Button();
            this.resetGraphButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.samplesToResetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.AinGraphUpdateBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.graphUpdateUDbox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfc2TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfc1TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfc3TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfc4TextBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesToResetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphUpdateUDbox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 7);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=False";
            series1.Legend = "Legend1";
            series1.Name = "MFC1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "IsXAxisQuantitative=False";
            series2.Legend = "Legend1";
            series2.Name = "MFC2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "MFC3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "MFC4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(651, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timeElapsedBox
            // 
            this.timeElapsedBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeElapsedBox.Enabled = false;
            this.timeElapsedBox.Location = new System.Drawing.Point(820, 271);
            this.timeElapsedBox.Name = "timeElapsedBox";
            this.timeElapsedBox.ReadOnly = true;
            this.timeElapsedBox.Size = new System.Drawing.Size(66, 22);
            this.timeElapsedBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Elapsed (min):";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(8, 128);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadFlowsButton
            // 
            this.loadFlowsButton.Location = new System.Drawing.Point(137, 128);
            this.loadFlowsButton.Name = "loadFlowsButton";
            this.loadFlowsButton.Size = new System.Drawing.Size(143, 23);
            this.loadFlowsButton.TabIndex = 6;
            this.loadFlowsButton.Text = "Load Flow Recipe";
            this.loadFlowsButton.UseVisualStyleBackColor = true;
            this.loadFlowsButton.Click += new System.EventHandler(this.loadFlowsButton_Click);
            // 
            // viewFlowRecipe
            // 
            this.viewFlowRecipe.Location = new System.Drawing.Point(137, 165);
            this.viewFlowRecipe.Name = "viewFlowRecipe";
            this.viewFlowRecipe.Size = new System.Drawing.Size(143, 23);
            this.viewFlowRecipe.TabIndex = 7;
            this.viewFlowRecipe.Text = "View Flow Recipe";
            this.viewFlowRecipe.UseVisualStyleBackColor = true;
            this.viewFlowRecipe.Click += new System.EventHandler(this.viewFlowRecipe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel2007+|*.xlsx";
            // 
            // mfc2Display
            // 
            this.mfc2Display.AutoSize = true;
            this.mfc2Display.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mfc2Display.Location = new System.Drawing.Point(8, 81);
            this.mfc2Display.Margin = new System.Windows.Forms.Padding(8);
            this.mfc2Display.Name = "mfc2Display";
            this.mfc2Display.Size = new System.Drawing.Size(16, 17);
            this.mfc2Display.TabIndex = 11;
            this.mfc2Display.Text = "2";
            // 
            // mfc1Display
            // 
            this.mfc1Display.AutoSize = true;
            this.mfc1Display.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mfc1Display.Location = new System.Drawing.Point(8, 35);
            this.mfc1Display.Margin = new System.Windows.Forms.Padding(8);
            this.mfc1Display.Name = "mfc1Display";
            this.mfc1Display.Size = new System.Drawing.Size(16, 17);
            this.mfc1Display.TabIndex = 10;
            this.mfc1Display.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "MFC STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 11);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enable?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 11);
            this.label4.TabIndex = 18;
            this.label4.Text = "Set Flow";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.configMFCsButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 303);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MFC4maxFlow, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.MFC3maxFlow, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.mfcPresFlowBox3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.mfcPlotCheck4, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.MFC3checkBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mfcPlotCheck2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.mfcPresFlowBox2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.mfc2TextBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.mfcPresFlowBox1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.mfc1TextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.MFC1maxLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MFC2maxFlow, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MFC2checkBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mfc1Display, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.MFC1checkBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.mfc2Display, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mfcPlotCheck1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MFC4checkBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.mfcPlotCheck3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.mfcPresFlowBox4, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.mfc3TextBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.mfc4TextBox, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 206);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // MFC4maxFlow
            // 
            this.MFC4maxFlow.AutoSize = true;
            this.MFC4maxFlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC4maxRange", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC4maxFlow.Location = new System.Drawing.Point(230, 164);
            this.MFC4maxFlow.Margin = new System.Windows.Forms.Padding(8);
            this.MFC4maxFlow.Name = "MFC4maxFlow";
            this.MFC4maxFlow.Size = new System.Drawing.Size(32, 17);
            this.MFC4maxFlow.TabIndex = 47;
            this.MFC4maxFlow.Text = global::GraphAsync1.Settings1.Default.MFC4maxRange;
            // 
            // MFC3maxFlow
            // 
            this.MFC3maxFlow.AutoSize = true;
            this.MFC3maxFlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC3maxRange", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC3maxFlow.Location = new System.Drawing.Point(230, 123);
            this.MFC3maxFlow.Margin = new System.Windows.Forms.Padding(8);
            this.MFC3maxFlow.Name = "MFC3maxFlow";
            this.MFC3maxFlow.Size = new System.Drawing.Size(32, 17);
            this.MFC3maxFlow.TabIndex = 46;
            this.MFC3maxFlow.Text = global::GraphAsync1.Settings1.Default.MFC3maxRange;
            // 
            // mfcPresFlowBox3
            // 
            this.mfcPresFlowBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mfcPresFlowBox3.Enabled = false;
            this.mfcPresFlowBox3.Location = new System.Drawing.Point(376, 123);
            this.mfcPresFlowBox3.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPresFlowBox3.Name = "mfcPresFlowBox3";
            this.mfcPresFlowBox3.Size = new System.Drawing.Size(45, 22);
            this.mfcPresFlowBox3.TabIndex = 32;
            // 
            // mfcPlotCheck4
            // 
            this.mfcPlotCheck4.AutoSize = true;
            this.mfcPlotCheck4.Checked = global::GraphAsync1.Settings1.Default.MFC4PlotEnable;
            this.mfcPlotCheck4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC4PlotEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mfcPlotCheck4.Location = new System.Drawing.Point(456, 164);
            this.mfcPlotCheck4.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPlotCheck4.Name = "mfcPlotCheck4";
            this.mfcPlotCheck4.Size = new System.Drawing.Size(15, 14);
            this.mfcPlotCheck4.TabIndex = 42;
            this.mfcPlotCheck4.UseVisualStyleBackColor = true;
            this.mfcPlotCheck4.CheckedChanged += new System.EventHandler(this.mfcPlotCheck4_CheckedChanged);
            // 
            // MFC3checkBox
            // 
            this.MFC3checkBox.AutoSize = true;
            this.MFC3checkBox.Checked = global::GraphAsync1.Settings1.Default.MFC3enable;
            this.MFC3checkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC3enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC3checkBox.Location = new System.Drawing.Point(159, 123);
            this.MFC3checkBox.Margin = new System.Windows.Forms.Padding(8);
            this.MFC3checkBox.Name = "MFC3checkBox";
            this.MFC3checkBox.Size = new System.Drawing.Size(15, 14);
            this.MFC3checkBox.TabIndex = 39;
            this.MFC3checkBox.UseVisualStyleBackColor = true;
            this.MFC3checkBox.CheckedChanged += new System.EventHandler(this.MFC3checkBox_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC3Gas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label19.Location = new System.Drawing.Point(53, 123);
            this.label19.Margin = new System.Windows.Forms.Padding(8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 17);
            this.label19.TabIndex = 37;
            this.label19.Text = global::GraphAsync1.Settings1.Default.MFC3Gas;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 8);
            this.label16.Margin = new System.Windows.Forms.Padding(8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 11);
            this.label16.TabIndex = 35;
            this.label16.Text = "MFC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label15.Location = new System.Drawing.Point(8, 123);
            this.label15.Margin = new System.Windows.Forms.Padding(8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "3";
            // 
            // mfcPlotCheck2
            // 
            this.mfcPlotCheck2.AutoSize = true;
            this.mfcPlotCheck2.Checked = global::GraphAsync1.Settings1.Default.MFC2PlotEnable;
            this.mfcPlotCheck2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mfcPlotCheck2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC2PlotEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mfcPlotCheck2.Location = new System.Drawing.Point(456, 81);
            this.mfcPlotCheck2.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPlotCheck2.Name = "mfcPlotCheck2";
            this.mfcPlotCheck2.Size = new System.Drawing.Size(15, 14);
            this.mfcPlotCheck2.TabIndex = 28;
            this.mfcPlotCheck2.UseVisualStyleBackColor = true;
            this.mfcPlotCheck2.CheckedChanged += new System.EventHandler(this.mfcPlotCheck2_CheckedChanged);
            // 
            // mfcPresFlowBox2
            // 
            this.mfcPresFlowBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mfcPresFlowBox2.Enabled = false;
            this.mfcPresFlowBox2.Location = new System.Drawing.Point(376, 81);
            this.mfcPresFlowBox2.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPresFlowBox2.Name = "mfcPresFlowBox2";
            this.mfcPresFlowBox2.Size = new System.Drawing.Size(45, 22);
            this.mfcPresFlowBox2.TabIndex = 31;
            // 
            // mfc2TextBox
            // 
            this.mfc2TextBox.DecimalPlaces = 2;
            this.mfc2TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mfc2TextBox.Location = new System.Drawing.Point(299, 81);
            this.mfc2TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.mfc2TextBox.Name = "mfc2TextBox";
            this.mfc2TextBox.Size = new System.Drawing.Size(54, 22);
            this.mfc2TextBox.TabIndex = 32;
            this.mfc2TextBox.ValueChanged += new System.EventHandler(this.mfc2TextBox_ValueChanged);
            // 
            // mfcPresFlowBox1
            // 
            this.mfcPresFlowBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mfcPresFlowBox1.Enabled = false;
            this.mfcPresFlowBox1.Location = new System.Drawing.Point(376, 35);
            this.mfcPresFlowBox1.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPresFlowBox1.Name = "mfcPresFlowBox1";
            this.mfcPresFlowBox1.Size = new System.Drawing.Size(45, 22);
            this.mfcPresFlowBox1.TabIndex = 30;
            // 
            // mfc1TextBox
            // 
            this.mfc1TextBox.DecimalPlaces = 2;
            this.mfc1TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mfc1TextBox.Location = new System.Drawing.Point(299, 35);
            this.mfc1TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.mfc1TextBox.Name = "mfc1TextBox";
            this.mfc1TextBox.Size = new System.Drawing.Size(54, 22);
            this.mfc1TextBox.TabIndex = 16;
            this.mfc1TextBox.ValueChanged += new System.EventHandler(this.mfc1TextBox_ValueChanged);
            // 
            // MFC1maxLabel
            // 
            this.MFC1maxLabel.AutoSize = true;
            this.MFC1maxLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC1maxRange", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC1maxLabel.Location = new System.Drawing.Point(230, 35);
            this.MFC1maxLabel.Margin = new System.Windows.Forms.Padding(8);
            this.MFC1maxLabel.Name = "MFC1maxLabel";
            this.MFC1maxLabel.Size = new System.Drawing.Size(40, 17);
            this.MFC1maxLabel.TabIndex = 20;
            this.MFC1maxLabel.Text = global::GraphAsync1.Settings1.Default.MFC1maxRange;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC1Gas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Location = new System.Drawing.Point(53, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = global::GraphAsync1.Settings1.Default.MFC1Gas;
            // 
            // MFC2maxFlow
            // 
            this.MFC2maxFlow.AutoSize = true;
            this.MFC2maxFlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC2maxRange", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC2maxFlow.Location = new System.Drawing.Point(230, 81);
            this.MFC2maxFlow.Margin = new System.Windows.Forms.Padding(8);
            this.MFC2maxFlow.Name = "MFC2maxFlow";
            this.MFC2maxFlow.Size = new System.Drawing.Size(32, 17);
            this.MFC2maxFlow.TabIndex = 21;
            this.MFC2maxFlow.Text = global::GraphAsync1.Settings1.Default.MFC2maxRange;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC2Gas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Location = new System.Drawing.Point(53, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = global::GraphAsync1.Settings1.Default.MFC2Gas;
            // 
            // MFC2checkBox
            // 
            this.MFC2checkBox.AutoSize = true;
            this.MFC2checkBox.Checked = global::GraphAsync1.Settings1.Default.MFC2enable;
            this.MFC2checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MFC2checkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC2enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC2checkBox.Location = new System.Drawing.Point(159, 81);
            this.MFC2checkBox.Margin = new System.Windows.Forms.Padding(8);
            this.MFC2checkBox.Name = "MFC2checkBox";
            this.MFC2checkBox.Size = new System.Drawing.Size(15, 14);
            this.MFC2checkBox.TabIndex = 16;
            this.MFC2checkBox.UseVisualStyleBackColor = true;
            this.MFC2checkBox.CheckedChanged += new System.EventHandler(this.MFC2checkBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 11);
            this.label9.TabIndex = 26;
            this.label9.Text = "Plot?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 11);
            this.label10.TabIndex = 29;
            this.label10.Text = "Pres. Flow";
            // 
            // MFC1checkBox
            // 
            this.MFC1checkBox.AutoSize = true;
            this.MFC1checkBox.Checked = global::GraphAsync1.Settings1.Default.MFC1enable;
            this.MFC1checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MFC1checkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC1enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC1checkBox.Location = new System.Drawing.Point(159, 35);
            this.MFC1checkBox.Margin = new System.Windows.Forms.Padding(8);
            this.MFC1checkBox.Name = "MFC1checkBox";
            this.MFC1checkBox.Size = new System.Drawing.Size(15, 14);
            this.MFC1checkBox.TabIndex = 15;
            this.MFC1checkBox.UseVisualStyleBackColor = true;
            this.MFC1checkBox.CheckedChanged += new System.EventHandler(this.MFC1checkBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 11);
            this.label5.TabIndex = 19;
            this.label5.Text = "Max Flow";
            // 
            // mfcPlotCheck1
            // 
            this.mfcPlotCheck1.AutoSize = true;
            this.mfcPlotCheck1.Checked = global::GraphAsync1.Settings1.Default.MFC1PlotEnable;
            this.mfcPlotCheck1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mfcPlotCheck1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC1PlotEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mfcPlotCheck1.Location = new System.Drawing.Point(456, 35);
            this.mfcPlotCheck1.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPlotCheck1.Name = "mfcPlotCheck1";
            this.mfcPlotCheck1.Size = new System.Drawing.Size(15, 14);
            this.mfcPlotCheck1.TabIndex = 27;
            this.mfcPlotCheck1.UseVisualStyleBackColor = true;
            this.mfcPlotCheck1.CheckedChanged += new System.EventHandler(this.mfcPlotCheck1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 11);
            this.label6.TabIndex = 22;
            this.label6.Text = "Gas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Location = new System.Drawing.Point(8, 164);
            this.label17.Margin = new System.Windows.Forms.Padding(8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GraphAsync1.Settings1.Default, "MFC4Gas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label20.Location = new System.Drawing.Point(53, 164);
            this.label20.Margin = new System.Windows.Forms.Padding(8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = global::GraphAsync1.Settings1.Default.MFC4Gas;
            // 
            // MFC4checkBox
            // 
            this.MFC4checkBox.AutoSize = true;
            this.MFC4checkBox.Checked = global::GraphAsync1.Settings1.Default.MFC4enable;
            this.MFC4checkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC4enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MFC4checkBox.Location = new System.Drawing.Point(159, 164);
            this.MFC4checkBox.Margin = new System.Windows.Forms.Padding(8);
            this.MFC4checkBox.Name = "MFC4checkBox";
            this.MFC4checkBox.Size = new System.Drawing.Size(15, 14);
            this.MFC4checkBox.TabIndex = 40;
            this.MFC4checkBox.UseVisualStyleBackColor = true;
            this.MFC4checkBox.CheckedChanged += new System.EventHandler(this.MFC4checkBox_CheckedChanged);
            // 
            // mfcPlotCheck3
            // 
            this.mfcPlotCheck3.AutoSize = true;
            this.mfcPlotCheck3.Checked = global::GraphAsync1.Settings1.Default.MFC3PlotEnable;
            this.mfcPlotCheck3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GraphAsync1.Settings1.Default, "MFC3PlotEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mfcPlotCheck3.Location = new System.Drawing.Point(456, 123);
            this.mfcPlotCheck3.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPlotCheck3.Name = "mfcPlotCheck3";
            this.mfcPlotCheck3.Size = new System.Drawing.Size(15, 14);
            this.mfcPlotCheck3.TabIndex = 41;
            this.mfcPlotCheck3.UseVisualStyleBackColor = true;
            this.mfcPlotCheck3.CheckedChanged += new System.EventHandler(this.mfcPlotCheck3_CheckedChanged);
            // 
            // mfcPresFlowBox4
            // 
            this.mfcPresFlowBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mfcPresFlowBox4.Enabled = false;
            this.mfcPresFlowBox4.Location = new System.Drawing.Point(376, 164);
            this.mfcPresFlowBox4.Margin = new System.Windows.Forms.Padding(8);
            this.mfcPresFlowBox4.Name = "mfcPresFlowBox4";
            this.mfcPresFlowBox4.Size = new System.Drawing.Size(45, 22);
            this.mfcPresFlowBox4.TabIndex = 43;
            // 
            // mfc3TextBox
            // 
            this.mfc3TextBox.DecimalPlaces = 2;
            this.mfc3TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mfc3TextBox.Location = new System.Drawing.Point(299, 123);
            this.mfc3TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.mfc3TextBox.Name = "mfc3TextBox";
            this.mfc3TextBox.Size = new System.Drawing.Size(54, 22);
            this.mfc3TextBox.TabIndex = 44;
            // 
            // mfc4TextBox
            // 
            this.mfc4TextBox.DecimalPlaces = 2;
            this.mfc4TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mfc4TextBox.Location = new System.Drawing.Point(299, 164);
            this.mfc4TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.mfc4TextBox.Name = "mfc4TextBox";
            this.mfc4TextBox.Size = new System.Drawing.Size(54, 22);
            this.mfc4TextBox.TabIndex = 45;
            // 
            // configMFCsButton
            // 
            this.configMFCsButton.Location = new System.Drawing.Point(3, 255);
            this.configMFCsButton.Name = "configMFCsButton";
            this.configMFCsButton.Size = new System.Drawing.Size(87, 43);
            this.configMFCsButton.TabIndex = 25;
            this.configMFCsButton.Text = "Configure MFCs";
            this.configMFCsButton.UseVisualStyleBackColor = true;
            this.configMFCsButton.Click += new System.EventHandler(this.configMFCbuttonClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "RECIPE CONTROL";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nextRecipeTimeEventBox);
            this.panel2.Controls.Add(this.lastRecipeTimeEventBox);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.recipePauseCheckbox);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.exitRecipeButton);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Controls.Add(this.viewFlowRecipe);
            this.panel2.Controls.Add(this.loadFlowsButton);
            this.panel2.Location = new System.Drawing.Point(577, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 265);
            this.panel2.TabIndex = 17;
            // 
            // nextRecipeTimeEventBox
            // 
            this.nextRecipeTimeEventBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nextRecipeTimeEventBox.Enabled = false;
            this.nextRecipeTimeEventBox.Location = new System.Drawing.Point(164, 81);
            this.nextRecipeTimeEventBox.Name = "nextRecipeTimeEventBox";
            this.nextRecipeTimeEventBox.ReadOnly = true;
            this.nextRecipeTimeEventBox.Size = new System.Drawing.Size(88, 22);
            this.nextRecipeTimeEventBox.TabIndex = 23;
            // 
            // lastRecipeTimeEventBox
            // 
            this.lastRecipeTimeEventBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lastRecipeTimeEventBox.Enabled = false;
            this.lastRecipeTimeEventBox.Location = new System.Drawing.Point(164, 51);
            this.lastRecipeTimeEventBox.Name = "lastRecipeTimeEventBox";
            this.lastRecipeTimeEventBox.ReadOnly = true;
            this.lastRecipeTimeEventBox.Size = new System.Drawing.Size(88, 22);
            this.lastRecipeTimeEventBox.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 17);
            this.label23.TabIndex = 21;
            this.label23.Text = "Next Event (min):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "Last Event (min):";
            // 
            // recipePauseCheckbox
            // 
            this.recipePauseCheckbox.AutoSize = true;
            this.recipePauseCheckbox.Location = new System.Drawing.Point(67, 170);
            this.recipePauseCheckbox.Name = "recipePauseCheckbox";
            this.recipePauseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.recipePauseCheckbox.TabIndex = 19;
            this.recipePauseCheckbox.UseVisualStyleBackColor = true;
            this.recipePauseCheckbox.CheckedChanged += new System.EventHandler(this.recipePauseCheckbox_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Pause?";
            // 
            // exitRecipeButton
            // 
            this.exitRecipeButton.Location = new System.Drawing.Point(8, 204);
            this.exitRecipeButton.Name = "exitRecipeButton";
            this.exitRecipeButton.Size = new System.Drawing.Size(75, 49);
            this.exitRecipeButton.TabIndex = 17;
            this.exitRecipeButton.Text = "Exit Recipe";
            this.exitRecipeButton.UseVisualStyleBackColor = true;
            this.exitRecipeButton.Click += new System.EventHandler(this.exitRecipe_Click);
            // 
            // resetGraphButton
            // 
            this.resetGraphButton.Location = new System.Drawing.Point(685, 78);
            this.resetGraphButton.Name = "resetGraphButton";
            this.resetGraphButton.Size = new System.Drawing.Size(75, 44);
            this.resetGraphButton.TabIndex = 18;
            this.resetGraphButton.Text = "Reset Graph";
            this.resetGraphButton.UseVisualStyleBackColor = true;
            this.resetGraphButton.Click += new System.EventHandler(this.resetGraphButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.samplesToResetUpDown);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.AinGraphUpdateBox);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.graphUpdateUDbox);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.resetGraphButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.timeElapsedBox);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 319);
            this.panel3.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(676, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "GRAPH CONTROL";
            // 
            // samplesToResetUpDown
            // 
            this.samplesToResetUpDown.Location = new System.Drawing.Point(822, 201);
            this.samplesToResetUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.samplesToResetUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.samplesToResetUpDown.Name = "samplesToResetUpDown";
            this.samplesToResetUpDown.Size = new System.Drawing.Size(73, 22);
            this.samplesToResetUpDown.TabIndex = 24;
            this.samplesToResetUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.samplesToResetUpDown.ValueChanged += new System.EventHandler(this.samplesToResetUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(676, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Samples until Reset:";
            // 
            // AinGraphUpdateBox
            // 
            this.AinGraphUpdateBox.AutoSize = true;
            this.AinGraphUpdateBox.Checked = true;
            this.AinGraphUpdateBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AinGraphUpdateBox.Location = new System.Drawing.Point(808, 160);
            this.AinGraphUpdateBox.Name = "AinGraphUpdateBox";
            this.AinGraphUpdateBox.Size = new System.Drawing.Size(15, 14);
            this.AinGraphUpdateBox.TabIndex = 22;
            this.AinGraphUpdateBox.UseVisualStyleBackColor = true;
            this.AinGraphUpdateBox.CheckedChanged += new System.EventHandler(this.AinGraphUpdateBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(686, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Graph Update?";
            // 
            // graphUpdateUDbox
            // 
            this.graphUpdateUDbox.DecimalPlaces = 1;
            this.graphUpdateUDbox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.graphUpdateUDbox.Location = new System.Drawing.Point(807, 236);
            this.graphUpdateUDbox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.graphUpdateUDbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.graphUpdateUDbox.Name = "graphUpdateUDbox";
            this.graphUpdateUDbox.Size = new System.Drawing.Size(79, 22);
            this.graphUpdateUDbox.TabIndex = 20;
            this.graphUpdateUDbox.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.graphUpdateUDbox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Update Time (s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Main Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfc2TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfc1TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfc3TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfc4TextBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesToResetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphUpdateUDbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox timeElapsedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadFlowsButton;
        private System.Windows.Forms.Button viewFlowRecipe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label mfc2Display;
        private System.Windows.Forms.Label mfc1Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MFC1checkBox;
        private System.Windows.Forms.CheckBox MFC2checkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MFC1maxLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button configMFCsButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox mfcPlotCheck1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox mfcPlotCheck2;
        private System.Windows.Forms.TextBox mfcPresFlowBox2;
        private System.Windows.Forms.NumericUpDown mfc2TextBox;
        private System.Windows.Forms.TextBox mfcPresFlowBox1;
        private System.Windows.Forms.NumericUpDown mfc1TextBox;
        private System.Windows.Forms.Label MFC2maxFlow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resetGraphButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown graphUpdateUDbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox AinGraphUpdateBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown samplesToResetUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox MFC3checkBox;
        private System.Windows.Forms.CheckBox MFC4checkBox;
        private System.Windows.Forms.CheckBox mfcPlotCheck4;
        private System.Windows.Forms.CheckBox mfcPlotCheck3;
        private System.Windows.Forms.TextBox mfcPresFlowBox3;
        private System.Windows.Forms.TextBox mfcPresFlowBox4;
        private System.Windows.Forms.NumericUpDown mfc3TextBox;
        private System.Windows.Forms.Label MFC4maxFlow;
        private System.Windows.Forms.Label MFC3maxFlow;
        private System.Windows.Forms.NumericUpDown mfc4TextBox;
        private System.Windows.Forms.Button exitRecipeButton;
        private System.Windows.Forms.CheckBox recipePauseCheckbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox lastRecipeTimeEventBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox nextRecipeTimeEventBox;
    }
}

