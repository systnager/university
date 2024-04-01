using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                     System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        double[,] arr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewMatrix_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                    e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int n,m;
            n = (int)numericUpDownN.Value;
            m = (int)numericUpDownM.Value;
            dataGridViewMatrix.RowCount = n;
            dataGridViewMatrix.ColumnCount = m;
            dataGridViewMatrix.RowHeadersWidth = 80;

            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                dataGridViewMatrix.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                dataGridViewMatrix.Columns[i].HeaderCell.Value = i.ToString();
            }

            arr = new double[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-11034, 11035) / 100.0;
                    dataGridViewMatrix[j, i].Value = arr[i,j];
                }
                
            }


        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double[] arrdo = new double[arr.GetLength(0)];

            double sum = 0, max = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                    if (j == arr.GetLength(1) - 1)
                    {
                        arrdo[i] = sum;
                        sum = 0;
                       
                    }
                }
            }
            for (int i = 0; i < arrdo.Length; i++)
                if (arrdo[i] > max) max = arrdo[i];
            textBoxsum.Text = $"{max}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int k = int.Parse(textBoxStep.Text);
            double temp;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (j % 2 == 0 && j != 0)
                    {
                        temp = arr[j, 0];
                        for (int g = 0; g < arr.GetLength(1) - 1; g++)
                            arr[j, g] = arr[j, g + 1];
                        arr[j, arr.GetLength(1) - 1] = temp;
                    }
                }
            }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   
                    dataGridViewMatrix[j, i].Value = arr[i, j];
                }

            }

        }
    }
}
