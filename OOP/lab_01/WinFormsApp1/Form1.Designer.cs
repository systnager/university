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
            x_ = new TextBox();
            y_ = new TextBox();
            z_ = new TextBox();
            button1 = new Button();
            r = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "x = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "y = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "z = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 195);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 3;
            label4.Text = "r = ";
            // 
            // x_
            // 
            x_.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            x_.Location = new Point(48, 7);
            x_.Margin = new Padding(2, 2, 2, 2);
            x_.Name = "x_";
            x_.RightToLeft = RightToLeft.Yes;
            x_.Size = new Size(326, 27);
            x_.TabIndex = 4;
            // 
            // y_
            // 
            y_.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            y_.Location = new Point(48, 62);
            y_.Margin = new Padding(2, 2, 2, 2);
            y_.Name = "y_";
            y_.Size = new Size(326, 27);
            y_.TabIndex = 5;
            // 
            // z_
            // 
            z_.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            z_.Location = new Point(48, 129);
            z_.Margin = new Padding(2, 2, 2, 2);
            z_.Name = "z_";
            z_.Size = new Size(326, 27);
            z_.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(48, 262);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 8;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // r
            // 
            r.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            r.Enabled = false;
            r.Location = new Point(48, 195);
            r.Margin = new Padding(2, 2, 2, 2);
            r.Name = "r";
            r.Size = new Size(326, 27);
            r.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(233, 328);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Nagornij T G vt-23-1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(382, 362);
            Controls.Add(linkLabel1);
            Controls.Add(r);
            Controls.Add(button1);
            Controls.Add(z_);
            Controls.Add(y_);
            Controls.Add(x_);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MaximumSize = new Size(404, 569);
            MinimumSize = new Size(244, 409);
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
        private TextBox x_;
        private TextBox y_;
        private TextBox z_;
        private Button button1;
        private TextBox r;
        private LinkLabel linkLabel1;
    }
}
