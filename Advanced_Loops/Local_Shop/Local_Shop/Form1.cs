namespace Local_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1Product.SelectedItem == null || comboBoxCity.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете продукт и глад от списъците!");
                return;
            }


            string product = comboBox1Product.SelectedItem!.ToString()!;
            string city = comboBoxCity.SelectedItem!.ToString()!;
            double quantity = double.Parse(textBoxQuantity.Text);

            if (textBoxQuantity.Text == "")
            {
                MessageBox.Show("Моля, въведете количество!");
                return;
            }

            double price = 0.0;

            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        price = 0.50;
                    }

                    else if (product == "water")
                    {
                        price = 0.80;
                    }

                    else if (product == "juice")
                    {
                        price = 1.20;
                    }

                    else if (product == "sweets")
                    {
                        price = 1.45;
                    }

                    else if (product == "peanuts")
                    {
                        price = 1.60;
                    }
                    break;

                case "Plovdiv":
                    if (product == "coffee")
                    {
                        price = 0.40;
                    }

                    else if (product == "water")
                    {
                        price = 0.70;
                    }

                    else if (product == "juice")
                    {
                        price = 1.15;
                    }

                    else if (product == "sweets")
                    {
                        price = 1.30;
                    }

                    else if (product == "peanuts")
                    {
                        price = 1.50;
                    }
                    break;

                case "Varna":
                    if (product == "coffee")
                    {
                        price = 0.45;
                    }

                    else if (product == "water")
                    {
                        price = 0.70;
                    }

                    else if (product == "juice")
                    {
                        price = 1.10;
                    }

                    else if (product == "sweets")
                    {
                        price = 1.35;
                    }

                    else if (product == "peanuts")
                    {
                        price = 1.55;
                    }
                    break;

            }

            double totalPrice = price * quantity;
            label5.Text = $"{totalPrice:f2} lv.";

        }
    }
}
