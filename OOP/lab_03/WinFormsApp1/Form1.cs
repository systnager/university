using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }
        double[] arr1;
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int n;
            n = (int)numericUpDownCount.Value;
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = n;
            dataGridViewArray.RowHeadersWidth = 80;

            for (int i=0; i<dataGridViewArray.RowCount;i++)
            {
                dataGridViewArray.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < dataGridViewArray.ColumnCount; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
            }

            arr1 = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {              
                arr1[i] = rnd.Next(-1051, 1053) / 100.0;
                dataGridViewArray[i, 0].Value = arr1[i];
             
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                    sum += arr1[i];
            }
            textBoxsum.Text = $"SUM = {sum}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[] arr2 = new double[arr1.Length / 2];
            for (int i = 0; i < arr1.Length / 2; i++)
             arr2[i] = arr1[i];           
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length / 2; i++)
            {
                arr1[i] = arr2[i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                dataGridViewArray[i, 0].Value = arr1[i];
            }
        }

        private void dataGridViewArray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
