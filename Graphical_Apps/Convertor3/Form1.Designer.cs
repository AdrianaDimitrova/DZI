namespace Convertor3
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
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            labelResult = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EUR", "USD", "GBP" });
            comboBox1.Location = new Point(289, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(32, 146);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(205, 148);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "BGN ->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(92, 266);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 3;
            label2.Text = "Result:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(221, 273);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(92, 355);
            button1.Name = "button1";
            button1.Size = new Size(292, 51);
            button1.TabIndex = 5;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label labelResult;
        private Button button1;
    }
}
