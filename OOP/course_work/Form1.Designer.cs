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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            start = new Button();
            panel2 = new Panel();
            variable = new Button();
            panel4 = new Panel();
            strings = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel_content = new Panel();
            textBox1 = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            flowLayoutPanel1.Size = new Size(239, 618);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 122);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 0;
            label1.Text = "Python3 beginner";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(start);
            panel3.Location = new Point(3, 134);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 80);
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
            start.Size = new Size(229, 72);
            start.TabIndex = 1;
            start.Text = "Початок";
            start.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(variable);
            panel2.Location = new Point(3, 222);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 80);
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
            variable.Size = new Size(229, 72);
            variable.TabIndex = 1;
            variable.Text = "Змінні";
            variable.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(strings);
            panel4.Location = new Point(3, 310);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 80);
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
            strings.Size = new Size(229, 72);
            strings.TabIndex = 1;
            strings.Text = "Строки";
            strings.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(18, 18);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel_content
            // 
            panel_content.Dock = DockStyle.Fill;
            panel_content.Location = new Point(239, 0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(777, 618);
            panel_content.TabIndex = 1;
            panel_content.Paint += panel_content_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 26);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 618);
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
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel_content;
        private TextBox textBox1;
    }
}
