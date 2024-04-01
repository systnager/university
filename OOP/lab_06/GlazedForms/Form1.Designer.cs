
namespace GlazedForms
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
            UnderwindcheckBox = new CheckBox();
            Calcbutton = new Button();
            label1 = new Label();
            MaterialcomboBox = new ComboBox();
            WidthtextBox = new TextBox();
            label2 = new Label();
            HeighttextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            odnoradioButton = new RadioButton();
            dworadiobutton = new RadioButton();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // UnderwindcheckBox
            // 
            UnderwindcheckBox.AutoSize = true;
            UnderwindcheckBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnderwindcheckBox.Location = new Point(304, 130);
            UnderwindcheckBox.Margin = new Padding(3, 4, 3, 4);
            UnderwindcheckBox.Name = "UnderwindcheckBox";
            UnderwindcheckBox.Size = new Size(110, 24);
            UnderwindcheckBox.TabIndex = 0;
            UnderwindcheckBox.Text = "Підвіконня";
            UnderwindcheckBox.UseVisualStyleBackColor = true;
            // 
            // Calcbutton
            // 
            Calcbutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Calcbutton.Location = new Point(146, 249);
            Calcbutton.Margin = new Padding(3, 4, 3, 4);
            Calcbutton.Name = "Calcbutton";
            Calcbutton.Size = new Size(183, 50);
            Calcbutton.TabIndex = 1;
            Calcbutton.Text = "Розрахувати";
            Calcbutton.UseVisualStyleBackColor = true;
            Calcbutton.Click += Calcbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(8, 50);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Ширина (см):";
            // 
            // MaterialcomboBox
            // 
            MaterialcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MaterialcomboBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaterialcomboBox.FormattingEnabled = true;
            MaterialcomboBox.Items.AddRange(new object[] { "Дерево", "Метал", "Металопластик" });
            MaterialcomboBox.Location = new Point(94, 134);
            MaterialcomboBox.Margin = new Padding(3, 4, 3, 4);
            MaterialcomboBox.Name = "MaterialcomboBox";
            MaterialcomboBox.Size = new Size(153, 28);
            MaterialcomboBox.TabIndex = 3;
            MaterialcomboBox.SelectedIndexChanged += MaterialcomboBox_SelectedIndexChanged;
            // 
            // WidthtextBox
            // 
            WidthtextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WidthtextBox.Location = new Point(118, 50);
            WidthtextBox.Margin = new Padding(3, 4, 3, 4);
            WidthtextBox.Name = "WidthtextBox";
            WidthtextBox.Size = new Size(129, 25);
            WidthtextBox.TabIndex = 4;
            WidthtextBox.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Розміри вікна";
            // 
            // HeighttextBox
            // 
            HeighttextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HeighttextBox.Location = new Point(118, 83);
            HeighttextBox.Margin = new Padding(3, 4, 3, 4);
            HeighttextBox.Name = "HeighttextBox";
            HeighttextBox.Size = new Size(129, 25);
            HeighttextBox.TabIndex = 7;
            HeighttextBox.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(8, 82);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Висота (см):";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(8, 134);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "Матеріал";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(8, 204);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 9;
            label5.Text = "Вартість:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(118, 204);
            label6.Name = "label6";
            label6.Size = new Size(21, 24);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(304, 9);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 11;
            label7.Text = "Склопакет";
            // 
            // odnoradioButton
            // 
            odnoradioButton.AutoSize = true;
            odnoradioButton.Checked = true;
            odnoradioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            odnoradioButton.Location = new Point(304, 46);
            odnoradioButton.Margin = new Padding(3, 4, 3, 4);
            odnoradioButton.Name = "odnoradioButton";
            odnoradioButton.Size = new Size(141, 24);
            odnoradioButton.TabIndex = 12;
            odnoradioButton.TabStop = true;
            odnoradioButton.Text = "Однокамерний";
            odnoradioButton.UseVisualStyleBackColor = true;
            // 
            // dworadiobutton
            // 
            dworadiobutton.AutoSize = true;
            dworadiobutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dworadiobutton.Location = new Point(304, 84);
            dworadiobutton.Margin = new Padding(3, 4, 3, 4);
            dworadiobutton.Name = "dworadiobutton";
            dworadiobutton.Size = new Size(130, 24);
            dworadiobutton.TabIndex = 13;
            dworadiobutton.Text = "Двокамерний";
            dworadiobutton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(259, 303);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(191, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нагорний Тарас ВТ-23-1";
            linkLabel1.VisitedLinkColor = Color.Red;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 332);
            Controls.Add(linkLabel1);
            Controls.Add(dworadiobutton);
            Controls.Add(odnoradioButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(HeighttextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(WidthtextBox);
            Controls.Add(MaterialcomboBox);
            Controls.Add(label1);
            Controls.Add(Calcbutton);
            Controls.Add(UnderwindcheckBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Cклопакет";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox UnderwindcheckBox;
        private System.Windows.Forms.Button Calcbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialcomboBox;
        private System.Windows.Forms.TextBox WidthtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton odnoradioButton;
        private System.Windows.Forms.RadioButton dworadiobutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

