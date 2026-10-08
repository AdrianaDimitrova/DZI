namespace Convertor3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = double.Parse(numericUpDown1.Text);
            string currency = comboBox1.SelectedItem!.ToString()!;

            double convertedSum = 0.0;

            if (currency == "EUR")
            {
                convertedSum = num / 1.95583;
                labelResult.Text = $"{convertedSum:f2} EUR";
            }
            else if (currency == "USD")
            {
                convertedSum = num / 1.81487;
                labelResult.Text = $"{convertedSum:f2} USD";
            }
            else if (currency == "GBP")
            {
                convertedSum = num / 2.21909;
                labelResult.Text = $"{convertedSum:f2} GBP";
            }
            else
            {
                comboBox1.Text = "Enter valid currency!";
            }

            


        }
    }
}
