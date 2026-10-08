namespace Convertor
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            labelResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 130);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Convert";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 133);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "from BGN to EUR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 217);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Result:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(155, 217);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(116, 261);
            button1.Name = "button1";
            button1.Size = new Size(235, 46);
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
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Metric Conventer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label labelResult;
        private Button button1;
    }
}
