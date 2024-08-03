namespace test_informatika_9v_22
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            buttonNextQuestion = new Button();
            richTextBox1 = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 47);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Оставащо време: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 47);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(455, 47);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 2;
            label3.Text = "Оставащи въпроси: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(631, 47);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 411);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 6;
            label6.Text = "Верен отговор:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(181, 411);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 27);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "а";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(181, 441);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 27);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "б";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(181, 471);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(40, 27);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "в";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(181, 501);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(38, 27);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "г";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonNextQuestion
            // 
            buttonNextQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNextQuestion.Location = new Point(662, 499);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(160, 29);
            buttonNextQuestion.TabIndex = 11;
            buttonNextQuestion.Text = "Следващ въпрос";
            buttonNextQuestion.UseVisualStyleBackColor = true;
            buttonNextQuestion.Click += buttonNextQuestion_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Beige;
            richTextBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(32, 110);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(790, 242);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(897, 598);
            Controls.Add(richTextBox1);
            Controls.Add(buttonNextQuestion);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Тест";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button buttonNextQuestion;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}