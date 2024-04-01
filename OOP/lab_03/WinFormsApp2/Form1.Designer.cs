
namespace Arrays2DWinForms
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
            buttonstep = new Button();
            textBoxsum = new TextBox();
            dataGridViewMatrix = new DataGridView();
            buttonSolve = new Button();
            buttonGenerate = new Button();
            numericUpDownM = new NumericUpDown();
            label1 = new Label();
            numericUpDownN = new NumericUpDown();
            textBoxStep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownN).BeginInit();
            SuspendLayout();
            // 
            // buttonstep
            // 
            buttonstep.Anchor = AnchorStyles.Bottom;
            buttonstep.BackColor = Color.White;
            buttonstep.FlatStyle = FlatStyle.Flat;
            buttonstep.Location = new Point(20, 176);
            buttonstep.Margin = new Padding(6, 4, 6, 4);
            buttonstep.Name = "buttonstep";
            buttonstep.Size = new Size(90, 42);
            buttonstep.TabIndex = 15;
            buttonstep.Text = "Крок";
            buttonstep.UseVisualStyleBackColor = false;
            buttonstep.Click += button1_Click;
            // 
            // textBoxsum
            // 
            textBoxsum.Anchor = AnchorStyles.Bottom;
            textBoxsum.Location = new Point(173, 115);
            textBoxsum.Margin = new Padding(6, 4, 6, 4);
            textBoxsum.Name = "textBoxsum";
            textBoxsum.Size = new Size(90, 27);
            textBoxsum.TabIndex = 14;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.AllowUserToDeleteRows = false;
            dataGridViewMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMatrix.BackgroundColor = Color.DarkSalmon;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(305, 56);
            dataGridViewMatrix.Margin = new Padding(6, 4, 6, 4);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(603, 445);
            dataGridViewMatrix.TabIndex = 13;
            dataGridViewMatrix.CellContentClick += dataGridViewMatrix_CellContentClick;
            // 
            // buttonSolve
            // 
            buttonSolve.Anchor = AnchorStyles.Bottom;
            buttonSolve.BackColor = Color.White;
            buttonSolve.FlatStyle = FlatStyle.Flat;
            buttonSolve.Location = new Point(20, 107);
            buttonSolve.Margin = new Padding(6, 4, 6, 4);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(90, 42);
            buttonSolve.TabIndex = 12;
            buttonSolve.Text = "Сума";
            buttonSolve.UseVisualStyleBackColor = false;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Top;
            buttonGenerate.BackColor = Color.White;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Location = new Point(60, 282);
            buttonGenerate.Margin = new Padding(6, 4, 6, 4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(176, 42);
            buttonGenerate.TabIndex = 11;
            buttonGenerate.Text = "Згенерувати";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // numericUpDownM
            // 
            numericUpDownM.Anchor = AnchorStyles.Top;
            numericUpDownM.Location = new Point(173, 56);
            numericUpDownM.Margin = new Padding(6, 4, 6, 4);
            numericUpDownM.Name = "numericUpDownM";
            numericUpDownM.Size = new Size(90, 27);
            numericUpDownM.TabIndex = 10;
            numericUpDownM.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 9;
            label1.Text = "Розміри матриці";
            // 
            // numericUpDownN
            // 
            numericUpDownN.Anchor = AnchorStyles.Top;
            numericUpDownN.Location = new Point(20, 56);
            numericUpDownN.Margin = new Padding(6, 4, 6, 4);
            numericUpDownN.Name = "numericUpDownN";
            numericUpDownN.Size = new Size(90, 27);
            numericUpDownN.TabIndex = 16;
            numericUpDownN.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // textBoxStep
            // 
            textBoxStep.Anchor = AnchorStyles.Bottom;
            textBoxStep.Location = new Point(173, 191);
            textBoxStep.Margin = new Padding(6, 4, 6, 4);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(90, 27);
            textBoxStep.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(968, 533);
            Controls.Add(textBoxStep);
            Controls.Add(numericUpDownN);
            Controls.Add(buttonstep);
            Controls.Add(textBoxsum);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(buttonSolve);
            Controls.Add(buttonGenerate);
            Controls.Add(numericUpDownM);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лаб робота 3. Завдання 2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownM).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonstep;
        private System.Windows.Forms.TextBox textBoxsum;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.TextBox textBoxStep;
    }
}

