using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtokerVN.Sprint6.Task1.V7.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task1.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxNamedTwo_SHVN.Text);
                int stopStep = Convert.ToInt32(textBoxNamedThree_SHVN.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxNamedOne_SHVN.Text = "";
                textBoxNamedOne_SHVN.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxNamedOne_SHVN.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textBoxNamedOne_SHVN.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxNamedOne_SHVN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxNamedOne_SHVN.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void buttonHelp_SHVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-1 Штокер Владимир Николаевич", "Сообщение");
        }
    }
}
