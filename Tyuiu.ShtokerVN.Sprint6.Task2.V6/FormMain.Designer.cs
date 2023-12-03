
namespace Tyuiu.ShtokerVN.Sprint6.Task2.V6
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SHVN = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOutPut_SHVN = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_SHVN = new System.Windows.Forms.GroupBox();
            this.textBoxNamedOne_SHVN = new System.Windows.Forms.TextBox();
            this.chartNamedOne_SHVN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_SHVN = new System.Windows.Forms.Button();
            this.buttonDoneClick_SHVN = new System.Windows.Forms.Button();
            this.textBoxNamedTwo_SHVN = new System.Windows.Forms.TextBox();
            this.textBoxNamedThree_SHVN = new System.Windows.Forms.TextBox();
            this.labelStart_SHVN = new System.Windows.Forms.Label();
            this.labelEnd_SHVN = new System.Windows.Forms.Label();
            this.labelResults_SHVN = new System.Windows.Forms.Label();
            this.labelNamedConditionOne_SHVN = new System.Windows.Forms.Label();
            this.labelNamedConditionTwo_SHVN = new System.Windows.Forms.Label();
            this.dataGridViewFunction_SHVN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_SHVN.SuspendLayout();
            this.groupBoxOutPut_SHVN.SuspendLayout();
            this.groupBoxInPut_SHVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamedOne_SHVN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SHVN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SHVN
            // 
            this.groupBoxTask_SHVN.Controls.Add(this.labelNamedConditionTwo_SHVN);
            this.groupBoxTask_SHVN.Controls.Add(this.labelNamedConditionOne_SHVN);
            this.groupBoxTask_SHVN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SHVN.Name = "groupBoxTask_SHVN";
            this.groupBoxTask_SHVN.Size = new System.Drawing.Size(503, 325);
            this.groupBoxTask_SHVN.TabIndex = 0;
            this.groupBoxTask_SHVN.TabStop = false;
            this.groupBoxTask_SHVN.Text = "Условие";
            // 
            // groupBoxOutPut_SHVN
            // 
            this.groupBoxOutPut_SHVN.Controls.Add(this.dataGridViewFunction_SHVN);
            this.groupBoxOutPut_SHVN.Controls.Add(this.labelResults_SHVN);
            this.groupBoxOutPut_SHVN.Controls.Add(this.chartNamedOne_SHVN);
            this.groupBoxOutPut_SHVN.Controls.Add(this.textBoxNamedOne_SHVN);
            this.groupBoxOutPut_SHVN.Location = new System.Drawing.Point(521, 12);
            this.groupBoxOutPut_SHVN.Name = "groupBoxOutPut_SHVN";
            this.groupBoxOutPut_SHVN.Size = new System.Drawing.Size(667, 426);
            this.groupBoxOutPut_SHVN.TabIndex = 1;
            this.groupBoxOutPut_SHVN.TabStop = false;
            this.groupBoxOutPut_SHVN.Text = "Вывод данных";
            // 
            // groupBoxInPut_SHVN
            // 
            this.groupBoxInPut_SHVN.Controls.Add(this.labelEnd_SHVN);
            this.groupBoxInPut_SHVN.Controls.Add(this.labelStart_SHVN);
            this.groupBoxInPut_SHVN.Controls.Add(this.textBoxNamedThree_SHVN);
            this.groupBoxInPut_SHVN.Controls.Add(this.textBoxNamedTwo_SHVN);
            this.groupBoxInPut_SHVN.Location = new System.Drawing.Point(12, 337);
            this.groupBoxInPut_SHVN.Name = "groupBoxInPut_SHVN";
            this.groupBoxInPut_SHVN.Size = new System.Drawing.Size(274, 95);
            this.groupBoxInPut_SHVN.TabIndex = 2;
            this.groupBoxInPut_SHVN.TabStop = false;
            this.groupBoxInPut_SHVN.Text = "Ввод данных";
            // 
            // textBoxNamedOne_SHVN
            // 
            this.textBoxNamedOne_SHVN.Location = new System.Drawing.Point(6, 42);
            this.textBoxNamedOne_SHVN.Multiline = true;
            this.textBoxNamedOne_SHVN.Name = "textBoxNamedOne_SHVN";
            this.textBoxNamedOne_SHVN.Size = new System.Drawing.Size(655, 378);
            this.textBoxNamedOne_SHVN.TabIndex = 0;
            // 
            // chartNamedOne_SHVN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNamedOne_SHVN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNamedOne_SHVN.Legends.Add(legend1);
            this.chartNamedOne_SHVN.Location = new System.Drawing.Point(155, 42);
            this.chartNamedOne_SHVN.Name = "chartNamedOne_SHVN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNamedOne_SHVN.Series.Add(series1);
            this.chartNamedOne_SHVN.Size = new System.Drawing.Size(506, 378);
            this.chartNamedOne_SHVN.TabIndex = 2;
            // 
            // buttonHelp_SHVN
            // 
            this.buttonHelp_SHVN.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_SHVN.Location = new System.Drawing.Point(292, 343);
            this.buttonHelp_SHVN.Name = "buttonHelp_SHVN";
            this.buttonHelp_SHVN.Size = new System.Drawing.Size(83, 89);
            this.buttonHelp_SHVN.TabIndex = 3;
            this.buttonHelp_SHVN.Text = "Справка";
            this.buttonHelp_SHVN.UseVisualStyleBackColor = false;
            // 
            // buttonDoneClick_SHVN
            // 
            this.buttonDoneClick_SHVN.Location = new System.Drawing.Point(381, 343);
            this.buttonDoneClick_SHVN.Name = "buttonDoneClick_SHVN";
            this.buttonDoneClick_SHVN.Size = new System.Drawing.Size(134, 89);
            this.buttonDoneClick_SHVN.TabIndex = 3;
            this.buttonDoneClick_SHVN.Text = "Выполнить";
            this.buttonDoneClick_SHVN.UseVisualStyleBackColor = true;
            this.buttonDoneClick_SHVN.Click += new System.EventHandler(this.buttonDoneClick_SHVN_Click);
            this.buttonDoneClick_SHVN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDoneClick_SHVN_MouseDown);
            this.buttonDoneClick_SHVN.MouseEnter += new System.EventHandler(this.buttonDoneClick_SHVN_MouseEnter);
            this.buttonDoneClick_SHVN.MouseLeave += new System.EventHandler(this.buttonDoneClick_SHVN_MouseLeave);
            // 
            // textBoxNamedTwo_SHVN
            // 
            this.textBoxNamedTwo_SHVN.Location = new System.Drawing.Point(6, 50);
            this.textBoxNamedTwo_SHVN.Multiline = true;
            this.textBoxNamedTwo_SHVN.Name = "textBoxNamedTwo_SHVN";
            this.textBoxNamedTwo_SHVN.Size = new System.Drawing.Size(131, 19);
            this.textBoxNamedTwo_SHVN.TabIndex = 0;
            this.textBoxNamedTwo_SHVN.Text = "-5";
            // 
            // textBoxNamedThree_SHVN
            // 
            this.textBoxNamedThree_SHVN.Location = new System.Drawing.Point(143, 50);
            this.textBoxNamedThree_SHVN.Multiline = true;
            this.textBoxNamedThree_SHVN.Name = "textBoxNamedThree_SHVN";
            this.textBoxNamedThree_SHVN.Size = new System.Drawing.Size(125, 19);
            this.textBoxNamedThree_SHVN.TabIndex = 0;
            this.textBoxNamedThree_SHVN.Text = "5";
            // 
            // labelStart_SHVN
            // 
            this.labelStart_SHVN.AutoSize = true;
            this.labelStart_SHVN.Location = new System.Drawing.Point(3, 31);
            this.labelStart_SHVN.Name = "labelStart_SHVN";
            this.labelStart_SHVN.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SHVN.TabIndex = 1;
            this.labelStart_SHVN.Text = "Старт шага:";
            // 
            // labelEnd_SHVN
            // 
            this.labelEnd_SHVN.AutoSize = true;
            this.labelEnd_SHVN.Location = new System.Drawing.Point(140, 31);
            this.labelEnd_SHVN.Name = "labelEnd_SHVN";
            this.labelEnd_SHVN.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_SHVN.TabIndex = 1;
            this.labelEnd_SHVN.Text = "Конец шага:";
            this.labelEnd_SHVN.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResults_SHVN
            // 
            this.labelResults_SHVN.AutoSize = true;
            this.labelResults_SHVN.Location = new System.Drawing.Point(3, 26);
            this.labelResults_SHVN.Name = "labelResults_SHVN";
            this.labelResults_SHVN.Size = new System.Drawing.Size(62, 13);
            this.labelResults_SHVN.TabIndex = 3;
            this.labelResults_SHVN.Text = "Результат:";
            // 
            // labelNamedConditionOne_SHVN
            // 
            this.labelNamedConditionOne_SHVN.AutoSize = true;
            this.labelNamedConditionOne_SHVN.Location = new System.Drawing.Point(6, 16);
            this.labelNamedConditionOne_SHVN.Name = "labelNamedConditionOne_SHVN";
            this.labelNamedConditionOne_SHVN.Size = new System.Drawing.Size(441, 13);
            this.labelNamedConditionOne_SHVN.TabIndex = 0;
            this.labelNamedConditionOne_SHVN.Text = "Протабулировать функцию: F(x) = cos(x)/x-0.7 - sin(x) * 12x + 2 на заданном диапа" +
    "зоне.";
            // 
            // labelNamedConditionTwo_SHVN
            // 
            this.labelNamedConditionTwo_SHVN.AutoSize = true;
            this.labelNamedConditionTwo_SHVN.Location = new System.Drawing.Point(6, 29);
            this.labelNamedConditionTwo_SHVN.Name = "labelNamedConditionTwo_SHVN";
            this.labelNamedConditionTwo_SHVN.Size = new System.Drawing.Size(335, 13);
            this.labelNamedConditionTwo_SHVN.TabIndex = 1;
            this.labelNamedConditionTwo_SHVN.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // dataGridViewFunction_SHVN
            // 
            this.dataGridViewFunction_SHVN.AllowUserToOrderColumns = true;
            this.dataGridViewFunction_SHVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SHVN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_SHVN.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewFunction_SHVN.Name = "dataGridViewFunction_SHVN";
            this.dataGridViewFunction_SHVN.RowHeadersVisible = false;
            this.dataGridViewFunction_SHVN.Size = new System.Drawing.Size(143, 378);
            this.dataGridViewFunction_SHVN.TabIndex = 4;
            this.dataGridViewFunction_SHVN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.buttonDoneClick_SHVN);
            this.Controls.Add(this.buttonHelp_SHVN);
            this.Controls.Add(this.groupBoxInPut_SHVN);
            this.Controls.Add(this.groupBoxOutPut_SHVN);
            this.Controls.Add(this.groupBoxTask_SHVN);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 6 | Штокер В.Н.";
            this.groupBoxTask_SHVN.ResumeLayout(false);
            this.groupBoxTask_SHVN.PerformLayout();
            this.groupBoxOutPut_SHVN.ResumeLayout(false);
            this.groupBoxOutPut_SHVN.PerformLayout();
            this.groupBoxInPut_SHVN.ResumeLayout(false);
            this.groupBoxInPut_SHVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamedOne_SHVN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SHVN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SHVN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SHVN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNamedOne_SHVN;
        private System.Windows.Forms.TextBox textBoxNamedOne_SHVN;
        private System.Windows.Forms.GroupBox groupBoxInPut_SHVN;
        private System.Windows.Forms.Label labelEnd_SHVN;
        private System.Windows.Forms.Label labelStart_SHVN;
        private System.Windows.Forms.TextBox textBoxNamedThree_SHVN;
        private System.Windows.Forms.TextBox textBoxNamedTwo_SHVN;
        private System.Windows.Forms.Button buttonHelp_SHVN;
        private System.Windows.Forms.Button buttonDoneClick_SHVN;
        private System.Windows.Forms.Label labelNamedConditionTwo_SHVN;
        private System.Windows.Forms.Label labelNamedConditionOne_SHVN;
        private System.Windows.Forms.Label labelResults_SHVN;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SHVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

