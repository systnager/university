using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MaterialcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialcomboBox.SelectedIndex = 0;
        }

        private void Calcbutton_Click(object sender, EventArgs e)
        {

            Glazed glass = new Glazed(double.Parse(WidthtextBox.Text), double.Parse(HeighttextBox.Text),
                 MaterialcomboBox.SelectedIndex, odnoradioButton.Checked ? 0 : 1,UnderwindcheckBox.Checked);

            label6.Text = glass.Calc().ToString() + " грн";

        }
    }
}
