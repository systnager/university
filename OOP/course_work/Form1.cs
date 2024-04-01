namespace course_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            panel_content.Controls.Add(webBrowser);
            var baseDir = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string htmlFilePath = $@"{baseDir}\index.html";
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
    }
}
