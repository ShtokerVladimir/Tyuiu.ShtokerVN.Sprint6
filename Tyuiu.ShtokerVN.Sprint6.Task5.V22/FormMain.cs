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
using Tyuiu.ShtokerVN.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task5.V22
{
    public partial class FormMain_SHVN : Form
    {
        public FormMain_SHVN()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\geroin\source\repos\Tyuiu.ShtokerVN.Sprint6\Tyuiu.ShtokerVN.Sprint6.Task5.V22\bin\Debug\OutPutFileTask5V22.txt";
        private void buttonUseDone_SHVN_Click(object sender, EventArgs e)
        {
            dataGridViewNums_SHVN.Rows.Clear();
            chartNamedOne_SHVN.Series[0].Points.Clear();

            dataGridViewNums_SHVN.ColumnCount = 2;
            dataGridViewNums_SHVN.Columns[0].Width = 20;
            dataGridViewNums_SHVN.Columns[1].Width = 50;

            this.chartNamedOne_SHVN.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartNamedOne_SHVN.ChartAreas[0].AxisY.Title = "Ось Y";

            chartNamedOne_SHVN.Series[0].Points.Clear();

            double[] dsArray = ds.LoadFromDataFile(path);
            
            for (int i = 0; i < dsArray.Length; i++)
            {
                dataGridViewNums_SHVN.Rows.Add(i + 1, dsArray[i]);
                chartNamedOne_SHVN.Series[0].Points.AddXY(i, dsArray[i]);
            }

        }

        private void buttonOpenFile_SHVN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelpDone_SHVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-1 Штокер Владимир Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
