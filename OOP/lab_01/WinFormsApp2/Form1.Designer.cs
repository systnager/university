namespace WinFormsApp2
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
            a = new Label();
            b = new Label();
            c = new Label();
            r = new Label();
            button1 = new Button();
            aBox = new TextBox();
            bBox = new TextBox();
            cBox = new TextBox();
            SuspendLayout();
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(15, 19);
            a.Name = "a";
            a.Size = new Size(43, 25);
            a.TabIndex = 0;
            a.Text = "a = ";
            a.Click += label1_Click;
            // 
            // b
            // 
            b.AutoSize = true;
            b.Location = new Point(15, 72);
            b.Name = "b";
            b.Size = new Size(45, 25);
            b.TabIndex = 1;
            b.Text = "b = ";
            // 
            // c
            // 
            c.AutoSize = true;
            c.Location = new Point(15, 125);
            c.Name = "c";
            c.Size = new Size(42, 25);
            c.TabIndex = 2;
            c.Text = "c = ";
            // 
            // r
            // 
            r.AutoSize = true;
            r.Location = new Point(100, 172);
            r.Name = "r";
            r.Size = new Size(0, 25);
            r.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(80, 225);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // aBox
            // 
            aBox.Location = new Point(80, 19);
            aBox.Name = "aBox";
            aBox.Size = new Size(150, 31);
            aBox.TabIndex = 5;
            // 
            // bBox
            // 
            bBox.Location = new Point(80, 66);
            bBox.Name = "bBox";
            bBox.Size = new Size(150, 31);
            bBox.TabIndex = 6;
            // 
            // cBox
            // 
            cBox.Location = new Point(80, 119);
            cBox.Name = "cBox";
            cBox.Size = new Size(150, 31);
            cBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 279);
            Controls.Add(cBox);
            Controls.Add(bBox);
            Controls.Add(aBox);
            Controls.Add(button1);
            Controls.Add(r);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(a);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label a;
        private Label b;
        private Label c;
        private Label r;
        private Button button1;
        private TextBox aBox;
        private TextBox bBox;
        private TextBox cBox;
    }
}
