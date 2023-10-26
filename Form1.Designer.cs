namespace WindForm_classwork
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            SecondsRadioButton = new RadioButton();
            MinutesRadioButton = new RadioButton();
            DaysRadioButton = new RadioButton();
            MonthsRadioButton = new RadioButton();
            YearsRadioButton = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            Resultlabel = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите дату";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SecondsRadioButton);
            groupBox1.Controls.Add(MinutesRadioButton);
            groupBox1.Controls.Add(DaysRadioButton);
            groupBox1.Controls.Add(MonthsRadioButton);
            groupBox1.Controls.Add(YearsRadioButton);
            groupBox1.Location = new Point(86, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 170);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // SecondsRadioButton
            // 
            SecondsRadioButton.AutoSize = true;
            SecondsRadioButton.Location = new Point(0, 140);
            SecondsRadioButton.Name = "SecondsRadioButton";
            SecondsRadioButton.Size = new Size(76, 24);
            SecondsRadioButton.TabIndex = 4;
            SecondsRadioButton.TabStop = true;
            SecondsRadioButton.Text = "секунд";
            SecondsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MinutesRadioButton
            // 
            MinutesRadioButton.AutoSize = true;
            MinutesRadioButton.Location = new Point(3, 113);
            MinutesRadioButton.Name = "MinutesRadioButton";
            MinutesRadioButton.Size = new Size(72, 24);
            MinutesRadioButton.TabIndex = 3;
            MinutesRadioButton.TabStop = true;
            MinutesRadioButton.Text = "минут";
            MinutesRadioButton.UseVisualStyleBackColor = true;
            // 
            // DaysRadioButton
            // 
            DaysRadioButton.AutoSize = true;
            DaysRadioButton.Location = new Point(3, 83);
            DaysRadioButton.Name = "DaysRadioButton";
            DaysRadioButton.Size = new Size(63, 24);
            DaysRadioButton.TabIndex = 2;
            DaysRadioButton.TabStop = true;
            DaysRadioButton.Text = "день";
            DaysRadioButton.UseVisualStyleBackColor = true;
            DaysRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // MonthsRadioButton
            // 
            MonthsRadioButton.AutoSize = true;
            MonthsRadioButton.Location = new Point(3, 53);
            MonthsRadioButton.Name = "MonthsRadioButton";
            MonthsRadioButton.Size = new Size(73, 24);
            MonthsRadioButton.TabIndex = 1;
            MonthsRadioButton.TabStop = true;
            MonthsRadioButton.Text = "месяц";
            MonthsRadioButton.UseVisualStyleBackColor = true;
            // 
            // YearsRadioButton
            // 
            YearsRadioButton.AutoSize = true;
            YearsRadioButton.Location = new Point(3, 23);
            YearsRadioButton.Name = "YearsRadioButton";
            YearsRadioButton.Size = new Size(53, 24);
            YearsRadioButton.TabIndex = 0;
            YearsRadioButton.TabStop = true;
            YearsRadioButton.Text = "год";
            YearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(423, 87);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Рассчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Cick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 91);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // Resultlabel
            // 
            Resultlabel.AutoSize = true;
            Resultlabel.Location = new Point(559, 92);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(0, 20);
            Resultlabel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Результат";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(587, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(Resultlabel);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Cick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_lick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton DaysRadioButton;
        private RadioButton MonthsRadioButton;
        private RadioButton YearsRadioButton;
        private RadioButton SecondsRadioButton;
        private RadioButton MinutesRadioButton;
        private Button button1;
        private Label label2;
        private Label Resultlabel;
        private Label label3;
        private TextBox textBox2;
    }
}