namespace course_work
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            start = new Button();
            panel2 = new Panel();
            variable = new Button();
            panel4 = new Panel();
            strings = new Button();
            panel_content = new Panel();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            panel5 = new Panel();
            startTab_back_button = new Button();
            startTab_next_button = new Button();
            startTabControl = new TabControl();
            startTab_0 = new TabPage();
            startTabwebView = new Panel();
            startTab_1 = new TabPage();
            tabPage2 = new TabPage();
            VariableTabControl = new TabControl();
            tabPage9 = new TabPage();
            tabPage10 = new TabPage();
            tabPage3 = new TabPage();
            StringTabControl = new TabControl();
            tabPage11 = new TabPage();
            tabPage12 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel_content.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            panel5.SuspendLayout();
            startTabControl.SuspendLayout();
            startTab_0.SuspendLayout();
            tabPage2.SuspendLayout();
            VariableTabControl.SuspendLayout();
            tabPage3.SuspendLayout();
            StringTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(239, 651);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 128);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 0;
            label1.Text = "Python3 beginner";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(start);
            panel3.Location = new Point(3, 140);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 84);
            panel3.TabIndex = 1;
            // 
            // start
            // 
            start.BackColor = Color.Black;
            start.BackgroundImageLayout = ImageLayout.None;
            start.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = Color.White;
            start.Location = new Point(0, 4);
            start.Margin = new Padding(3, 4, 3, 4);
            start.Name = "start";
            start.Size = new Size(229, 76);
            start.TabIndex = 1;
            start.Text = "Початок";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(variable);
            panel2.Location = new Point(3, 232);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 84);
            panel2.TabIndex = 2;
            // 
            // variable
            // 
            variable.BackColor = Color.Black;
            variable.BackgroundImageLayout = ImageLayout.None;
            variable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            variable.ForeColor = Color.White;
            variable.Location = new Point(0, 4);
            variable.Margin = new Padding(3, 4, 3, 4);
            variable.Name = "variable";
            variable.Size = new Size(229, 76);
            variable.TabIndex = 1;
            variable.Text = "Змінні";
            variable.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(strings);
            panel4.Location = new Point(3, 324);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 84);
            panel4.TabIndex = 2;
            // 
            // strings
            // 
            strings.BackColor = Color.Black;
            strings.BackgroundImageLayout = ImageLayout.None;
            strings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strings.ForeColor = Color.White;
            strings.Location = new Point(0, 4);
            strings.Margin = new Padding(3, 4, 3, 4);
            strings.Name = "strings";
            strings.Size = new Size(229, 76);
            strings.TabIndex = 1;
            strings.Text = "Строки";
            strings.UseVisualStyleBackColor = false;
            // 
            // panel_content
            // 
            panel_content.Controls.Add(tabControl);
            panel_content.Dock = DockStyle.Fill;
            panel_content.Location = new Point(239, 0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(777, 651);
            panel_content.TabIndex = 1;
            panel_content.Paint += panel_content_Paint;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(777, 651);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(startTabControl);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(769, 618);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(startTab_back_button);
            panel5.Controls.Add(startTab_next_button);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 565);
            panel5.MaximumSize = new Size(0, 50);
            panel5.MinimumSize = new Size(0, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(763, 50);
            panel5.TabIndex = 1;
            // 
            // startTab_back_button
            // 
            startTab_back_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            startTab_back_button.Location = new Point(10, 10);
            startTab_back_button.MaximumSize = new Size(150, 30);
            startTab_back_button.MinimumSize = new Size(150, 30);
            startTab_back_button.Name = "startTab_back_button";
            startTab_back_button.Size = new Size(150, 30);
            startTab_back_button.TabIndex = 1;
            startTab_back_button.Text = "Назад";
            startTab_back_button.UseVisualStyleBackColor = true;
            // 
            // startTab_next_button
            // 
            startTab_next_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startTab_next_button.Location = new Point(603, 10);
            startTab_next_button.MaximumSize = new Size(150, 30);
            startTab_next_button.MinimumSize = new Size(150, 30);
            startTab_next_button.Name = "startTab_next_button";
            startTab_next_button.Size = new Size(150, 30);
            startTab_next_button.TabIndex = 0;
            startTab_next_button.Text = "Уперед";
            startTab_next_button.UseVisualStyleBackColor = true;
            // 
            // startTabControl
            // 
            startTabControl.Controls.Add(startTab_0);
            startTabControl.Controls.Add(startTab_1);
            startTabControl.Controls.Add(tabPage6);
            startTabControl.Controls.Add(tabPage7);
            startTabControl.Controls.Add(tabPage8);
            startTabControl.Dock = DockStyle.Fill;
            startTabControl.Location = new Point(3, 3);
            startTabControl.Name = "startTabControl";
            startTabControl.SelectedIndex = 0;
            startTabControl.Size = new Size(763, 612);
            startTabControl.TabIndex = 0;
            // 
            // startTab_0
            // 
            startTab_0.Controls.Add(startTabwebView);
            startTab_0.Location = new Point(4, 29);
            startTab_0.Name = "startTab_0";
            startTab_0.Padding = new Padding(3);
            startTab_0.Size = new Size(755, 579);
            startTab_0.TabIndex = 0;
            startTab_0.Text = "startTab_0";
            startTab_0.UseVisualStyleBackColor = true;
            // 
            // startTabwebView
            // 
            startTabwebView.Dock = DockStyle.Fill;
            startTabwebView.Location = new Point(3, 3);
            startTabwebView.Name = "startTabwebView";
            startTabwebView.Size = new Size(749, 573);
            startTabwebView.TabIndex = 0;
            // 
            // startTab_1
            // 
            startTab_1.Location = new Point(4, 29);
            startTab_1.Name = "startTab_1";
            startTab_1.Padding = new Padding(3);
            startTab_1.Size = new Size(755, 579);
            startTab_1.TabIndex = 1;
            startTab_1.Text = "startTab_1";
            startTab_1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(VariableTabControl);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(769, 618);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // VariableTabControl
            // 
            VariableTabControl.Controls.Add(tabPage9);
            VariableTabControl.Controls.Add(tabPage10);
            VariableTabControl.Dock = DockStyle.Fill;
            VariableTabControl.Location = new Point(3, 3);
            VariableTabControl.Name = "VariableTabControl";
            VariableTabControl.SelectedIndex = 0;
            VariableTabControl.Size = new Size(763, 612);
            VariableTabControl.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 29);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(755, 579);
            tabPage9.TabIndex = 0;
            tabPage9.Text = "tabPage9";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new Point(4, 29);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(755, 579);
            tabPage10.TabIndex = 1;
            tabPage10.Text = "tabPage10";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(StringTabControl);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(769, 618);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // StringTabControl
            // 
            StringTabControl.Controls.Add(tabPage11);
            StringTabControl.Controls.Add(tabPage12);
            StringTabControl.Dock = DockStyle.Fill;
            StringTabControl.Location = new Point(3, 3);
            StringTabControl.Name = "StringTabControl";
            StringTabControl.SelectedIndex = 0;
            StringTabControl.Size = new Size(763, 612);
            StringTabControl.TabIndex = 0;
            // 
            // tabPage11
            // 
            tabPage11.Location = new Point(4, 29);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(3);
            tabPage11.Size = new Size(755, 579);
            tabPage11.TabIndex = 0;
            tabPage11.Text = "tabPage11";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            tabPage12.Location = new Point(4, 29);
            tabPage12.Name = "tabPage12";
            tabPage12.Padding = new Padding(3);
            tabPage12.Size = new Size(755, 579);
            tabPage12.TabIndex = 1;
            tabPage12.Text = "tabPage12";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(769, 618);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(769, 618);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(755, 579);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(755, 579);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(755, 579);
            tabPage8.TabIndex = 4;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 651);
            Controls.Add(panel_content);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Підручник для вивчення мови програмування";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel_content.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            startTabControl.ResumeLayout(false);
            startTab_0.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            VariableTabControl.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            StringTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Button variable;
        private Button start;
        private Panel panel4;
        private Button strings;
        private Panel panel_content;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabControl startTabControl;
        private TabPage startTab_0;
        private TabPage startTab_1;
        private TabControl VariableTabControl;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabControl StringTabControl;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private Button startTab_next_button;
        private Panel panel5;
        private Button startTab_back_button;
        private Panel startTabwebView;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
    }
}
