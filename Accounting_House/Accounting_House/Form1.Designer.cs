namespace Accounting_House
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
            tabControlBooks = new TabControl();
            tabPage1 = new TabPage();
            Notebooks = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelResult = new Label();
            button1 = new Button();
            tabPageWriting = new TabPage();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            tabControlBooks.SuspendLayout();
            tabPage1.SuspendLayout();
            Notebooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPageWriting.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlBooks
            // 
            tabControlBooks.Controls.Add(tabPage1);
            tabControlBooks.Controls.Add(Notebooks);
            tabControlBooks.Controls.Add(tabPageWriting);
            tabControlBooks.Location = new Point(12, 70);
            tabControlBooks.Name = "tabControlBooks";
            tabControlBooks.SelectedIndex = 0;
            tabControlBooks.Size = new Size(404, 258);
            tabControlBooks.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBox4);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(396, 225);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Notebooks
            // 
            Notebooks.Controls.Add(checkBox8);
            Notebooks.Controls.Add(checkBox7);
            Notebooks.Controls.Add(checkBox6);
            Notebooks.Controls.Add(checkBox5);
            Notebooks.Location = new Point(4, 29);
            Notebooks.Name = "Notebooks";
            Notebooks.Padding = new Padding(3);
            Notebooks.Size = new Size(396, 225);
            Notebooks.TabIndex = 1;
            Notebooks.Text = "Тетрадки";
            Notebooks.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(151, 48);
            label1.TabIndex = 0;
            label1.Text = "СТОКИ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 43);
            label2.Name = "label2";
            label2.Size = new Size(311, 24);
            label2.TabIndex = 1;
            label2.Text = "ИНФОРМАЦИЯ ЗА ПОРЪЧКАТА";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(529, 99);
            label3.Name = "label3";
            label3.Size = new Size(166, 27);
            label3.TabIndex = 2;
            label3.Text = "ЗАПОРЪЧАНИЕ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(529, 178);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 155);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 5;
            label4.Text = "Количество:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 244);
            label5.Name = "label5";
            label5.Size = new Size(191, 20);
            label5.TabIndex = 6;
            label5.Text = "Начислена отстъпка (в %):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Elephant", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(12, 352);
            label6.Name = "label6";
            label6.Size = new Size(273, 43);
            label6.TabIndex = 7;
            label6.Text = "Към плащане:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(86, 408);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(95, 33);
            labelResult.TabIndex = 8;
            labelResult.Text = "0.00 €";
            // 
            // button1
            // 
            button1.Location = new Point(505, 330);
            button1.Name = "button1";
            button1.Size = new Size(192, 97);
            button1.TabIndex = 9;
            button1.Text = "Изчисли и Плати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPageWriting
            // 
            tabPageWriting.Controls.Add(checkBox11);
            tabPageWriting.Controls.Add(checkBox10);
            tabPageWriting.Controls.Add(checkBox9);
            tabPageWriting.Location = new Point(4, 29);
            tabPageWriting.Name = "tabPageWriting";
            tabPageWriting.Padding = new Padding(3);
            tabPageWriting.Size = new Size(396, 225);
            tabPageWriting.TabIndex = 2;
            tabPageWriting.Text = "Пишещти";
            tabPageWriting.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(219, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Първи стъпки в C# - 25,00€";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(16, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(186, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Приключения - 18,50€";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(16, 129);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(221, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Научна фантастика - 22,10€";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(16, 181);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(238, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "История на България - 31,99€";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(20, 24);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(252, 24);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "Голям формат - 60 листа - 1,00€";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(20, 79);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(252, 24);
            checkBox6.TabIndex = 1;
            checkBox6.Text = "Голям формат - 80 листа - 1,50€";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(20, 124);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(260, 24);
            checkBox7.TabIndex = 2;
            checkBox7.Text = "Голям формат - 100 листа - 2,00€";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(20, 171);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(254, 24);
            checkBox8.TabIndex = 3;
            checkBox8.Text = "Малък формат - 40 листа - 0,50€";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(20, 34);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(141, 24);
            checkBox9.TabIndex = 0;
            checkBox9.Text = "Химикал - 0,40€";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(20, 102);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(127, 24);
            checkBox10.TabIndex = 1;
            checkBox10.Text = "Молив - 0,20€";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(20, 170);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(134, 24);
            checkBox11.TabIndex = 2;
            checkBox11.Text = "Маркер - 0,50€";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabControlBooks);
            Name = "Form1";
            Text = "Счетоводна каса на Книжарница";
            tabControlBooks.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Notebooks.ResumeLayout(false);
            Notebooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPageWriting.ResumeLayout(false);
            tabPageWriting.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlBooks;
        private TabPage tabPage1;
        private TabPage Notebooks;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelResult;
        private Button button1;
        private TabPage tabPageWriting;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
    }
}
