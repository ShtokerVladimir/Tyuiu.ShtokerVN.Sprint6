
namespace Tyuiu.ShtokerVN.Sprint6.Task6.V30
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
            this.panelButtonsAll_SHVN = new System.Windows.Forms.Panel();
            this.buttonUseSearch_SHVN = new System.Windows.Forms.Button();
            this.buttonOpenFile_SHVN = new System.Windows.Forms.Button();
            this.buttonHelpDone_SHVN = new System.Windows.Forms.Button();
            this.panelCondition_SHVN = new System.Windows.Forms.Panel();
            this.groupBoxConditionAll_SHVN = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SHVN = new System.Windows.Forms.TextBox();
            this.panelInPutAll_SHVN = new System.Windows.Forms.Panel();
            this.groupBoxInPut_SHVN = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_SHVN = new System.Windows.Forms.TextBox();
            this.panelOutPutAll_SHVN = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SHVN = new System.Windows.Forms.GroupBox();
            this.textBoxResultFile_SHVN = new System.Windows.Forms.TextBox();
            this.openFileInPut_SHVN = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelButtonsAll_SHVN.SuspendLayout();
            this.panelCondition_SHVN.SuspendLayout();
            this.groupBoxConditionAll_SHVN.SuspendLayout();
            this.panelInPutAll_SHVN.SuspendLayout();
            this.groupBoxInPut_SHVN.SuspendLayout();
            this.panelOutPutAll_SHVN.SuspendLayout();
            this.groupBoxOutPut_SHVN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtonsAll_SHVN
            // 
            this.panelButtonsAll_SHVN.Controls.Add(this.buttonUseSearch_SHVN);
            this.panelButtonsAll_SHVN.Controls.Add(this.buttonOpenFile_SHVN);
            this.panelButtonsAll_SHVN.Controls.Add(this.buttonHelpDone_SHVN);
            this.panelButtonsAll_SHVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonsAll_SHVN.Location = new System.Drawing.Point(0, 0);
            this.panelButtonsAll_SHVN.Name = "panelButtonsAll_SHVN";
            this.panelButtonsAll_SHVN.Size = new System.Drawing.Size(800, 81);
            this.panelButtonsAll_SHVN.TabIndex = 0;
            // 
            // buttonUseSearch_SHVN
            // 
            this.buttonUseSearch_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonUseSearch_SHVN.Image")));
            this.buttonUseSearch_SHVN.Location = new System.Drawing.Point(101, 3);
            this.buttonUseSearch_SHVN.Name = "buttonUseSearch_SHVN";
            this.buttonUseSearch_SHVN.Size = new System.Drawing.Size(88, 72);
            this.buttonUseSearch_SHVN.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonUseSearch_SHVN, "Выводит четвертое слово каждой строки в результирующею строку");
            this.buttonUseSearch_SHVN.UseVisualStyleBackColor = true;
            this.buttonUseSearch_SHVN.Click += new System.EventHandler(this.buttonUseSearch_SHVN_Click);
            // 
            // buttonOpenFile_SHVN
            // 
            this.buttonOpenFile_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SHVN.Image")));
            this.buttonOpenFile_SHVN.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_SHVN.Name = "buttonOpenFile_SHVN";
            this.buttonOpenFile_SHVN.Size = new System.Drawing.Size(92, 72);
            this.buttonOpenFile_SHVN.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonOpenFile_SHVN, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SHVN.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SHVN.Click += new System.EventHandler(this.buttonOpenFile_SHVN_Click);
            // 
            // buttonHelpDone_SHVN
            // 
            this.buttonHelpDone_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelpDone_SHVN.Image")));
            this.buttonHelpDone_SHVN.Location = new System.Drawing.Point(715, 3);
            this.buttonHelpDone_SHVN.Name = "buttonHelpDone_SHVN";
            this.buttonHelpDone_SHVN.Size = new System.Drawing.Size(82, 72);
            this.buttonHelpDone_SHVN.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonHelpDone_SHVN, "Сведение о программе\r\n");
            this.buttonHelpDone_SHVN.UseVisualStyleBackColor = true;
            this.buttonHelpDone_SHVN.Click += new System.EventHandler(this.buttonHelpDone_SHVN_Click);
            // 
            // panelCondition_SHVN
            // 
            this.panelCondition_SHVN.Controls.Add(this.groupBoxConditionAll_SHVN);
            this.panelCondition_SHVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_SHVN.Location = new System.Drawing.Point(0, 81);
            this.panelCondition_SHVN.Name = "panelCondition_SHVN";
            this.panelCondition_SHVN.Size = new System.Drawing.Size(800, 88);
            this.panelCondition_SHVN.TabIndex = 1;
            // 
            // groupBoxConditionAll_SHVN
            // 
            this.groupBoxConditionAll_SHVN.Controls.Add(this.textBoxCondition_SHVN);
            this.groupBoxConditionAll_SHVN.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConditionAll_SHVN.Name = "groupBoxConditionAll_SHVN";
            this.groupBoxConditionAll_SHVN.Size = new System.Drawing.Size(794, 79);
            this.groupBoxConditionAll_SHVN.TabIndex = 0;
            this.groupBoxConditionAll_SHVN.TabStop = false;
            this.groupBoxConditionAll_SHVN.Text = "Условие";
            // 
            // textBoxCondition_SHVN
            // 
            this.textBoxCondition_SHVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_SHVN.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition_SHVN.Multiline = true;
            this.textBoxCondition_SHVN.Name = "textBoxCondition_SHVN";
            this.textBoxCondition_SHVN.ReadOnly = true;
            this.textBoxCondition_SHVN.Size = new System.Drawing.Size(782, 54);
            this.textBoxCondition_SHVN.TabIndex = 0;
            this.textBoxCondition_SHVN.Text = resources.GetString("textBoxCondition_SHVN.Text");
            // 
            // panelInPutAll_SHVN
            // 
            this.panelInPutAll_SHVN.Controls.Add(this.groupBoxInPut_SHVN);
            this.panelInPutAll_SHVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPutAll_SHVN.Location = new System.Drawing.Point(0, 169);
            this.panelInPutAll_SHVN.Name = "panelInPutAll_SHVN";
            this.panelInPutAll_SHVN.Size = new System.Drawing.Size(399, 281);
            this.panelInPutAll_SHVN.TabIndex = 2;
            // 
            // groupBoxInPut_SHVN
            // 
            this.groupBoxInPut_SHVN.Controls.Add(this.textBoxLoadFromFile_SHVN);
            this.groupBoxInPut_SHVN.Location = new System.Drawing.Point(3, 6);
            this.groupBoxInPut_SHVN.Name = "groupBoxInPut_SHVN";
            this.groupBoxInPut_SHVN.Size = new System.Drawing.Size(393, 272);
            this.groupBoxInPut_SHVN.TabIndex = 0;
            this.groupBoxInPut_SHVN.TabStop = false;
            this.groupBoxInPut_SHVN.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_SHVN
            // 
            this.textBoxLoadFromFile_SHVN.Location = new System.Drawing.Point(6, 19);
            this.textBoxLoadFromFile_SHVN.Multiline = true;
            this.textBoxLoadFromFile_SHVN.Name = "textBoxLoadFromFile_SHVN";
            this.textBoxLoadFromFile_SHVN.ReadOnly = true;
            this.textBoxLoadFromFile_SHVN.Size = new System.Drawing.Size(381, 244);
            this.textBoxLoadFromFile_SHVN.TabIndex = 0;
            // 
            // panelOutPutAll_SHVN
            // 
            this.panelOutPutAll_SHVN.Controls.Add(this.groupBoxOutPut_SHVN);
            this.panelOutPutAll_SHVN.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutPutAll_SHVN.Location = new System.Drawing.Point(405, 169);
            this.panelOutPutAll_SHVN.Name = "panelOutPutAll_SHVN";
            this.panelOutPutAll_SHVN.Size = new System.Drawing.Size(395, 281);
            this.panelOutPutAll_SHVN.TabIndex = 3;
            // 
            // groupBoxOutPut_SHVN
            // 
            this.groupBoxOutPut_SHVN.Controls.Add(this.textBoxResultFile_SHVN);
            this.groupBoxOutPut_SHVN.Location = new System.Drawing.Point(3, 6);
            this.groupBoxOutPut_SHVN.Name = "groupBoxOutPut_SHVN";
            this.groupBoxOutPut_SHVN.Size = new System.Drawing.Size(389, 272);
            this.groupBoxOutPut_SHVN.TabIndex = 0;
            this.groupBoxOutPut_SHVN.TabStop = false;
            this.groupBoxOutPut_SHVN.Text = "Вывод:";
            // 
            // textBoxResultFile_SHVN
            // 
            this.textBoxResultFile_SHVN.Location = new System.Drawing.Point(6, 19);
            this.textBoxResultFile_SHVN.Multiline = true;
            this.textBoxResultFile_SHVN.Name = "textBoxResultFile_SHVN";
            this.textBoxResultFile_SHVN.ReadOnly = true;
            this.textBoxResultFile_SHVN.Size = new System.Drawing.Size(377, 244);
            this.textBoxResultFile_SHVN.TabIndex = 0;
            this.textBoxResultFile_SHVN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // openFileInPut_SHVN
            // 
            this.openFileInPut_SHVN.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(399, 169);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 281);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOutPutAll_SHVN);
            this.Controls.Add(this.panelInPutAll_SHVN);
            this.Controls.Add(this.panelCondition_SHVN);
            this.Controls.Add(this.panelButtonsAll_SHVN);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Штокер В.Н.";
            this.panelButtonsAll_SHVN.ResumeLayout(false);
            this.panelCondition_SHVN.ResumeLayout(false);
            this.groupBoxConditionAll_SHVN.ResumeLayout(false);
            this.groupBoxConditionAll_SHVN.PerformLayout();
            this.panelInPutAll_SHVN.ResumeLayout(false);
            this.groupBoxInPut_SHVN.ResumeLayout(false);
            this.groupBoxInPut_SHVN.PerformLayout();
            this.panelOutPutAll_SHVN.ResumeLayout(false);
            this.groupBoxOutPut_SHVN.ResumeLayout(false);
            this.groupBoxOutPut_SHVN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonsAll_SHVN;
        private System.Windows.Forms.Panel panelCondition_SHVN;
        private System.Windows.Forms.GroupBox groupBoxConditionAll_SHVN;
        private System.Windows.Forms.Panel panelInPutAll_SHVN;
        private System.Windows.Forms.GroupBox groupBoxInPut_SHVN;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_SHVN;
        private System.Windows.Forms.Panel panelOutPutAll_SHVN;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SHVN;
        private System.Windows.Forms.TextBox textBoxResultFile_SHVN;
        private System.Windows.Forms.Button buttonUseSearch_SHVN;
        private System.Windows.Forms.Button buttonOpenFile_SHVN;
        private System.Windows.Forms.Button buttonHelpDone_SHVN;
        private System.Windows.Forms.TextBox textBoxCondition_SHVN;
        private System.Windows.Forms.OpenFileDialog openFileInPut_SHVN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

