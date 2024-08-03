namespace egn
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
            inputTextbox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            yearTextbox = new TextBox();
            monthTextbox = new TextBox();
            label3 = new Label();
            dayTextbox = new TextBox();
            label4 = new Label();
            isValidTextbox = new TextBox();
            label5 = new Label();
            genderTextbox = new TextBox();
            label6 = new Label();
            placeTextbox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Въведете ЕГН:";
            // 
            // inputTextbox
            // 
            inputTextbox.Location = new Point(45, 69);
            inputTextbox.Name = "inputTextbox";
            inputTextbox.Size = new Size(125, 27);
            inputTextbox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(256, 67);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 2;
            button1.Text = "Изчисли!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 136);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 3;
            label2.Text = "Година на раждане";
            // 
            // yearTextbox
            // 
            yearTextbox.Location = new Point(256, 129);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(108, 27);
            yearTextbox.TabIndex = 4;
            // 
            // monthTextbox
            // 
            monthTextbox.Location = new Point(256, 174);
            monthTextbox.Name = "monthTextbox";
            monthTextbox.Size = new Size(108, 27);
            monthTextbox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 181);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Месец на раждане";
            // 
            // dayTextbox
            // 
            dayTextbox.Location = new Point(256, 217);
            dayTextbox.Name = "dayTextbox";
            dayTextbox.Size = new Size(108, 27);
            dayTextbox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 224);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 7;
            label4.Text = "Дата на раждане";
            // 
            // isValidTextbox
            // 
            isValidTextbox.Location = new Point(256, 347);
            isValidTextbox.Name = "isValidTextbox";
            isValidTextbox.Size = new Size(108, 27);
            isValidTextbox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 354);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 13;
            label5.Text = "Достоверност";
            // 
            // genderTextbox
            // 
            genderTextbox.Location = new Point(256, 304);
            genderTextbox.Name = "genderTextbox";
            genderTextbox.Size = new Size(108, 27);
            genderTextbox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 311);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 11;
            label6.Text = "Пол";
            // 
            // placeTextbox
            // 
            placeTextbox.Location = new Point(256, 259);
            placeTextbox.Name = "placeTextbox";
            placeTextbox.Size = new Size(108, 27);
            placeTextbox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 266);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 9;
            label7.Text = "Място на раждане";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(isValidTextbox);
            Controls.Add(label5);
            Controls.Add(genderTextbox);
            Controls.Add(label6);
            Controls.Add(placeTextbox);
            Controls.Add(label7);
            Controls.Add(dayTextbox);
            Controls.Add(label4);
            Controls.Add(monthTextbox);
            Controls.Add(label3);
            Controls.Add(yearTextbox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(inputTextbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Проверка на ЕГН";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextbox;
        private Button button1;
        private Label label2;
        private TextBox yearTextbox;
        private TextBox monthTextbox;
        private Label label3;
        private TextBox dayTextbox;
        private Label label4;
        private TextBox isValidTextbox;
        private Label label5;
        private TextBox genderTextbox;
        private Label label6;
        private TextBox placeTextbox;
        private Label label7;
    }
}