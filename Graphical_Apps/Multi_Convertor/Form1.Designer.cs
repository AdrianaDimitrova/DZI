namespace Multi_Convertor
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelBGN1 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelBGN2 = new Label();
            label8 = new Label();
            label9 = new Label();
            labelBGN3 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(379, 277);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 169);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Convert";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 166);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 2;
            label2.Text = "from BGN to EUR, USD and GBP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 233);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Result:";
            // 
            // labelBGN1
            // 
            labelBGN1.AutoSize = true;
            labelBGN1.Location = new Point(77, 277);
            labelBGN1.Name = "labelBGN1";
            labelBGN1.Size = new Size(50, 20);
            labelBGN1.TabIndex = 4;
            labelBGN1.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 277);
            label5.Name = "label5";
            label5.Size = new Size(19, 20);
            label5.TabIndex = 5;
            label5.Text = "=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 281);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // labelBGN2
            // 
            labelBGN2.AutoSize = true;
            labelBGN2.Location = new Point(77, 336);
            labelBGN2.Name = "labelBGN2";
            labelBGN2.Size = new Size(50, 20);
            labelBGN2.TabIndex = 7;
            labelBGN2.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(145, 336);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 8;
            label8.Text = "=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 336);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 9;
            label9.Text = "label9";
            // 
            // labelBGN3
            // 
            labelBGN3.AutoSize = true;
            labelBGN3.Location = new Point(77, 386);
            labelBGN3.Name = "labelBGN3";
            labelBGN3.Size = new Size(58, 20);
            labelBGN3.TabIndex = 10;
            labelBGN3.Text = "label10";
            labelBGN3.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(137, 386);
            label11.Name = "label11";
            label11.Size = new Size(19, 20);
            label11.TabIndex = 11;
            label11.Text = "=";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(182, 386);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 12;
            label12.Text = "label12";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(labelBGN3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelBGN2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(labelBGN1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Currency Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelBGN1;
        private Label label5;
        private Label label6;
        private Label labelBGN2;
        private Label label8;
        private Label label9;
        private Label labelBGN3;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
    }
}
