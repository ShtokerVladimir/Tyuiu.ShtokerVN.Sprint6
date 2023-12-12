
namespace Tyuiu.ShtokerVN.Sprint6.Task7.V29
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtonAllDone_SHVN = new System.Windows.Forms.Panel();
            this.buttonHelpDone_SHVN = new System.Windows.Forms.Button();
            this.buttonSaveFile_SHVN = new System.Windows.Forms.Button();
            this.buttonDone_SHVN = new System.Windows.Forms.Button();
            this.buttonOpenFile_SHVN = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelConditionAll_SHVN = new System.Windows.Forms.Panel();
            this.groupBoxConditionAll_SHVN = new System.Windows.Forms.GroupBox();
            this.textBoxConditionText_SHVN = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panelInPut_SHVN = new System.Windows.Forms.Panel();
            this.groupBoxInPut_SHVN = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixInPut_SHVN = new System.Windows.Forms.DataGridView();
            this.panelOutPut_SHVN = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SHVN = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixOutPut_SHVN = new System.Windows.Forms.DataGridView();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_SHVN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtonAll_SHVN = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SHVN = new System.Windows.Forms.SaveFileDialog();
            this.panelButtonAllDone_SHVN.SuspendLayout();
            this.panelConditionAll_SHVN.SuspendLayout();
            this.groupBoxConditionAll_SHVN.SuspendLayout();
            this.panelInPut_SHVN.SuspendLayout();
            this.groupBoxInPut_SHVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixInPut_SHVN)).BeginInit();
            this.panelOutPut_SHVN.SuspendLayout();
            this.groupBoxOutPut_SHVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOutPut_SHVN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtonAllDone_SHVN
            // 
            this.panelButtonAllDone_SHVN.Controls.Add(this.buttonHelpDone_SHVN);
            this.panelButtonAllDone_SHVN.Controls.Add(this.buttonSaveFile_SHVN);
            this.panelButtonAllDone_SHVN.Controls.Add(this.buttonDone_SHVN);
            this.panelButtonAllDone_SHVN.Controls.Add(this.buttonOpenFile_SHVN);
            this.panelButtonAllDone_SHVN.Controls.Add(this.splitter2);
            this.panelButtonAllDone_SHVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonAllDone_SHVN.Location = new System.Drawing.Point(0, 0);
            this.panelButtonAllDone_SHVN.Name = "panelButtonAllDone_SHVN";
            this.panelButtonAllDone_SHVN.Size = new System.Drawing.Size(979, 94);
            this.panelButtonAllDone_SHVN.TabIndex = 0;
            // 
            // buttonHelpDone_SHVN
            // 
            this.buttonHelpDone_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelpDone_SHVN.Image")));
            this.buttonHelpDone_SHVN.Location = new System.Drawing.Point(888, 3);
            this.buttonHelpDone_SHVN.Name = "buttonHelpDone_SHVN";
            this.buttonHelpDone_SHVN.Size = new System.Drawing.Size(88, 88);
            this.buttonHelpDone_SHVN.TabIndex = 4;
            this.buttonHelpDone_SHVN.Text = "\r\n";
            this.toolTipButtonAll_SHVN.SetToolTip(this.buttonHelpDone_SHVN, "Сведения о программе\r\n");
            this.buttonHelpDone_SHVN.UseVisualStyleBackColor = true;
            this.buttonHelpDone_SHVN.Click += new System.EventHandler(this.buttonHelpDone_SHVN_Click);
            this.buttonHelpDone_SHVN.MouseEnter += new System.EventHandler(this.buttonHelpFile_MouseEnter_SHVN);
            // 
            // buttonSaveFile_SHVN
            // 
            this.buttonSaveFile_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SHVN.Image")));
            this.buttonSaveFile_SHVN.Location = new System.Drawing.Point(229, 3);
            this.buttonSaveFile_SHVN.Name = "buttonSaveFile_SHVN";
            this.buttonSaveFile_SHVN.Size = new System.Drawing.Size(101, 85);
            this.buttonSaveFile_SHVN.TabIndex = 3;
            this.toolTipButtonAll_SHVN.SetToolTip(this.buttonSaveFile_SHVN, "Сохранить обработанные данные в файл в формате CSV\r\n");
            this.buttonSaveFile_SHVN.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SHVN.Click += new System.EventHandler(this.buttonSaveFile_SHVN_Click);
            this.buttonSaveFile_SHVN.MouseEnter += new System.EventHandler(this.buttonSaveFile_MouseEnter_SHVN);
            // 
            // buttonDone_SHVN
            // 
            this.buttonDone_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SHVN.Image")));
            this.buttonDone_SHVN.Location = new System.Drawing.Point(116, 3);
            this.buttonDone_SHVN.Name = "buttonDone_SHVN";
            this.buttonDone_SHVN.Size = new System.Drawing.Size(107, 85);
            this.buttonDone_SHVN.TabIndex = 2;
            this.toolTipButtonAll_SHVN.SetToolTip(this.buttonDone_SHVN, "Выполнить обработку данных");
            this.buttonDone_SHVN.UseVisualStyleBackColor = true;
            this.buttonDone_SHVN.Click += new System.EventHandler(this.buttonUseSearch_SHVN_Click);
            this.buttonDone_SHVN.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter_SHVN);
            // 
            // buttonOpenFile_SHVN
            // 
            this.buttonOpenFile_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SHVN.Image")));
            this.buttonOpenFile_SHVN.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_SHVN.Name = "buttonOpenFile_SHVN";
            this.buttonOpenFile_SHVN.Size = new System.Drawing.Size(107, 85);
            this.buttonOpenFile_SHVN.TabIndex = 1;
            this.toolTipButtonAll_SHVN.SetToolTip(this.buttonOpenFile_SHVN, "Выберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SHVN.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SHVN.Click += new System.EventHandler(this.buttonOpenFile_SHVN_Click);
            this.buttonOpenFile_SHVN.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter_SHVN);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 94);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // panelConditionAll_SHVN
            // 
            this.panelConditionAll_SHVN.Controls.Add(this.groupBoxConditionAll_SHVN);
            this.panelConditionAll_SHVN.Controls.Add(this.splitter3);
            this.panelConditionAll_SHVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConditionAll_SHVN.Location = new System.Drawing.Point(0, 94);
            this.panelConditionAll_SHVN.Name = "panelConditionAll_SHVN";
            this.panelConditionAll_SHVN.Size = new System.Drawing.Size(979, 102);
            this.panelConditionAll_SHVN.TabIndex = 1;
            // 
            // groupBoxConditionAll_SHVN
            // 
            this.groupBoxConditionAll_SHVN.Controls.Add(this.textBoxConditionText_SHVN);
            this.groupBoxConditionAll_SHVN.Location = new System.Drawing.Point(9, 6);
            this.groupBoxConditionAll_SHVN.Name = "groupBoxConditionAll_SHVN";
            this.groupBoxConditionAll_SHVN.Size = new System.Drawing.Size(967, 90);
            this.groupBoxConditionAll_SHVN.TabIndex = 1;
            this.groupBoxConditionAll_SHVN.TabStop = false;
            this.groupBoxConditionAll_SHVN.Text = "Условие:";
            // 
            // textBoxConditionText_SHVN
            // 
            this.textBoxConditionText_SHVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxConditionText_SHVN.Location = new System.Drawing.Point(0, 19);
            this.textBoxConditionText_SHVN.Multiline = true;
            this.textBoxConditionText_SHVN.Name = "textBoxConditionText_SHVN";
            this.textBoxConditionText_SHVN.ReadOnly = true;
            this.textBoxConditionText_SHVN.Size = new System.Drawing.Size(967, 72);
            this.textBoxConditionText_SHVN.TabIndex = 0;
            this.textBoxConditionText_SHVN.Text = resources.GetString("textBoxConditionText_SHVN.Text");
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 102);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // panelInPut_SHVN
            // 
            this.panelInPut_SHVN.Controls.Add(this.groupBoxInPut_SHVN);
            this.panelInPut_SHVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_SHVN.Location = new System.Drawing.Point(0, 196);
            this.panelInPut_SHVN.Name = "panelInPut_SHVN";
            this.panelInPut_SHVN.Size = new System.Drawing.Size(591, 331);
            this.panelInPut_SHVN.TabIndex = 2;
            // 
            // groupBoxInPut_SHVN
            // 
            this.groupBoxInPut_SHVN.Controls.Add(this.dataGridViewMatrixInPut_SHVN);
            this.groupBoxInPut_SHVN.Location = new System.Drawing.Point(9, 6);
            this.groupBoxInPut_SHVN.Name = "groupBoxInPut_SHVN";
            this.groupBoxInPut_SHVN.Size = new System.Drawing.Size(576, 313);
            this.groupBoxInPut_SHVN.TabIndex = 0;
            this.groupBoxInPut_SHVN.TabStop = false;
            this.groupBoxInPut_SHVN.Text = "Ввод:";
            this.groupBoxInPut_SHVN.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridViewMatrixInPut_SHVN
            // 
            this.dataGridViewMatrixInPut_SHVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixInPut_SHVN.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMatrixInPut_SHVN.Name = "dataGridViewMatrixInPut_SHVN";
            this.dataGridViewMatrixInPut_SHVN.Size = new System.Drawing.Size(564, 288);
            this.dataGridViewMatrixInPut_SHVN.TabIndex = 0;
            // 
            // panelOutPut_SHVN
            // 
            this.panelOutPut_SHVN.Controls.Add(this.groupBoxOutPut_SHVN);
            this.panelOutPut_SHVN.Controls.Add(this.splitter4);
            this.panelOutPut_SHVN.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutPut_SHVN.Location = new System.Drawing.Point(597, 196);
            this.panelOutPut_SHVN.Name = "panelOutPut_SHVN";
            this.panelOutPut_SHVN.Size = new System.Drawing.Size(382, 331);
            this.panelOutPut_SHVN.TabIndex = 3;
            // 
            // groupBoxOutPut_SHVN
            // 
            this.groupBoxOutPut_SHVN.Controls.Add(this.dataGridViewMatrixOutPut_SHVN);
            this.groupBoxOutPut_SHVN.Location = new System.Drawing.Point(9, 6);
            this.groupBoxOutPut_SHVN.Name = "groupBoxOutPut_SHVN";
            this.groupBoxOutPut_SHVN.Size = new System.Drawing.Size(361, 313);
            this.groupBoxOutPut_SHVN.TabIndex = 1;
            this.groupBoxOutPut_SHVN.TabStop = false;
            this.groupBoxOutPut_SHVN.Text = "Вывод:";
            this.groupBoxOutPut_SHVN.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridViewMatrixOutPut_SHVN
            // 
            this.dataGridViewMatrixOutPut_SHVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixOutPut_SHVN.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMatrixOutPut_SHVN.Name = "dataGridViewMatrixOutPut_SHVN";
            this.dataGridViewMatrixOutPut_SHVN.Size = new System.Drawing.Size(349, 288);
            this.dataGridViewMatrixOutPut_SHVN.TabIndex = 0;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(0, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 331);
            this.splitter4.TabIndex = 0;
            this.splitter4.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(591, 196);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 331);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_SHVN
            // 
            this.openFileDialogTask_SHVN.FileName = "openFileDialog1";
            // 
            // toolTipButtonAll_SHVN
            // 
            this.toolTipButtonAll_SHVN.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 527);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOutPut_SHVN);
            this.Controls.Add(this.panelInPut_SHVN);
            this.Controls.Add(this.panelConditionAll_SHVN);
            this.Controls.Add(this.panelButtonAllDone_SHVN);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Штокер В.Н.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtonAllDone_SHVN.ResumeLayout(false);
            this.panelConditionAll_SHVN.ResumeLayout(false);
            this.groupBoxConditionAll_SHVN.ResumeLayout(false);
            this.groupBoxConditionAll_SHVN.PerformLayout();
            this.panelInPut_SHVN.ResumeLayout(false);
            this.groupBoxInPut_SHVN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixInPut_SHVN)).EndInit();
            this.panelOutPut_SHVN.ResumeLayout(false);
            this.groupBoxOutPut_SHVN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOutPut_SHVN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonAllDone_SHVN;
        private System.Windows.Forms.Button buttonHelpDone_SHVN;
        private System.Windows.Forms.Button buttonSaveFile_SHVN;
        private System.Windows.Forms.Button buttonDone_SHVN;
        private System.Windows.Forms.Button buttonOpenFile_SHVN;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelConditionAll_SHVN;
        private System.Windows.Forms.GroupBox groupBoxConditionAll_SHVN;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panelInPut_SHVN;
        private System.Windows.Forms.GroupBox groupBoxInPut_SHVN;
        private System.Windows.Forms.Panel panelOutPut_SHVN;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SHVN;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxConditionText_SHVN;
        private System.Windows.Forms.DataGridView dataGridViewMatrixInPut_SHVN;
        private System.Windows.Forms.DataGridView dataGridViewMatrixOutPut_SHVN;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SHVN;
        private System.Windows.Forms.ToolTip toolTipButtonAll_SHVN;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SHVN;
    }
}

