using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtokerVN.Sprint6.Task2.V6.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task2.V6
{
    public partial class FormMain_SHVN : Form
    {
        public FormMain_SHVN()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDoneClick_SHVN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxNamedTwo_SHVN.Text);
                int stopStep = Convert.ToInt32(textBoxNamedThree_SHVN.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartNamedOne_SHVN.Titles.Add("График функции F(x) = cos(x)/x-0.7 - sin(x) * 12x + 2");

                this.chartNamedOne_SHVN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartNamedOne_SHVN.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SHVN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartNamedOne_SHVN.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void buttonDoneClick_SHVN_MouseLeave(object sender, EventArgs e)
        {
            buttonDoneClick_SHVN.BackColor = Color.Green;
        }

        private void buttonDoneClick_SHVN_MouseEnter(object sender, EventArgs e)
        {
            buttonDoneClick_SHVN.BackColor = Color.Red;
        }

        private void buttonDoneClick_SHVN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoneClick_SHVN.BackColor = Color.Blue;
        }

        private void buttonHelp_SHVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-1 Штокер Владимир Николаевич", "Сообщение");
        }
    }
}
