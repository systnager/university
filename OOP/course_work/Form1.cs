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
        List<int> uncompleteTestStartTabIndexList = new List<int>();

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
            current_tab_index = 0;
            startTabProgressBar.Value = 0;
            addSTartTabListElements();
            tabControl.SelectTab(0);
            startTabControl.SelectTab(current_tab_index);
        }

        private void configureVariableTab()
        {
            current_tab_index = 0;
            variable_progressBar.Value = 0;
            addVariableTabListElements();
            tabControl.SelectTab(1);
            VariableTabControl.SelectTab(current_tab_index);
        }

        private void configureStringTab()
        {
            current_tab_index = 0;
            string_progressBar.Value = 0;
            addStringTabListElements();
            tabControl.SelectTab(2);
            StringTabControl.SelectTab(current_tab_index);
        }

        private void addStringTabListElements()
        {
            current_tab_index = 0;
            tabsList = new List<TabPage>();
            tabsList.Add(string_tab_0);
            tabsList.Add(string_tab_1);
            tabsList.Add(string_tab_2);
            tabsList.Add(string_tab_3);
            tabsList.Add(string_tab_4);
        }

        private void addVariableTabListElements()
        {
            current_tab_index = 0;
            tabsList = new List<TabPage>();
            tabsList.Add(variable_tab_0);
            tabsList.Add(variable_tab_1);
            tabsList.Add(variable_tab_2);
            tabsList.Add(variable_tab_3);
            tabsList.Add(variable_tab_4);
        }

        private void addSTartTabListElements()
        {
            current_tab_index = 0;
            tabsList = new List<TabPage>();
            tabsList.Add(startTab_0);
            tabsList.Add(startTab_1);
            tabsList.Add(startTab_2);
            tabsList.Add(startTab_3);
            tabsList.Add(startTab_4);
        }

        private void uncompleteTestStartTabIndexListElements()
        {

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
                else if (tabIndex == 4)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    startTab4webView.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\beginning_2.html";
                    webBrowser.Navigate(htmlFilePath);
                }
            }

            else if (tabControl.SelectedIndex == 1)
            {
                if (tabIndex == 0)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    VariableWebViewPanel.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\variable_0.html";
                    webBrowser.Navigate(htmlFilePath);
                }
                else if (tabIndex == 2)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    VariableWebViewPanel2.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\variable_1.html";
                    webBrowser.Navigate(htmlFilePath);
                }
                else if (tabIndex == 4)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    VariableWebViewPanel4.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\variable_2.html";
                    webBrowser.Navigate(htmlFilePath);
                }
            }

            else if (tabControl.SelectedIndex == 2)
            {
                if (tabIndex == 0)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    StringWebViewPanel.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\string_0.html";
                    webBrowser.Navigate(htmlFilePath);
                }
                else if (tabIndex == 2)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    StringWebViewPanel2.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\string_1.html";
                    webBrowser.Navigate(htmlFilePath);
                }
                else if (tabIndex == 4)
                {
                    webBrowser.Dock = DockStyle.Fill;
                    StringWebViewPanel4.Controls.Add(webBrowser);
                    string htmlFilePath = $@"{baseDir}\string_2.html";
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
            configureStringTab();
            webBrowser.Dock = DockStyle.Fill;
            StringWebViewPanel.Controls.Add(webBrowser);

            string htmlFilePath = $@"{baseDir}\string_0.html";
            webBrowser.Navigate(htmlFilePath);
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
            configureVariableTab();
            webBrowser.Dock = DockStyle.Fill;
            VariableWebViewPanel.Controls.Add(webBrowser);

            string htmlFilePath = $@"{baseDir}\variable_0.html";
            webBrowser.Navigate(htmlFilePath);
            tabControl.SelectTab(1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void startTab1CheckButton_Click(object sender, EventArgs e)
        {
            int pythonCount = 0;

            foreach (object item in startTab1CheckedListBox.CheckedItems)
            {
                if (item.ToString() == "Python")
                {
                    pythonCount++;
                }
                else
                {
                    MessageBox.Show("Неправильна відповідь!");
                    return;
                }
            }

            if (pythonCount == 1)
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                MessageBox.Show("Неправильна відповідь!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pythonCount = 0;

            foreach (object item in checkedListBox1.CheckedItems)
            {
                if (item.ToString() == "print(\"hello, world\")")
                {
                    pythonCount++;
                }
                else
                {
                    MessageBox.Show("Неправильна відповідь!");
                    return;
                }
            }

            if (pythonCount == 1)
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                MessageBox.Show("Неправильна відповідь!");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startTab2webView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void string_next_Click(object sender, EventArgs e)
        {
            if ((current_tab_index + 1) < tabsList.Count)
            {
                current_tab_index++;
                int progress = ((current_tab_index + 1) * 100 / tabsList.Count);
                string_progressBar.Value = progress;
                loadHTMLInWebView(current_tab_index);
                StringTabControl.SelectTab(current_tab_index);
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void string_back_Click(object sender, EventArgs e)
        {
            if (current_tab_index > 0)
            {
                current_tab_index--;
                int progress = ((current_tab_index + 1) * 100 / tabsList.Count);
                string_progressBar.Value = progress;
                loadHTMLInWebView(current_tab_index);
                StringTabControl.SelectTab(current_tab_index);
            }
            else
            {
                MessageBox.Show("Це перша сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void variable_back_Click(object sender, EventArgs e)
        {
            if (current_tab_index > 0)
            {
                current_tab_index--;
                int progress = ((current_tab_index + 1) * 100 / tabsList.Count);
                variable_progressBar.Value = progress;
                loadHTMLInWebView(current_tab_index);
                VariableTabControl.SelectTab(current_tab_index);
            }
            else
            {
                MessageBox.Show("Це перша сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void variable_next_Click(object sender, EventArgs e)
        {
            if ((current_tab_index + 1) < tabsList.Count)
            {
                current_tab_index++;
                int progress = ((current_tab_index + 1) * 100 / tabsList.Count);
                variable_progressBar.Value = progress;
                loadHTMLInWebView(current_tab_index);
                VariableTabControl.SelectTab(current_tab_index);
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
