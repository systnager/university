
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            textBoxX1 = new TextBox();
            textBoxY = new TextBox();
            textBoxZ = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxX = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBoxX2 = new TextBox();
            textBoxD = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(479, 517);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(209, 27);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нагорний Т. Г. ВТ-23-1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBoxX1
            // 
            textBoxX1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxX1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxX1.Location = new Point(53, 257);
            textBoxX1.Margin = new Padding(3, 4, 3, 4);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.ReadOnly = true;
            textBoxX1.Size = new Size(252, 34);
            textBoxX1.TabIndex = 18;
            // 
            // textBoxY
            // 
            textBoxY.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxY.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxY.Location = new Point(53, 67);
            textBoxY.Margin = new Padding(3, 4, 3, 4);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(252, 34);
            textBoxY.TabIndex = 16;
            // 
            // textBoxZ
            // 
            textBoxZ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxZ.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxZ.Location = new Point(53, 134);
            textBoxZ.Margin = new Padding(3, 4, 3, 4);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(252, 34);
            textBoxZ.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 139);
            label3.Name = "label3";
            label3.Size = new Size(26, 27);
            label3.TabIndex = 14;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(25, 27);
            label2.TabIndex = 13;
            label2.Text = "B";
            // 
            // textBoxX
            // 
            textBoxX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxX.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxX.Location = new Point(52, 9);
            textBoxX.Margin = new Padding(3, 4, 3, 4);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(252, 34);
            textBoxX.TabIndex = 12;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(25, 27);
            label1.TabIndex = 11;
            label1.Text = "A";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(52, 398);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(212, 86);
            button1.TabIndex = 10;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxX2
            // 
            textBoxX2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxX2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxX2.Location = new Point(52, 332);
            textBoxX2.Margin = new Padding(3, 4, 3, 4);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.ReadOnly = true;
            textBoxX2.Size = new Size(252, 34);
            textBoxX2.TabIndex = 21;
            // 
            // textBoxD
            // 
            textBoxD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxD.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxD.Location = new Point(52, 196);
            textBoxD.Margin = new Padding(3, 4, 3, 4);
            textBoxD.Name = "textBoxD";
            textBoxD.ReadOnly = true;
            textBoxD.Size = new Size(252, 34);
            textBoxD.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(10, 202);
            label6.Name = "label6";
            label6.Size = new Size(26, 27);
            label6.TabIndex = 22;
            label6.Text = "D";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(1, 264);
            label4.Name = "label4";
            label4.Size = new Size(35, 27);
            label4.TabIndex = 17;
            label4.Text = "X1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(1, 339);
            label5.Name = "label5";
            label5.Size = new Size(35, 27);
            label5.TabIndex = 20;
            label5.Text = "X2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(700, 553);
            Controls.Add(textBoxD);
            Controls.Add(label6);
            Controls.Add(textBoxX2);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(textBoxX1);
            Controls.Add(label4);
            Controls.Add(textBoxY);
            Controls.Add(textBoxZ);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxX);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(818, 600);
            MinimumSize = new Size(718, 600);
            Name = "Form1";
            Text = "Квадратне рівняння завдання 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxD;
        private Label label6;
        private Label label4;
        private Label label5;
    }
}

