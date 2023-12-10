using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShtokerVN.Sprint6.Task4.V7.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task4.V7
{
    public partial class FormMain_SHVN : Form
    {
        public FormMain_SHVN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V7.txt";
                File.WriteAllText(path, textBoxResult_SHVN.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path +" сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUseDone_SHVN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SHVN.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep_SHVN.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartNamedOne_SHVN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartNamedOne_SHVN.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SHVN.Text = "";

                chartNamedOne_SHVN.Series[0].Points.Clear();

                
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartNamedOne_SHVN.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SHVN.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошмбка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpDone_SHVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-1 Штокер Владимир Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartNamedOne_SHVN_Click(object sender, EventArgs e)
        {

        }
    }
}
