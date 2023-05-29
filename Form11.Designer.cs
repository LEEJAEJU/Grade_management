namespace exam_program
{
    partial class Form11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            close = new System.Windows.Forms.Button();
            grade_sort = new System.Windows.Forms.Button();
            name_sort = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            next_quzi = new System.Windows.Forms.Button();
            quzi_num = new System.Windows.Forms.Label();
            rigth_rating = new System.Windows.Forms.Label();
            pie_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            back_quzi = new System.Windows.Forms.Button();
            save_dd = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pie_chart).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.BackgroundImage = Properties.Resources.close_btn;
            close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            close.Location = new System.Drawing.Point(1063, 677);
            close.Name = "close";
            close.Size = new System.Drawing.Size(98, 62);
            close.TabIndex = 0;
            close.UseVisualStyleBackColor = true;
            close.Click += button3_Click;
            // 
            // grade_sort
            // 
            grade_sort.BackgroundImage = Properties.Resources.grade_sort;
            grade_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            grade_sort.Location = new System.Drawing.Point(1027, 450);
            grade_sort.Name = "grade_sort";
            grade_sort.Size = new System.Drawing.Size(56, 54);
            grade_sort.TabIndex = 2;
            grade_sort.UseVisualStyleBackColor = true;
            grade_sort.Click += button4_Click;
            // 
            // name_sort
            // 
            name_sort.BackgroundImage = Properties.Resources.name_sort;
            name_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            name_sort.Location = new System.Drawing.Point(1027, 390);
            name_sort.Name = "name_sort";
            name_sort.Size = new System.Drawing.Size(56, 54);
            name_sort.TabIndex = 3;
            name_sort.UseVisualStyleBackColor = true;
            name_sort.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(793, 330);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellErrorTextChanged += dataGridView1_CellErrorTextChanged;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new System.Drawing.Point(12, 348);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Grade";
            chart1.Series.Add(series1);
            chart1.Size = new System.Drawing.Size(1160, 401);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // next_quzi
            // 
            next_quzi.BackgroundImage = Properties.Resources.next_btn;
            next_quzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            next_quzi.Location = new System.Drawing.Point(1115, 297);
            next_quzi.Name = "next_quzi";
            next_quzi.Size = new System.Drawing.Size(46, 33);
            next_quzi.TabIndex = 7;
            next_quzi.UseVisualStyleBackColor = true;
            next_quzi.Click += next_quzi_Click;
            // 
            // quzi_num
            // 
            quzi_num.AutoSize = true;
            quzi_num.BackColor = System.Drawing.Color.White;
            quzi_num.Location = new System.Drawing.Point(824, 315);
            quzi_num.Name = "quzi_num";
            quzi_num.Size = new System.Drawing.Size(39, 15);
            quzi_num.TabIndex = 8;
            quzi_num.Text = "label1";
            // 
            // rigth_rating
            // 
            rigth_rating.AutoSize = true;
            rigth_rating.BackColor = System.Drawing.Color.White;
            rigth_rating.Location = new System.Drawing.Point(824, 22);
            rigth_rating.Name = "rigth_rating";
            rigth_rating.Size = new System.Drawing.Size(39, 15);
            rigth_rating.TabIndex = 9;
            rigth_rating.Text = "label1";
            // 
            // pie_chart
            // 
            chartArea2.Name = "ChartArea1";
            pie_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            pie_chart.Legends.Add(legend2);
            pie_chart.Location = new System.Drawing.Point(811, 12);
            pie_chart.Name = "pie_chart";
            pie_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "rate";
            pie_chart.Series.Add(series2);
            pie_chart.Size = new System.Drawing.Size(361, 330);
            pie_chart.TabIndex = 6;
            pie_chart.Text = "chart2";
            // 
            // back_quzi
            // 
            back_quzi.BackgroundImage = Properties.Resources.back_btn;
            back_quzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            back_quzi.Location = new System.Drawing.Point(1063, 297);
            back_quzi.Name = "back_quzi";
            back_quzi.Size = new System.Drawing.Size(46, 33);
            back_quzi.TabIndex = 11;
            back_quzi.UseVisualStyleBackColor = true;
            back_quzi.Click += back_quzi_Click;
            // 
            // save_dd
            // 
            save_dd.BackgroundImage = Properties.Resources.save_as;
            save_dd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            save_dd.Location = new System.Drawing.Point(1027, 510);
            save_dd.Name = "save_dd";
            save_dd.Size = new System.Drawing.Size(56, 54);
            save_dd.TabIndex = 12;
            save_dd.UseVisualStyleBackColor = true;
            save_dd.Click += save_dd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 348);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // Form11
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1184, 761);
            Controls.Add(textBox1);
            Controls.Add(save_dd);
            Controls.Add(back_quzi);
            Controls.Add(rigth_rating);
            Controls.Add(quzi_num);
            Controls.Add(next_quzi);
            Controls.Add(dataGridView1);
            Controls.Add(name_sort);
            Controls.Add(grade_sort);
            Controls.Add(close);
            Controls.Add(pie_chart);
            Controls.Add(chart1);
            Name = "Form11";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pie_chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button grade_sort;
        private System.Windows.Forms.Button name_sort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button next_quzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quzi_num;
        private System.Windows.Forms.Label rigth_rating;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_chart;
        private System.Windows.Forms.Button back_quzi;
        private System.Windows.Forms.Button save_dd;
        private System.Windows.Forms.TextBox textBox1;
    }
}