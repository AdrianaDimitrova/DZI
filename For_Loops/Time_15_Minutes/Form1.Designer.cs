namespace Time_15_Minutes
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
            label1Hour = new Label();
            label2Minutes = new Label();
            label3 = new Label();
            label4Result = new Label();
            button1 = new Button();
            numericUpDownHour = new NumericUpDown();
            numericUpDownMinutes = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).BeginInit();
            SuspendLayout();
            // 
            // label1Hour
            // 
            label1Hour.AutoSize = true;
            label1Hour.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1Hour.Location = new Point(79, 89);
            label1Hour.Name = "label1Hour";
            label1Hour.Size = new Size(67, 24);
            label1Hour.TabIndex = 0;
            label1Hour.Text = "Hour:";
            // 
            // label2Minutes
            // 
            label2Minutes.AutoSize = true;
            label2Minutes.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2Minutes.Location = new Point(370, 90);
            label2Minutes.Name = "label2Minutes";
            label2Minutes.Size = new Size(106, 24);
            label2Minutes.TabIndex = 1;
            label2Minutes.Text = "Minutes: ";
            label2Minutes.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(101, 261);
            label3.Name = "label3";
            label3.Size = new Size(249, 24);
            label3.TabIndex = 2;
            label3.Text = "Time after 15 minutes:";
            // 
            // label4Result
            // 
            label4Result.AutoSize = true;
            label4Result.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4Result.Location = new Point(370, 261);
            label4Result.Name = "label4Result";
            label4Result.Size = new Size(0, 23);
            label4Result.TabIndex = 3;
            label4Result.Click += label4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(154, 329);
            button1.Name = "button1";
            button1.Size = new Size(361, 35);
            button1.TabIndex = 4;
            button1.Text = "Add 15 minutes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Location = new Point(154, 87);
            numericUpDownHour.Name = "numericUpDownHour";
            numericUpDownHour.Size = new Size(150, 27);
            numericUpDownHour.TabIndex = 5;
            // 
            // numericUpDownMinutes
            // 
            numericUpDownMinutes.Location = new Point(482, 89);
            numericUpDownMinutes.Name = "numericUpDownMinutes";
            numericUpDownMinutes.Size = new Size(150, 27);
            numericUpDownMinutes.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 390);
            Controls.Add(numericUpDownMinutes);
            Controls.Add(numericUpDownHour);
            Controls.Add(button1);
            Controls.Add(label4Result);
            Controls.Add(label3);
            Controls.Add(label2Minutes);
            Controls.Add(label1Hour);
            Name = "Form1";
            Text = "Add 15 minutes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1Hour;
        private Label label2Minutes;
        private Label label3;
        private Label label4Result;
        private Button button1;
        private NumericUpDown numericUpDownHour;
        private NumericUpDown numericUpDownMinutes;
    }
}
