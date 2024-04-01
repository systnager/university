
namespace TravelForm
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
            winterradiobutton = new RadioButton();
            summerradioButton = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            DaystextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            voucherstextBox = new TextBox();
            CountrycomboBox = new ComboBox();
            label1 = new Label();
            Calcbutton = new Button();
            GuidecheckBox = new CheckBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(69, 474);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(191, 20);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нагорний Тарас ВТ-23-1";
            // 
            // winterradiobutton
            // 
            winterradiobutton.AutoSize = true;
            winterradiobutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            winterradiobutton.Location = new Point(125, 223);
            winterradiobutton.Margin = new Padding(3, 4, 3, 4);
            winterradiobutton.Name = "winterradiobutton";
            winterradiobutton.Size = new Size(67, 24);
            winterradiobutton.TabIndex = 28;
            winterradiobutton.Text = "Зима";
            winterradiobutton.UseVisualStyleBackColor = true;
            // 
            // summerradioButton
            // 
            summerradioButton.AutoSize = true;
            summerradioButton.Checked = true;
            summerradioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            summerradioButton.Location = new Point(18, 223);
            summerradioButton.Margin = new Padding(3, 4, 3, 4);
            summerradioButton.Name = "summerradioButton";
            summerradioButton.Size = new Size(60, 24);
            summerradioButton.TabIndex = 27;
            summerradioButton.TabStop = true;
            summerradioButton.Text = "Літо";
            summerradioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(217, 300);
            label6.Name = "label6";
            label6.Size = new Size(21, 24);
            label6.TabIndex = 25;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(105, 300);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 24;
            label5.Text = "Вартість:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 23;
            label4.Text = "Країна";
            // 
            // DaystextBox
            // 
            DaystextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DaystextBox.Location = new Point(134, 107);
            DaystextBox.Margin = new Padding(3, 4, 3, 4);
            DaystextBox.Name = "DaystextBox";
            DaystextBox.Size = new Size(166, 25);
            DaystextBox.TabIndex = 22;
            DaystextBox.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 21;
            label3.Text = "Кількість днів";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(256, 20);
            label2.TabIndex = 20;
            label2.Text = "Оберіть необхідні параметри";
            // 
            // voucherstextBox
            // 
            voucherstextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            voucherstextBox.Location = new Point(134, 52);
            voucherstextBox.Margin = new Padding(3, 4, 3, 4);
            voucherstextBox.Name = "voucherstextBox";
            voucherstextBox.Size = new Size(166, 25);
            voucherstextBox.TabIndex = 19;
            voucherstextBox.Text = "3";
            // 
            // CountrycomboBox
            // 
            CountrycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CountrycomboBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountrycomboBox.FormattingEnabled = true;
            CountrycomboBox.Items.AddRange(new object[] { "Болгарія", "Німеччина", "Польща" });
            CountrycomboBox.Location = new Point(134, 167);
            CountrycomboBox.Margin = new Padding(3, 4, 3, 4);
            CountrycomboBox.Name = "CountrycomboBox";
            CountrycomboBox.Size = new Size(166, 28);
            CountrycomboBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 17;
            label1.Text = "Путівок";
            // 
            // Calcbutton
            // 
            Calcbutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Calcbutton.Location = new Point(69, 357);
            Calcbutton.Margin = new Padding(3, 4, 3, 4);
            Calcbutton.Name = "Calcbutton";
            Calcbutton.Size = new Size(199, 63);
            Calcbutton.TabIndex = 16;
            Calcbutton.Text = "Розрахувати";
            Calcbutton.UseVisualStyleBackColor = true;
            Calcbutton.Click += Calcbutton_Click;
            // 
            // GuidecheckBox
            // 
            GuidecheckBox.AutoSize = true;
            GuidecheckBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuidecheckBox.Location = new Point(249, 224);
            GuidecheckBox.Margin = new Padding(3, 4, 3, 4);
            GuidecheckBox.Name = "GuidecheckBox";
            GuidecheckBox.Size = new Size(51, 24);
            GuidecheckBox.TabIndex = 15;
            GuidecheckBox.Text = "Гід";
            GuidecheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 503);
            Controls.Add(linkLabel1);
            Controls.Add(winterradiobutton);
            Controls.Add(summerradioButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DaystextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(voucherstextBox);
            Controls.Add(CountrycomboBox);
            Controls.Add(label1);
            Controls.Add(Calcbutton);
            Controls.Add(GuidecheckBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Travel";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton winterradiobutton;
        private System.Windows.Forms.RadioButton summerradioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DaystextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox voucherstextBox;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calcbutton;
        private System.Windows.Forms.CheckBox GuidecheckBox;
    }
}

