using System.Windows.Forms;

namespace course_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl.ItemSize = new Size(0, 1);
            startTabControl.ItemSize = new Size(0, 1);
            VariableTabControl.ItemSize = new Size(0, 1);
            StringTabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            startTabControl.SizeMode = TabSizeMode.Fixed;
            VariableTabControl.SizeMode = TabSizeMode.Fixed;
            StringTabControl.SizeMode = TabSizeMode.Fixed;
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            startTabwebView.Controls.Add(webBrowser);
            var baseDir = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string htmlFilePath = $@"{baseDir}\beginning.html";
            webBrowser.Navigate(htmlFilePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

        }
    }
}
