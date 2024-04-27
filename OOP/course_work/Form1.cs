using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace course_work
{
    public partial class Form1 : Form
    {
        WebBrowser webBrowser = new WebBrowser();
        String baseDir = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        int current_tab_index = 0;
        List<TabPage> tabsList = new List<TabPage>();

        public Form1()
        {
            InitializeComponent();
            start_Click(new object(), new EventArgs());

            tabControl.ItemSize = new Size(0, 1);
            startTabControl.ItemSize = new Size(0, 1);
            VariableTabControl.ItemSize = new Size(0, 1);
            StringTabControl.ItemSize = new Size(0, 1);

            tabControl.SizeMode = TabSizeMode.Fixed;
            startTabControl.SizeMode = TabSizeMode.Fixed;
            VariableTabControl.SizeMode = TabSizeMode.Fixed;
            StringTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void configureStartTab()
        {
            startTabProgressBar.Value = 0;
            addSTartTabListElements();
            tabControl.SelectTab(0);
        }

        private void addSTartTabListElements()
        {
            current_tab_index = 0;
            tabsList.Add(startTab_0);
            tabsList.Add(startTab_1);
            tabsList.Add(startTab_2);
            tabsList.Add(startTab_3);
            tabsList.Add(startTab_4);
        }

        private void loadHTMLInWebView(int tabIndex)
        {
            if (tabControl.SelectedIndex == 0)
            {
                if (tabIndex == 0)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    startTabwebView.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\beginning_0.html";
                    webBrowser.Navigate(htmlFilePath);
                }
                else if (tabIndex == 2)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    startTab2webView.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\beginning_1.html";
                    webBrowser.Navigate(htmlFilePath);
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            configureStartTab();
            webBrowser.Dock = DockStyle.Fill;
            startTabwebView.Controls.Add(webBrowser);

            string htmlFilePath = $@"{baseDir}\beginning_0.html";
            webBrowser.Navigate(htmlFilePath);
            tabControl.SelectTab(0);
        }

        private void strings_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void startTab_next_button_Click(object sender, EventArgs e)
        {
            if ((current_tab_index + 1) < tabsList.Count)
            {
                current_tab_index++;
                int progress = ((current_tab_index + 1) * 100 / tabsList.Count);
                startTabProgressBar.Value = progress;
                loadHTMLInWebView(current_tab_index);
                startTabControl.SelectTab(current_tab_index);
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startTab_back_button_Click(object sender, EventArgs e)
        {
            if (current_tab_index > 0)
            {
                current_tab_index--;
                int progress = ((current_tab_index + 1) * 100 / tabsList.Count);
                startTabProgressBar.Value = progress;
                loadHTMLInWebView(current_tab_index);
                startTabControl.SelectTab(current_tab_index);
            }
            else
            {
                MessageBox.Show("Це перша сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void variable_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
