namespace Local_Shop
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
            label3 = new Label();
            label4Price = new Label();
            label5 = new Label();
            textBoxQuantity = new TextBox();
            comboBox1Product = new ComboBox();
            comboBoxCity = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 93);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Product:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 164);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 241);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantity:";
            // 
            // label4Price
            // 
            label4Price.AutoSize = true;
            label4Price.Location = new Point(52, 331);
            label4Price.Name = "label4Price";
            label4Price.Size = new Size(44, 20);
            label4Price.TabIndex = 3;
            label4Price.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 331);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(150, 234);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(125, 27);
            textBoxQuantity.TabIndex = 5;
            // 
            // comboBox1Product
            // 
            comboBox1Product.FormattingEnabled = true;
            comboBox1Product.Items.AddRange(new object[] { "coffee", "water", "juice", "sweets", "peanuts" });
            comboBox1Product.Location = new Point(150, 93);
            comboBox1Product.Name = "comboBox1Product";
            comboBox1Product.Size = new Size(151, 28);
            comboBox1Product.TabIndex = 6;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Sofia", "Plovdiv", "Varna" });
            comboBoxCity.Location = new Point(150, 164);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(151, 28);
            comboBoxCity.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(78, 372);
            button1.Name = "button1";
            button1.Size = new Size(223, 54);
            button1.TabIndex = 8;
            button1.Text = "Calculate price";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(button1);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBox1Product);
            Controls.Add(textBoxQuantity);
            Controls.Add(label5);
            Controls.Add(label4Price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4Price;
        private Label label5;
        private TextBox textBoxQuantity;
        private ComboBox comboBox1Product;
        private ComboBox comboBoxCity;
        private Button button1;
    }
}
