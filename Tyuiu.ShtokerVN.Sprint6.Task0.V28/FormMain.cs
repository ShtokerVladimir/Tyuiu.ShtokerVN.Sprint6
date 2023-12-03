using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtokerVN.Sprint6.Task0.V28.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task0.V28
{
    public partial class FormMain_SHVN : Form
    {
        public FormMain_SHVN()
        {
            InitializeComponent();
        }

        private void buttonNamedOne_SHVN_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResults_SHVN.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVariable_SHVN.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void buttonNamedTwo_SHVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-23-1 Штокер Владимир Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
