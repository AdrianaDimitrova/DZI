namespace Numbe_Sumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox1.Text);

                double result = num1 + num2;
                textBox3.Text = result.ToString();
            }

            catch (Exception)
            {
                textBox3.Text = "error";
            }
            

        }
    }
}
