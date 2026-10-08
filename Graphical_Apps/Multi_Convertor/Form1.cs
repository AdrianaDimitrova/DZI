namespace Multi_Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            labelBGN1.Text = $"{textBox1.Text} BGN";
            labelBGN2.Text = $"{textBox1.Text} BGN";
            labelBGN3.Text = $"{textBox1.Text} BGN";

            double EUR = number / 1.95583;
            double USD = number / 1.81487;
            double GBP = number / 2.21909;

            label6.Text = $"{EUR:f2} EUR";
            label9.Text = $"{USD:f2} USD";
            label12.Text = $"{GBP:f2} GBP";
        }
    }
}
