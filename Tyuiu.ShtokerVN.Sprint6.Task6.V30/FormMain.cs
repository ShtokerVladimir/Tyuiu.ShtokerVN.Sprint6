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
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.ShtokerVN.Sprint6.Task6.V30.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_SHVN_Click(object sender, EventArgs e)
        {
            openFileInPut_SHVN.ShowDialog();
            openFilePath = openFileInPut_SHVN.FileName;
            textBoxLoadFromFile_SHVN.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_SHVN.Text = groupBoxOutPut_SHVN.Text + " " + openFileInPut_SHVN.FileName;
            buttonUseSearch_SHVN.Enabled = true;
        }

        private void buttonUseSearch_SHVN_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxResultFile_SHVN.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelpDone_SHVN_Click(object sender, EventArgs e)
        {
            FormAboutMe_SHVN formAbout = new FormAboutMe_SHVN();
            formAbout.ShowDialog();
        }
    }
}
