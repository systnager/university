
namespace Arrays1DWinForms
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
            label1 = new Label();
            numericUpDownCount = new NumericUpDown();
            buttonGenerate = new Button();
            buttonSolve = new Button();
            dataGridViewArray = new DataGridView();
            textBoxsum = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 17);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 29);
            label1.TabIndex = 0;
            label1.Text = "Кількісь елементів";
            label1.Click += label1_Click_1;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Anchor = AnchorStyles.Top;
            numericUpDownCount.Location = new Point(245, 15);
            numericUpDownCount.Margin = new Padding(6, 4, 6, 4);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(112, 34);
            numericUpDownCount.TabIndex = 1;
            numericUpDownCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCount.ValueChanged += numericUpDownCount_ValueChanged;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Top;
            buttonGenerate.BackColor = SystemColors.ButtonFace;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Location = new Point(6, 112);
            buttonGenerate.Margin = new Padding(6, 4, 6, 4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(275, 42);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Згенерувати";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSolve
            // 
            buttonSolve.Anchor = AnchorStyles.Bottom;
            buttonSolve.BackColor = Color.White;
            buttonSolve.FlatStyle = FlatStyle.Flat;
            buttonSolve.Location = new Point(6, 62);
            buttonSolve.Margin = new Padding(6, 4, 6, 4);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(171, 42);
            buttonSolve.TabIndex = 3;
            buttonSolve.Text = "Знайти суму";
            buttonSolve.UseVisualStyleBackColor = false;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // dataGridViewArray
            // 
            dataGridViewArray.AllowUserToAddRows = false;
            dataGridViewArray.AllowUserToDeleteRows = false;
            dataGridViewArray.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewArray.BackgroundColor = Color.Bisque;
            dataGridViewArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArray.Location = new Point(304, 62);
            dataGridViewArray.Margin = new Padding(6, 4, 6, 4);
            dataGridViewArray.Name = "dataGridViewArray";
            dataGridViewArray.ReadOnly = true;
            dataGridViewArray.RowHeadersWidth = 51;
            dataGridViewArray.Size = new Size(772, 329);
            dataGridViewArray.TabIndex = 4;
            dataGridViewArray.CellContentClick += dataGridViewArray_CellContentClick;
            // 
            // textBoxsum
            // 
            textBoxsum.Anchor = AnchorStyles.Bottom;
            textBoxsum.Location = new Point(189, 70);
            textBoxsum.Margin = new Padding(6, 4, 6, 4);
            textBoxsum.Name = "textBoxsum";
            textBoxsum.Size = new Size(113, 34);
            textBoxsum.TabIndex = 5;
            textBoxsum.TextChanged += textBoxsum_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(387, 457);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(335, 42);
            button1.TabIndex = 8;
            button1.Text = "Сортувати першу половину";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1091, 512);
            Controls.Add(button1);
            Controls.Add(textBoxsum);
            Controls.Add(dataGridViewArray);
            Controls.Add(buttonSolve);
            Controls.Add(buttonGenerate);
            Controls.Add(numericUpDownCount);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 13.8F);
            Margin = new Padding(6, 4, 6, 4);
            MaximumSize = new Size(1484, 559);
            MinimumSize = new Size(1109, 559);
            Name = "Form1";
            Text = "Лаб 3-Завдання1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.TextBox textBoxsum;
        private System.Windows.Forms.Button button1;
    }
}

