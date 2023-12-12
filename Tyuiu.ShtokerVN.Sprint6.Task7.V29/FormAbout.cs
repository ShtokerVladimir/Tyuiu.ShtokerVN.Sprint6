using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShtokerVN.Sprint6.Task7.V29
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void textBoxInfo_SHVN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCloseDone_SHVN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
