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
using Tyuiu.ShtokerVN.Sprint6.Task7.V29.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_SHVN.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SHVN.Filter = "Значения, разделенными запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
            private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_SHVN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SHVN.ShowDialog();
            openFilePath = openFileDialogTask_SHVN.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewMatrixInPut_SHVN.ColumnCount = colums;
            dataGridViewMatrixInPut_SHVN.RowCount = rows;
            dataGridViewMatrixOutPut_SHVN.ColumnCount = colums;
            dataGridViewMatrixOutPut_SHVN.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrixInPut_SHVN.Columns[i].Width = 25;
                dataGridViewMatrixOutPut_SHVN.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewMatrixInPut_SHVN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SHVN.Enabled = true;
        }

        private void buttonHelpDone_SHVN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_SHVN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SHVN.FileName = "OutPutFileTask7V29.csv";
            saveFileDialogMatrix_SHVN.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SHVN.ShowDialog();

            string path = saveFileDialogMatrix_SHVN.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;

            if (fileexists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMatrixOutPut_SHVN.RowCount;
            int colums = dataGridViewMatrixOutPut_SHVN.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if ( j != colums - 1)
                    {
                        str = str + dataGridViewMatrixOutPut_SHVN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMatrixOutPut_SHVN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonUseSearch_SHVN_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < colums; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewMatrixOutPut_SHVN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }

        private void buttonHelpFile_MouseEnter_SHVN(object sender, EventArgs e)
        {
            toolTipButtonAll_SHVN.ToolTipTitle = "Справка";
        }

        private void buttonSaveFile_MouseEnter_SHVN(object sender, EventArgs e)
        {
            toolTipButtonAll_SHVN.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonDone_MouseEnter_SHVN(object sender, EventArgs e)
        {
            toolTipButtonAll_SHVN.ToolTipTitle = "Выполнить";
        }

        private void buttonOpenFile_MouseEnter_SHVN(object sender, EventArgs e)
        {
            toolTipButtonAll_SHVN.ToolTipTitle = "Открыть файл";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrixInPut_SHVN.ColumnCount = 50;
            dataGridViewMatrixOutPut_SHVN.ColumnCount = 50;

            dataGridViewMatrixInPut_SHVN.RowCount = 50;
            dataGridViewMatrixOutPut_SHVN.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewMatrixInPut_SHVN.Columns[i].Width = 25;
                dataGridViewMatrixOutPut_SHVN.Columns[i].Width = 25;
            }
        }
    }
}
