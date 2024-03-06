namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            x = new TextBox();
            y = new TextBox();
            z = new TextBox();
            button1 = new Button();
            r = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "x = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 1;
            label2.Text = "y = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "z = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 3;
            label4.Text = "r = ";
            // 
            // x
            // 
            x.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            x.Location = new Point(60, 9);
            x.Name = "x";
            x.RightToLeft = RightToLeft.Yes;
            x.Size = new Size(406, 31);
            x.TabIndex = 4;
            // 
            // y
            // 
            y.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            y.Location = new Point(60, 77);
            y.Name = "y";
            y.Size = new Size(406, 31);
            y.TabIndex = 5;
            // 
            // z
            // 
            z.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            z.Location = new Point(60, 161);
            z.Name = "z";
            z.Size = new Size(406, 31);
            z.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(60, 328);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // r
            // 
            r.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            r.Enabled = false;
            r.Location = new Point(60, 244);
            r.Name = "r";
            r.Size = new Size(406, 31);
            r.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(291, 410);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Nagornij T G vt-23-1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(478, 444);
            Controls.Add(linkLabel1);
            Controls.Add(r);
            Controls.Add(button1);
            Controls.Add(z);
            Controls.Add(y);
            Controls.Add(x);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 700);
            MinimumSize = new Size(300, 500);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота 1";
            AutoSizeChanged += Form1_Load;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox x;
        private TextBox y;
        private TextBox z;
        private Button button1;
        private TextBox r;
        private LinkLabel linkLabel1;
    }
}
