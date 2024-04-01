using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CountrycomboBox.SelectedIndex = 0;
        }

        private void Calcbutton_Click(object sender, EventArgs e)
        {
            Travel trav = new Travel(int.Parse(voucherstextBox.Text), int.Parse(DaystextBox.Text),CountrycomboBox.SelectedIndex, summerradioButton.Checked ? 0:1, GuidecheckBox.Checked);

            label6.Text = trav.CountPrices().ToString() + "$";

        }
    }
}
